using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Aplicacion_Web
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        private int Prioridad(string operador)
        {
            switch (operador)
            {
                case "^": return 3;
                case "*":
                case "/": return 2;
                case "+":
                case "-": return 1;
                default: return 0;
            }
        }

        private List<string> infijaPostfija(string[] elementos)
        {
            Stack<string> pila = new Stack<string>();
            List<string> salida = new List<string>(); // Usar List<string> en lugar de Queue<string>
            foreach (string e in elementos)
            {
                if (double.TryParse(e, out double numero))
                {
                    salida.Add(e); // Agregar a la lista
                }
                else if (e == "(")
                {
                    pila.Push(e);
                }
                else if (e == ")")
                {
                    while (pila.Count > 0 && pila.Peek() != "(")
                    {
                        salida.Add(pila.Pop()); // Agregar a la lista
                    }
                    pila.Pop();
                }
                else
                {
                    while (pila.Count > 0 && Prioridad(pila.Peek()) >= Prioridad(e))
                    {
                        salida.Add(pila.Pop()); // Agregar a la lista
                    }
                    pila.Push(e);
                }
            }

            while (pila.Count > 0)
            {
                salida.Add(pila.Pop()); // Agregar a la lista
            }

            return salida;
        }

        [WebMethod]
        public string CalcularInfija(string[] elementos)
        {
            return CalcularPostfija(infijaPostfija(elementos).ToArray()); // Convertir a arreglo
        }

        [WebMethod]
        public string CalcularPostfija(string[] elementos) // Aceptar string[]
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
            catch (Exception)
            {
                return "ERROR DE NOTACIÓN";
            }
        }

        [WebMethod]
        public string CalcularPrefija(string[] elementos)
        {
            Stack<double> pila = new Stack<double>();
            try
            {
                foreach (string e in elementos.Reverse()) // Invertir el array para procesar en prefija
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