﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new string[] { "muzi", "frodo", "apeach", "neo" }, new string[] { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" }, 2);

            LottoSolution(new int[] { 45, 4, 35, 20, 3, 9 }, new int[] { 20, 9, 3, 45, 4, 35 });
        }

        public static int[] LottoSolution(int[] lottos, int[] win_nums)
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

        public static int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[] { };

            Dictionary<string, int> reportCheck = new Dictionary<string, int>();
            Dictionary<string, List<string>> reportResult = new Dictionary<string, List<string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            if (id_list.Length < 2 || id_list.Length > 1000 || report.Length < 1 || report.Length > 200000)
            {
                return new int[] { };
            }

            foreach (var item in id_list)
            {
                if (item.Length < 1 || item.Length > 10)
                {
                    return new int[] { };
                }
            }

            foreach (var item in report)
            {
                if (item.Length < 3 || item.Length > 21)
                {
                    return new int[] { };

                }
            }

            if (k < 1 || k > 200)
            {
                return new int[] { };
            }

            foreach (var item in id_list)
            {
                reportCheck.Add(item, 0);
                reportResult.Add(item, new List<string>());
                result.Add(item, 0);
            }

            foreach (var item in report)
            {
                var v = item.Split(" ");

                if (!reportResult[v[1]].Contains(v[0]))
                {
                    reportResult[v[1]].Add(v[0]);
                    reportCheck[v[1]]++; // 내가 몇번 신고당했는지 저장
                }
            }

            int i = 0;
            answer = new int[id_list.Length];
            foreach (var item in id_list)
            {
                if (reportCheck[item] >= k)
                {
                    foreach (var item2 in reportResult[item])
                    {
                        result[item2]++;
                    }
                }
            }

            foreach (var item in result)
            {
                answer[i] = item.Value;
                i++;
            }

            return answer;


            // 중복 제거 방법
            //    List<string> reportList = report.ToList().Distinct().ToList();
            //    Dictionary<string, int> reportCountLog = new Dictionary<string, int>();
            //    Dictionary<string, List<string>> reportLog = new Dictionary<string, List<string>>();
            //    Dictionary<string, int> result = new Dictionary<string, int>();

            //    foreach (string id in id_list)
            //    {
            //        reportCountLog[id] = 0;
            //        reportLog[id] = new List<string>();
            //        result[id] = 0;
            //    }

            //    foreach (string reportItem in reportList)
            //    {
            //        var split = reportItem.Split(' ');
            //        ++reportCountLog[split[1]];
            //        reportLog[split[0]].Add(split[1]);
            //    }

            //    foreach (var countLog in reportCountLog.Where((e) => e.Value >= k))
            //    {
            //        foreach (var log in reportLog)
            //        {
            //            if (log.Value.Contains(countLog.Key))
            //            {
            //                ++result[log.Key];
            //            }
            //        }
            //    }

            //    return result.Values.ToArray();
            //}



            // 추천 제일 많은 답
            //int[] answer = new int[id_list.Length]; // 결과 배열.

            //int[] receive = new int[id_list.Length]; // 신고받은 횟수.
            //int[] send = new int[id_list.Length];    // 신고한 횟수.

            //report = report.Distinct().ToArray();

            //// 신고받은 횟수를 기록.
            //for (int i = 0; i < report.Length; i++)
            //{
            //    string report_str = report[i].Split(' ')[1];
            //    int report_index = Array.IndexOf(id_list, report_str);
            //    receive[report_index]++;
            //}

            //// 신고받은 횟수가 k보다 높을 시 answer 값을 상승.
            //for (int i = 0; i < report.Length; i++)
            //{
            //    string report_str = report[i].Split(' ')[1];
            //    int report_index = Array.IndexOf(id_list, report_str);

            //    if (receive[report_index] >= k)
            //    {
            //        string send_str = report[i].Split(' ')[0];
            //        int send_index = Array.IndexOf(id_list, send_str);
            //        answer[send_index]++;
            //    }
            //}

            //return answer;
        }
    }
}
