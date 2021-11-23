using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину 1 стороны 1 треугольника, затем нажмите Enter");
            double l1_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны 1 треугольника, затем нажмите Enter");
            double l2_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину 3 стороны 1 треугольника, затем нажмите Enter");
            double l3_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину 1 стороны 2 треугольника, затем нажмите Enter");
            double l1_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны 2 треугольника, затем нажмите Enter");
            double l2_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину 3 стороны 2 треугольника, затем нажмите Enter");
            double l3_2 = Convert.ToDouble(Console.ReadLine());
            static double CalcS(double d1, double d2, double d3, out double s)
            {
                s= Math.Sqrt(((d1+d2+d3) / 2) * (((d1 + d2 + d3) / 2) - d1) * (((d1 + d2 + d3) / 2) - d2) * (((d1 + d2 + d3) / 2) - d3));
                return s;
            }
            
            if (CalcS(l1_1,l2_1,l3_1, out double s1)< CalcS(l1_2, l2_2, l3_2, out double s2))
            {
                Console.WriteLine("Площадь первого треугольника меньше площади второго");
            }
            if (CalcS(l1_1, l2_1, l3_1, out double s3) > CalcS(l1_2, l2_2, l3_2, out double s4))
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            if (CalcS(l1_1, l2_1, l3_1, out double s5) == CalcS(l1_2, l2_2, l3_2, out double s6))
            {
                Console.WriteLine("Площадь первого треугольника равна площади второго");
            }
            Console.WriteLine("Спасибо, что использовали нашу программу. Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
