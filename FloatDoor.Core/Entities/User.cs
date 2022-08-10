using System;
using System.Collections.Generic;

namespace FloatDoor.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string userName, string email, DateTime birthDate)
        {
            UserName = userName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            CustomerFloats = new List<Float>();
            OwnerFloat = new Float();
            UserRents = new List<RentRequest>();
            Ratings = new List<Rating>();
        }

        public string UserName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Float> CustomerFloats { get; private set; }
        public Float OwnerFloat { get; private set; }        
        public List<RentRequest> UserRents { get; private set; }
        public List<Rating> Ratings { get; private set; }

    }
}
