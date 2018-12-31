using System;

namespace PH.Coding.HackerRank.Challenges.Jumping_on_the_Clouds
{
    public class ProblemResolution
    {
        public static void Apply(string[] args) {
            Console.Write("Please provide a number (integer): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now insert a sequence of integers: ");
            int[] c = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
        }

        private static int jumpingOnClouds(int[] c) {
            if(c.Length < 2) return 0;

            var minimumJumps = 0;
            for(var i = 0; i < c.Length; i++) {
                if(i < c.Length - 2 && c[i + 2] == 0) {
                    minimumJumps++;
                    i++;
                }
                else if(i < c.Length - 1 && c[i + 1] == 0) {
                    minimumJumps++;
                }
            }
            return minimumJumps;
        }
    }
}