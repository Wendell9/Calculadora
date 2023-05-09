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
                }
                cont++;
            }
            media = soma / cont;
            this.Controls["label6"].Text=media.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double multiplica = 1, valor;
            foreach (Control controlador in this.Controls)
            {
                if (controlador is TextBox && ((TextBox)controlador).Text != "")
                {
                    valor = Convert.ToSingle(((TextBox)controlador).Text);
                    multiplica *= valor;
                }
            }
            this.Controls["label6"].Text = multiplica.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double soma = 0, valor;
            foreach (Control controlador in this.Controls)
            {
                if (controlador is TextBox && ((TextBox)controlador).Text != "")
                {
                    valor = Convert.ToSingle(((TextBox)controlador).Text);
                    soma += valor;
                }
            }
            this.Controls["label6"].Text = soma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double resultado = 1, valor;
            foreach (Control controlador in this.Controls)
            {
                if (controlador is TextBox && ((TextBox)controlador).Text != "")
                {
                    valor = Convert.ToSingle(((TextBox)controlador).Text);
                    resultado=valor/resultado;
                }
            }
            this.Controls["label6"].Text = resultado.ToString();
        }
    }
}