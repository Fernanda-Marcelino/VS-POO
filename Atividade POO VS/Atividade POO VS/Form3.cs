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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double num, result, i;

            num = Convert.ToDouble(txtnum.Text);
            i = 1;
            while (i <= 10)
            {
                result = num * 1;
                txtresult.Text = String.Concat(txtresult.Text, "\n\n", num.ToString() + "X" + i.ToString() + "=" + result.ToString());


                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }
    }
}
