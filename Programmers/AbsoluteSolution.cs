using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class AbsoluteSolution
    {
        /*
         어떤 정수들이 있습니다.
        이 정수들의 절댓값을 차례대로 담은 정수 배열 absolutes와 이 정수들의 부호를 차례대로 담은 불리언 배열 signs가 매개변수로 주어집니다.
        실제 정수들의 합을 구하여 return 하도록 solution 함수를 완성해주세요.
        */
        public int Solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                answer += signs[i] ? absolutes[i] : -absolutes[i];
            }

            return answer;
        }

        // 추천 제일 많은 정답
        //public int solution(int[] absolutes, bool[] signs)
        //{
        //    return absolutes.Select((t, idx) => signs[idx] ? t : -t).Sum();
        //}
    }
}
