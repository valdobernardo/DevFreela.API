using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Commands.InsertComment
{
    public class InsertCommentCommad : IRequest<ResultViewModel>
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
