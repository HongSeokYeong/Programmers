using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class StringSolution
    {
        /*
         문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수, solution을 완성하세요.
        예를 들어 s가 "a234"이면 False를 리턴하고 "1234"라면 True를 리턴하면 됩니다.
        */
        public static bool Solution(string s)
        {
            if (s.Length != 4 && s.Length != 6) return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!(48 <= s[i] || s[i] <= 57) || (97 <= s[i] && s[i] <= 122)) return false;
            }

            return true;
        }
    }
}
