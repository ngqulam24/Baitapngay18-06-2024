using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khai báo biến x kiểu float (số thực 4 byte)
        float x;

        // Gọi hàm ReadFloat() để nhập giá trị của x
        x = ReadFloat();

        // In ra giá trị x đã nhập
        Console.WriteLine($"Giá trị của x đã nhập: {x}");
    }

    /// <summary>
    /// Hàm đọc số thực 4 byte từ bàn phím, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <returns>Số thực 4 byte được nhập từ bàn phím.</returns>
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            Console.Write("Nhập số thực 4 byte: ");
            if (float.TryParse(Console.ReadLine(), out value))
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