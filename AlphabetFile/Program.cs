using System;
using System.IO;

namespace AIE
{
    class Program
    {
        public static void Main()
        {
            string content = File.ReadAllText(@"C:\Users\patie\source\repos\CSharpAssessment\AlphabetFile\words.txt");
            File.WriteAllText(@"C:\Users\patie\source\repos\CSharpAssessment\AlphabetFile\output.txt", "text");

            var alphabetize = File.ReadAllLines(content);
            Array.Sort(alphabetize);

            string[] result = alphabetize.Select(i => i.ToString()).ToArray();
            
            File.WriteAllText(@"C:\output.txt", string.Join("", result));
            return;
        }
    }
}