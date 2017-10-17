using System;
namespace NASAIsABlast.Models
{
    public class RocketDistance
    {
		public int LatDegree { get; set; }
		public int LatMinute { get; set; }
		public int LngDegree { get; set; }
		public int LngMinute { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double FloridaLat { get; set; } = 28.45;
        public double FloridaLng { get; set; } = -80.52;

        public RocketDistance(int latDegree, int latMinute, int lngDegree, int lngMinute)
        {
			this.LatDegree = latDegree;
			this.LatMinute = latMinute;
			this.LngDegree = lngDegree;
            this.LngMinute = lngMinute;

			this.Latitude = LatDegree + (LatMinute / 60);
			this.Longitude = LngDegree + (LngMinute / 60);

        }

        public double CalculateDistance()
        {
			var R = 6372.8; // In kilometers
			var dLat = toRadians(Latitude - FloridaLat);
			var dLon = toRadians(Longitude - FloridaLng);
			FloridaLat = toRadians(FloridaLat);
			Latitude = toRadians(Latitude);

			var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(Latitude) * Math.Cos(FloridaLat);
			var c = 2 * Math.Asin(Math.Sqrt(a));
			return R * 2 * Math.Asin(Math.Sqrt(a));
		}

		public static double toRadians(double angle)
		{
			return Math.PI * angle / 180.0;
		}
    }
}
