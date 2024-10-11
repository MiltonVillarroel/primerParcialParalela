#include <stdio.h>
#include <omp.h>

int main() {
    int a = 0, b = 1, c;
    int procesadores, procesador;

    #pragma omp parallel shared(a,b) private(c,procesadores,procesador)
    {

        procesadores = omp_get_num_threads();
        procesador = omp_get_thread_num();

        printf("\nProcesador %d de %d :", procesador,procesadores);
        #pragma omp for

            for (int i = 0 ; i < 10; i++) 
            {
                printf("%d ", a);
                c = a + b;
                a = b;
                b = c;
                
            }
    }    
    return 0;
}