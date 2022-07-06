using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class ModOneSolution
    {
        /*
         자연수 n이 매개변수로 주어집니다.
        n을 x로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 x를 return 하도록 solution 함수를 완성해주세요.
        답이 항상 존재함은 증명될 수 있습니다.
        */
        public static int Solution(int n)
        {
            int modNumber = 2;

            for (int i = 0; i <= n; i++)
            {
                if (n % modNumber == 1)
                {
                    return modNumber;
                }
                else
                {
                    modNumber++;
                }
            }

            return -1;
        }
    }
}
