namespace Core.ValueObjects
{
    public class AltitudeChange
    {
        public Altitude Gain { get; }
        public Altitude Loss { get; }

        public AltitudeChange(Altitude gain, Altitude loss)
        {
            Gain = gain;
            Loss = loss;
        }
    }
}