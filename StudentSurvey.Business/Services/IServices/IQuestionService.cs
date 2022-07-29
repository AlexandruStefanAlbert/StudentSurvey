using StudentSurvey.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSurvey.Business.Services.IServices
{
    public interface IQuestionService
    {
        int AddQuestion(QuestionModel question);
        int AddQuestionType(QuestionTypeModel questionType);

    }
}
