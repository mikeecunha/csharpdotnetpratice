namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_welcome.ForeColor = Color.Red;
        }

        private void menu_ex1_Click(object sender, EventArgs e)
        {
            ex1A novoForm = new ex1A();
            novoForm.Show();
        }
    }
}