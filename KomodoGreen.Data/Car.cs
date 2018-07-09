using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    abstract class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (value < 1885)
                    throw new ArgumentOutOfRangeException("Your car is too old");
                else
                    _year = value; 
            }
        }

        private float _cityMilesPerWeek;

        public float CityMilesPerWeek
        {
            get => _cityMilesPerWeek;
            set
            {
                if(value < 0f)
                    throw new ArgumentOutOfRangeException("Your has a stupid low mileage and we think it was a typo. Please check it and correct it");
                else
                _cityMilesPerWeek = value; 

            }
        }

        private float _highwayMilesPerWeek;

        public float HighwayMilesPerWeek
        {
            get => _highwayMilesPerWeek;
            set
            {
                if (value < 0f)
                    throw new ArgumentOutOfRangeException("Your has a stupid low mileage and we think it was a typo. Please check it and correct it");
                else
                _highwayMilesPerWeek = value; 

            }
        }


        protected Car(string make, string model, int year, float cityMilesPerWeek, float highwayMilesPerWeek)
        {
            Make = make;
            Model = model;
            Year = year;
            CityMilesPerWeek = cityMilesPerWeek;
            HighwayMilesPerWeek = highwayMilesPerWeek;
        }
    }
}
