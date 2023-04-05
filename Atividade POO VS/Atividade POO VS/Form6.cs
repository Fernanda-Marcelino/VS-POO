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
    public partial class Form6 : Form
    {
        double voto, c1, c2, c3, total, porcent;

        public Form6()
        {
            InitializeComponent();
        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }

        private void btnjose_Click(object sender, EventArgs e)
        {
            c1++;
            lblnome.Text = "Você votou em José Nascimento";
        }

        private void btnfim_Click(object sender, EventArgs e)
        {
            btnjoao.Enabled = false;
            btnjose.Enabled = false;
            btnmaria.Enabled = false;
            lblnome.Text = "...";

            total = c1 + c2 + c3;
            txtvotos.Text = total.ToString();

            if (c1 > c2 && c1 > c3)
            {
                porcent = (c1 * 100) / total;
                txtganhador.Text = "José Nascimento".ToString();
                txtvotos.Text = porcent.ToString();
            }
            else if (c2 > c1 && c2 > c3)
            {
                porcent = (c2 * 100) / total;
                txtganhador.Text = "Maria Juruma".ToString();
                txtvotos.Text = porcent.ToString();
            }
            else if (c3 > c1 && c3 > c2)
            {
                porcent = (c3 * 100) / total;
                txtganhador.Text = "João da Tapioca".ToString();
                txtvotos.Text = porcent.ToString();
            }
        }

        private void btnmaria_Click(object sender, EventArgs e)
        {
            c2++;
            lblnome.Text = "Você votou em Maria Juruma";
        }

        private void btnjoao_Click(object sender, EventArgs e)
        {
            c3++;
            lblnome.Text = "Você votou em João da Tapioca";
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            txtganhador.Clear();
            txtvotos.Clear();
            lblnome.Text = "...";
            c1 = 0;
            c2 = 0;
            c3 = 0;
            btnjose.Enabled = true;
            btnmaria.Enabled = true;
            btnjoao.Enabled = true;

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
