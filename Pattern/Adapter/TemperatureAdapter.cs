namespace DesignPatternsDemo.Adapter
{
    /// <summary>
    /// Adapter to convert FahrenheitSensor to ITemperatureSensor.
    /// </summary>
    public class TemperatureAdapter : ITemperatureSensor
    {
        private readonly FahrenheitSensor _sensor;
        public TemperatureAdapter(FahrenheitSensor sensor)
        {
            _sensor = sensor;
        }
        public double GetTemperatureCelsius()
        {
            double f = _sensor.GetTemperatureFahrenheit();
            return (f - 32) * 5.0 / 9.0;
        }
    }
}
