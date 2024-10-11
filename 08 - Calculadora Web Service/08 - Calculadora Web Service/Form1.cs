using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _08___Calculadora_Web_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operacion(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((System.Windows.Forms.Button)sender).Text;
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

            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();

            switch (bTipo.Text)
            {
                case "INFIJA":
                default:
                                       
                    textBox2.Text = ws.CalcularInfija(listar());
                    break;
                case "PREFIJA":

                    textBox2.Text = ws.CalcularPrefija(listar());
                    break;
                case "POSTFIJA":
                    textBox2.Text = ws.CalcularPostfija(listar());
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

        private ServiceReference1.ArrayOfString listar()
        {
            // Crear una instancia de ArrayOfString
            ServiceReference1.ArrayOfString lista = new ServiceReference1.ArrayOfString();
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
                    // Si hemos acumulado un número, añadirlo a la lista
                    if (numero != string.Empty)
                    {
                        if (negativo)
                        {
                            lista.Add("-" + numero);
                        }
                        else
                        {
                            lista.Add(numero);
                        }
                        numero = string.Empty; // Reiniciar número
                        negativo = false; // Reiniciar negativo
                    }

                    // Manejar signos negativos
                    if (caracter == '-' && bTipo.Text == "INFIJA")
                    {
                        // Solo marcar como negativo si no hay número previo
                        if (i == 0 || (!char.IsDigit(textBox1.Text[i - 1]) && textBox1.Text[i - 1] != ')'))
                        {
                            negativo = true; // Preparar para el siguiente número
                        }
                        else
                        {
                            lista.Add(caracter.ToString());
                        }
                    }
                    else if (caracter != '_') // Ignorar caracteres no deseados
                    {
                        lista.Add(caracter.ToString());
                    }
                }
            }

            // Añadir el último número si existe
            if (numero != string.Empty)
            {
                if (negativo)
                {
                    lista.Add("-" + numero);
                }
                else
                {
                    lista.Add(numero);
                }
            }

            return lista; // Devolver ArrayOfString directamente
        }


    }
}
