using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class NumberToWordSolution
    {
        /*
         네오와 프로도가 숫자놀이를 하고 있습니다. 네오가 프로도에게 숫자를 건넬 때 일부 자릿수를 영단어로 바꾼 카드를 건네주면 프로도는 원래 숫자를 찾는 게임입니다.
        다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.
        1478 → "one4seveneight"
        234567 → "23four5six7"
        10203 → "1zerotwozero3"
        이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 혹은 바뀌지 않고 그대로인 문자열 s가 매개변수로 주어집니다.
        s가 의미하는 원래 숫자를 return 하도록 solution 함수를 완성해주세요.
         */
        public static int Solution(string s)
        {
            int answer = 0;

            Dictionary<string, int> dic = new Dictionary<string, int>() { { "zero", 0 }, { "one", 1 } , { "two", 2 } , { "three", 3 } , { "four", 4 } ,
                { "five", 5 } , { "six", 6 } , { "seven", 7 } , { "eight", 8 } , { "nine", 9 } };

            string[] strs = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] strs2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            int i = 0;
            int cnt = 0;

            int l = s.Length;

            while (l > 0)
            {
                if (int.TryParse(s.Substring(cnt, 1), out var number))
                {
                    answer = (10 * answer) + number;
                    i = 0;
                    cnt += 1;
                    l -= 1;
                    continue;
                }

                if (l < strs[i].Length)
                {
                    i++;
                    continue;
                }

                var substring = s.Substring(cnt, strs[i].Length);

                if (strs[i].Equals(substring))
                {
                    answer = (10 * answer) + dic[substring];
                    cnt += strs[i].Length;
                    l -= strs[i].Length;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return answer;
        }

        // 추천수 제일 많은 정답
        //public int solution(string s)
        //{
        //    int answer = 0;
        //    string transString = s;

        //    transString = transString.Replace("zero", "0");
        //    transString = transString.Replace("one", "1");
        //    transString = transString.Replace("two", "2");
        //    transString = transString.Replace("three", "3");
        //    transString = transString.Replace("four", "4");
        //    transString = transString.Replace("five", "5");
        //    transString = transString.Replace("six", "6");
        //    transString = transString.Replace("seven", "7");
        //    transString = transString.Replace("eight", "8");
        //    transString = transString.Replace("nine", "9");

        //    answer = Convert.ToInt32(transString);

        //    return answer;
        //}
    }
}
