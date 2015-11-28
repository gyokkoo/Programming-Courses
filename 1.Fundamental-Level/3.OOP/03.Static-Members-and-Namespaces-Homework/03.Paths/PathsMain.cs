using System;

class PathsMain
{
    static void Main()
    {
        Console.Title = "Problem 3.	Paths";

        string loadPath = "../../Points-Input.txt";
        string savePath = "../../Points-Output.txt";

        Path3D path = new Path3D(Storage.LoadPaths(loadPath));

        Storage.SavePath(savePath, path);

        Console.WriteLine("The points are successfully saved in Points-Output.txt");
        Console.WriteLine(path.ToString());
    }
}

