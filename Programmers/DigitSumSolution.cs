using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class DigitSumSolution
    {
        public int solution(int n)
        {
            int answer = 0;

            while (n > 1)
            {
                answer += n % 10;
                n = n / 10;
            }

            answer += n;

            return answer;
        }
    }
}
