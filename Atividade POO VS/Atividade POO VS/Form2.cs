using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_POO_VS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double litro, valor, result;

            litro = Convert.ToDouble(txttipo2.Text);

            char comb;
            comb = Convert.ToChar(txttipo.Text);

            if (litro <= 20)
            {
                if (comb == 'A')
                {
                    valor = ((litro * 4.90 * 3) / 100);
                    result = ((litro * 4.90) - valor);
                    txtdesc.Text = valor.ToString();
                    txtvalor.Text = result.ToString();
                }
                else
                {
                    valor = (litro * 4.90 * 5) / 100;
                    result = (litro * 4.90) / valor;
                    txtdesc.Text = valor.ToString();
                    txtvalor.Text = result.ToString();
                }
                if (comb == 'G')
                {
                    if (litro <= 20)
                    {
                        valor = (litro * 5.50 * 4) / 100;
                        result = (litro * 5.50) - valor;
                        txtdesc.Text = valor.ToString();
                        txtvalor.Text = result.ToString();


                    }
                    else
                    {
                        valor = (litro * 5.50 * 6) / 100;
                        result = (litro * 5.50) - valor;
                        txtdesc.Text = valor.ToString();
                        txtvalor.Text = result.ToString();
                    }
                }
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttipo.Clear();
            txttipo2.Clear();
            txtdesc.Clear();
            txtvalor.Clear();

            txttipo.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
