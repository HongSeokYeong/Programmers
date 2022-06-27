using System;

namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }

        public int solution(int[] numbers)
        {
            int answer = 45;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer -= numbers[i];
            }

            return answer;
        }
    }
}
