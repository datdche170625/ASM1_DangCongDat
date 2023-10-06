
// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace FibonacciSeries
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng số Fibonacci cần in ra: ");  //Yêu cầu người dùng nhập số lượng số Fibonacci cần in ra
            int n = int.Parse(Console.ReadLine());

            PrintFibonacci(n); //Gọi hàm PrintFibonacci để in ra dãy số Fibonacci
        }

        static void PrintFibonacci(int n)
        {
            int first = 1, second = 1;

            Console.WriteLine($"{n} số Fibonacci mà bạn cần là:"); //Hiển thị số số Fibonacci mà người dùng muốn in ra
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(first);

                int next = first + second;  //Tính toán số Fibonacci tiếp theo
                first = second;
                second = next;
            }
        }
    }
}


