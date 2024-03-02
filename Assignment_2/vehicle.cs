// Abstract class representing a Vehicle
abstract class VehicleMSystem
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public abstract void DisplayInformation();
}
