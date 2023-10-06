// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Tính giá trị của x trong phương trình ax^2 + bx + c = 0");
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập hệ số b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập hệ số c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình không có nghiệm.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình có một nghiệm: x = {x}");
            }
        }
        else
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm : x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có một nghiệm : x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình không có nghiệm .");
            }
        }
    }
}
