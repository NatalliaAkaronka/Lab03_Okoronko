using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Okoronko
{
    class Program
    {
        static double Fact(double y)
        {
            return (y == 0) ? 1 : y * Fact(y - 1);
        }

            static void Main(string[] args)
        {
            Console.Title = "Циклы с контролем за монотонной велечиной";
            Console.Write("Введите переменную х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность: ");
            double точность = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            int k = 0;
            while (Math.Abs(Math.Pow(-1, k) / (2 * k + 1) * Math.Pow((x / 2), (2 * k + 1)) / Fact(k)) > точность)
            {
                s+= Math.Pow(-1, k) / (2*k + 1)*Math.Pow((x/2),(2*k+1))/Fact(k);
                k++;
                
                
            }
            string txt = "Сумма слагаемых равна: ";
            Console.WriteLine(txt+s);
            Console.ReadLine();
        }
    }
}
