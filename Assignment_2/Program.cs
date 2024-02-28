using System;

{
    static void Main(string[] args)
    {
        // Create an instance of class B
        B bInstance = new B();
        bInstance.Method1();
        bInstance.Method2();

        Console.WriteLine();

        // Create an instance of class D
        D dInstance = new D();
        dInstance.Method1();
        dInstance.Method2();
        dInstance.Accelerate(10);
        dInstance.Decelerate(5);
    }
}