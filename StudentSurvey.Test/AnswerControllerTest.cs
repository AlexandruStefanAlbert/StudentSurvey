using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHotel.Domain.Entities;
using StudentSurvey.Business.Models;

namespace StudentSurvey.Test
{
    [TestClass]
    public class AnswerControllerTest : BaseIntegrationTests
    {

        /*[TestMethod]
        public async Task When_AddAnswer_ShouldAddAnswer()
        {
            var Addanswer = new AnswerModel
            {
                QuestionID = 12,
                Option1 = "Avem",
                Option2 = "Bbe",
                Option3 = "Cer", 
                Option4 = "Dor",
                
            };
            var result = await HttpClient.PostAsJsonAsync("api/Answer", Addanswer);
            //Assert
            result.EnsureSuccessStatusCode();
            var AnswerIdfromresult = await result.Content.ReadAsStringAsync();
            AnswerIdfromresult.Should().NotBeNullOrEmpty();
            var ResultofGetAnswerByID = await HttpClient.GetAsync($"api/Answer/{AnswerIdfromresult}");
            ResultofGetAnswerByID.EnsureSuccessStatusCode();
            var AnswerfromResults = await ResultofGetAnswerByID.Content.ReadFromJsonAsync<Answers>();
            AnswerfromResults.Should().NotBeNull();
            AnswerfromResults.Id.ToString().Should().Be(AnswerIdfromresult);

        }

        [TestMethod]
        public async Task When_UpdateAnswer_ShouldChangeAnswerData()
        {


            var Addanswer = new AnswerModel
            {
                QuestionID = 1,
                Option1 = "Are",
                Option2 = "Bere",
                Option3 = "Cere",
                Option4 = "Doare"
            };
            var result = await HttpClient.PostAsJsonAsync("api/Answer", Addanswer);
            //Assert
            result.EnsureSuccessStatusCode();
            var AnswerIdfromresult = await result.Content.ReadAsStringAsync();

            var expectedDataChangeAnswer = "Merge";
            var answer = new AnswerModel
            {
                Id = Convert.ToInt32(AnswerIdfromresult),
                QuestionID = 1,
                Option1 = "Are",
                Option2 = "Bere",
                Option3 = "Cere",
                Option4 = expectedDataChangeAnswer
            };
            var resultforUpdateAnswer = await HttpClient.PutAsJsonAsync("api/Answer", answer);
            //Assert

            resultforUpdateAnswer.EnsureSuccessStatusCode();

            var ResultofGetAnswerByID = await HttpClient.GetAsync($"api/Answer/{AnswerIdfromresult}");
            ResultofGetAnswerByID.EnsureSuccessStatusCode();
            var AnswerfromResults = await ResultofGetAnswerByID.Content.ReadFromJsonAsync<Answers>();
            AnswerfromResults.Should().NotBeNull();
            AnswerfromResults.Id.ToString().Should().Be(AnswerIdfromresult);
            AnswerfromResults.Option4.Should().Be(expectedDataChangeAnswer);


        }*/

        [TestMethod]
        public async Task When_GetAll_ShouldGiveOKResponse()
        {



            var response = await HttpClient.GetAsync("/api/Answer");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

    }
}