using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using FloatDoor.Application.ViewModels;
using FloatDoor.Core.Entities;
using FloatDoor.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly FloatDoorDbContext _context;
        public UserService(FloatDoorDbContext context)
        {
            _context = context;
        }

        public int CreateUser(CreateUserInputModel inputModel)
        {
            var user = new User(inputModel.UserName, inputModel.Email, inputModel.BirthDate);
            _context.Users.Add(user);

            return user.Id;
        }

        public UserViewModel GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            var userVM = new UserViewModel(user.Id, user.UserName, user.Email, user.BirthDate);

            return userVM;
        }
    }
}
