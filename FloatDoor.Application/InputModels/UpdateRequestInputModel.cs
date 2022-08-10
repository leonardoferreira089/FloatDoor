using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.InputModels
{
    public class UpdateRequestInputModel
    {
        public int Id { get; set; }
        public DateTime RentDate { get; private set; }       
        public string Message { get; private set; }
    }
}
