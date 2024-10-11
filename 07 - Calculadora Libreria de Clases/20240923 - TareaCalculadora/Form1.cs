namespace _20240923___TareaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operacion(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch (Exception)
            {

            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "0";
        }

        private void bTipo_Click(object sender, EventArgs e)
        {
            if (c == 0) { bTipo.Text = "PREFIJA"; c++; }
            else if (c == 1) { bTipo.Text = "POSTFIJA"; c++; }
            else if (c == 2) { bTipo.Text = "INFIJA"; c = 0; }
        }

        int c = 0;

        private void bResultado_Click(object sender, EventArgs e)
        {
            //foreach (string el in listar()) MessageBox.Show(el);

            switch (bTipo.Text)
            {
                case "INFIJA":
                default:
                    Operaciones.Infija infija = new Operaciones.Infija();
                    textBox2.Text = infija.Calcular(listar());
                    break;
                case "PREFIJA":
                    Operaciones.Prefija prefija = new Operaciones.Prefija();
                    textBox2.Text = prefija.Calcular(listar());
                    break;
                case "POSTFIJA":
                    Operaciones.Postfija postfija = new Operaciones.Postfija();
                    textBox2.Text = postfija.Calcular(listar());
                    break;

            }


        }

        private void teclado_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Simula el clic del botón
                b1.PerformClick();
            }
        }

        private Queue<string> listar()
        {
            Queue<string> lista = new Queue<string>();
            string numero = string.Empty;
            bool negativo = false;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char caracter = textBox1.Text[i];

                // Si el carácter es un dígito o un punto decimal
                if (char.IsDigit(caracter) || caracter == '.')
                {
                    numero += caracter;
                }
                else
                {
                    // Si hemos acumulado un número, añadimos a la lista
                    if (numero != string.Empty)
                    {
                        if (negativo)
                        {
                            lista.Enqueue("-" + numero);
                        }
                        else
                        {
                            lista.Enqueue(numero);
                        }
                        numero = string.Empty; // Reiniciar número
                        negativo = false; // Reiniciar negativo
                    }

                    // Manejar signos negativos
                    if (caracter == '-' && bTipo.Text=="INFIJA")
                    {
                        // Solo marcar como negativo si no hay número previo
                        if (i == 0 || !char.IsDigit(textBox1.Text[i - 1]) && textBox1.Text[i - 1] != ')')
                        {
                            negativo = true; // Preparar para el siguiente número
                        }
                        else
                        {
                            lista.Enqueue(caracter.ToString());
                        }
                    }

                    // Ignorar caracteres no deseados
                    else if (caracter != '_')
                    {
                        lista.Enqueue(caracter.ToString());
                    }
                }
            }

            // Añadir el último número si existe
            if (numero != string.Empty)
            {
                if (negativo)
                {
                    lista.Enqueue("-" + numero);
                }
                else
                {
                    lista.Enqueue(numero);
                }
            }

            return lista;
        }

    }
}