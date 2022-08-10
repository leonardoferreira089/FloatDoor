namespace FloatDoor.Application.ViewModels
{
    public class FloatDetailsViewModel
    {
        public FloatDetailsViewModel(int id, string floatName, string descriprion, double price)
        {
            Id = id;
            FloatName = floatName;
            Descriprion = descriprion;
            Price = price;
        }

        public int Id { get; private set; }
        public string FloatName { get; private set; }
        public string Descriprion { get; private set; }
        public double Price { get; private set; }
       
    }
}
