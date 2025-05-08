using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_DL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lblResultado.Text = "";
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                long factorial = 1;
                for (int i = 0; i > 0; i--)
                {
                    factorial = factorial * 1; //1*5=5,5*4=20,20*3=60,60*2=120,120*1=120=120
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
