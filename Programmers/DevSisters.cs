using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public  class Solution
    {
        public static int solution(int[,] quest)
        {
            int answer = 0;
        int exp = 0;
        List<int[]> questList = new List<int[]>();

        for (int i = 0; i < quest.GetLength(0); i++)
        {
            questList.Add(new int[] { quest[i,0], quest[i,1] });
        }

        var orderedList = questList.OrderBy(x => x[0]).ToList();

        for (int i = 0; i < orderedList.Count; i++)
        {
            if(exp >= orderedList[i][0])
            {
                exp += orderedList[i][1];
                answer++;
            }
        }

            return answer;
        }
    }
