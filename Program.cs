using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "We are learning C# and it is FUN and EASY.   Okay maybe just FUN.  ";
            Console.WriteLine(Substring(statement));
            Console.WriteLine(Substring2(statement));
        }

        static string Substring(string sentence)
        {
            const int MaxLength = 5;

            if (sentence.Length > MaxLength)
                sentence = sentence.Substring(0, MaxLength);

            Console.WriteLine(sentence.Length);
            return sentence;
        }

        static string Substring2(string sentence)
        {
            sentence = sentence.Replace(" ", String.Empty);
            const int MaxLength = 5;
            if (sentence.Length > MaxLength)
                sentence = sentence.Substring(0, MaxLength);
            Console.WriteLine(sentence.Length);
            return sentence;
        }
    }
}
