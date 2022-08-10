using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.ViewModels
{
    public class FloatsViewModel
    {
        public FloatsViewModel(int id, string floatName, double price)
        {
            Id = id;
            FloatName = floatName;
            Price = price;

        }

        public int Id { get; private set; }
        public string FloatName { get; private set; }
        public double Price { get; private set; }


    }
}
