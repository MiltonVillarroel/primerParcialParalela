// 4. Realice el cálculo de pi secuencial con el uso de punteros, hágalo iterativamente y recursivamente.

// Usando la Serie de Leibniz que se aproxima a pi/4 donde se hace la sumatoria de 1 dividido entre denominadores que van cambiando con cada iteracion
// los signos alternan de + a - y los denominadores se incrementan de forma impar

#include <stdio.h>
#include <stdbool.h>
#include <math.h> 

int main(int argc, char const *argv[])
{
    float leibniz=0;
    float leibnizAnterior=0;
    float *p=&leibniz;
    int i=1;
    bool signo=true;
    float errorAceptado=0.001;
    do
    {
        leibnizAnterior=*p;
        *p+=signo?1/(float)i:-1/(float)i;        
        i+=2;
        signo=!signo;
    } while (fabs(leibniz-leibnizAnterior)>errorAceptado);    

    printf("Pi aproximado por la serie de Leibniz con un error de %.8f es: %.8f",errorAceptado,leibniz*4);
    return 0;
}