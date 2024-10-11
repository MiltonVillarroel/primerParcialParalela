namespace Operaciones
{
    public class Infija
    {
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
        private Queue<string> infijaPostfija(Queue<string> elementos)
        {

            Stack<string> pila = new Stack<string>();
            Queue<string>salida = new Queue<string>();
            foreach(string e in elementos)
            {
                if (double.TryParse(e, out double numero))
                {
                    salida.Enqueue(e);
                }
                else if (e=="(")
                {
                    pila.Push(e);
                }
                else if (e == ")") { 
                    while (pila.Count > 0 && pila.Peek() != "(")
                    {
                        salida.Enqueue(pila.Pop());
                    }
                    pila.Pop();
                }
                else 
                {
                    while (pila.Count > 0 && Prioridad(pila.Peek()) >= Prioridad(e))
                    {
                        salida.Enqueue(pila.Pop());
                    }
                    pila.Push(e);
                }
            }

            while (pila.Count > 0)
            {
                salida.Enqueue(pila.Pop());
            }

            return salida;
        }

        public string Calcular(Queue<string> elementos)
        {
            Postfija postfija = new Postfija();
            return postfija.Calcular(infijaPostfija(elementos));
        }

    }

}