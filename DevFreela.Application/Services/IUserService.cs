﻿using DevFreela.Application.Models;

namespace DevFreela.Application.Services
{
    public interface IUserService
    {
        ResultViewModel<UserViewModel> GetById(int id);
        ResultViewModel<int> Insert(CreateUserInputModel model);
        ResultViewModel PostSkills(UserSkillsInputModel model);
    }
}