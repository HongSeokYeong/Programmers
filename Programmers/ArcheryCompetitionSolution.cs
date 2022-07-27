//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programmers
//{
//    class ArcheryCompetitionSolution
//    {
//        public static int[] solution(int n, int[] info)
//        {
//            int[] answer = new int[11];
//            int tempN = n;
//            int maxShoot = 0;
//            int scoreResult = 0;

//            for (int i = 0; i < info.Length; i++)
//            {
//                if (maxShoot < info[i]) maxShoot = info[i];
//            }

//            for (int j = 0; j <= maxShoot; j++)
//            {
//                tempN = n;
//                int[] tempAnswer = new int[11];
//                for (int i = 0; i < info.Length; i++)
//                {
//                    if (tempN == 0) break;
//                    // 남은 화살보다 적게 꽂혀있으면 점수 얻기
//                    if (info[i] <= j && info[i] < tempN)
//                    {
//                        tempAnswer[i] += info[i] + 1;
//                        tempN -= (info[i] + 1);
//                    }
//                }

//                // 점수계산
//                int apeachScore = 0;
//                int ryanScore = 0;

//                for (int i = 0; i < info.Length; i++)
//                {
//                    if (info[i] == 0 && tempAnswer[i] == 0) continue;

//                    if (info[i] >= tempAnswer[i])
//                    {
//                        apeachScore += 10 - i;
//                    }
//                    else
//                    {
//                        ryanScore += 10 - i;
//                    }
//                }

//                tempAnswer[10] += tempN;

//                bool bLastScore = true;

//                for (int i = 10; i >= 0; i--)
//                {
//                    if (tempAnswer[i] > answer[i])
//                    {
//                        bLastScore = true;
//                        break;
//                    }
//                    if (tempAnswer[i] < answer[i])
//                    {
//                        bLastScore = false;
//                        break;
//                    }
//                }
//                var result = ryanScore - apeachScore;

//                if ((scoreResult < result) || (scoreResult == result && bLastScore))
//                {
//                    scoreResult = result;

//                    answer = tempAnswer;
//                }
//            }

//            return scoreResult == 0 ? new int[] { -1 } : answer;
//        }
//    }
//}






using System;
using System.Collections.Generic;
public class ArcheryCompetitionSolution
{
    static int[] _info;
    static int[] _temp;
    static int[] _maxTemp;
    static int _maxPoint = 0;
    public static int[] solution(int n, int[] info)
    {
        _temp = new int[info.Length];
        _maxTemp = new int[] { -1 };
        _info = info;

        DepthFirstSearch(n, 0);
        return _maxTemp;
    }

    public static void DepthFirstSearch(int arrows, int range)
    {
        if (arrows == 0 || range == 10)
        {
            _temp[range] = arrows;

            int appeachPoint, lionPoint;
            appeachPoint = lionPoint = 0;
            for (int i = 0; i < _info.Length; ++i)
            {
                if (_info[i] >= _temp[i] && _info[i] > 0)
                    appeachPoint += 10 - i;
                else if (_temp[i] > 0)
                    lionPoint += 10 - i;
            }

            if (appeachPoint < lionPoint)
            {
                int gapPoint = lionPoint - appeachPoint;
                if (_maxPoint < gapPoint)
                {
                    _maxPoint = gapPoint;
                    _maxTemp = new int[_temp.Length];
                    Array.Copy(_temp, _maxTemp, _temp.Length);
                }
                else if (_maxPoint == gapPoint)
                {
                    for (int i = 10; i >= 0; --i)
                    {
                        if (_maxTemp[i] != _temp[i])
                        {
                            if (_maxTemp[i] < _temp[i])
                            {
                                _maxTemp = new int[_temp.Length];
                                Array.Copy(_temp, _maxTemp, _temp.Length);
                            }
                            break;
                        }
                    }
                }
            }
            _temp[range] = 0;
            return;
        }

        if (arrows > _info[range])
        {
            _temp[range] = _info[range] + 1;
            DepthFirstSearch(arrows - _temp[range], range + 1);
            _temp[range] = 0;
        }
        DepthFirstSearch(arrows, range + 1);
    }
}