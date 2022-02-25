﻿using System;
using System.Collections.Generic;

namespace WordscapesBruteForce
{
    class Program
    {
        private static int minWordSize = 2;
        private static string letters = string.Empty;
        private static List<string> validWords = new List<string>();

        static void Main(string[] args)
        {
            try
            {
                Helpers.LoadQuestions1(out letters, out minWordSize);

                Helpers.StopWatch.Start();
                Helpers.StartHeavyWorkWithPermutations(out validWords, letters, minWordSize);
                Helpers.StopWatch.Stop();

                if (validWords.Count > 0)
                    while (true)
                    {
                        var hints = Helpers.LoadQuestions2(validWords);
                        if (hints.Length == 0)
                        {
                            var key = Helpers.LoadQuestions3();
                            if (key.Key == ConsoleKey.S)
                            {
                                Console.Clear();
                                Helpers.StopWatch.Start();
                                Helpers.StartHeavyWorkWithPermutations(out validWords, string.Join("", letters.Shuffle()), minWordSize);
                                Helpers.StopWatch.Stop();
                            }
                            else if (key.Key == ConsoleKey.N)
                            {
                                letters = "";
                                Helpers.LoadQuestions1(out letters, out minWordSize);
                            }

                            Helpers.LoadQuestions4(validWords);
                        }
                    }
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
