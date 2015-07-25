using System;

namespace Galactic_GPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double londitude,Planet palnet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = londitude;
            this.Planet = palnet;
        }

        public Planet Planet { get; set; }
        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("value", "Longitude must be between -180.0 and 180.0.");
                }
                this.longitude = value;
            }
        }
        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("value", "Latitude must be between -90.0 and 90.0.");
                }
                this.latitude = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}