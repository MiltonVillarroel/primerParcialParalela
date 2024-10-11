// 13.  Utilizando MPI realice el despliegue de un vector de datos tipo cadena, el procesador 0 sera el distribuidor, 
// el 1 desplegara posiciones pares y el 2 posiciones impares.
#include <mpi.h>
#include <stdio.h>

int main(int argc, char *argv[]) {
    int procesador;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &procesador);

    if (procesador == 0) {
        char vector[4][10] = {"Milton", "Alejandro", "Villarroel", "Garvizu"};
        
        for (int i = 0; i < 4; i++) {
            if (i % 2 == 0) {
                MPI_Send(&vector[i], 10, MPI_CHAR, 1, 0, MPI_COMM_WORLD);
            } else {
                MPI_Send(&vector[i], 10, MPI_CHAR, 2, 0, MPI_COMM_WORLD);
            }
        }
    }

    if (procesador == 1) {
        char vectorP[10];
        
        for (int i = 0; i < 2; i++) {
            MPI_Recv(&vectorP, 10, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Procesador %d: Posicion par: %s\n", procesador, vectorP);
        }
    }

    if (procesador == 2) {
        char vectorI[10];
        
        for (int j = 0; j < 2; j++) {
            MPI_Recv(&vectorI, 10, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Procesador %d: Posicion impar: %s\n", procesador, vectorI);
        }
    }

    MPI_Finalize();
    return 0;
}