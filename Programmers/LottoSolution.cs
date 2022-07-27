using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class LottoSolution
    {
        /*
         로또를 구매한 민우는 당첨 번호 발표일을 학수고대하고 있었습니다. 하지만, 민우의 동생이 로또에 낙서를 하여, 일부 번호를 알아볼 수 없게 되었습니다.
        당첨 번호 발표 후, 민우는 자신이 구매했던 로또로 당첨이 가능했던 최고 순위와 최저 순위를 알아보고 싶어 졌습니다.
        알아볼 수 없는 번호를 0으로 표기하기로 하고, 민우가 구매한 로또 번호 6개가 44, 1, 0, 0, 31 25라고 가정해보겠습니다.
        당첨 번호 6개가 31, 10, 45, 1, 6, 19라면, 당첨 가능한 최고 순위와 최저 순위의 한 예는 아래와 같습니다.
        당첨 번호	31	10	45	1	6	19	결과
        최고 순위 번호	31	0→10	44	1	0→6	25	4개 번호 일치, 3등
        최저 순위 번호	31	0→11	44	1	0→7	25	2개 번호 일치, 5등
        순서와 상관없이, 구매한 로또에 당첨 번호와 일치하는 번호가 있으면 맞힌 걸로 인정됩니다.
        알아볼 수 없는 두 개의 번호를 각각 10, 6이라고 가정하면 3등에 당첨될 수 있습니다.
        3등을 만드는 다른 방법들도 존재합니다. 하지만, 2등 이상으로 만드는 것은 불가능합니다.
        알아볼 수 없는 두 개의 번호를 각각 11, 7이라고 가정하면 5등에 당첨될 수 있습니다.
        5등을 만드는 다른 방법들도 존재합니다. 하지만, 6등(낙첨)으로 만드는 것은 불가능합니다.
        민우가 구매한 로또 번호를 담은 배열 lottos, 당첨 번호를 담은 배열 win_nums가 매개변수로 주어집니다.
        이때, 당첨 가능한 최고 순위와 최저 순위를 차례대로 배열에 담아서 return 하도록 solution 함수를 완성해주세요.
         */
        public static int[] Solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int[] lottoTable = new int[7] { 6, 6, 5, 4, 3, 2, 1 };
            int lottoGrade = 0;

            var lottosList = lottos.ToList().Distinct().ToList().OrderBy(x => x).ToList();

            if (lottosList[0] == 0)
                lottosList.RemoveAt(0);

            int zeroCnt = lottos.Length - lottosList.Count();

            var winList = win_nums.ToList().OrderBy(x => x).ToList();

            for (int i = 0; i < lottosList.Count(); i++)
            {
                for (int j = 0; j < winList.Count(); j++)
                {
                    if (lottosList[i] == winList[j])
                    {
                        lottoGrade++;
                        break;
                    }
                }
            }

            answer[0] = lottoTable[lottoGrade + zeroCnt];
            answer[1] = lottoTable[lottoGrade];

            return answer;
        }

        // 추천수 제일 많은 정답
        //public int[] solution(int[] lottos, int[] win_nums)
        //{
        //    int winCount = lottos.Intersect(win_nums).Count();
        //    int loseCount = lottos.Where((number) => number != 0).Count() - winCount;

        //    int[] answer = new int[] { WinCountToRank(6 - loseCount), WinCountToRank(winCount) };
        //    return answer;
        //}

        //public int WinCountToRank(int count)
        //{
        //    if (count <= 1)
        //    {
        //        return 6;
        //    }

        //    return 7 - count;
        //}
    }
}
