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