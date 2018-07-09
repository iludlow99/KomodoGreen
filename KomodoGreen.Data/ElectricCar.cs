using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    class ElectricCar : Car
    {
        private float _milesPerCharge;

        public float MilesPerCharge
        {
            get => _milesPerCharge;
            set
            {
                if (value < 0f)
                    throw new ArgumentOutOfRangeException("Your has a stupid low charge mileage and we think it was a typo. Please check it and correct it");
                else
                    _milesPerCharge = value;

            }
        }

        public ElectricCar(string make, string model, int year, float cityMilesPerWeek, float highwayMilesPerWeek, float milesPerCharge) :
            base(make, model, year, cityMilesPerWeek, highwayMilesPerWeek)
        {
            MilesPerCharge = milesPerCharge;
        }
    }
}
