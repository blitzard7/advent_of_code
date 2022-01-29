using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021
{
    class Day02
    {
        public int Solve01()
        {
            var input = ReadInput();
            var horizontal = 0;
            var depth = 0;

            foreach (var line in input)
            {
                var splitLine = line.Split(" ");
                var command = splitLine[0];
                var value = int.Parse(splitLine[1]);

                switch (command)
                {
                    case "forward":
                        horizontal+= value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }

            return horizontal * depth;
        }

        public int Solve02()
        {
            var input = ReadInput();
            var horizontal = 0;
            var depth = 0;
            var aim = 0;

            foreach (var line in input)
            {
                var splitLine = line.Split(" ");
                var command = splitLine[0];
                var value = int.Parse(splitLine[1]);

                switch (command)
                {
                    case "forward":
                        horizontal += value;
                        depth += aim * value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }

            return horizontal * depth;
        }

        private static List<string> ReadInput() => File.ReadAllLines("Inputs/Day02.txt").ToList();
    }
}
