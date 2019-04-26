using miForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miForm
{
    public partial class Form1 : Form
    {
        private string[][] franz;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //string regreso = miWS.GetData2(Int32.Parse(textBox1.Text));
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client miWS = new ServiceReference1.Service1Client();
            franz = miWS.GetOrden2();

            if (franz[0][0] == "000040144289")
            {
                txtCentro.Text = franz[1][0];
                txtOrdenProceso.Text = franz[0][0];
                txtProducto.Text = franz[3][0];
            }
            else if (franz[0][0] == "2")
            {
                MessageBox.Show("Codigo de Orden 2");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCentro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
