using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ParkingPriceSolution.solution(new int[] { 180, 5000, 10, 600 }, new string[] { "05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT" });
            //ParkingPriceSolution.solution(new int[] { 120, 0, 60, 591 }, new string[] { "16:00 3961 IN", "16:00 0202 IN", "18:00 3961 OUT", "18:00 0202 OUT", "23:58 3961 IN" });


            DevSisters2.solution(new int[,] { { 0, 0, 1, 0, 0 }, { 1, 1, 0, 0, 2 }, { 1, 0, 0, 0, 0 } }, 3);
        }        

        

        
    }
}
