using System;
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