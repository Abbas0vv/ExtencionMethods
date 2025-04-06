using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EES
{
    public class ExtentionMethods
    {
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static string ToCapitalize(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public static int[] GetValueIndexes(char letter)
        {
            string word = "Abbasov";
            int[] indexes = new int[word.Length];

            int index = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    indexes[index] += i;
                    index++;
                }
            }

            return indexes;
        }

        public static bool CustomContains(string word)
        {
            string prg = "Software Development from CodeForFuture.";
            string empty = "";
            for (int i = 0; i < prg.Length; i++)
            {
                if (prg[i] == ' ' && empty.ToUpper() == word.ToUpper())
                    return true;
                
                empty += prg[i]; 
            }
            return false;
        }
    }
}
