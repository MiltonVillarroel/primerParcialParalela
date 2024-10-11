using System.Drawing;
using System.Windows.Forms;

namespace _08___Calculadora_Web_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            bDecimal = new Button();
            b0 = new Button();
            bResultado = new Button();
            bSuma = new Button();
            bMultiplicacion = new Button();
            bDivision = new Button();
            bResta = new Button();
            bDel = new Button();
            bClear = new Button();
            bEspacio = new Button();
            bRPar = new Button();
            bLPar = new Button();
            bTipo = new Button();
            bPotencia = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(18, 10);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(240, 22);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // b1
            // 
            b1.Location = new Point(18, 245);
            b1.Name = "b1";
            b1.Size = new Size(44, 46);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += operacion;
            // 
            // b2
            // 
            b2.Location = new Point(67, 245);
            b2.Name = "b2";
            b2.Size = new Size(44, 46);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += operacion;
            // 
            // b3
            // 
            b3.Location = new Point(116, 245);
            b3.Name = "b3";
            b3.Size = new Size(44, 46);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += operacion;
            // 
            // b6
            // 
            b6.Location = new Point(116, 192);
            b6.Name = "b6";
            b6.Size = new Size(44, 46);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += operacion;
            // 
            // b5
            // 
            b5.Location = new Point(67, 192);
            b5.Name = "b5";
            b5.Size = new Size(44, 46);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += operacion;
            // 
            // b4
            // 
            b4.Location = new Point(18, 192);
            b4.Name = "b4";
            b4.Size = new Size(44, 46);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += operacion;
            // 
            // b9
            // 
            b9.Location = new Point(116, 140);
            b9.Name = "b9";
            b9.Size = new Size(44, 46);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += operacion;
            // 
            // b8
            // 
            b8.Location = new Point(67, 140);
            b8.Name = "b8";
            b8.Size = new Size(44, 46);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += operacion;
            // 
            // b7
            // 
            b7.Location = new Point(18, 140);
            b7.Name = "b7";
            b7.Size = new Size(44, 46);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += operacion;
            // 
            // bDecimal
            // 
            bDecimal.Location = new Point(116, 297);
            bDecimal.Name = "bDecimal";
            bDecimal.Size = new Size(44, 46);
            bDecimal.TabIndex = 12;
            bDecimal.Text = ".";
            bDecimal.UseVisualStyleBackColor = true;
            bDecimal.Click += operacion;
            // 
            // b0
            // 
            b0.Location = new Point(67, 297);
            b0.Name = "b0";
            b0.Size = new Size(44, 46);
            b0.TabIndex = 11;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += operacion;
            // 
            // bResultado
            // 
            bResultado.Location = new Point(214, 297);
            bResultado.Name = "bResultado";
            bResultado.Size = new Size(44, 46);
            bResultado.TabIndex = 13;
            bResultado.Text = "=";
            bResultado.UseVisualStyleBackColor = true;
            bResultado.Click += bResultado_Click;
            // 
            // bSuma
            // 
            bSuma.Location = new Point(165, 297);
            bSuma.Name = "bSuma";
            bSuma.Size = new Size(44, 46);
            bSuma.TabIndex = 14;
            bSuma.Text = "+";
            bSuma.UseVisualStyleBackColor = true;
            bSuma.Click += operacion;
            // 
            // bMultiplicacion
            // 
            bMultiplicacion.Location = new Point(165, 192);
            bMultiplicacion.Name = "bMultiplicacion";
            bMultiplicacion.Size = new Size(44, 46);
            bMultiplicacion.TabIndex = 15;
            bMultiplicacion.Text = "*";
            bMultiplicacion.UseVisualStyleBackColor = true;
            bMultiplicacion.Click += operacion;
            // 
            // bDivision
            // 
            bDivision.Location = new Point(214, 192);
            bDivision.Name = "bDivision";
            bDivision.Size = new Size(44, 46);
            bDivision.TabIndex = 16;
            bDivision.Text = "/";
            bDivision.UseVisualStyleBackColor = true;
            bDivision.Click += operacion;
            // 
            // bResta
            // 
            bResta.Location = new Point(165, 245);
            bResta.Name = "bResta";
            bResta.Size = new Size(44, 46);
            bResta.TabIndex = 17;
            bResta.Text = "-";
            bResta.UseVisualStyleBackColor = true;
            bResta.Click += operacion;
            // 
            // bDel
            // 
            bDel.Location = new Point(18, 104);
            bDel.Name = "bDel";
            bDel.Size = new Size(44, 30);
            bDel.TabIndex = 18;
            bDel.Text = "DEL";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bDel_Click;
            // 
            // bClear
            // 
            bClear.Location = new Point(67, 104);
            bClear.Name = "bClear";
            bClear.Size = new Size(44, 30);
            bClear.TabIndex = 19;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bEspacio
            // 
            bEspacio.Location = new Point(18, 297);
            bEspacio.Name = "bEspacio";
            bEspacio.Size = new Size(44, 46);
            bEspacio.TabIndex = 10;
            bEspacio.Text = "_";
            bEspacio.UseVisualStyleBackColor = true;
            bEspacio.Click += operacion;
            // 
            // bRPar
            // 
            bRPar.Location = new Point(214, 140);
            bRPar.Name = "bRPar";
            bRPar.Size = new Size(44, 46);
            bRPar.TabIndex = 21;
            bRPar.Text = ")";
            bRPar.UseVisualStyleBackColor = true;
            bRPar.Click += operacion;
            // 
            // bLPar
            // 
            bLPar.BackgroundImageLayout = ImageLayout.Zoom;
            bLPar.Location = new Point(166, 140);
            bLPar.Name = "bLPar";
            bLPar.Size = new Size(44, 46);
            bLPar.TabIndex = 20;
            bLPar.Text = "(";
            bLPar.UseVisualStyleBackColor = true;
            bLPar.Click += operacion;
            // 
            // bTipo
            // 
            bTipo.Location = new Point(116, 104);
            bTipo.Name = "bTipo";
            bTipo.Size = new Size(142, 30);
            bTipo.TabIndex = 22;
            bTipo.Text = "INFIJA";
            bTipo.UseVisualStyleBackColor = true;
            bTipo.Click += bTipo_Click;
            // 
            // bPotencia
            // 
            bPotencia.Location = new Point(214, 245);
            bPotencia.Name = "bPotencia";
            bPotencia.Size = new Size(44, 46);
            bPotencia.TabIndex = 23;
            bPotencia.Text = "^";
            bPotencia.UseVisualStyleBackColor = true;
            bPotencia.Click += operacion;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(18, 38);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(240, 60);
            textBox2.TabIndex = 24;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 364);
            Controls.Add(textBox2);
            Controls.Add(bPotencia);
            Controls.Add(bTipo);
            Controls.Add(bRPar);
            Controls.Add(bLPar);
            Controls.Add(bClear);
            Controls.Add(bDel);
            Controls.Add(bResta);
            Controls.Add(bDivision);
            Controls.Add(bMultiplicacion);
            Controls.Add(bSuma);
            Controls.Add(bResultado);
            Controls.Add(bDecimal);
            Controls.Add(b0);
            Controls.Add(bEspacio);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULADORA";
            KeyDown += teclado_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button bDecimal;
        private Button b0;
        private Button bResultado;
        private Button bSuma;
        private Button bMultiplicacion;
        private Button bDivision;
        private Button bResta;
        private Button bDel;
        private Button bClear;
        private Button bEspacio;
        private Button bRPar;
        private Button bLPar;
        private Button bTipo;
        private Button bPotencia;
        private TextBox textBox2;
    }
}

