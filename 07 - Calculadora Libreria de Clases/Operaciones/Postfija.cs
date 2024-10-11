using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Postfija
    {
        public string Calcular(Queue<string> elementos)
        {
            Stack<double> pila = new Stack<double>();
            try
            {
                foreach (string e in elementos)
                {
                    if (double.TryParse(e, out double numero))
                    {
                        pila.Push(numero);
                    }
                    else
                    {
                        double resultado = 0;
                        double op2 = pila.Pop();
                        double op1 = pila.Pop();
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
                                resultado = op1 / op2;
                                if (op2 == 0) return "NO SE PUEDE DIVIDIR ENTRE CERO";
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
            catch (Exception )
            {
                return "ERROR DE NOTACIÓN";
            }
        }
    }
}
