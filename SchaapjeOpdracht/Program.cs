using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SchaapjeOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep sheep = new Sheep();
            TextReader textReader = new TextReader();
            string path = @"C:\Users\pepij\Downloads\Programmeeruitdaging_SchaapjePluus\Input_SchaapjePluus.txt";

            Console.WriteLine("Do you want to use the testcase file? (Type 'y' to confirm)");
            if (Console.ReadLine() == "y")
            {
                if (File.Exists(path))
                {
                    Console.Write(textReader.StartTest());
                }
                else
                {
                    Console.WriteLine("No file found, exiting");
                }
            } else
            {
                Console.WriteLine("Enter the number you want to try:");
                string input = Console.ReadLine();
                Console.WriteLine(sheep.StartProgram(input));
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
