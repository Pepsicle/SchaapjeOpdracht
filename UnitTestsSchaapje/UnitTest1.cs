using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchaapjeOpdracht;
using System.Collections.Generic;

namespace UnitTestsSchaapje
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectAnswer()
        {
            // Arrange
            int input = 10;
            string answer = "90";
            Sheep sheep = new Sheep();

            // Act
            var output = sheep.StartTest(input);

            // Assert
            Assert.AreEqual(answer, output);
        }

        [TestMethod]
        public void CorrectAnswerList()
        {
            // Arrange
            List<int> InputList = new List<int> { 1, 5, 10, 15, 0 };
            List<string> answer = new List<string> { "10", "90", "90", "180", "Insomnia" };
            Sheep sheep = new Sheep();

            // Act
            List<string> answerList = new List<string>();
            foreach (int i in InputList)
            {
                answerList.Add(sheep.StartTest(i));
            }

            // Assert
            CollectionAssert.AreEqual(answer, answerList);
        }
    }
}
