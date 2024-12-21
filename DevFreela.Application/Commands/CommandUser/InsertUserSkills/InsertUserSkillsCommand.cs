using DevFreela.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CommandUser.InsertUserSkills
{
    public class InsertUserSkillsCommand : IRequest<ResultViewModel>
    {
        public InsertUserSkillsCommand(int[] skillIds, int id)
        {
            SkillIds = skillIds;
            Id = id;
        }

        public int[] SkillIds { get; set; }
        public int Id { get; set; }
    }
}
