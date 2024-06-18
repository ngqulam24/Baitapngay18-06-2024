using System;
using System.Text;

public class WordCounter
{
    public static int CountWords(string str)
    {
        // Xóa các khoảng trắng ở đầu và cuối xâu
        str = str.Trim();

        // Nếu xâu trống, trả về 0 từ
        if (string.IsNullOrEmpty(str))
            return 0;

        // Tách xâu thành mảng các từ và đếm số lượng
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập xâu kí tự: ");
        string st = Console.ReadLine();

        if (st == "#")
        {
            // Phát tiếng beep nếu xâu là "#"
            Console.Beep();
        }
        else
        {
            // In ra số từ của xâu
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong xâu: {wordCount}");
        }
    }
}