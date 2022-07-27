using Microsoft.Extensions.DependencyInjection;
using StudentSurvey.Business.Services;
using StudentSurvey.Business.Services.IServices;
using System.Reflection;

namespace StudentSurvey.Business
{
    public static class BussinessServiceRegistration 
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
           
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IAnswerService, AnswerService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
