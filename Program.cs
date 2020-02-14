using System;

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

        static void Main(string[] args)
        {
        }
    }
}
