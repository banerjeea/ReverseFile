using System;
using System.IO;

namespace ReverseFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputPath = @"c:\temp\input.txt";
            const string outputPath = @"c:\temp\output.txt";

            using (var file = new StreamWriter(outputPath))
            {
                var reverse = new Reverser();
                var lines = reverse.ReverseLineOrder(inputPath);
                foreach (var line in lines)
                {
                    file.WriteLine(reverse.ReverseLine(line));
                }

            }

            Console.WriteLine("File written at {0}", outputPath);
            Console.ReadKey();
        }
    }
}
