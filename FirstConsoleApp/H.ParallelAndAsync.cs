using System;
using System.Threading;
using System.Threading.Tasks;

public class ParallelAndASync
{
    //Parallel Programming
    //Tasks - Takes CPU time and independent
    int [ ]numbers=[323,234, 343, 234, 542, 333];

    private void CalculateSquare(int n)
    {
        var square = n*(long)n;
        Console.WriteLine($"Square of {n} is {square}");
        Thread.Sleep(1000);
    }
    //sequential
    public void ProcessNumbers ()
    {
        Console.WriteLine("Sequential loop:");
      foreach(var num in numbers)
    {
        CalculateSquare(num);
    }
    }

    //parallel 
    public void ProcessNumbersParallel ()
    {
         Console.WriteLine("Prallel loop:");
        Parallel.ForEach(numbers,CalculateSquare);
    }

}