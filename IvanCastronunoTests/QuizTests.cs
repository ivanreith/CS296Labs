using System;
using Xunit;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using IvanCastronuno.Models;
namespace IvanCastronunoTests
{
    public class QuizModelTest
    {
        [Fact]
        // Test when the user gives all the right answers
        public void RightAnswerTest()
        {
            // Arrange
            var quiz = new QuizAnswers()
            {
                Quest1 = "answer1",
                Quest2 = "answer2",
                UserQuesting = new AppUser()
                { Name ="Name"}
            };

            // Act
            string resultQuiz = quiz.CheckQuiz(quiz);

            // Assert
            Assert.True(resultQuiz ==" Pass!");
        }

        [Fact]
        // Test when the user gives all the wrong answers
        public void WrongAnswerTest()
        {
            // Arrange
            var quiz = new QuizAnswers()
            {
                Quest1 = "wrong1",
                Quest2 = "wrong2",
                UserQuesting = new AppUser()
                { Name = "Name" }
            };

            // Act
            string resultQuiz = quiz.CheckQuiz(quiz);

            // Assert
            Assert.False(resultQuiz == " Pass!");
        }
        [Fact]
        // Test when the user doesn't give the name
        public void NoNameAnswerTest()
        {
            // Arrange
            var quiz = new QuizAnswers()
            {
                Quest1 = "answer1",
                Quest2 = "answer2",  // the answers are correct
                UserQuesting = new AppUser()
                { Name = null } // Technically if the name is empty, the quiz should not give true 
            };

            // Act
            string resultQuiz = quiz.CheckQuiz(quiz);

            // Assert
            Assert.False(resultQuiz == " Pass!");
        }
    }
}
