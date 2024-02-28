// Interface C with two methods
interface Color
{
    void Method1();
    void Method2();
}

// Class B implements interface C
class B : C
{
    // Property
    public string Color { get; set; }

    // Method 1 from interface C
    public void Method1()
    {
        Console.WriteLine("Method 1 implementation in B.");
    }

    // Method 2 from interface C
    public void Method2()
    {
        Console.WriteLine("Method 2 implementation in B.");
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
