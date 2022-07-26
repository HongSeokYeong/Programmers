using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    /*
     정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수, solution을 완성해주세요.
     */
    class DivisorSumSolution
    {
        public int solution(int n)
        {
            int answer = 1;

            if (n < 2) return n;

            for (int i = 2; i <= n; i++)
            {
                if(n % i == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }

        // 추천수 제일 많은 정답
        //public int solution(int n)
        //{
        //    int res = 0;
        //    int halfNumber = n / 2;

        //    for (int i = 1; i <= halfNumber; ++i)
        //    {
        //        if (n % i == 0)
        //            res += i;
        //    }

        //    return res + n;
        //}
    }
}
