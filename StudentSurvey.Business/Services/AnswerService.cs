using AutoMapper;
using MyHotel.Domain.Entities;
using StudentSurvey.Business.Models;
using StudentSurvey.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSurvey.Business.Services.IServices
{
    class AnswerService :  IAnswerService
    {
        private readonly IAnswersRepository _answersRepository;
        private readonly IMapper _mapper;


        public AnswerService(IAnswersRepository answersRepository, IMapper mapper)
        {
            _answersRepository = answersRepository;
            _mapper = mapper;
        }

        public int AddAnswer(AnswerModel answer)
        {
            var newAnswer = _answersRepository.Add(_mapper.Map<Answers>(answer));
            return newAnswer.Id;
        }
    }
}
