# 6.  Realice el algoritmo de fibonacci, utilizando solo los términos iniciales en cada vector, conservando la forma de cálculo convencional.

import multiprocessing as mp

# Devuelve el valor del numro fibonacci en una posicion
def fiboPoscicion(n):
    phi=(1+5**(0.5))/2
    fin =(phi**n-(-phi**(-1))**n)/5**0.5
    return round(fin)


def fiboClasico(inicio,fin):
    vector=[]
    a=fiboPoscicion(inicio)
    b=fiboPoscicion(inicio+1)
    for i in range(inicio,fin):
        vector.append(a)
        c=a+b
        a=b
        b=c
    return vector

if __name__=='__main__':

    procesadores=mp.cpu_count()
    terminos=int(input("Ingrese la cantidad de términos a generar: "))
    procesosProcesador=terminos//procesadores
    saldoProcesos=terminos%procesadores

    entradas=[(i*procesosProcesador,(i+1)*procesosProcesador)for i in range(procesadores)]
    if saldoProcesos>0:
        inicio,fin=entradas[-1]
        entradas[-1]=(inicio,fin+saldoProcesos)

    print ("Entradas: ",entradas)
    resultados=mp.Pool().starmap(fiboClasico,entradas)

    for i in range(len(resultados)):
        print(f"Procesador {i+1}:",resultados[i])
    