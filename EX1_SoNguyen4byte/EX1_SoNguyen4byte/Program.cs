using System;

namespace SoNguyen4byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Nhập và tính toán số nguyên 4 byte");
            Console.WriteLine("2. Tính tổng mảng số nguyên 4 byte");
            Console.WriteLine("3. Đảo ngược chữ số của số nguyên không dấu 4 byte");
            Console.Write("Nhập lựa chọn (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            //Số nguyên 4 byte = Số nguyên 32 bit, 

            switch (choice)
            {
                case 1:
                    // Phần a: Nhập và tính toán số nguyên 4 byte
                    int a, b;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Nhập số nguyên a (4 byte): ");
                            a = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập lại.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Nhập số nguyên b (4 byte): ");
                            b = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập lại.");
                        }
                    }

                    // Tính toán
                    int sum = a + b;
                    int difference = a - b;
                    int product = a * b;
                    int quotient = a / b; // Lấy phần nguyên

                    // Hiển thị kết quả
                    Console.WriteLine($"Tổng: {sum}");
                    Console.WriteLine($"Hiệu: {difference}");
                    Console.WriteLine($"Tích: {product}");
                    Console.WriteLine($"Thương (số nguyên): {quotient}");
                    Console.WriteLine($"Thương (số thực): {(double)a / b}");
                    break;

                case 2:
                    // Phần b: Tính tổng mảng số nguyên 4 byte
                    Console.Write("Nhập số lượng phần tử trong mảng: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int[] arr = new int[n];
                    int arraySum = 0;

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Nhập phần tử thứ {i + 1}: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                        arraySum += arr[i];
                    }

                    Console.WriteLine($"Tổng của các phần tử trong mảng: {arraySum}");
                    break;

                case 3:
                    // Phần c: Đảo ngược chữ số của số nguyên không dấu 4 byte
                    Console.Write("Nhập số nguyên không dấu (4 byte): ");
                    uint number = Convert.ToUInt32(Console.ReadLine());

                    uint reversedNumber = 0;
                    while (number > 0)
                    {
                        uint digit = number % 10;
                        reversedNumber = reversedNumber * 10 + digit;
                        number /= 10;
                    }

                    Console.WriteLine($"Số sau khi đảo ngược chữ số: {reversedNumber}");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
