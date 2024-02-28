using System;

class Car : Vehicle, Color   // Multiple Inheritance
{
     public string Color { get; set; } // Property 
    {
       
    }
//methods
   public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
       Console.WriteLine($"Model: {Model}");
    }
    

    public  Color() => 3.6;
}