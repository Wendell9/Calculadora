using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "÷";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "X";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
           int posicao,posicao1,posicao2;
            double resultado = 0;
            double a, b;
            string operacao = this.Controls["textBox1"].Text;
        Inicio:
            if (operacao.IndexOf('X') < operacao.IndexOf('÷'))
            {
                if (operacao.Contains('X'))
                {
                    posicao = operacao.IndexOf("X");
                    a=Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b =Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.multiplicacao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2-posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('÷'))
                {
                    posicao = operacao.IndexOf("÷");
                    a = Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.divisao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.soma(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                Console.WriteLine(resultado);
            }
            else
            {
                if (operacao.Contains('÷'))
                {
                    posicao = operacao.IndexOf("÷");
                    a = Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.divisao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('X'))
                {
                    posicao = operacao.IndexOf("X");
                    a = Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.multiplicacao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = Operacoes.coletanumerosantes(operacao, posicao)[0];
                    posicao1 = (int)Operacoes.coletanumerosantes(operacao, posicao)[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao)[0];
                    posicao2 = (int)Operacoes.coletanumerodepois(operacao, posicao)[1];
                    resultado = Operacoes.soma(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
            }
            this.Controls["textBox1"].Text = resultado.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 outroform = new Form1();
            outroform.Visible = true;
            this.Visible = false;
        }
    }
}
