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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            ventas v = new ventas();
            v.Precio = double.Parse(txtprecio.Text);
            //v.Des = double.Parse(txtdesc.Text);

            //MessageBox.Show("si ejecuta" +v.calDesc().ToString());
            txtprecioventa.Text = v.calPreventa().ToString();
            txtdesc.Text = v.calDesc().ToString();
        }
    }
}
