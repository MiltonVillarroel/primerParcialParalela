// 2. Realice un programa que tenga los métodos suma, resta, multiplicación, división en lenguaje c. Programe los mismo sin el uso de punteros.

#include <stdio.h>
#include <stdlib.h> 
int suma(int a,int b){
    return a+b;
}

int resta(int a,int b){
    return a-b;
}
int multiplicaicon(int a,int b){
    return a*b;
}
float division(int a,int b){
    if(b==0) {
        printf("No se puede dividir entre cero\n"); 
        return 0;
    }    
    else return (float)a/(float)b;
}

int main()
{
    int op,a,b;
    do
    {

        printf("Seleccione una opcion:\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n0.Salir\n");
        printf("Ingresa una opcion: ");
        scanf("%d", &op);
        getchar();

        switch (op)
        {
        case 1:
            system("clear"); //"cls" en windows
            printf("\nIngresa un entero: ");
            scanf("%d", &a);
            printf("\nIngresa otro entero: ");
            scanf("%d", &b);
            printf("El resultado es: %d\n",suma(a,b));

            break;
        case 2:
            system("clear"); 
            printf("\nIngresa un entero: ");
            scanf("%d", &a);
            printf("\nIngresa otro entero: ");
            scanf("%d", &b);
            printf("El resultado es: %d\n",resta(a,b));
            getchar();
            break;
        case 3:
            system("clear"); 
            printf("\nIngresa un entero: ");
            scanf("%d", &a);
            printf("\nIngresa otro entero: ");
            scanf("%d", &b);
            printf("El resultado es: %d\n",multiplicaicon(a,b));
            getchar();
            break;
        case 4:
            system("clear"); 
            printf("\nIngresa un entero: ");
            scanf("%d", &a);
            printf("\nIngresa otro entero: ");
            scanf("%d", &b);
            printf("El resultado es: %f\n",division(a,b));
            getchar();
            break;
        
        default:
            system("clear"); 
            break;
        }

    } while (op!=0);

    return 0;
}
