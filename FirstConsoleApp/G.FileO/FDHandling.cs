using System.IO;
class FDHandling
{
    //File IO

    public static void CreateFile()
    {
        var folderPath = @"D:\GIT\NETlearning-anjalitandukar\FirstConsoleApp\G.FileO";
        var filePath = $"{folderPath}\\student.txt";

        File.WriteAllText(filePath, "This is first line of text");

        Directory.CreateDirectory($"{folderPath}\\Dummy");

        //Create 10 files with names File1.cs , File2.cs , File3.cs and so on
        //Each file should contain byte variable 'age' with value as 1, 2, 3... 
        for (int counter = 1 ; counter <= 10 ; counter ++)
        {
            var file =$"File{counter}" ;
            var fileP = $"{folderPath}\\Dummy\\{file}.cs";
            
             File.WriteAllText(fileP, "class "+  file + "{}" );


        }

       




      


    }
}