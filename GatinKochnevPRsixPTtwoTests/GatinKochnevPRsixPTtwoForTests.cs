using Microsoft.VisualStudio.TestTools.UnitTesting;
using GatinKochnevPRsixPTtwo;
using System;

namespace GatinKochnevPRsixPTtwoTests
{
    [TestClass]
    public class GatinKochnevPRsixPTtwoForTests
    {
        /// <summary>
        /// Данный класс исполняет тесты
        /// </summary>
        
        /// <summary>
        /// Тест уравнения 1
        /// </summary>
        [TestMethod]
        public void Equation1Test()
        {
            double x = 20;
            double y = 21;
            double z = 22;
            MathEquationForTest mat = new MathEquationForTest();
            double result = mat.GetEquation1(x, y, z);
        }
        /// <summary>
        /// Тест уравнения 2 с математической функцией shX
        /// </summary>
        [TestMethod]
        public void Equation2Test1()
        {
            MathEquationForTest mat = new MathEquationForTest();
            double x = 20;
            double y = 21;
            MathEquationForTest.MatFx funcX_local = MathEquationForTest.MatFx.shX;
            double result = mat.GetEquation2(x, y, funcX_local);
        }
        /// <summary>
        /// Тест уравнения 2 с математической функцией e в квадрате
        /// </summary>
        [TestMethod]
        public void Equation2Test2()
        {
            MathEquationForTest mat = new MathEquationForTest();
            double x = 20;
            double y = 21;
            MathEquationForTest.MatFx funcX_local = MathEquationForTest.MatFx.eX;
            double result = mat.GetEquation2(x, y, funcX_local);
        }

        /// <summary>
        /// Тест уравнения 2 с математической функцией x в квадрате
        /// </summary>
        [TestMethod]
        public void Equation2Test3()
        {
            MathEquationForTest mat = new MathEquationForTest();
            double x = 20;
            double y = 21;
            MathEquationForTest.MatFx funcX_local = MathEquationForTest.MatFx.x2;
            double result = mat.GetEquation2(x, y, funcX_local);
        }

        /// <summary>
        /// Тест уравнения 3
        /// </summary>
        [TestMethod]
        public void Equation3Test()
        {
            double x = 20;
            MathEquationForTest mat = new MathEquationForTest();
            double result = mat.GetEquation3(x);
        }

    }
}
