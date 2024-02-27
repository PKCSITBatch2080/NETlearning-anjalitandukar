using System;

class DataTypes
{
    public void Learn()
    {
        //Numbers
        byte age = 255;
        byte dayOfWeek = 11;        //Camel casing
        byte DayOfWeek = 11;        //Pascal casing

        float weight1 = 45.634f;
        double weight2 = 45678.6872346;
        decimal weight3 = 435678.69834728942748924m;

        // Text
        char initial = 'D';
        string name = "Anjali Tandukar";

        bool? isFemale = null;

        DateTime date = DateTime.Now;

        Console.WriteLine(date);
    }
}