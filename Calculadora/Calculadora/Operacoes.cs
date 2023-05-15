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
            if (a < 0 && b < 0)
            {
                return a + b;
            }
            return a - Math.Abs(b);
        }

        public static double[] coletanumerosantes(string operacao, int posicao, char simbolo)
        {
            double[] a = new double[2];
            bool negativo = false;
            if (operacao[0] == '-')
            {
                negativo = true;
                operacao = operacao.Remove(0, 1);
                posicao = operacao.IndexOf(simbolo);
            }
            for (int i = 1; 0 <= posicao - i; i++)
            {
                if ((operacao.Substring(posicao - i, 1) == "X" || operacao.Substring(posicao - i, 1) == "÷" || operacao.Substring(posicao - i, 1) == "-" || operacao.Substring(posicao - i, 1) == "+"))
                {
                    if (operacao.Substring(posicao - i, 1) == "-")
                    {
                        a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i), CultureInfo.InvariantCulture);
                        a[1] = posicao - i;
                    }
                    break;
                }
                else if (operacao.Substring(posicao - i, 1) == ".")
                {
                    i++;
                    a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i), CultureInfo.InvariantCulture);
                    a[1] = posicao - i;
                }
                else
                {
                    a[0] = Convert.ToDouble(operacao.Substring(posicao - i, i), CultureInfo.InvariantCulture);
                    a[1] = posicao - i;
                }
            }
            if (negativo)
            {
                a[0] *= (-1);
            }
            return a;
        }

        public static double[] coletanumerodepois(string operacao, int posicao)
        {
            double[] b = new double[2];
            bool negativo = false;
            if (operacao[posicao] == '-')
            {
                negativo = true;
                operacao = operacao.Remove(0, 1);
                posicao = operacao.IndexOf("-");
            }
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
            if (negativo)
            {
                b[0] *= (-1);
                b[1]++;
            }
            return b;
        }
    }
}
