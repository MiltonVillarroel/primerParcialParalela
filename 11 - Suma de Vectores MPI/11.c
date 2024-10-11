#include <mpi.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
    int procesador;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &procesador);

    if (procesador == 0)
    {
        int vectorA[10];
        int vectorB[10];
        int vectorC[10];

        for (int i = 0; i < 10; i++)
        {
            vectorA[i] = i;
            vectorB[i] = 5;
        }

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {

                MPI_Send(&vectorA[i], 1, MPI_INT, 2, 0, MPI_COMM_WORLD);
                MPI_Send(&vectorB[i], 1, MPI_INT, 2, 1, MPI_COMM_WORLD);
                MPI_Recv(&vectorC[i], 1, MPI_INT, 2, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            }
            else
            {

                MPI_Send(&vectorA[i], 1, MPI_INT, 1, 0, MPI_COMM_WORLD);
                MPI_Send(&vectorB[i], 1, MPI_INT, 1, 1, MPI_COMM_WORLD);
                MPI_Recv(&vectorC[i], 1, MPI_INT, 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            }
        }


        printf("Procesador %d ha enviado a los procesadores 1 y 2 los vectores:\n", procesador);
        printf("Vector A: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vectorA[i]);
        }
        printf("\n");

        printf("Vector B: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vectorB[i]);
        }
        printf("\n");


        printf("Vector C: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vectorC[i]);
        }
        printf("\n");
    }
    else if (procesador == 1)
    {

        for (int i = 1; i < 10; i += 2)
        {
            int imparA, imparB;
            MPI_Recv(&imparA, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            MPI_Recv(&imparB, 1, MPI_INT, 0, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            int sumaImpar = imparA + imparB;
            MPI_Send(&sumaImpar, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
        }
    }
    else if (procesador == 2)
    {

        for (int i = 0; i < 10; i += 2)
        {
            int parA, parB;
            MPI_Recv(&parA, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            MPI_Recv(&parB, 1, MPI_INT, 0, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            int sumaPar = parA + parB;
            MPI_Send(&sumaPar, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
        }
    }

    MPI_Finalize();
    return 0;
}
