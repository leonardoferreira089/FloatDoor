using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Core.Entities
{
    public class RentRequest : BaseEntity
    {
        public RentRequest(int idFloat, int idUser, DateTime rentDate, string message)
        {
            IdFloat = idFloat;
            IdUser = idUser;
            RentDate = rentDate;
            Message = message;
        }

        public int IdFloat { get; private set; }
        public int IdUser { get; private set; }
        public DateTime RentDate { get; private set; }
        public string Message { get; private set; }        


    }
}
