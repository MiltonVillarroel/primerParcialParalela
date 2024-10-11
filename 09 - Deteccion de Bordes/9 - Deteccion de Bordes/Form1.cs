namespace _9___Deteccion_de_Bordes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg|*.jpg|Archivos png|*.png|Archivos bmp|*.bmp|Archivos gif|*.gif|Archivos tiff|*.tiff|Archivos ico|*.ico|Todos los archivos|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            }

        }

        private void bBordes_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = bordesSobel(escalaGrises((Bitmap)pictureBox1.Image));
                pictureBox1.Image = bmp;
            }
            catch (Exception) { }
        }

        private Bitmap escalaGrises(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    Color pixel = bmp.GetPixel(i, j);
                    int gris = (pixel.R + pixel.G + pixel.B) / 3;
                    //gris = (gris >= 127) ? 255 : 0;//blanco o negro
                    bmp.SetPixel(i, j, Color.FromArgb(gris, gris, gris));
                }
            }
            return bmp;
        }

        private Bitmap bordesSobel(Bitmap bmp)
        {
            // MILTON DEL FUTURO REVISA LOS CONCEPTOS SOBRE LOS OPERADORES SOBEL Y CONVOLUCION DE IMAGEN PARA VISION COMPUTACIONAL
            // https://www.youtube.com/watch?v=VL8PuOPjVjY ATTE.MILTON DEL PASADO
            int[,] Gx =
            {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] Gy =
            {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            Bitmap resultado = new Bitmap(bmp.Width, bmp.Height);

            // SE DEBE RECORRER LA IMAGEN SIN CONTAR LOS BORDES
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    int gradX = 0, gradY = 0;

                    // SE RECORREN TODOS LOS PIXELES QUE RODEAN AL PIXEL OBJETIVO Y SE DEBE MULTIPLLICAR POR LAS GRADIENTES
                    // Y ACUMULARLAS
                    for (int k = -1; k <= 1; k++)
                        for (int l = -1; l <= 1; l++)
                        {
                            int pixel = bmp.GetPixel(i + k, j + l).R;
                            gradX += pixel * Gx[k + 1, l + 1];
                            gradY += pixel * Gy[k + 1, l + 1];
                        }

                    //CADA SE DEBE CALCULAR LA MAGNITUD DE LA GRADIENTE

                    int magnitud = (int)Math.Sqrt(gradX * gradX + gradY * gradY);
                    magnitud = Math.Min(255, Math.Max(0, magnitud));
                    resultado.SetPixel(i, j, Color.FromArgb(magnitud, magnitud, magnitud));
                }
            }

            return resultado;
        }

    }
}