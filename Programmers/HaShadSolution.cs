using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class HaShadSolution
    {
        /*
         양의 정수 x가 하샤드 수이려면 x의 자릿수의 합으로 x가 나누어져야 합니다.
        예를 들어 18의 자릿수 합은 1+8=9이고, 18은 9로 나누어 떨어지므로 18은 하샤드 수입니다.
        자연수 x를 입력받아 x가 하샤드 수인지 아닌지 검사하는 함수, solution을 완성해주세요.
        */
        public bool solution(int x)
        {
            int sum = 0;
            int tempX = x;

            while (tempX > 9)
            {
                sum += tempX % 10;
                tempX /= 10;
            }

            sum += tempX;

            if (x % sum == 0) return true;
            else return false;
        }

        // 추천 제일 많은 정답
        //public bool solution(int x)
        //{
        //    bool answer = true;

        //    var temp = x.ToString().ToList().Select(y => int.Parse(y.ToString())).Sum();

        //    if (x % temp != 0)
        //        answer = false;

        //    return answer;
        //}
    }
}
