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