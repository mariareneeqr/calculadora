using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapiCalculadora.Controllers;

namespace utCalculadora
{
    [TestClass]
    public class UnitTest1Calculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act=Ejecucion
            int result = cal.Add(numa, numb);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet2()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = -7;

            //Act=Ejecucion
            int result = cal.Add(numa, numb);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet3()
        {

            //Arrange=Preparacion 
        CalculatorController cal = new CalculatorController();
            int numa = 3;
            int numb = 5;
            int numc = 2;
            int numres = 15;

            //Act=Ejecucion
            int result = cal.Multiply(numa, numb, numc);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet4()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = -3;
            int numb = -5;
            int numc = -2;
            int numres = 15;

            //Act=Ejecucion
            int result = cal.Multiply(numa, numb, numc);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet5()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = 3;
            int numb = 5;
           
            int numres = 15;

            //Act=Ejecucion
            int result = cal.Multiply(numa, numb);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet6()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = -3;
            int numb = -5;

            int numres = 15;

            //Act=Ejecucion
            int result = cal.Multiply(numa, numb);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet7()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 6;
            int numres = 7;

            //Act=Ejecucion
            int result = cal.Add(numa, numb, numc);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet8()
        {

            //Arrange=Preparacion 
            CalculatorController cal = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = 6;
            int numres = -7;

            //Act=Ejecucion
            int result = cal.Add(numa, numb, numc);


            // Assert=verificacion
            Assert.AreEqual(numres, result);
        }
    }
}
