namespace POO_Ejercicio_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.txtSaludo = new System.Windows.Forms.TextBox();
            this.txtSWelcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saludar";
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaludar.Location = new System.Drawing.Point(544, 111);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 1;
            this.btnSaludar.Text = "Enviar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // txtSaludo
            // 
            this.txtSaludo.Location = new System.Drawing.Point(181, 115);
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(343, 20);
            this.txtSaludo.TabIndex = 2;
            this.txtSaludo.Text = " ";
            // 
            // txtSWelcome
            // 
            this.txtSWelcome.Location = new System.Drawing.Point(182, 185);
            this.txtSWelcome.Multiline = true;
            this.txtSWelcome.Name = "txtSWelcome";
            this.txtSWelcome.Size = new System.Drawing.Size(341, 144);
            this.txtSWelcome.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSWelcome);
            this.Controls.Add(this.txtSaludo);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox txtSaludo;
        private System.Windows.Forms.TextBox txtSWelcome;
    }
}

