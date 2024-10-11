namespace _9___Deteccion_de_Bordes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            bCargar = new Button();
            openFileDialog1 = new OpenFileDialog();
            bBordes = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(58, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bCargar
            // 
            bCargar.Location = new Point(510, 153);
            bCargar.Name = "bCargar";
            bCargar.Size = new Size(135, 59);
            bCargar.TabIndex = 1;
            bCargar.Text = "Cargar\r\nImagen";
            bCargar.UseVisualStyleBackColor = true;
            bCargar.Click += bCargar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // bBordes
            // 
            bBordes.Location = new Point(510, 218);
            bBordes.Name = "bBordes";
            bBordes.Size = new Size(135, 59);
            bBordes.TabIndex = 2;
            bBordes.Text = "Detectar\r\nBordes";
            bBordes.UseCompatibleTextRendering = true;
            bBordes.UseVisualStyleBackColor = true;
            bBordes.Click += bBordes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 3;
            label1.Text = "Milton Alejandro Villarroel Garvizu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(label1);
            Controls.Add(bBordes);
            Controls.Add(bCargar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Detector de Bordes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bCargar;
        private OpenFileDialog openFileDialog1;
        private Button bBordes;
        private Label label1;
    }
}