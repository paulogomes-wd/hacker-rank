using System;

namespace PH.Coding.HackerRank.Challenges.Minimum_Swaps_Two
{
    public class ProblemResolution
    {
        public static void Apply(string[] args){
            Console.Write("Please provide a number (integer): ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Now insert a sequence of integers (space-separated): ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }

        private static int minimumSwaps(int[] arr) {
            int i, j, minimumSwaps = 0; //, aux
            if(arr.Length < 2) return minimumSwaps;

            for(i = 0; i < arr.Length - 1; i++){
                if(arr[i] == i + 1) continue;
                for(j = arr.Length - 1; j > i; j--){
                    if(arr[j] == i + 1) {
                        //aux = arr[i];
                        //arr[i] = arr[j];
                        arr[j] = arr[i];
                        
                        minimumSwaps++;
                        j = i;
                    }
                }
            }
            return minimumSwaps;
        }
    }
}