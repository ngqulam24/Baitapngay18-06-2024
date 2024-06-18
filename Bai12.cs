using System;
using System.Text;

class Program
{
    static void Main()
        {
        Console.OutputEncoding = Encoding.UTF8;
        // Khai báo biến n kiểu ushort (số nguyên 2 byte không dấu)
        ushort n;

        // Gọi hàm ReadUShort() để nhập giá trị của n
        n = ReadUShort();

        // In ra giá trị n đã nhập
        Console.WriteLine($"Giá trị của n đã nhập: {n}");

        // Tính tổng bình phương các số từ 1 đến n
        long sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += (long)i * i;
        }

        // In ra kết quả tính toán
        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sum}");
    }

    /// <summary>
    /// Hàm đọc số nguyên không dấu 2 byte từ bàn phím, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <returns>Số nguyên không dấu 2 byte được nhập từ bàn phím.</returns>
    static ushort ReadUShort()
    {
        ushort value;
        while (true)
        {
            Console.Write("Nhập số nguyên không dấu 2 byte: ");
            if (ushort.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }
}