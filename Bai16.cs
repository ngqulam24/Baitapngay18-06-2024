using System;
using System.Text;

class Program
{
    
    static byte ReadByteWithinRange(byte min, byte max)
    {
        byte value;
        while (true)
        {
            Console.Write($"Nhập số nguyên 1 byte trong khoảng từ {min} đến {max}: ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static int ReadInt32()
    {
        int value;
        while (true)
        {
            Console.Write("Nhập số nguyên 4 byte: ");
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static int[,] ReadInt32Array(byte m, byte n)
    {
        int[,] array = new int[m, n];
        for (byte i = 0; i < m; i++)
        {
            for (byte j = 0; j < n; j++)
            {
                Console.Write($"Nhập phần tử [{i},{j}]: ");
                array[i, j] = ReadInt32();
            }
        }
        return array;
    }

    static int SumDivisibleByP(int[,] array, int p)
    {
        int sum = 0;
        foreach (int element in array)
        {
            if (element % p == 0)
                sum += element;
        }
        return sum;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        byte m = ReadByteWithinRange(2, 10);
        byte n = ReadByteWithinRange(2, 10);
        Console.WriteLine($"Giá trị của m = {m}, n = {n}");

        int[,] a = new int[m, n];
        a = ReadInt32Array(m, n);
        Console.WriteLine("Mảng a đã được nhập:");
        for (byte i = 0; i < m; i++)
        {
            for (byte j = 0; j < n; j++)
                Console.Write($"{a[i, j]} ");
            Console.WriteLine();
        }

        int sum = SumDivisibleByP(a, 2024);
        Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {sum}");
    }
}