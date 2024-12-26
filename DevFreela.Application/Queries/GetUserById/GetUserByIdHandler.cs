﻿using DevFreela.Application.Models;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, ResultViewModel<UserViewModel>>
    {
        private readonly DevFreelaDbContext _context;
        public GetUserByIdHandler(DevFreelaDbContext context)
        {
            _context = context;
        }

        public async Task<ResultViewModel<UserViewModel>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Include(u => u.Skills)
                .ThenInclude(u => u.Skill)
                .SingleOrDefaultAsync(u => u.Id == request.Id);

            if (user is null)
            {
                return ResultViewModel<UserViewModel>.Error("O Usuário não existe.");
            }

            var model = UserViewModel.FromEntity(user);

            return ResultViewModel<UserViewModel>.Success(model);
        }
    }
}
