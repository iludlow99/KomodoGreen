using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    class HybridCar : Car
    {
        private float _milesPerGallon;

        public float MilesPerGallon
        {
            get => _milesPerGallon;
            set
            {
                if (value < 0f)
                    throw new ArgumentOutOfRangeException("Your has a stupid low gas mileage and we think it was a typo. Please check it and correct it");
                else
                    _milesPerGallon = value;

            }
        }

        public HybridCar(string make, string model, int year, float cityMilesPerWeek, float highwayMilesPerWeek, float milesPerGallon) :
            base(make, model, year, cityMilesPerWeek, highwayMilesPerWeek)
        {
            MilesPerGallon = milesPerGallon;
        }
    }
}
