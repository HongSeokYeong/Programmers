using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class MinSquareSolution
    {
        /*
         명함 지갑을 만드는 회사에서 지갑의 크기를 정하려고 합니다. 다양한 모양과 크기의 명함들을 모두 수납할 수 있으면서, 작아서 들고 다니기 편한 지갑을 만들어야 합니다.
        이러한 요건을 만족하는 지갑을 만들기 위해 디자인팀은 모든 명함의 가로 길이와 세로 길이를 조사했습니다.
        아래 표는 4가지 명함의 가로 길이와 세로 길이를 나타냅니다.
        명함 번호	가로 길이	세로 길이
        1	    60	50
        2	    30	70
        3	    60	30
        4	    80	40
        가장 긴 가로 길이와 세로 길이가 각각 80, 70이기 때문에 80(가로) x 70(세로) 크기의 지갑을 만들면 모든 명함들을 수납할 수 있습니다.
        하지만 2번 명함을 가로로 눕혀 수납한다면 80(가로) x 50(세로) 크기의 지갑으로 모든 명함들을 수납할 수 있습니다. 이때의 지갑 크기는 4000(=80 x 50)입니다.
        모든 명함의 가로 길이와 세로 길이를 나타내는 2차원 배열 sizes가 매개변수로 주어집니다.
        모든 명함을 수납할 수 있는 가장 작은 지갑을 만들 때, 지갑의 크기를 return 하도록 solution 함수를 완성해주세요.
        */
        public static int Solution(int[,] sizes)
        {
            int answer = 0;
            int temp = 0;
            int w = 0;
            int h = 0;
            int len = sizes.GetLength(0);

            for (int i = 0; i < len; i++)
            {
                if (sizes[i, 0] > sizes[i, 1])
                {
                    temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }

                if (w < sizes[i, 0])
                {
                    w = sizes[i, 0];
                }

                if (h < sizes[i, 1])
                {
                    h = sizes[i, 1];
                }
            }

            answer = w * h;

            return answer;
        }

        // 추천수 많은 정답
        //public int solution(int[,] sizes)
        //{
        //    List<int[]> list = new List<int[]>();

        //    for (int i = 0; i < sizes.GetLength(0); i++)
        //    {
        //        int temp = 0;

        //        if (sizes[i, 0] < sizes[i, 1])
        //        {
        //            temp = sizes[i, 1];
        //            sizes[i, 1] = sizes[i, 0];
        //            sizes[i, 0] = temp;
        //        }

        //        list.Add(new int[2] { sizes[i, 0], sizes[i, 1] });
        //    }

        //    return list.Max(x => x[0]) * list.Max(x => x[1]);
        //}
    }
}
