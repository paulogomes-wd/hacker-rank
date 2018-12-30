using System.Collections.Generic;
using System.IO;
using System;

namespace PH.Coding.HackerRank.Challenges.Sock_Merchant
{
    public static class ProblemResolution
    {
        public static void Apply(string[] args){
            Console.Write("Please provide a number (integer): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now insert a sequence of integers: ");
            int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }

        private static int sockMerchant(int n, int[] ar) {
            if(ar.Length < 2) return 0;

            var organizedPairs = new Dictionary<int, int>();
            var totalPairs = 0;

            for(int i = 0; i < n; i++) {
                if(organizedPairs.ContainsKey(ar[i])){
                    organizedPairs[ar[i]]++;
                }
                else {
                    organizedPairs[ar[i]] = 1;
                }
            }

            foreach(var item in organizedPairs){
                totalPairs += (item.Value / 2);
            }
            return totalPairs;
        }
    }
}