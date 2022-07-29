using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSurvey.Api;
using StudentSurvey.Business.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StudentSurvey.Test
{
    [TestClass]
    public class AddQuestionsControllerTest: BaseIntegrationTests
    {
        
        [TestMethod]
        public async Task When_AddQuestionType_ShouldInsertQuestionType()
        {
            

            var model = new QuestionTypeModel
            { 
                
                QuestionType = "Selector"
            };

           

            //Act
            var result = await HttpClient.PostAsJsonAsync("api/QuestionType", model);

            //Assert
            result.EnsureSuccessStatusCode();
            var questionTypeIdfromResult = result.Content.ReadAsStringAsync();
            questionTypeIdfromResult.Should().NotBeNull();

        }

        [TestMethod]
        public async Task When_AddQuestion_ShouldInsertQuestion()
        {
            
            var model = new QuestionModel
            {
                Question_TypeID= 24,
                Question = "Intrebare 1"
            };

            

            //Act
            var result = await HttpClient.PostAsJsonAsync("api/Question", model);

            //Assert
            result.EnsureSuccessStatusCode();
            var questionTypeIdfromResult = result.Content.ReadAsStringAsync();
            questionTypeIdfromResult.Should().NotBeNull();

        }

        [TestMethod]
        public async Task When_AddAnswer_ShouldInsertAnswer()
        {
            //Arrange
           
            var model = new AnswerModel
            {
                QuestionID = 33,
                Option1 = "A",
                Option2 = "B",
                Option3 = "C",
                Option4 = "D"
            };
            
            //Act
            var result = await HttpClient.PostAsJsonAsync("api/Answer", model);
            //Assert
            result.EnsureSuccessStatusCode();
            var answerIdfromresult = result.Content.ReadAsStringAsync();

            answerIdfromresult.Should().NotBeNull();
            //Assert.AreEqual("1", answerIdfromresult);
        }
    }
}