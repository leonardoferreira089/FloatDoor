using FloatDoor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Infrastructure.Persistence
{
    public class FloatDoorDbContext
    {
        public FloatDoorDbContext()
        {            
        }

        public List<Float> Floats { get; set; }
        public List<User> Users { get; set; }
        public List<RentRequest> Rents { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
