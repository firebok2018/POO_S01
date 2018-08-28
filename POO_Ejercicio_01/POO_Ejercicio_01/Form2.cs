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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Continuar programa");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int num = Int32.Parse(txtn1.Text);
            int n1, n2;

            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            //string num = txtn1.Text;
            // MessageBox.Show((n1+n2).ToString());
            MessageBox.Show(""+(n1 + n2));
        }

        private void cboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
