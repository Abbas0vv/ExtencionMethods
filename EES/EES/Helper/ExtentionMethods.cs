using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EES.Helper
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static string ToCapitalize(this string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public static int[] GetValueIndexes(this char letter)
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

        public static bool CustomContains(this string prg, string word)
        {
            string empty = "";
            for (int i = 0; i < prg.Length; i++)
            {
                if (prg[i] == ' ')
                {
                    if (empty.ToUpper() == word.ToUpper())
                        return true;
                    else
                    {
                        empty = "";
                        i++;
                    }
                }

                empty += prg[i];
            }
            return false;
        }
    }
}
