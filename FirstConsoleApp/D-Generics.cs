using System;
class Generics
{
    public T Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
        return value;
    }
}