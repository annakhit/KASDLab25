using System;
using System.IO;

namespace KASDLab25
{
    internal class Program
    {
        static void Main()
        {
            string[] rows = File.ReadAllLines("../../Data/input.txt");

            MyHashSet<StringLine> hashSet = new MyHashSet<StringLine>();

            foreach (string row in rows) hashSet.Add(new StringLine(row));

            foreach (StringLine line in hashSet.ToArray()) Console.WriteLine("Value: {0}", line.value);

            Console.ReadKey();
        }
    }
}
