namespace Core.ValueObjects
{
    public class Distance
    {
        public double ValueInMeters { get; }

        public double ValueInKms => ValueInMeters / 1000;

        public Distance(double meters) 
        {
            ValueInMeters = meters;
        }

        public static Distance FromKms(double meters) => new(meters / 1000);
    }
}