using System;

// this below is class A
abstract class vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public abstract void Calculatemileage();
    
    
}

//this below is a interface
interface IColor
{
    void ChooseColor(string color);

   
}


//this below car is class B
class Car : A_vehicle, IColor
{
    public int Mileage { get; set; }

    public override void Calculatemileage()
    {
        Console.WriteLine($"Driving {Brand} {Model} gives {Mileage} mileage");
    }

    public virtual void detail()
    {
        Console.WriteLine($"This car use petrol");
    }

    public void ChooseColor(string color)
    {
        Console.WriteLine($"You chose car of {color}");
    }
}


//this below is class D
class ElectricCar : Car
{
    public static int NumOfElectricCar;

    public void count(int num)
    {
        Console.WriteLine($"There are {num} of electric cars");
    }

    public override void detail()
    {
        Console.WriteLine("This car uses electricity");
    }
}


//below is the main program
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Below shows about normal car");
        Car myCar = new Car();
        myCar.Brand = "Lamborghini";
        myCar.Model = "Sesto Elemento";

        myCar.Mileage = 20;

        myCar.Calculatemileage();
        myCar.detail();
        myCar.ChooseColor("black");

        //below is for electric car
        Console.WriteLine("Below shows about electric car");
        ElectricCar myElectricCar = new ElectricCar();
        myElectricCar.count(5);
        myElectricCar.detail();

    }
}