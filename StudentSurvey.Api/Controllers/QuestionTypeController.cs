using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSurvey.Business.Models;
using StudentSurvey.Business.Services.IServices;

namespace StudentSurvey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionTypeController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionTypeController(IQuestionService questionService)
        {
            _questionService = questionService;

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult AddQuestionType([FromBody] QuestionTypeModel question)
        {
            var questionResult = _questionService.AddQuestionType(question);

            return CreatedAtAction(null, questionResult);

        }


    }
}