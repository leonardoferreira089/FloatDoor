using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.InputModels
{
    public class CreateRequestInputModel
    {
        public int IdFloat { get; set; }
        public int IdUser { get; set; }
        public DateTime RentDate { get; set; }
        public string Message { get; set; }
    }
}
