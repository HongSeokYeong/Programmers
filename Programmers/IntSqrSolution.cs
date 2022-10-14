using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class IntSqrSolution
    {
        public long solution(long n)
        {
            long num = (long)MathF.Sqrt(n);

            if (num * num == n)
            {
                return (num + 1) * (num + 1);
            }

            return -1;
        }
    }
}
