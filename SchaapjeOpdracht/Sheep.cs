using System;
using System.Collections.Generic;
using System.Text;

namespace SchaapjeOpdracht
{
    class Sheep
    {
        public int multiplier = 1;
        readonly string[] NeededNumbers = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string Numbers = "";
        private string numberString = "";

        public string StartProgram(string inputString) //naar program
        {
            int input = Int32.Parse(inputString);
            string Answer = TryAnswer(input);
            return Answer + " is the answer.";
        }

        public string StartTest(int input)
        {
            string Answer = TryAnswer(input);
            return Answer;
        }

        private string TryAnswer(int input) //naam functie
        {
            numberString = "";
            Numbers = "";
            for (int i = 0; i < 10001; i++) //magic number, constante maken
            {
                numberString = CreateNumberString(input);
                if (NumberCheck(numberString))
                {
                    return (multiplier * input).ToString();
                }
                multiplier++;
            }
            return "Insomnia";
        }

        private string CreateNumberString(int input)
        {
            Numbers += input * multiplier;
            return Numbers;
        }

        private bool NumberCheck(string input)
        {
            foreach (string manditoryNumber in NeededNumbers)
            {
                if (!input.Contains(manditoryNumber))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
