// Class B with one property and two methods
class B
{
    // Property
    public string Color { get; set; }

    // Method 1
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    // Method 2
    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Class D inherits from class B
class D : B
{
    // Field
    private int _speed;

    // Method 1
    public void Accelerate(int increment)
    {
        _speed += increment;
        Console.WriteLine($"Speed increased by {increment} units. Current speed: {_speed}.");
    }

    // Method 2
    public void Decelerate(int decrement)
    {
        _speed -= decrement;
        Console.WriteLine($"Speed decreased by {decrement} units. Current speed: {_speed}.");
    }
}
