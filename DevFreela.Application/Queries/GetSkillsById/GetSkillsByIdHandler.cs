using DevFreela.Application.Models;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetSkillsById
{
    public class GetSkillsByIdHandler : IRequestHandler<GetSkillsByIdQuery, ResultViewModel<SkillViewModel>>
    {
        private readonly DevFreelaDbContext _context;
        public GetSkillsByIdHandler(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<SkillViewModel>> Handle(GetSkillsByIdQuery request, CancellationToken cancellationToken)
        {
            var skill = await _context.Skills
                .SingleOrDefaultAsync(p => p.Id == request.Id);

            if (skill is null)
            {
                return ResultViewModel<SkillViewModel>.Error("A Skill não existe.");
            }

            var model = SkillViewModel.FromEntity(skill);

            return ResultViewModel<SkillViewModel>.Success(model);
        }
    }

}
