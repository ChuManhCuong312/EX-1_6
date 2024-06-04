using System;

namespace SoNguyen1byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("a. Tìm số lớn nhất và nhỏ nhất trong dãy số");
            Console.WriteLine("b. Tính tổng các số chẵn trong dãy số");
            Console.WriteLine("c. Tính tổng các số từ 1 đến n");
            Console.WriteLine("d. Tính tổng các chữ số trong số nguyên không dấu");
            Console.Write("Nhập lựa chọn (a/b/c/d): ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    // Tìm số lớn nhất và nhỏ nhất trong dãy số
                    FindMinMax();
                    break;

                case 'b':
                    // Tính tổng các số chẵn trong dãy số
                    CalculateEvenSum();
                    break;

                case 'c':
                    // Tính tổng các số từ 1 đến n
                    CalculateSumToN();
                    break;

                case 'd':
                    // Tính tổng các chữ số trong số nguyên không dấu
                    CalculateDigitSum();
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        // Tìm số lớn nhất và nhỏ nhất trong dãy số
        static void FindMinMax()
        {
            Console.Write("Nhập số lượng phần tử trong dãy số: ");
            int n = Convert.ToInt32(Console.ReadLine());

            byte[] numbers = new byte[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToByte(Console.ReadLine());
            }

            byte min = numbers[0];
            byte max = numbers[0];

            foreach (byte num in numbers)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine($"Số nhỏ nhất: {min}");
            Console.WriteLine($"Số lớn nhất: {max}");
        }

        // Tính tổng các số chẵn trong dãy số
        static void CalculateEvenSum()
        {
            Console.Write("Nhập số lượng phần tử trong dãy số: ");
            int n = Convert.ToInt32(Console.ReadLine());

            byte[] numbers = new byte[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToByte(Console.ReadLine());
            }

            int evenSum = 0;
            foreach (byte num in numbers)
            {
                if (num % 2 == 0)
                    evenSum += num;
            }

            Console.WriteLine($"Tổng các số chẵn: {evenSum}");
        }

        // Tính tổng các số từ 1 đến n
        static void CalculateSumToN()
        {
            Console.Write("Nhập số nguyên không dấu n: ");
            byte n = Convert.ToByte(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Tổng các số từ 1 đến {n}: {sum}");
        }

        // Tính tổng các chữ số trong số nguyên không dấu
        static void CalculateDigitSum()
        {
            Console.Write("Nhập số nguyên không dấu: ");
            byte number = Convert.ToByte(Console.ReadLine());

            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"Tổng các chữ số: {digitSum}");
        }
    }
}

