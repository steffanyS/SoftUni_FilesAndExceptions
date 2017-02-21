using System.Collections.Generic;
using System.IO;

namespace _04_MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");
            var result=new List<string>();

            for (int i = 0; i < fileOne.Length; i++)
            {
                result.Add(fileOne[i]);
                result.Add(fileTwo[i]);
            }

            File.WriteAllLines("result.txt", result);
        }
    }
}
