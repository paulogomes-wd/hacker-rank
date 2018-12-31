using System;

namespace PH.Coding.HackerRank.Challenges.BiDimensional_Array_DS
{
    public class ProblemResolution
    {
        public static void Apply(string[] args) {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                Console.Write("Please provide a sequence of six numbers (integer, space-separated): ");
                arr[i] = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }

        private static int hourglassSum(int[][] arr) {
            var currentSum = 0;
            var maxTime = 0;

            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    currentSum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    if(currentSum > maxTime || i == 0 && j == 0) { maxTime = currentSum; }
                }
            }
            return maxTime;
        }
    }
}