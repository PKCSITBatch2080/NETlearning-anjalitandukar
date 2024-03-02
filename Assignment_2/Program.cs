using System;

// Abstract class representing a Vehicle
abstract class VehicleMSystem
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public abstract void DisplayInformation();
}

// Interface for vehicles with color options
interface IColor
{
    void ChooseColor(string color);
}

// Class representing a Petrol Car
class PetrolCar : VehicleMSystem, IColor
{
    public int Mileage { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}");
    }

    public void ChooseColor(string color)
    {
        Console.WriteLine($"You chose the {color} color for your {Brand} {Model}");
    }
}

// Class representing an Electric Car
class ElectricCar : VehicleMSystem, IColor
{
    public int BatteryCapacity { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nBattery Capacity: {BatteryCapacity} kWh");
    }

    public void ChooseColor(string color)
    {
        Console.WriteLine($"You chose the {color} color for your {Brand} {Model}");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating a Petrol Car instance
        Console.WriteLine("Below shows information about a petrol car:");
        PetrolCar myPetrolCar = new PetrolCar
        {
            Brand = "Lamborghini",
            Model = "Sesto Elemento",
            Year = 2023,
            Mileage = 20
        };
        myPetrolCar.DisplayInformation();
        myPetrolCar.ChooseColor("black");

        // Creating an Electric Car instance
        Console.WriteLine("\nBelow shows information about an electric car:");
        ElectricCar myElectricCar = new ElectricCar
        {
            Brand = "Tesla",
            Model = "Model S",
            Year = 2024,
            BatteryCapacity = 100
        };
        myElectricCar.DisplayInformation();
        myElectricCar.ChooseColor("blue");
    }
}