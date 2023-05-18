using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using figurasGeometricas;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circulo cr = new Circulo();
            double  d =  cr.getRadio();
            double test =  figurasGeometricas.Program.debeSerUno(d);
            Assert.AreEqual("1", test);            
        }
       
        [TestMethod]
        public void DebeSer1()
        {
            figurasGeometricas.Rectangulo ds = new figurasGeometricas.Rectangulo();
            double test = figurasGeometricas.Program.debeSerUno(d);
            Assert.AreEqual("1", test);
        }

    }
}
