using System;

namespace PH.Coding.HackerRank.Challenges.Data_Types
{
    public class ProblemResolution
    {
        public static void Apply(string[] args) {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Console.Write("Please provide a number (integer): ");
            int intVariable = Convert.ToInt32(Console.ReadLine().Trim());

            // Console.Write("Please provide a number (double): ");
            double doubleVariable = double.Parse(Console.ReadLine().Trim(), System.Globalization.CultureInfo.InvariantCulture);

            // Console.Write("Please provide a string: ");
            string someString = Console.ReadLine();
            
            Console.WriteLine(i + intVariable);
            Console.WriteLine(string.Format("{0:0.0}", (d + doubleVariable)));
            Console.WriteLine(s + someString);
        }
    }
}