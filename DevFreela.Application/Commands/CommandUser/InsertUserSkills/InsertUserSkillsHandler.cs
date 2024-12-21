﻿using DevFreela.Application.Models;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.CommandUser.InsertUserSkills
{
    public class InsertUserSkillsHandler : IRequestHandler<InsertUserSkillsCommand, ResultViewModel>
    {
        private readonly DevFreelaDbContext _context;
        public InsertUserSkillsHandler(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(InsertUserSkillsCommand request, CancellationToken cancellationToken)
        {

            {
                var userSkills = request.SkillIds.Select(s => new UserSkill(request.Id, s)).ToList();

                await _context.UserSkills.AddRangeAsync(userSkills);
                await _context.SaveChangesAsync();

                return ResultViewModel.Success();
            }
        }
    }
}