using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        String text = "What is the only thing, that we need in life?";
        String key = "love";
        string tmp = CodeTextAndDecode(text, key);
        Console.WriteLine(tmp);//crypt
        Console.WriteLine(CodeTextAndDecode(tmp,key));//decrypt
    }

    private static string CodeTextAndDecode(string text, string key)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            str.Append((char)(text[i] ^ key[i%key.Length]));
        }
        return str.ToString();
    }
}

