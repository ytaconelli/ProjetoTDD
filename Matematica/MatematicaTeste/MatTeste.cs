using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatematicaTeste
{
    [TestClass]
    public class MatTeste
    {
        [TestMethod]
        public void RaizQuadradaBasicaTeste()
        {
            Mat m = new Mat();
            double esperado = 2.0;
            double entrada = esperado * esperado;
            double ResultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, ResultadoReal, esperado / 100);
        }

        [TestMethod]
        public void RaizQuadradaInteiroPositivoTeste()
        {
            Mat m = new Mat();
            double esperado = 5.7;
            double entrada = esperado * esperado;
            double ResultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, ResultadoReal, esperado / 100);
        }

        [TestMethod]
        public void RaizQuadradaValorNegativoTeste()
        {
            Mat m = new Mat();
            double entrada = -1.0;

            try
            {
                m.RaizQuadrada(entrada);
            }

            catch(ArgumentOutOfRangeException ae)
            {
                StringAssert.Contains(ae.Message, Mat.msgErroRaizValorNegativo);
                return;
            }

            Assert.Fail("O método não lançou a exceção esperada");

            
        }
        [TestMethod]
        public void RaizQuadradaInteiroNegativoTeste()
        {
            Mat m = new Mat();
            double entrada = -5.7;

            try
            {
                m.RaizQuadrada(entrada);
            }

            catch (ArgumentOutOfRangeException ae)
            {
                StringAssert.Contains(ae.Message, Mat.msgErroRaizValorNegativo);
                return;
            }

            Assert.Fail("O método não lançou a exceção esperada");
        }


        [TestMethod]
        public void MediaAritmeticaTeste()
        {
            Mat m = new Mat();
            double[] num = new double[3];
            num[0] = 5.0;
            num[1] = 3.0;
            num[2] = 7.0;

            double esperado = 5.0;
            double ResultadoReal = m.MediaAritmetica(num);

            Assert.AreEqual(esperado, ResultadoReal, 0.01);
        }

    }
}
