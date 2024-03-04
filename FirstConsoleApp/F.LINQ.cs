//LINQ - LANGUAGE INTEGRATED QUERY
using System;
using System.Collections.Generic;
using System.Linq;
class LINQLearner
{
    void Learn()
    {
        int[] numbers = [3,4,5,67,12,34,56,78,89,98,123];
        List<string> names =[ "Anjali","Prakriti","Sumina","Rikisha","Anamika"];

        var s1 = new Student ("Anjali",1 , new DateTime(2002 ,04,20));
        var s2 = new Student ("Sumina",22 , new DateTime(1999 ,01,20));
        var s3 = new Student ("Laxmi",32 , new DateTime(1896 ,05,20));
        var s4 = new Student ("Ojesh",4 , new DateTime(1894 ,07,20));
        var s5 = new Student ("Aryan",15 , new DateTime(2008 ,06,20));

        List<Student> students = [s1, s2, s3, s4 ,s5];
        

        //Get odd numbers from "numbers"

        var oddNumbers = numbers.Where(number => number % 2 ! == 1);    //Lambda Expression

        // Get squares of all items in "numbers"

        var squares = numbers.Select(x => x * x);


        //Get square of even numbers only

        var esquares = numbers.Where(x => x % 2  == 0).Select(y => y * y);   //method syntax

          //query syntax
        esquares = from x in numbers 
                      where x % 2 == 0
                       select x*x;
       
       //Get all name initials
       var initials = names.Select(name => name[0]); //['A','P','S','R','A']

       //Order names in Ascending order 
       var namesOrdered = names.OrderBy(x => x); 


       //Find students with name starting with"O"
       var oStudents = students.Where( student => student.name.ToLower().StartsWith('o'));

       //Group students by birth month
       var bmonthStudents = students.GroupBy ( student => student.Dob.Month );

       //Get youngest student
       var youngest = students.OrderByDescending(x => x.Dob).First();
       youngest = students.MaxBy(x => x.Dob);

       

     





    }
}