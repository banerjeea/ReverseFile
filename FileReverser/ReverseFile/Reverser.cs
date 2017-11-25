using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReverseFile
{
    public class Reverser
    {
        public string ReverseLine(string input)
        {
            var arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string[] ReverseLineOrder(string path)
        {
            var lines = File.ReadAllLines(path);
            Array.Reverse(lines);
            return lines;
        }
    }
}
