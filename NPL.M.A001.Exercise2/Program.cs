// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace NumberConversion
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số tự nhiên từ cơ số 10 để chuyển đổi sang cơ số 2: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = ConvertToBinary(decimalNumber);
            Console.WriteLine($"{decimalNumber}  -> {binaryNumber} ");
        }

        static string ConvertToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }
    }
}

