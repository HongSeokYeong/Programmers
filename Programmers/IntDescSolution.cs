using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class IntDescSolution
    {
        public long solution(long n)
        {
            long answer = 0;

            return long.Parse(n.ToString().OrderByDescending(x => x).ToArray());
        }
    }
}
