using System;
using System.Text;

namespace Programmers
{
    class KGetPrimeNumberSolution
    {
        public static  int solution(int n, int k)
        {
            int answer = 0;
            //StringBuilder sb = new StringBuilder();

            string str = "";

            while (n >=k)
            {
                //sb.Append(n % k);

                str = (n % k).ToString() + str;

                n /= k;
            }

            str = n.ToString() + str;

            //var charArray = sb.ToString().ToCharArray();
            //Array.Reverse(charArray);

            //string reverseString = new string(charArray);

            var splitString = str.Split("0",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitString.Length; i++)
            {
                if (IsPrimeNumber(long.Parse(splitString[i])))
                {
                    answer++;
                }
            }

            return answer;
        }

        public static bool IsPrimeNumber(long number)
        {
            if (number <= 1) return false;
            for (int l = 2; l <= Math.Sqrt(number); l++)
            {
                if ((number % l) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
