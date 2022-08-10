namespace FloatDoor.Application.Services.Implementations
{
    public class CreateRatingInputModel
    {
        public int ValuationNote { get; set; }
        public string Comment { get; set; }
        public int IdFloat { get; set; }
        public int IdCustomer { get; set; }
    }
}
