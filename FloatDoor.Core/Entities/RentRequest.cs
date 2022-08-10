using FloatDoor.Core.Enums;
using System;

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
        public RentStatus Status { get; private set; } = RentStatus.Requested;
        public string Message { get; private set; }     

        public void Approve()
        {
            if (Status == RentStatus.Requested)
            {
                Status = RentStatus.Approved;
            }
        }

        public void Reject()
        {
            if (Status == RentStatus.Requested)
            {
                Status = RentStatus.Disapproved;
            }
        }

        public void Update(DateTime rentDate, string message)
        {
            RentDate = rentDate;
            Message = message;
        }
    }
}
