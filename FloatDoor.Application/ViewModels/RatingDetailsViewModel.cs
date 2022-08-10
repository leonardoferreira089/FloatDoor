namespace FloatDoor.Application.ViewModels
{
    public class RatingDetailsViewModel
    {
        public RatingDetailsViewModel(int id, int valuationNote, string comment)
        {
            Id = id;
            ValuationNote = valuationNote;
            Comment = comment;
        }

        public int Id { get; private set; }
        public int ValuationNote { get; private set; }
        public string Comment { get; private set; }
    }
}
