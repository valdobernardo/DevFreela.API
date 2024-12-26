using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly DevFreelaDbContext _context;
        public SkillsRepository(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Skill skill)
        {
            await _context.Skills.AddAsync(skill);
            await _context.SaveChangesAsync();

            return skill.Id;
        }

        public async Task<List<int>> AddUserSkill(List<UserSkill> userSkills)
        {
            await _context.UserSkills.AddRangeAsync(userSkills);
            await _context.SaveChangesAsync();

            return userSkills.Select(s=> s.Id).ToList();
        }

        public async Task<List<Skill>> GetAll()
        {
            var skills = await _context.Skills.ToListAsync();

            return skills;
        }
    }
}
