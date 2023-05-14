namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soma = 0, valor, media,cont=0;
            foreach (Control controlador in this.Controls)
            {
                if (controlador is TextBox && ((TextBox)controlador).Text!="")
                {
                    valor = Convert.ToSingle(((TextBox)controlador).Text);
                    soma += valor;
                    cont++;
                }
            }
            media = soma / cont;
            this.Controls["textBox5"].Text=media.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 outroform = new Form2();
            outroform.Visible = true;
            this.Visible = false;
        }
    }
}