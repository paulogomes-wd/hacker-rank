using System;

namespace PH.Coding.HackerRank.Challenges.Arrays_Left_Rotation
{
    public class ProblemResolution
    {
        public static void Apply(string[] args){
            Console.Write("Please provide two numbers, size of the array and the number of rotations to perform: ");
            string[] nd = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            Console.Write("Now insert a sequence of integers (space-separated): ");
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = rotLeft(a, d);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] rotLeft(int[] a, int d) {
            if(a.Length < 2) return a;

            var result = new int[a.Length];
            for(int i = 0; i < result.Length; i++){
                result[i] = a[(i + d) % a.Length];
            }
            return result;
        }
    }
}