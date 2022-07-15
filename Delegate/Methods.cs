using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Methods
    {
        public static bool per(int a)
        {
            if (a > 3)
            {
                return true;
            }
            return false;
        }
        public static double Addition(double a, double b) => a + b;

        public static double Subtraction(double a, double b) => a - b;

        public static double Mulityplaction(double a, double b) => a * b;

        public static double Division(double a, double b) => a / b;
        public static double ChoiseMethod(double a)
        {
            Console.WriteLine("Выбирете функцию:\n 1.Addition\n 2.Subtraction\n 3.Mulityplaction\n 4.Division");
            var x=Console.ReadLine();
            Console.WriteLine("Введите числo   : ");
            
            var b= Convert.ToDouble(Console.ReadLine());
            switch (x)
            {
                case "1":
                    Console.WriteLine(Addition(a, b));
                    return Addition(a, b);
                    break;
                case "2":
                    Console.WriteLine(Subtraction(a, b));
                    return Subtraction(a, b);
                    break;
                case "3":
                    Console.WriteLine(Mulityplaction(a, b));
                    return Mulityplaction(a, b);
                    break;
                case "4":
                    Console.WriteLine(Division(a, b));
                    return Division(a, b);
                    break;
                default: 
                    Console.WriteLine("чё-то не то выбрали");
                    return a;
                    break;

            }
        }
    }
}
