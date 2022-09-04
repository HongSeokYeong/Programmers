using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers
{
    /*
     질문마다 판단하는 지표를 담은 1차원 문자열 배열 survey와 검사자가 각 질문마다 선택한 선택지를 담은 1차원 정수 배열 choices가 매개변수로 주어집니다.
     이때, 검사자의 성격 유형 검사 결과를 지표 번호 순서대로 return 하도록 solution 함수를 완성해주세요.
     */
    class MBTISolution
    {
        public string solution(string[] survey, int[] choices)
        {
            int[] score = new int[7] { 3, 2, 1, 0, 1, 2, 3 };

            Dictionary<char, int> score2 = new Dictionary<char, int>();

            score2.Add('R', 0);
            score2.Add('T', 0);
            score2.Add('C', 0);
            score2.Add('F', 0);
            score2.Add('J', 0);
            score2.Add('M', 0);
            score2.Add('A', 0);
            score2.Add('N', 0);

            for (int i = 0; i < survey.Length; i++)
            {
                if (choices[i] < 4)
                {
                    var str = survey[i].Substring(0);
                    score2[str[0]] += score[choices[i] - 1];

                }
                else if (choices[i] > 4)
                {
                    var str = survey[i].Substring(1);
                    score2[str[0]] += score[choices[i] - 1];
                }
            }

            StringBuilder sb = new StringBuilder();

            if (score2['R'] < score2['T'])
            {
                sb.Append('T');
            }
            else
            {
                sb.Append('R');
            }

            if (score2['C'] < score2['F'])
            {
                sb.Append('F');
            }
            else
            {
                sb.Append('C');
            }

            if (score2['J'] < score2['M'])
            {
                sb.Append('M');
            }
            else
            {
                sb.Append('J');
            }

            if (score2['A'] < score2['N'])
            {
                sb.Append('N');
            }
            else
            {
                sb.Append('A');
            }

            return sb.ToString();
        }
    }
}
