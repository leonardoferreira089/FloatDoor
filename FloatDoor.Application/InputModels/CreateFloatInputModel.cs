using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.InputModels
{
    public class CreateFloatInputModel
    {
        public string FloatName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Price { get; set; }
        public int IdCustomer { get; set; }
        public int IdFloatOwner { get; set; }
        public int IdRequest { get; set; }        
    }
}
