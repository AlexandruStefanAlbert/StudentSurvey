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
    public class ConsentControllerTest : BaseIntegrationTests
    {

        /*[TestMethod]
        public async Task When_AddConsent_ShouldAddConsent()
        {
           
            var Addconsent = new ConsentModel
            {
                UserID = 1,
                SurveyID = 1,
                ExpirationDate = DateTime.Now.AddMonths(36)

            };
            var result = await HttpClient.PostAsJsonAsync("api/Consent", Addconsent);
            //Assert
            result.EnsureSuccessStatusCode();
            var ConsentIdfromresult = await result.Content.ReadAsStringAsync();
            ConsentIdfromresult.Should().NotBeNullOrEmpty();
            var ResultofGetConsentByID = await HttpClient.GetAsync($"api/Consent/{ConsentIdfromresult}");
            ResultofGetConsentByID.EnsureSuccessStatusCode();
            var ConsentfromResults = await ResultofGetConsentByID.Content.ReadFromJsonAsync<Consent>();
            ConsentfromResults.Should().NotBeNull();
            ConsentfromResults.Id.ToString().Should().Be(ConsentIdfromresult);

        }*/

       /* [TestMethod]
        public async Task When_UpdateConsent_ShouldChangeConsentData()
        {


            var Addconsent = new ConsentModel
            {
                UserID = 1,
                SurveyID = 1,
                ExpirationDate = DateTime.Now.AddMonths(36),
                Agree=true
            };
            var result = await HttpClient.PostAsJsonAsync("api/Consent", Addconsent);
            //Assert
            result.EnsureSuccessStatusCode();
            var ConsentIdfromresult = await result.Content.ReadAsStringAsync();

            var expectedDataChangeConsent = false;
            var consent = new ConsentModel
            {
                Id = Convert.ToInt32(ConsentIdfromresult),
                UserID = 1,
                SurveyID = 1,
                ExpirationDate = DateTime.Now.AddMonths(36),
                Agree = expectedDataChangeConsent
            };
            var resultforUpdateConsent = await HttpClient.PutAsJsonAsync("api/Consent", consent);
            //Assert

            resultforUpdateConsent.EnsureSuccessStatusCode();

            var ResultofGetConsentByID = await HttpClient.GetAsync($"api/Consent/{ConsentIdfromresult}");
            ResultofGetConsentByID.EnsureSuccessStatusCode();
            var ConsentfromResults = await ResultofGetConsentByID.Content.ReadFromJsonAsync<Consent>();
            ConsentfromResults.Should().NotBeNull();
            ConsentfromResults.Id.ToString().Should().Be(ConsentIdfromresult);
            ConsentfromResults.Agree.Should().Be(expectedDataChangeConsent);


        }*/

        [TestMethod]
        public async Task When_GetAll_ShouldGiveOKResponse()
        {



            var response = await HttpClient.GetAsync("/api/Consent");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

    }
}