using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class StringToIntSolution
    {
        /*
         문자열 s를 숫자로 변환한 결과를 반환하는 함수, solution을 완성하세요.
        */
        public static int solution(string s)
        {
            int answer = 0;

            if (s[0] == 43)
            {
                answer = Convert.ToInt32(s.Substring(1, s.Length));

            }
            else if (s[0] == 45)
            {
                answer = Convert.ToInt32(s.Substring(1, s.Length));
                answer *= -1;
            }
            else
            {
                answer = Convert.ToInt32(s);
            }


            return answer;
        }

        // 추천수 많은 정답
        //public int solution(string s)
        //{
        //    int answer = 0;
        //    answer = Convert.ToInt32(s);
        //    return answer;
        //}
    }
}
