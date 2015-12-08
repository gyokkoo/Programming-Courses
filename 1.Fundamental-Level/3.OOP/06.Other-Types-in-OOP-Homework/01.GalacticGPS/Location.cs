using System;

namespace _01.GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }


        public double Latitude
        {
            get { return this.latitude; }

            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("latitude", "Latitude must be in ragne [-90...90]");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }

            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude", "Longitude must be in range [-180...180]");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return $"{this.Latitude}, {this.Longitude} - {this.Planet}";
        }
    }
}
