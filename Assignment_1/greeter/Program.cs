// using System;
// class Program
// {
//     static void Main()
//     {
//         string fullName ;
//         Console.ReadLine();

//         Console.WriteLine("Please enter your date of birth (MM/DD/YYYY):");
//         string dobString = Console.ReadLine();
//         DateTime dob;
//         if (DateTime.TryParse(dobString, out dob))
//         {
            
//             string birthDateString = dob.ToString("MM/dd/yyyy");
//             Console.WriteLine($"Your date of birth is: {birthDateString}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid date format entered.");
//         }
//     }
// }
using System;
class Program
{
    static void Main(string[] args)
    {
        string fullName ;
       Console.ReadLine();

        Console.WriteLine("Please enter your date of birth (YYYY-MM-DD):");
        DateTime dob;
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Invalid date format. Please enter your date of birth in YYYY-MM-DD format:");
        }
        DateTime currentDate = DateTime.Now;
        int ageYears = currentDate.Year - dob.Year;
        int ageMonths = currentDate.Month - dob.Month;
        int ageDays = currentDate.Day - dob.Day;
        if (ageMonths < 0 || (ageMonths == 0 && ageDays < 0))
        {
            ageYears--;
            ageMonths += 12;
        }
        Console.WriteLine($"Age as of now: {ageYears} years, {ageMonths} months, and {ageDays} days.");
    }
}
