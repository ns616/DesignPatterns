namespace DesignPatternsDemo.Adapter
{
    /// <summary>
    /// Adaptee class with incompatible interface (returns Fahrenheit).
    /// </summary>
    public class FahrenheitSensor
    {
        public double GetTemperatureFahrenheit() => 77.0; // Example value
    }
}
