using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Ejercicio_01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEjec_Click(object sender, EventArgs e)
        {
            Rectangulo re = new Rectangulo();

            re.B = double.Parse(txtBase.Text);
            re.H = double.Parse(txtAltura.Text);

            txtarea.Text = re.calcArea().ToString();
            txtperi.Text = re.calcPerimetro().ToString();
            txtdiag.Text = re.calcPerimetro().ToString();

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            txtBase.Text = null;
            txtAltura.Text = "";
            txtarea.Clear();
            txtperi.Text = "";
            txtdiag.Clear();
        }
    }
}
