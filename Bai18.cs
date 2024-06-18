using System;
using System.Text;

public class Program
{
    public static double ReadDouble()
    {
        double value;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập 1 số để tính căn bậc 2: ");
        double x = ReadDouble();
        Console.WriteLine($"Căn bậc 2 của {x} là {Math.Sqrt(x)}");
    }
}