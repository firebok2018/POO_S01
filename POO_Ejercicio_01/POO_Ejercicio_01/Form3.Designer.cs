namespace POO_Ejercicio_01
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtperi = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtdiag = new System.Windows.Forms.TextBox();
            this.btnEjec = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtperi
            // 
            this.txtperi.Location = new System.Drawing.Point(245, 128);
            this.txtperi.Name = "txtperi";
            this.txtperi.Size = new System.Drawing.Size(152, 20);
            this.txtperi.TabIndex = 2;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(244, 154);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(150, 20);
            this.txtarea.TabIndex = 3;
            // 
            // txtdiag
            // 
            this.txtdiag.Location = new System.Drawing.Point(245, 184);
            this.txtdiag.Name = "txtdiag";
            this.txtdiag.Size = new System.Drawing.Size(149, 20);
            this.txtdiag.TabIndex = 4;
            // 
            // btnEjec
            // 
            this.btnEjec.Location = new System.Drawing.Point(293, 40);
            this.btnEjec.Name = "btnEjec";
            this.btnEjec.Size = new System.Drawing.Size(75, 23);
            this.btnEjec.TabIndex = 5;
            this.btnEjec.Text = "PROCESAR";
            this.btnEjec.UseVisualStyleBackColor = true;
            this.btnEjec.Click += new System.EventHandler(this.btnEjec_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(296, 75);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(72, 22);
            this.LIMPIAR.TabIndex = 6;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Perimetro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Diagonal";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(473, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.btnEjec);
            this.Controls.Add(this.txtdiag);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtperi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtperi;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtdiag;
        private System.Windows.Forms.Button btnEjec;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}