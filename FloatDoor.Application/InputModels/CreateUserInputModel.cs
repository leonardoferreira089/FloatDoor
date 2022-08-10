using System;

namespace FloatDoor.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
