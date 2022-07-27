using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class YakSuSolution
    {
        /*
         두 정수 left와 right가 매개변수로 주어집니다.
        left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고
        약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.
        */
        public static int Solution(int left, int right)
        {
            int answer = 0;

            int cnt = 1;
            int temp = 0;
            int result = 1;

            for (int i = left; i <= right; i++)
            {
                temp = i / 2;

                while (cnt <= temp)
                {
                    if (i % cnt == 0)
                    {
                        result++;
                    }

                    cnt++;
                }

                if (result % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }

                cnt = 1;
                result = 1;
            }

            return answer;
        }

        // 추천수 제일 많은 정답
        //public int solution(int left, int right)
        //{
        //    int answer = 0;
        //    int count = 0;

        //    for (int i = left; i <= right; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            if (i % j == 0) count++;
        //        }
        //        answer += (count % 2 == 0) ? i : i * -1;
        //        count = 0;
        //    }

        //    return answer;
        //}
    }
}
