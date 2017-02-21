using System;
using System.IO;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("Output.txt", text[i]+Environment.NewLine);
            }
        }
    }
}
