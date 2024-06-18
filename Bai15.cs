using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khai báo số nguyên n 1 byte không dấu
        byte n;

        // Gọi hàm ReadByte() để nhập giá trị của n
        n = ReadByte();

        // In ra giá trị n đã nhập
        Console.WriteLine($"Giá trị của n đã nhập: {n}");

        // Khai báo mảng 1 chiều các số thực 4 byte a, và cấp phát để a gồm n phần tử
        float[] a = new float[n];

        // Gọi hàm ReadFloatArray() để nhập giá trị các phần tử của mảng a
        ReadFloatArray(a);

        // In ra giá trị các phần tử của mảng a
        Console.WriteLine("Giá trị của mảng a:");
        foreach (float value in a)
        {
            Console.WriteLine(value);
        }
    }

    /// <summary>
    /// Hàm đọc số nguyên 1 byte không dấu từ 2 đến 10 từ bàn phím, nếu nhập sai thì nhập lại.
    /// </summary>
    /// <returns>Số nguyên 1 byte không dấu từ 2 đến 10.</returns>
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte không dấu từ 2 đến 10: ");
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

    /// <summary>
    /// Hàm nhập giá trị cho mảng số thực 4 byte.
    /// </summary>
    /// <param name="array">Mảng số thực 4 byte cần nhập giá trị.</param>
    static void ReadFloatArray(float[] array)
    {
        Console.WriteLine("Nhập giá trị các phần tử của mảng:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadFloat();
        }
    }
}