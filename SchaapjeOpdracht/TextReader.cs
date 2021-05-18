using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SchaapjeOpdracht
{
    class TextReader
    {
        private string[] ReadFile()
        {
            string path = @"C:\Users\pepij\Downloads\Programmeeruitdaging_SchaapjePluus\Input_SchaapjePluus.txt";
            string[] readText = File.ReadAllLines(path);
            return readText;
        }

        public string StartTest()
        {
            string[] data = ReadFile();
            string Answer = GetAnswer(data);
            return Answer;
        }

        private string GetAnswer(string[] data)
        {
            Sheep sheep = new Sheep();
            string Answer = "";
            int caseNumber = 1;
            List<string> answers = new List<string>();
            List<string> dataStringList = data.ToList<string>();
            List<int> dataList = new List<int>();

            foreach (string item in dataStringList)
            {
                int newItem = Int32.Parse(item);
                dataList.Add(newItem);
            }
            dataList.RemoveAt(0);

            foreach (int test in dataList)
            {
                string sheepAnswer = sheep.StartTest(test);
                answers.Add("Testcase #" + caseNumber + "= " + sheepAnswer + "\n");
                caseNumber++;
            }

            foreach (string answer in answers)
            {
                Answer += answer;
            }

            return Answer;
        }
    }
}
