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
    public class AnswerControllerTest
    {
        [TestMethod]
        public async Task When_AddAnswer_ShouldInsertAnswer()
        {
            //Arrange
            var application = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
            {
            
             });
            var model = new AnswerModel
            {
                QuestionID = 2,
                Option1 = "A",
                Option2 = "B",
                Option3 = "C",
                Option4 = "D"
            };
            var client = application.CreateClient();
            //Act
            var result = await client.PostAsJsonAsync("api/Answer", model);
            //Assert
            result.EnsureSuccessStatusCode();
            var answerIdfromresult = result.Content.ReadAsStringAsync();
            Assert.AreEqual("2", answerIdfromresult);
        }
    }
}