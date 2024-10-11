# 5.      Con multiprocessing calculo pi hasta el término 1 millón, utilice al menos 3 procesadores.

import multiprocessing as mp

def leibniz(inicio,fin):
    suma=0
    for i in range (inicio,fin+1):
        suma+= 1/(i*2-1) if i%2!=0 else -1/(i*2-1)
    return suma


if __name__=='__main__':
    procesadores = mp.cpu_count()
    terminos=1000000

    procesosProcesador=terminos//procesadores
    saldoProcesos=terminos%procesadores
    entradas=[(i*procesosProcesador+1,(i+1)*procesosProcesador if i!=procesadores-1 else (i+1)*procesosProcesador + saldoProcesos)for i in range(procesadores)]
    print (entradas)

    resultado=mp.Pool().starmap(leibniz,entradas) #starmap se usa para mandar a una funcion una lista de tuplas en cambio map solo se usa para enviar una lista
    pi=4*sum(resultado)

    print(pi)
# Es interesante observar los errores de punto flotante al cambiar de 8 a 6 procesadores, lo que se debe al redondeo
# con 8 procesadores = 3.141591653589728
# con 6 procesadores, la ultima tupla aumenta en 4 lo que ocasiona que los ultimos procesos tengan numeros mas altos alfectando el resultado de pi que es 3.141591653589747
