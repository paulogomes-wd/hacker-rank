using System;

namespace PH.Coding.HackerRank.Challenges.Repeated_String
{
    public class ProblemResolution
    {
        public static void Apply(string[] args) {
            Console.Write("Please provide a string: ");
            string s = Console.ReadLine();

            Console.Write("Please provide a number (integer): ");
            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }

        private static long repeatedString(string s, long n) {
            var aStringOccurrences = 0;
            for(int i = 0; i < s.Length; i++) {
                if(s[i] == 'a') { aStringOccurrences++; }
            }
            if(aStringOccurrences == 0) return aStringOccurrences;

            var lettersOfLastInteration = n % s.Length;
            var numberOfInterations = n / s.Length;

            var aTotalOccurrences = numberOfInterations * aStringOccurrences;
            for(int i = 0; i < lettersOfLastInteration; i++) {
                if(s[i] == 'a') { aTotalOccurrences++; }
            }
            return aTotalOccurrences;
        }
    }
}