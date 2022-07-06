using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class SosuFindSolution
    {
        // 소수를 찾는 문제
        // 1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수, solution을 만들어 보세요.
        // 소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다.
        // (1은 소수가 아닙니다.)
        // https://loosie.tistory.com/267
        // https://torbjorn.tistory.com/246
        // https://jongmin92.github.io/2017/11/05/Algorithm/Concept/prime/
        // 소수 구하는 알고리즘 링크 주소
        public int Solution(int n)
        {
            int primeCount = 0;
            bool[] erased = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                if (!erased[i])
                {
                    primeCount++;

                    for (int j = i * 2; j <= n; j += i)
                    {
                        erased[j] = true;
                    }
                }
            }

            return primeCount;
        }
    }
}
