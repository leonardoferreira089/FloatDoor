using System;

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
