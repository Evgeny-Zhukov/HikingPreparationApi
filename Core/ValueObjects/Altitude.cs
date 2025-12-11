namespace Core.ValueObjects
{
    public class Altitude
    {
        public double ValueInMeters { get; }

        public double ValueInKms => ValueInMeters / 1000;

        public Altitude(double meters) 
        {
            ValueInMeters = meters;
        }

        public static Altitude FromKm(double meters) => new(meters / 1000);
    }
}