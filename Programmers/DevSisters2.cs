using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class DevSisters2
    {
        // [0,0,1,0,0] 0,0 0,1 0,2 0,3 0,4
        // [1,1,0,0,2] 1,0 1,1 1,2 1,3 1,4
        // [1,0,0,0,0] 2,0 2,1 2,2 2,3 2,4

        // [0,2,1,0,0]
        // [1,1,0,0,2]
        // [1,0,0,0,0]

        // 팜 사이즈별로 한칸씩 옮겨가며 돌의 최소 갯수를 저장

        public static int solution(int[,] field, int farmSize)
        {
            int answer = -1;
            int y = farmSize;
            int xmin = 0;
            int xmax = farmSize;

            int rockCount = 0;

            List<int[]> farmList = new List<int[]>();

            bool mushRoom = false;
            while (xmax <= field.GetLength(1) && y <= field.GetLength(1))
            {
                for (int i = 0; i < y; i++)
                {
                    for (int j = xmin; j < xmax; j++)
                    {
                        if (field[i, j] == 2)
                        {
                            mushRoom = true;
                        }
                        else if (field[i, j] == 1)
                        {
                            rockCount++;
                        }
                    }
                }
                farmList.Add(new int[] { mushRoom ? 1 : 0, rockCount });

                xmin++;
                xmax++;
                mushRoom = false;
                rockCount = 0;
            }

            for (int i = 0; i < farmList.Count; i++)
            {
                if (farmList[i][0] == 1)
                {
                    continue;
                }
                else
                {
                    if (answer == -1)
                    {
                        answer = farmList[i][1];
                    }
                    else
                    {
                        if (answer >= farmList[i][1]) answer = farmList[i][1];
                    }
                }
            }

            return farmList.Count == 0 ?-1: answer;
        }
    }
}
