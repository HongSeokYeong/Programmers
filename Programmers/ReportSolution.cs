using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class ReportSolution
    {
        /*
         문제 설명

        신입사원 무지는 게시판 불량 이용자를 신고하고 처리 결과를 메일로 발송하는 시스템을 개발하려 합니다. 무지가 개발하려는 시스템은 다음과 같습니다.
        각 유저는 한 번에 한 명의 유저를 신고할 수 있습니다.
        신고 횟수에 제한은 없습니다. 서로 다른 유저를 계속해서 신고할 수 있습니다.
        한 유저를 여러 번 신고할 수도 있지만, 동일한 유저에 대한 신고 횟수는 1회로 처리됩니다.
        k번 이상 신고된 유저는 게시판 이용이 정지되며, 해당 유저를 신고한 모든 유저에게 정지 사실을 메일로 발송합니다.
        유저가 신고한 모든 내용을 취합하여 마지막에 한꺼번에 게시판 이용 정지를 시키면서 정지 메일을 발송합니다.
         */
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
