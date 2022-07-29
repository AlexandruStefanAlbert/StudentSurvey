﻿using AutoMapper;
using MyHotel.Domain.Entities;
using StudentSurvey.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSurvey.Business.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Questions, QuestionModel>().ReverseMap();
            CreateMap<Question_Type, QuestionTypeModel>().ReverseMap();
            CreateMap<Answers, AnswerModel>().ReverseMap();

        }
    }
}