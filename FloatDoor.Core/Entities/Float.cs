using FloatDoor.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Core.Entities
{
    public class Float : BaseEntity
    {
        public Float()
        {
        }

        public Float(string floatName, string description, string email, string phoneNumber, double price, int idCustomer, int idFloatOwner)
        {           
            FloatName = floatName;
            Description = description;
            Email = email;
            PhoneNumber = phoneNumber;
            Price = price;
            IdCustomer = idCustomer;
            IdFloatOwner = idFloatOwner;
            CreatedAt = DateTime.Now;
            FloatRents = new List<RentRequest>();
            Ratings = new List<Rating>(); ;
        }

        public string FloatName { get; private set; }
        public string Description { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public double Price { get; private set; }
        public int IdCustomer { get; private set; }
        public User Customer { get; private set; }
        public int IdFloatOwner { get; private set; }
        public User FloatOwner { get; private set; }
        public int IdRequest { get; private set; }
        public RentRequest RentRequest { get; private set; }
        public bool Active { get; private set; } = true;
        public RentStatus Status { get; private set; } = RentStatus.Created;
        public DateTime CreatedAt { get; private set; }        
        public List<RentRequest> FloatRents { get; private set; }
        public List<Rating> Ratings { get; private set; }
        

        public void Request()
        {
            if(Status == RentStatus.Created)
            {
                Status = RentStatus.Requested;
            }
        }

        public void Approve()
        {
            if(Status == RentStatus.Requested)
            {
                Status = RentStatus.Approved;
            }
        }

        public void Reject()
        {
            if(Status == RentStatus.Requested)
            {
                Status = RentStatus.Disapproved;
            }
        }

        public void Update(string floatName, string email, string phoneNumber, double price)
        {
            FloatName = floatName;
            Email = email;
            PhoneNumber = phoneNumber;
            Price = price;
        }

        public void Disabled()
        {
            Active = false;
        }
    }
}
