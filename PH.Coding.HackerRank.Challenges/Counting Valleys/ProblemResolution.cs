using System;

namespace PH.Coding.HackerRank.Challenges.Counting_Valleys
{
    public class ProblemResolution
    {
        public static void Apply(string[] args){
            Console.Write("Please provide a number (integer): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now insert Gary's path: ");
            string s = Console.ReadLine();

            int result = countingValleys(n, s);
            Console.WriteLine(result);
        }

        private static int countingValleys(int n, string s) {
            if(s.Length < 2) return 0;

            var numberOfValleys = 0;
            var valleysDepth = 0;

            foreach(var step in s){
                if(valleysDepth == 1 && step == 'U'){ numberOfValleys++; }

                if(step == 'D') { valleysDepth++; }
                else if (step == 'U') { valleysDepth--; }
            }
            return numberOfValleys;
        }
    }
}