﻿using AutoMapper;
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
        private readonly IQuestion_TypeRepository _question_TypeRepository;
        private readonly IMapper _mapper;

        public QuestionService(
            IQuestionsRepository questionsRepository,
            IQuestion_TypeRepository question_TypeRepository,
            IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _question_TypeRepository = question_TypeRepository;
            _mapper = mapper;
        }

        public int AddQuestion(QuestionModel question)
        {
            var newQuestion = _questionsRepository.Add(_mapper.Map<Questions>(question));
            return newQuestion.Id;
        }
        public int AddQuestionType(QuestionTypeModel questionType)
        {
            var newQuestionType = _question_TypeRepository.Add(_mapper.Map<Question_Type>(questionType));
            return newQuestionType.Id;
        }


    }
}
