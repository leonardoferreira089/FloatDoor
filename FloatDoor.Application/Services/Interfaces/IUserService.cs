using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);
        int CreateUser(CreateUserInputModel inputModel);
    }
}
