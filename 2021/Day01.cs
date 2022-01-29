using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021
{
    class Day01
    {
        public int Solve1()
        {
            var signals = ReadInput();
            var result = 0;

            for (int i = 0; i < signals.Count - 1; i++)
            {
                var current = signals[i];
                var next = signals[i+1];

                if (next > current)
                {
                    result++;
                }
            }

            return result;
        }

        public int Solve2()
        {
            var signals = ReadInput();
            var result = 0;

            for (int i = 0; i < signals.Count - 3; i++)
            {
                var current = signals[i];
                var next = signals[i + 3];

                if (next > current)
                {
                    result++;
                }
            }

            return result;
        }

        private static List<int> ReadInput() => File.ReadAllLines("Inputs/Day01.txt").Select(int.Parse).ToList();
    }
}
