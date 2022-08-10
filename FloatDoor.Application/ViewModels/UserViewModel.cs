using System;

namespace FloatDoor.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string userName, string email, DateTime birthDate)
        {
            Id = id;
            UserName = userName;
            Email = email;
            BirthDate = birthDate;
        }

        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
