using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Queries.GetSkillsById
{
    public class GetSkillsByIdQuery : IRequest<ResultViewModel<SkillViewModel>>
    {
        public GetSkillsByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
