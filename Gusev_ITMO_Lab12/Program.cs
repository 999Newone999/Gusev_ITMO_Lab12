using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputOk;
            double radius=0;

            double X = 0;
            double Y = 0;
            double X0 = 0;
            double Y0 = 0;

            do
            {
                inputOk = true;
                Console.Write("Введите радиус окружности: ");
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }

                if (radius < 0)
                {
                    Console.WriteLine("Радиус окружности должен быть больше или равен нулю.");
                    inputOk = false;
                }
            
            }while (inputOk==false);
            Console.WriteLine("Длина окружности: {0}", Circle.Circumference(radius));
            Console.WriteLine("площадь круга: {0}", Circle.AreaOfCircle(radius));

            Console.WriteLine("Введите координаты точки (Х, Y).");
            do
            {
                Console.Write("X = ");
                inputOk = true;
                try
                {
                    X = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }           
            }while (inputOk==false);

            do
            {
                Console.Write("Y = ");
                inputOk = true;
                try
                {
                    Y = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }
            } while (inputOk == false);
        

            Console.WriteLine("Введите координаты центра круга (Х0, Y0) и его радиус R.");
           
            do
            {
                Console.Write("X0 = ");
                inputOk = true;
                try
                {
                    X0 = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }           
            }while (inputOk==false);

            do
            {
                Console.Write("Y0 = ");
                inputOk = true;
                try
                {
                    Y0 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }
            } while (inputOk == false);
        
            do
            {
                Console.Write("R = ");
                inputOk = true;
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    inputOk = false;
                }
                if (radius < 0)
                {
                    Console.WriteLine("Радиус окружности должен быть больше или равен нулю.");
                    inputOk = false;
                }
            } while (inputOk == false);

            if (Circle.IncludeInCircle(X0, Y0, X, Y, radius))
                Console.WriteLine("Точка ({0}, {1}) попадает в круг с центром в точке ({2}, {3}) и радиусом {4}.", X, Y, X0, Y0, radius);
            else
                Console.WriteLine("Точка ({0}, {1}) не попадает в круг с центром в точке ({2}, {3}) и радиусом {4}.", X, Y, X0, Y0, radius);
            Console.ReadKey();
        }


        public class Circle
        {
            public double Radius { set; get; }

            public static double Circumference(double Radius)
            { 
                return 2*Math.PI*Radius;
            }

            public static double AreaOfCircle(double Radius)
            {
                return Math.PI * Math.Pow(Radius,2);
            }

            public static bool IncludeInCircle(double X0, double Y0, double X, double Y, double Radius)
            {
                // Точка (X,Y) находится в круге с центров в точке (Х0, Y0) и радиусом R
                // если выполняется условие: (Х-Х0)^2 + (Y-Y0)^2 <=R^2
                if (Math.Pow((X - X0), 2) + Math.Pow((Y - Y0), 2) <= Math.Pow(Radius, 2))
                    return true;
                else
                    return false;
            }
        }
    }
}
