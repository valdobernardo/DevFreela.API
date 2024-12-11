using DevFreela.Core.Entities;

namespace DevFreela.Application.Models
{
    public class UserSkillsInputModel
    {
        public UserSkillsInputModel(int[] skillIds, int id)
        {
            SkillIds = skillIds;
            Id = id;
        }

        public int[] SkillIds { get; set; }
        public int Id { get; set; }
    }
}
