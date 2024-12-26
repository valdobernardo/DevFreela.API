using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Commands.CommandsSkills.InsertSkills
{
    public class InsertSkillsCommand : IRequest<ResultViewModel<int>>
    {
        public string Description { get; set; }
    }
}
