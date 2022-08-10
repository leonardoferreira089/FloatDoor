using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);
        int CreateUser(CreateUserInputModel inputModel);
    }
}
