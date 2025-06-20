# Adapter Pattern

## What is the Adapter Pattern?
The Adapter Pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces by wrapping an existing class with a new interface.

## Real-World Problem
Suppose you have a temperature sensor that returns values in Fahrenheit, but your application expects temperatures in Celsius. You want to use the existing sensor without modifying its code.

## Solution with Adapter Pattern
The Adapter Pattern lets you create a `TemperatureAdapter` that converts Fahrenheit readings to Celsius, allowing the client to use the sensor as if it provided Celsius values.

## Example Code
```csharp
// Target interface
public interface ITemperatureSensor {
    double GetTemperatureCelsius();
}

// Adaptee
public class FahrenheitSensor {
    public double GetTemperatureFahrenheit() => 77.0;
}

// Adapter
public class TemperatureAdapter : ITemperatureSensor {
    private readonly FahrenheitSensor _sensor;
    public TemperatureAdapter(FahrenheitSensor sensor) { _sensor = sensor; }
    public double GetTemperatureCelsius() {
        double f = _sensor.GetTemperatureFahrenheit();
        return (f - 32) * 5.0 / 9.0;
    }
}

// Usage
var sensor = new FahrenheitSensor();
var adapter = new TemperatureAdapter(sensor);
double celsius = adapter.GetTemperatureCelsius();
```

## How This Solves the Problem
- Allows the use of existing code (Fahrenheit sensor) with a new interface (Celsius).
- No need to modify the original sensor class.
- Promotes code reuse and flexibility.

## Summary
The Adapter Pattern is ideal when you need to integrate classes with incompatible interfaces, such as legacy code or third-party libraries.
