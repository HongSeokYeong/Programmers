using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class NaturalNumberSolution
    {
        public int[] solution(long n)
        {
            int nLength = n.ToString().Length;

            int[] answer = new int[nLength];

            for (int i = 0; i < nLength; i++)
            {
                answer[i] = (int)(n % 10);
                n = n / 10;
            }

            return answer;
        }
    }
}
