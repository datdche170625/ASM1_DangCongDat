// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;

            // Yêu cầu người dùng nhập số nguyên dương và kiểm tra
            do
            {
                Console.Write("Nhập một số nguyên dương: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Số nhập vào không hợp lệ. Hãy nhập lại.");
                }
            } while (number < 0);

            // Khi người dùng đã nhập số hợp lệ thì tiền hành kiểm tra xem số đó có phải số nguyên tố hay không

            if (CheckPrimeNumber(number))
            {
                Console.WriteLine($"{number} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{number} KHÔNG phải là số nguyên tố.");
            }
        }

        static bool CheckPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}


