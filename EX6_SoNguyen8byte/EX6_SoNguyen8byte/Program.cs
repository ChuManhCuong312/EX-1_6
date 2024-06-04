using System;

namespace SoNguyen8byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("a. Tính trung bình cộng mảng số thực");
            Console.WriteLine("b. Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực");
            Console.Write("Nhập lựa chọn (a/b): ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    // Tính trung bình cộng mảng số thực
                    CalculateAverage();
                    break;

                case 'b':
                    // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
                    FindMinMax();
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        // Tính trung bình cộng mảng số thực
        static void CalculateAverage()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            double average = sum / n;
            Console.WriteLine($"Trung bình cộng của các số trong mảng: {average}");
        }

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
        static void FindMinMax()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double min = numbers[0];
            double max = numbers[0];

            foreach (double num in numbers)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine($"Giá trị nhỏ nhất: {min}");
            Console.WriteLine($"Giá trị lớn nhất: {max}");
        }
    }
}
