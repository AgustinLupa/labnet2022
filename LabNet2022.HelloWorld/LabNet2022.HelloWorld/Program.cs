using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LabNet2022.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteAnimation(200, "Hello World!");
            Console.ReadKey();
        }

        static void WriteAnimation(int vel, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
                Thread.Sleep(vel);
            }
        }
    }
}
