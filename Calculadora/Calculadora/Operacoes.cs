using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacoes
    {
        public static double soma(double a, double b)
        {
            return a + b;
        }

        public static double multiplicacao(double a, double b)
        {
            return a * b;
        }

        public static double divisao(double a, double b)
        {
            return a / b;
        }

        public static double[] coletanumerosantes(string operacao, int posicao)
        {
            double[] a = new double[2];
            for (int i = 1; i < posicao + 1; i++)
            {
                if ((operacao.Substring(posicao - i, 1) == "X" || operacao.Substring(posicao - i, 1) == "÷" || operacao.Substring(posicao - i, 1) == "-" || operacao.Substring(posicao - i, 1) == "+"))
                {
                    break;
                }
                a[0] = double.Parse(operacao.Substring(posicao - i, i));
                a[1] = posicao - i;
            }
            return a;
        }

        public static double[] coletanumerodepois(string operacao, int posicao)
        {
            double[] b = new double[2];
            for (int i = 1; posicao + i < operacao.Length; i++)
            {
                if ((operacao.Substring(posicao + i, 1) == "X" || operacao.Substring(posicao + i, 1) == "÷" || operacao.Substring(posicao + i, 1) == "-" || operacao.Substring(posicao + i, 1) == "+"))
                {
                    break;
                }
                b[0] = double.Parse(operacao.Substring(posicao + 1, i));
                b[1] = posicao + i + 1;
            }
            return b;
        }
    }
}
