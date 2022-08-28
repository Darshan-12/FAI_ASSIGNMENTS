using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    class Assignment9
    {
        static void Main(string[] args)
        {
            string input = Util.GetString("Enter the input string");
            string reversedSentence=reverseByWords(input);
            Console.WriteLine(reversedSentence);
        }
        public static string reverseByWords(string sentence)
        {
            string[] words = sentence.Split();
            string[] reverse= new string[words.Count()];
            for (int i = words.Count() - 1, j = 0; i>=0; i--, j++)
                reverse[j] = words[i];
            return string.Join(" ",reverse);
        }
    }
}
