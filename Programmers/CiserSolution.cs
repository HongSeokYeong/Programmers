using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class CiserSolution
    {
        /*
         어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다.
        예를 들어 "AB"는 1만큼 밀면 "BC"가 되고, 3만큼 밀면 "DE"가 됩니다. "z"는 1만큼 밀면 "a"가 됩니다.
        문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수, solution을 완성해 보세요.
        */
        public string solution(string s, int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals((char)32))
                {
                    stringBuilder.Append((char)32);
                    continue;
                };

                if (s[i] <= 90 && 65 <= s[i] )
                {
                    var v = s[i] + n;
                    if (v > 90)
                    {
                        stringBuilder.Append((char)(s[i] -26+ n));
                    }
                    else
                    {
                        stringBuilder.Append((char)v);
                    }
                }
                else if(s[i] <= 122 && 97 <= s[i])
                {
                    var v = s[i] + n;
                    if (v > 122)
                    {
                        stringBuilder.Append((char)(s[i] - 26 + n));
                    }
                    else
                    {
                        stringBuilder.Append((char)v);
                    }
                }
            }

            return stringBuilder.ToString();
        }

        // 추천수 제일 많은 정답
        //public string solution(string s, int n)
        //{
        //    string answer = "";
        //    char[] temp = s.ToCharArray();
        //    for (int i = 0; i < s.Length; ++i)
        //    {
        //        if ((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >= 'A' && temp[i] <= 'Z'))
        //        {
        //            if (char.IsUpper(temp[i]))
        //            {
        //                temp[i] = (char)((temp[i] + n - 'A') % 26 + 'A');
        //            }
        //            else
        //            {
        //                temp[i] = (char)((temp[i] + n - 'a') % 26 + 'a');
        //            }
        //        }
        //    }
        //    return new string(temp);
        //}
    }
}
