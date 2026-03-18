using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatinKochnevPRsixPTtwo
{
    public class MathEquationForTest
    {
        /// <summary>
        /// Данный класс используется для хранения всех функций и методов,
        /// которые будут тестироваться
        /// MatFx - переменная, позволяющая выбрать математическую функцию
        /// Используется для второго уравнения
        /// </summary>
        public enum MatFx
        {
            shX, eX, x2
        }
        /// <summary>
        /// Уравнение 1
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double GetEquation1(double x, double y, double z)
        {
            var partLeftUp = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), (1 / 3));
            var partLeftDown = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;
            var partLeft = partLeftUp / partLeftDown;

            var partRight1 = Math.Pow(Math.E, Math.Abs(x - y));
            var partRight2 = Math.Pow((Math.Pow(Math.Tan(z), 2) + 1), x);
            var partRight = partRight1 * partRight2;

            var result = partLeft - partRight;
            return result;
        }
        /// <summary>
        /// Уравнение 2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="funcX_local"></param>
        /// <returns></returns>
        public double GetEquation2(double x, double y, MatFx funcX_local)
        {
            double funcX = 0;
            double result = 0;

            if (funcX_local == MatFx.shX)
            {
                funcX = Math.Sinh(x);
            }
            else if (funcX_local == MatFx.eX)
            {
                funcX = Math.Pow(Math.E, x);
            }
            else if (funcX_local == MatFx.x2)
            {
                funcX = Math.Pow(x, 2);
            }

            if (x / y > 0)
            {
                result = Math.Log10(funcX) + Math.Pow((Math.Pow(funcX, 2) + y), 3);
            }
            else if (x / y < 0)
            {
                result = Math.Log10(Math.Abs(funcX / y)) + Math.Pow((funcX + y), 3);
            }
            else if (x == 0)
            {
                result = Math.Pow((Math.Pow(funcX, 2) + y), 3);
            }
            else if (y == 0)
            {
                result = 0;
            }

            return result;
        }
        /// <summary>
        /// Уравнение 3
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double GetEquation3(double x)
        {
            double result = 0;
            double x0 = -0.75;
            double a = 1.5;
            double b = 1.2;

            double y = 1.2 * Math.Pow((a - b), 3) * Math.Pow(Math.E, Math.Pow(x, 2)) + x;

            result = y;

            return result;
        }

        public static void Main()
        {
            
        }
    }
}
