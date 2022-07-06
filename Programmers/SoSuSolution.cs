using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class SoSuSolution
    {
        /*
         주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다.
        숫자들이 들어있는 배열 nums가 매개변수로 주어질 때,
        nums에 있는 숫자들 중 서로 다른 3개를 골라 더했을 때 소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.
         */
        public static int Solution(int[] nums)
        {
            int answer = 0;

            int sum = 0;

            // i == 0   i == 0
            // j == 1   j == 2
            // k == 2   k == 3
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        sum += nums[i] + nums[j] + nums[k];

                        if (SoSuSolutionFunc(sum))
                        {
                            answer++;
                        }

                        sum = 0;
                    }
                }
            }

            return answer;
        }

        public static bool SoSuSolutionFunc(int sum)
        {
            for (int l = 2; l <= Math.Floor(Math.Sqrt(sum)); l++)
            {
                if ((sum % l) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
