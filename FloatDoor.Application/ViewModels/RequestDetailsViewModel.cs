using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.ViewModels
{
    public class RequestDetailsViewModel
    {
        public RequestDetailsViewModel(int id, int idFloat, int idUser, DateTime rentDate, string message)
        {
            Id = id;
            IdFloat = idFloat;
            IdUser = idUser;
            RentDate = rentDate;
            Message = message;
        }

        public int Id { get; set; }
        public int IdFloat { get; private set; }
        public int IdUser { get; private set; }
        public DateTime RentDate { get; private set; }       
        public string Message { get; private set; }
        
    }
}
