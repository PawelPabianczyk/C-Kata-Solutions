using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Kata
{
    class Program
    {
        //Square Every Digit 7kyu
        public static int SquareDigits(int n)
        {
            var number = n.ToString();
            string result = "";
            foreach (var x in number)
                result += (Math.Pow((int)Char.GetNumericValue(x), 2)).ToString();
            return Int32.Parse(result);
        }

        //You're a square! 7kyu
        public static bool IsSquare(int n)
        {
            var result = (int)Math.Sqrt(n);
            if (Math.Pow(result, 2) == n)
                return true;
            else
                return false;
        }

        //Sum of Digits / Digital Root 6kyu
        public static int DigitalRoot(long n)
        {
            var number = n.ToString();
            int result = 0;
            for (int i = 0; number.Length > 1 && i < number.Length; i++)
            {
                result = 0;
                foreach (var c in number)
                {
                    result += (int)Char.GetNumericValue(c);
                }
                number = result.ToString();
            }
            return result;
        }

        //Find The Parity Outlier 6kyu
        public static int Find(int[] integers)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (integers[i] % 2 != 0)
                    odd.Add(integers[i]);
                else
                    even.Add(integers[i]);
            }

            var isOdd = true;

            if (odd.Count >=2)
            {
                isOdd = false;
                if (even.Count == 1)
                    return even[0];
            }
            else if (odd.Count == 1)
                return odd[0];


            for (int i = 3; i < integers.Length; i++)
            {
                if (isOdd)
                {
                    if (integers[i] % 2 != 0)
                        return integers[i];
                }
                else
                {
                    if (integers[i] % 2 == 0)
                        return integers[i];
                }
            }
            return -1;
        }

        //Stop gninnipS My sdroW!
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            string result = "";
            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    char[] arr = word.ToCharArray();
                    Array.Reverse(arr);
                    result = String.Concat(result, new string(arr), ' ');
                }
                else
                {
                    result = String.Concat(result, word, ' ');
                }
            }
            return result.TrimEnd();
        }

        static void Main(string[] args)
        {
        }
    }
}
