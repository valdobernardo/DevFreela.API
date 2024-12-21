using DevFreela.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CommandsSkills.InsertSkills
{
    public class InsertSkillsCommand : IRequest<ResultViewModel<int>>
    {
        public string Description { get; set; }
    }
}
