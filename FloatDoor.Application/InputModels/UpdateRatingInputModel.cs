using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.InputModels
{
    public class UpdateRatingInputModel
    {
        public int Id { get; set; }
        public int ValuationNote { get; set; }
        public string Comment { get; set; }
    }
}
