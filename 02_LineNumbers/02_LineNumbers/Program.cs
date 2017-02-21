using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = File.ReadAllLines("Input.txt");

            for (int i = 0; i < text.Length; i ++)
            {
                File.AppendAllText("Output.txt",(i+1)+". "+ text[i] + Environment.NewLine);
            }
        }
    }
}
