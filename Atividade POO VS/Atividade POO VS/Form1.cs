namespace Atividade_POO_VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}