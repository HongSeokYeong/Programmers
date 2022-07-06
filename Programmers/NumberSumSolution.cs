using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class NumberSumSolution
    {
        /*
         0부터 9까지의 숫자 중 일부가 들어있는 정수 배열 numbers가 매개변수로 주어집니다.
        numbers에서 찾을 수 없는 0부터 9까지의 숫자를 모두 찾아 더한 수를 return 하도록 solution 함수를 완성해주세요.
         */
        public int solution(int[] numbers)
        {
            int answer = 45;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer -= numbers[i];
            }

            return answer;
        }

        // 추천 제일 많은 정답
        //public int solution(int[] numbers)
        //{
        //    var numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    return numberArray.Except(numbers).Sum();
        //}
    }
}
