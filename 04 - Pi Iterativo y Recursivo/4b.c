// 4. Realice el cálculo de pi secuencial con el uso de punteros, hágalo iterativamente y recursivamente.

// Usando la Serie de Leibniz que se aproxima a pi/4 donde se hace la sumatoria de 1 dividido entre denominadores que van cambiando con cada iteracion
// los signos alternan de + a - y los denominadores se incrementan de forma impar

#include <stdio.h>
#include <stdbool.h>
#include <math.h> 

void serieLeibniz(float *actual, float anterior, int denominador, bool signo, float errorAceptado) {
    anterior = *actual;  
    *actual += signo ? 1.0 / (float)denominador : -1.0 / (float)denominador; 
    signo = !signo; 
    denominador += 2;     

    if (fabs(anterior - *actual) > errorAceptado) {
        serieLeibniz(actual,anterior, denominador, signo, errorAceptado);
    }
}

int main() {
    float leibniz = 0;  
    float errorAceptado = 0.001; 
    serieLeibniz(&leibniz, 0, 1, true, errorAceptado);  
    printf("Pi aproximado por la serie de Leibniz con un error de %.8f es: %.8f\n", errorAceptado, leibniz * 4);  
    
    return 0;
}

