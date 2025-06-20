# Strategy Pattern

## What is the Strategy Pattern?
The Strategy Pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. The strategy lets the algorithm vary independently from clients that use it.

## Real-World Problem
Suppose you are building a payment processing system that supports multiple payment methods (Credit Card, PayPal, etc.). You want to allow the user to select a payment method at runtime without changing the payment processing code.

## Solution with Strategy Pattern
The Strategy Pattern lets you define a `PaymentContext` that can use different payment strategies interchangeably.

## Example Code
```csharp
// Strategy interface
public interface IPaymentStrategy {
    void Pay(decimal amount);
}

// Concrete strategies
public class CreditCardPayment : IPaymentStrategy {
    public void Pay(decimal amount) {
        Console.WriteLine($"Paid {amount:C} using Credit Card.");
    }
}
public class PaypalPayment : IPaymentStrategy {
    public void Pay(decimal amount) {
        Console.WriteLine($"Paid {amount:C} using PayPal.");
    }
}

// Context
public class PaymentContext {
    private IPaymentStrategy _strategy;
    public PaymentContext(IPaymentStrategy strategy) {
        _strategy = strategy;
    }
    public void SetStrategy(IPaymentStrategy strategy) {
        _strategy = strategy;
    }
    public void Pay(decimal amount) {
        _strategy.Pay(amount);
    }
}

// Usage
var context = new PaymentContext(new CreditCardPayment());
context.Pay(100);
context.SetStrategy(new PaypalPayment());
context.Pay(50);
```

## How This Solves the Problem
- The payment method can be changed at runtime without modifying the context code.
- New payment methods can be added easily by implementing the strategy interface.
- The code is flexible and adheres to the Open/Closed Principle.

## Summary
The Strategy Pattern is ideal when you need to switch between different algorithms or behaviors at runtime, such as payment methods, sorting algorithms, or compression strategies.
