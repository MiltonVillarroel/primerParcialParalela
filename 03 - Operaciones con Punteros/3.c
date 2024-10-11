// 3. Realice un programa que tenga los métodos suma, resta, multiplicación, división en lenguaje c. Programe los mismo con el uso de punteros.
#include <stdio.h>
#include <stdlib.h>

void calcular(int a, int b, int *suma, int *resta, int *mult, float *division) {
    *suma = a + b;
    *resta = a - b;
    *mult = a * b;
    *division = (b == 0) ? 0.0f : (float)a / (float)b;   
}

int main() {
    int op, suma, resta, mult, a, b;
    float division;

    do {
        system("clear"); 
        printf("\nIngresa un entero: ");
        scanf("%d", &a);
        printf("\nIngresa otro entero: ");
        scanf("%d", &b);
        
        calcular(a, b, &suma, &resta, &mult, &division);

        printf("La suma es: %d\n", suma);
        printf("La resta es: %d\n", resta);
        printf("La multiplicacion es: %d\n", mult);
        
        if (b != 0) {
            printf("La division es: %.2f\n", division);
        } else {
            printf("No se puede dividir entre cero\n");
        }

        printf("\nIngrese 0 para salir o cualquier otro valor para reiniciar: ");
        scanf("%d", &op);

    } while (op != 0);

    return 0;
}
