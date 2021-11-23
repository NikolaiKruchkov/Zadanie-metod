using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба, затем нажмите Enter");
            double l = Convert.ToDouble(Console.ReadLine());
            static void CalcSv(double l1)
            {
                double s = Math.Sqrt(l1) * 6;
                double v = Math.Pow(l1, 3);
                Console.WriteLine("При длине ребра куба {0}, площадь его поврхности составляет {1}, а объем {2}", l1,s,v);
                
            }
            CalcSv(l);
            
            Console.WriteLine("Спасибо, что использовали нашу программу. Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
