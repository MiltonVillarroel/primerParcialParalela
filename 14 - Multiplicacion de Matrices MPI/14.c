// 14.  Con MPI utilizando MPI_Send y MPI_Recv multiplique dos matrices.
#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char *argv[])
{
    int procesador,procesadores;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &procesador);
    MPI_Comm_size( MPI_COMM_WORLD, &procesadores);

    srand(time(NULL));
    int m1F = 3;
    int m1C = 2;
    int m2F = 2;
    int m2C = 3;
    
    //procesador 0 genera la matriz 1
    //procesadro 1 genera la matriz 2
    //procesador 2 multiplica las matrices

    if(procesador==0){
        int matriz1[m1F][m1C];
        printf("Procesador: %d, Matriz 1\n",procesador);

        for (int i = 0; i < m1F; i++)
        {
            for ( int j = 0; j < m1C; j++)
            {
                matriz1[i][j]=rand()%10;
                printf("%d ", matriz1[i][j]);
            }
            printf("\n");        
        }

        MPI_Send( &matriz1 , m1F*m1C, MPI_INT , 2 , 0 , MPI_COMM_WORLD);
    }
    if(procesador==1){
        int matriz2[m2F][m2C];
        printf("Procesador: %d, Matriz 2\n",procesador);

        for (int i = 0; i < m2F; i++)
        {
            for ( int j = 0; j < m2C; j++)
            {
                matriz2[i][j]=rand()%10;
                printf("%d ", matriz2[i][j]);
            }
            printf("\n");        
        }

        MPI_Send( &matriz2 , m2F*m2C, MPI_INT , 2 , 0 , MPI_COMM_WORLD);
    }
    if (procesador==2){
        int matrizR[m1F][m2C];
        int m1[m1F][m1C];
        int m2[m2F][m2C];

        MPI_Recv( &m1 , m1F*m1C , MPI_INT , 0, 0 , MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        MPI_Recv( &m2 , m2F*m2C , MPI_INT , 1, 0 , MPI_COMM_WORLD, MPI_STATUS_IGNORE);


        printf("Procesador: %d, Matriz Resultado\n",procesador);
        for (int i = 0; i < m1F; i++)
        {
            for (int j = 0; j < m2C; j++)
            {
                int suma=0;
                for (int k = 0; k < m2F; k++)
                {
                    suma += m1[i][k] * m2[k][j];
                }
                matrizR[i][j]=suma;
                printf("%d ", matrizR[i][j]);
            }
            printf("\n");
        }

    }
    MPI_Finalize();
    return 0;
}
