﻿using System;
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
    public class QuestionControllerTest : BaseIntegrationTests
    {

        /*[TestMethod]
        public async Task When_AddQuestion_ShouldAddQuestion()
        {


            var Addquestion = new QuestionModel
            {
                Question = "Care?",
                Question_TypeID = 20

            };
            var result = await HttpClient.PostAsJsonAsync("api/Question", Addquestion);
            //Assert
            result.EnsureSuccessStatusCode();
            var questionIdfromresult = await result.Content.ReadAsStringAsync();
            questionIdfromresult.Should().NotBeNullOrEmpty();
            var ResultofGetQuestionByID = await HttpClient.GetAsync($"api/Question/{questionIdfromresult}");
            ResultofGetQuestionByID.EnsureSuccessStatusCode();
            var QuestionfromResults = await ResultofGetQuestionByID.Content.ReadFromJsonAsync<Questions>();
            QuestionfromResults.Should().NotBeNull();
            QuestionfromResults.Id.ToString().Should().Be(questionIdfromresult);

        }

        [TestMethod]
        public async Task When_UpdateQuestion_ShouldChangeQuestionData()
        {

            var Addquestion = new QuestionModel
            {
                Question = "Care?",
                Question_TypeID = 20

            };
            var result = await HttpClient.PostAsJsonAsync("api/Question", Addquestion);
            //Assert
            result.EnsureSuccessStatusCode();
            var questionIdfromresult = await result.Content.ReadAsStringAsync();

            var expectedDataChangeQuestion = "Cum?";
            var question = new QuestionModel
            {
                Id = Convert.ToInt32(questionIdfromresult),
                Question = expectedDataChangeQuestion,
                Question_TypeID = 20
            };
            var resultforUpdateUser = await HttpClient.PutAsJsonAsync("api/Question", question);
            //Assert

            resultforUpdateUser.EnsureSuccessStatusCode();

            var ResultofGetQuestionByID = await HttpClient.GetAsync($"api/Question/{questionIdfromresult}");
            ResultofGetQuestionByID.EnsureSuccessStatusCode();
            var QuestionfromResults = await ResultofGetQuestionByID.Content.ReadFromJsonAsync<Questions>();
            QuestionfromResults.Should().NotBeNull();
            QuestionfromResults.Id.ToString().Should().Be(questionIdfromresult);
            QuestionfromResults.Question.Should().Be(expectedDataChangeQuestion);


        }
        */
        [TestMethod]
        public async Task When_GetAll_ShouldGiveOKResponse()
        {



            var response = await HttpClient.GetAsync("/api/Question");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

    }
}