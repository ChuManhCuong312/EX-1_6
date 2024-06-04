using System;

namespace ASoNguyen4byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("a. Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực");
            Console.WriteLine("b. Tính tổng mảng số thực");
            Console.Write("Nhập lựa chọn (a/b): ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
                    FindMinMax();
                    break;

                case 'b':
                    // Tính tổng mảng số thực
                    CalculateSum();
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
        static void FindMinMax()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            float[] numbers = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToSingle(Console.ReadLine());
            }

            float min = numbers[0];
            float max = numbers[0];

            foreach (float num in numbers)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine($"Giá trị nhỏ nhất: {min}");
            Console.WriteLine($"Giá trị lớn nhất: {max}");
        }

        // Tính tổng mảng số thực
        static void CalculateSum()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            float[] numbers = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToSingle(Console.ReadLine());
            }

            float sum = 0;
            foreach (float num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Tổng của các số trong mảng: {sum}");
        }
    }
}
