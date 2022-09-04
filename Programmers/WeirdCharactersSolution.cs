using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class WeirdCharactersSolution
    {
        public string solution(string s)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();

            var splitStrings= s.Split(" ");

            for (int i = 0; i < splitStrings.Length; i++)
            {
                for (int j = 0; j < splitStrings[i].Length; j++)
                {
                    if (j %2 == 0)
                    {
                        sb.Append(splitStrings[i][j].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(splitStrings[i][j].ToString().ToLower());
                    }
                }
                sb.Append(" ");
            }

            sb.Remove(sb.Length-1, 1);

            return sb.ToString();
        }
    }
}
