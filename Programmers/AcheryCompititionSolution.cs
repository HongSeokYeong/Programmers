using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class AcheryCompititionSolution
    {
        public static int[] solution(int n, int[] info)
        {
            int[] answer = new int[11];

            int maxShoot = 0;
            int tempN = n;
            int apeachScore = 0;
            int lionScore = 0;
            int scoreResult = 0;
            bool bWin = false;
            int tempApeachScore = 0;

            Dictionary<int, int> countDic = new Dictionary<int, int>();

            for (int i = 0; i < info.Length; i++)
            {
                countDic.Add(10 - i, (10 - i) / (info[i] + 1));
            }

            var orderedDic = countDic.OrderByDescending(key => key.Value).ToDictionary(x => x.Key, x => x.Value);
            int arrow = 0;

            // 점수별로 정렬되어있다
            // 10 9 6 8 5 4 7 3 2 1 0
            foreach (var item in orderedDic)
            {
                if (tempN == 0) break;
                if (tempN <= info[arrow]) continue;
                // 0 1 4 2 5 6 3 7 8 9 10
                answer[10 - item.Key] = info[10 - item.Key] + 1;
                tempN = tempN - (info[10 - item.Key] + 1);

                arrow++;
            }

            int asdf = 0;
            for (int i = 0; i < info.Length; i++)
            {
                // 둘다 0이면 점수 얻는사람 없음
                if (info[i] == 0 && answer[i] == 0) continue;

                if (info[i] >= answer[i])
                {
                    asdf += 10 - i;
                }
                else
                {
                    lionScore += 10 - i;
                }
            }

            if (tempN != 0)
            {
                answer[10] += tempN;
            }

            if (lionScore <= tempApeachScore)
            {
                bWin = false;
            }
            else
            {
                bWin = true;
            }

            // --------------------------------------------

            //for (int i = 0; i < info.Length; i++)
            //{
            //    if (info[i] > maxShoot) maxShoot = info[i];
            //}

            //while (maxShoot >= 0)
            //{
            //    int tempApeachScore = 0;
            //    int[] tempAnswer = new int[11];

            //    for (int j = maxShoot; j >= 0; j--)
            //    {
            //        for (int i = 0; i < info.Length; i++)
            //        {
            //            // 남은 화살의 갯수가 0개면 경기종료
            //            if (tempN == 0) break;

            //            // 남은 화살의 갯수가 현재 점수칸의 상대방 화살 갯수보다 같거나 적으면 패스
            //            if (tempN <= info[i]) continue;

            //            // 현재 체크중인 범위 안이면
            //            if (info[i] == j)
            //            {
            //                // 화살 소비
            //                tempN = tempN - (info[i] + 1);

            //                // 소비한 화살 기록
            //                tempAnswer[i] = info[i] + 1;
            //            }
            //        }
            //    }

            //    // 점수 계산
            //    for (int i = 0; i < info.Length; i++)
            //    {
            //        // 둘다 0이면 점수 얻는사람 없음
            //        if (info[i] == 0 && tempAnswer[i] == 0) continue;

            //        if (info[i] >= tempAnswer[i])
            //        {
            //            tempApeachScore += 10 - i;
            //        }
            //        else
            //        {
            //            lionScore += 10 - i;
            //        }
            //    }

            //    if (scoreResult < lionScore - tempApeachScore)
            //    {
            //        answer = tempAnswer;
            //        scoreResult = lionScore - tempApeachScore;

            //        if (tempN != 0)
            //        {
            //            answer[10] += tempN;
            //        }

            //        if (lionScore <= tempApeachScore)
            //        {
            //            bWin = false;
            //        }
            //        else
            //        {
            //            bWin = true;
            //        }
            //    }

            //    tempN = n;
            //    lionScore = 0;
            //    maxShoot--;
            //}

            return bWin ? answer : new int[1] { -1 };

        }
    }
}
