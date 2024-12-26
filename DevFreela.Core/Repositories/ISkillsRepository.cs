using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface ISkillsRepository
    {
        Task<List<Skill>> GetAll();
        Task<List<int>> AddUserSkill(List<UserSkill> userSkills);
        Task<int> Add(Skill skill);
    }
}
