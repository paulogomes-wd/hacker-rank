using System.Text;
using System.IO;
using System;

namespace PH.Coding.HackerRank.Challenges.New_Year_Chaos
{
    public class ProblemResolution
    {
        public static void Apply(string[] args){
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\PH.Coding.HackerRank.Challenges\New Year Chaos\test-case-09.txt", Encoding.UTF8);
            // // Console.Write("Please provide the number of test cases: ");
            int t = Convert.ToInt32(lines[0]/*Console.ReadLine()*/);

            for (int tItr = 1; tItr < t * 2; tItr+=2) {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //Console.Write("Please provide the number of people in the queue : ");
                int n = Convert.ToInt32(lines[tItr]);

                //Console.Write("Now insert a sequence of integers (space-separated): ");
                int[] q = Array.ConvertAll(lines[tItr+1].Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);

                watch.Stop();
                Console.WriteLine($"It took {watch.ElapsedMilliseconds} to execute");
            }
        }

        private static void minimumBribes(int[] q){
            int minimumBribes = 0, tempBribes, i, j;
            if(q.Length < 2) {
                Console.WriteLine(minimumBribes);
                return;
            }

            for(i = 0; i < q.Length - 1; i++) {
                if (q[i] > i + 3) {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                if (q[i] == i + 3 || q[i] == i + 2){
                    minimumBribes += q[i] - (i + 1);
                    continue;
                }
                // if (q[i] == i + 3){
                //     minimumBribes += 2;
                //     continue;
                // }
                // if (q[i] == i + 2){
                //     minimumBribes++;
                //     continue;
                // }
                
                tempBribes = 0;
                //for(j = q.Length - 1; j > i; j--) {
                for(j = i + 1; j < q.Length; j++) {
                    if(q[i] > q[j]) {
                        tempBribes++;

                        if(tempBribes > 2) {
                            Console.WriteLine("Too chaotic");
                            return;
                        }
                    }
                }
                minimumBribes += tempBribes;
            }
            Console.WriteLine(minimumBribes);
        }
    }
}