using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        // Khai báo biến n kiểu byte (số nguyên 1 byte không dấu)
        byte n;

        // Gọi hàm ReadByte() để nhập giá trị của n
        n = ReadByte();

        // In ra giá trị n đã nhập
        Console.WriteLine($"Giá trị của n đã nhập: {n}");
    }

    /// <summary>
    /// Hàm đọc số nguyên không dấu 1 byte từ bàn phím, giá trị nằm trong khoảng 2 đến 10, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <returns>Số nguyên không dấu 1 byte được nhập từ bàn phím.</returns>
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhập số nguyên không dấu 1 byte (từ 2 đến 10): ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
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