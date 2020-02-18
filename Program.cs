using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    class Program
    {
        public static int PositiveSum(int[] arr) => arr.Sum(x => x > 0 ? x : 0);

        public static string Remove_char(string s) => s.Substring(1, s.Length - 2);

        public static String AccumOption1(string s) 
            => string.Join("-", s.Select((c, i) => char.ToUpper(c) + new string(char.ToLower(c), i)));

        public static String AccumOption2(string s)
        {
            string r = "";
            int i = 0;
            foreach (var ch in s)
            {
                r = char.ToUpper(ch) + new string(char.ToLower(ch), i++);
            }

            return r.TrimEnd('-');
        }

        public static string GetMiddle(string s) => s.Substring((s.Length - 1) / 2, s.Length % 2 == 0 ? 2 : 1);

        public static bool IsIsogramOption1(string str) => str.ToLower().Distinct().Count() == str.Count();

        public static bool IsIsogramOption2(string str)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char ch in str.ToLower())
            {

                if (set.Contains(ch))
                    return false;
                set.Add(ch);
            }

            return true;
        }

        public static int CountBits(int n)
            => Convert.ToString(n, 2).Sum(c => c == '1' ? 1 : 0);

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            foreach (int item in str.ToLower())
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    vowelCount++;
            }

            return vowelCount;
        }

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

        //Stop gninnipS My sdroW! 6kyu
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

        //Duplicate Encoder 6kyu
        public static string DuplicateEncode(string word)
        {
            var unique = new HashSet<char>(word = word.ToLower());
            if (unique.Contains('('))
            {
                if (word.IndexOf('(') != word.LastIndexOf('('))
                    word = word.Replace('(', 'A');
                unique.Remove('(');
            }

            if (unique.Contains(')'))
            {
                if (word.IndexOf(')') == word.LastIndexOf(')'))
                    word = word.Replace(')', '(');
                unique.Remove(')');
            }

            if(word.Contains('A'))
                word = word.Replace('A', ')');

            foreach (var c in unique)
            {
                if (word.IndexOf(c) != word.LastIndexOf(c))
                    word = word.Replace(c, ')');
                else
                    word = word.Replace(c, '(');
            }
            return word;
        }

        static void Main(string[] args)
        {
        }
    }
}
