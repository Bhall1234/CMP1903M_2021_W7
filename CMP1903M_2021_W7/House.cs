using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_2021_W7
{
    class House : Property
    {
       
        public Enums.PType propertyType { get; set; }
        public int numberOfBedrooms { get; set; }
        public bool garage { get; set; }

        //House constructor
        //ID, Address, Value, noOfBeds, Garage?, propertyType
        //ID could be changed to auto-generated ID's
        public House(int id, string a, int v, int n, bool g, int propType)
        {
            ID = id;
            Address = a;
            Value = v;
            numberOfBedrooms = n;
            garage = g;
            //set property type
            switch(propType)
            {
                case 1: propertyType = Enums.PType.Detached; break;
                case 2: propertyType = Enums.PType.SemiDetached; break;
                case 3: propertyType = Enums.PType.Terrace; break;
                default: propertyType = Enums.PType.Unknown; break;
            }
        }
    }
}
