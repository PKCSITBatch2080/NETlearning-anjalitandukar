using System.Collections.Generic;

class Coll
{
    void Learn()
    {
        // One dimensional
        byte[] ages = [78, 23, 45, 67, 12, 34, 56, 7, 8];
        string[] names = ["23", "343", "sdfsdf sfsf"];

        // Multi
        int[,] studentsInClassRoom = new int[7, 6];
        studentsInClassRoom[0, 0] = 0;
        studentsInClassRoom[0, 1] = 1;
        studentsInClassRoom[0, 2] = 2;
        studentsInClassRoom[0, 3] = 30;

        // Jagged array
        int[][] studentsInClassRoom2 = [[1, 2, 3], [3, 4], [2, 4, 5, 6]];

        // Collections
        List<int> ageList = [3,4,5,7,7,8];
        List<string> namesList = ["anjali","sumina","praku"];

        Dictionary<string,long> countryPopulation= new();
        countryPopulation.Add("Nepal",2323232323);
        countryPopulation.Add("India",6666666666);
        countryPopulation.Add("USA",4545454545);
        countryPopulation.Add("Canada",111111111);

        var p = countryPopulation["India"];


     
     
    }
}