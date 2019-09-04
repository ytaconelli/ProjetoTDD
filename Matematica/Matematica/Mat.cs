using System;

namespace Matematica
{
    public class Mat
    {
        public static string msgErroRaizValorNegativo = "Não existe solução nos conjuntos dos reais";

        public double RaizQuadrada(double entrada)
        {
            if (entrada < 0)
                throw new ArgumentOutOfRangeException("entrada", entrada, msgErroRaizValorNegativo);

            return Math.Pow(entrada, 1.0 / 2.0);
        }

        public double MediaAritmetica(double[] num)
        {

            double soma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }

            return soma / (double)num.Length;
        }
    }
}
