using System;

namespace SoNguyen2byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("a. Tính tổng mảng số nguyên không dấu 2 byte");
            Console.WriteLine("b. Tính tổng mảng số nguyên có dấu 2 byte");
            Console.Write("Nhập lựa chọn (a/b): ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    // Tính tổng mảng số nguyên không dấu 2 byte
                    CalculateUnsignedSum();
                    break;

                case 'b':
                    // Tính tổng mảng số nguyên có dấu 2 byte
                    CalculateSignedSum();
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        // Tính tổng mảng số nguyên không dấu 2 byte
        static void CalculateUnsignedSum()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            ushort[] numbers = new ushort[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToUInt16(Console.ReadLine());
            }

            uint sum = 0;
            foreach (ushort num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Tổng của các số trong mảng: {sum}");
        }

        // Tính tổng mảng số nguyên có dấu 2 byte
        static void CalculateSignedSum()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            short[] numbers = new short[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }

            int sum = 0;
            foreach (short num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Tổng của các số trong mảng: {sum}");
        }
    }
}
