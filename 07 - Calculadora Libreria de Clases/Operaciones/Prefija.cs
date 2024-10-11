using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Prefija
    {
        public string Calcular(Queue<string> elementos)
        {
            Stack<double> pila = new Stack<double>();
            try
            {
                foreach (string e in elementos.Reverse()) // Invertir la cola para procesar en prefija
                {
                    if (double.TryParse(e, out double numero))
                    {
                        pila.Push(numero);
                    }
                    else
                    {
                        double resultado = 0;
                        double op1 = pila.Pop();
                        double op2 = pila.Pop();
                        switch (e)
                        {
                            case "+":
                                resultado = op1 + op2;
                                break;
                            case "-":
                                resultado = op1 - op2;
                                break;
                            case "*":
                                resultado = op1 * op2;
                                break;
                            case "/":
                                if (op2 == 0) return "NO SE PUEDE DIVIDIR ENTRE CERO";
                                resultado = op1 / op2;
                                break;
                            case "^":
                                resultado = Math.Pow(op1, op2);
                                break;
                        }
                        pila.Push(resultado);
                    }
                }

                return Math.Round(pila.Pop(), 5).ToString();
            }
            catch (Exception)
            {
                return "ERROR DE NOTACIÓN";
            }
        }

    }
}
