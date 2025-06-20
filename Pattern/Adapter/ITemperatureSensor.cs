namespace DesignPatternsDemo.Adapter
{
    /// <summary>
    /// Target interface expected by the client.
    /// </summary>
    public interface ITemperatureSensor
    {
        double GetTemperatureCelsius();
    }
}
