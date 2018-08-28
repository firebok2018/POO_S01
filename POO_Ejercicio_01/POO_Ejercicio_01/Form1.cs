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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nom;
            nom = txtSaludo.Text;

            txtSWelcome.Text = "buenos dias" + nom;
            MessageBox.Show("WELCOME"+ nom);
        }
    }
}
