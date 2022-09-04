using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class ParkingPriceSolution
    {
        public static int[] solution(int[] fees, string[] records)
        {
            List<string[]> recordsList = new List<string[]>();
            List<int> answer = new List<int>();

            for (int i = 0; i < records.Length; i++)
            {
                recordsList.Add(records[i].Split(" "));
            }

            var recordsSort = recordsList.OrderBy(x => x[1]).ToList();

            int carIndex = 0;

            var carNumber = recordsSort[carIndex][1];
            var totalTime = 0;

            // 차 번호가 같으면 계산
            while (carIndex < recordsSort.Count)
            {
                // 마지막 차량
                if(carIndex == recordsSort.Count - 1)
                {
                    var inTime = recordsSort[carIndex][0].Split(":");

                    totalTime += (23 - int.Parse(inTime[0])) * 60 + (59 - int.Parse(inTime[1]));

                    answer.Add(ClacPrice(fees, totalTime));

                    break;
                }

                // 쌍으로 검사한다.
                // 차 번호가 같으면 계산
                if (recordsSort[carIndex][1] == recordsSort[carIndex + 1][1])
                {
                    totalTime += CalcTime(fees, recordsSort, carIndex);
                    carIndex += 2;
                }
                else
                {
                    var inTime = recordsSort[carIndex][0].Split(":");

                    totalTime += (23 - int.Parse(inTime[0])) * 60 + (59 - int.Parse(inTime[1]));
                    carIndex++;
                }

                if(carIndex == recordsSort.Count)
                {
                    answer.Add(ClacPrice(fees, totalTime));

                    break;
                }

                // 차 번호가 달라졌으면 그동안의 누적 시간으로 비용 계산
                if (carNumber != recordsSort[carIndex][1])
                {
                    answer.Add(ClacPrice(fees, totalTime));

                    carNumber = recordsSort[carIndex][1];
                    totalTime = 0;
                }
            }

            return answer.ToArray();
        }

        public static int CalcTime(int[] fees, List<string[]> recordsSort, int carIndex)
        {
            var inTime = recordsSort[carIndex][0].Split(":");
            var outTime = recordsSort[carIndex + 1][0].Split(":");

            return (int.Parse(outTime[0]) - int.Parse(inTime[0])) * 60 + (int.Parse(outTime[1]) - int.Parse(inTime[1]));
        }

        public static int ClacPrice(int[] fees, int totalTime)
        {
            if (totalTime <= fees[0])
            {
                return fees[1];
            }
            else
            {
                var price = totalTime - fees[0];
                if (price % fees[2] == 0)
                {
                    return fees[1] + ((totalTime - fees[0]) / fees[2]) * fees[3];
                }
                else
                {
                    return fees[1] + (((totalTime - fees[0]) / fees[2]) + 1) * fees[3];
                }
            }
        }
    }
}
