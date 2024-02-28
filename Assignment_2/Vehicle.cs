using System;
class Vehicle
{
    // Properties
    public string Make { get; set; }
    public string Model { get; set; }

    // Field
    private int _year;

    // Constructor
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        _year = year;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {_year}");
    }
}

