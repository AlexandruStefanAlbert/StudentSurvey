using AutoMapper;
using MyHotel.Domain.Entities;
using StudentSurvey.Business.Models;
using StudentSurvey.Business.Services.IServices;
using StudentSurvey.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSurvey.Business.Services
{
    class QuestionService: IQuestionService
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;

        public QuestionService(
            IQuestionsRepository questionsRepository,
            IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
        }

        public int AddQuestion(QuestionModel question)
        {
            var newQuestion = _questionsRepository.Add(_mapper.Map<Questions>(question));
            return newQuestion.Id;
        }

        
        
    }
}
