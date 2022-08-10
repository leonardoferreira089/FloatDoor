using System;

namespace FloatDoor.Application.InputModels
{
    public class UpdateRequestInputModel
    {
        public int Id { get; set; }
        public DateTime RentDate { get; private set; }       
        public string Message { get; private set; }
    }
}
