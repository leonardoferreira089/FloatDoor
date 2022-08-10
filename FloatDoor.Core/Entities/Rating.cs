using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Core.Entities
{
    public class Rating : BaseEntity
    {
        public Rating(int valuationNote, string comment, int idFloat, int idCustomer)
        {
            ValuationNote = valuationNote;
            Comment = comment;
            IdFloat = idFloat;
            IdCustomer = idCustomer;
        }

        public int ValuationNote { get; private set; }
        public string Comment { get; private set; }
        public int IdFloat { get; private set; }
        public int IdCustomer { get; private set; }    
        
        public void Update(int valuationNote, string comment)
        {
            ValuationNote = valuationNote;
            Comment = comment;
        }
    }
}
