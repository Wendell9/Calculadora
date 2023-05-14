using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static double subtracao(double a, double b)
        {
            return a - b;
        }

        public static double[] coletanumerosantes(string operacao, int posicao)
        {
            double[] a = new double[2];
            for (int i = 1; i < posicao + 1; i++)
            {
                if ((operacao.Substring(posicao - i, 1) == "X" || operacao.Substring(posicao - i, 1) == "÷" || operacao.Substring(posicao - i, 1) == "-" || operacao.Substring(posicao - i, 1) == "+"))
                {
                    if (operacao.Substring(posicao - i, 1) == "-")
                    {
                        a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i));
                        a[1] = posicao - i;
                    }
                    break;
                }
                else if (operacao.Substring(posicao - i, 1) == ".")
                {
                    i++;
                    a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i));
                    a[1] = posicao - i;
                }
                else
                {
                    a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i));
                    a[1] = posicao - i;
                }

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
                else if (operacao.Substring(posicao + i, 1) == ".")
                {
                    i++;
                    b[0] = Convert.ToDouble(operacao.Substring(posicao + 1, i), CultureInfo.InvariantCulture);
                    b[1] = posicao + i + 1;
                }
                else
                {
                    b[0] = Convert.ToDouble(operacao.Substring(posicao + 1, i), CultureInfo.InvariantCulture);
                    b[1] = posicao + i + 1;
                }
            }
            return b;
        }
    }
}
