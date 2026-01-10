using System.IO;
using System;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            System.Console.WriteLine("Folder Already Exist...");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder Created");
        }
    }
    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo = new DriveInfo(driveName);
        System.Console.WriteLine($"Drive Name {dInfo.Name}");
        System.Console.WriteLine($"Drive FileSystem {dInfo.DriveType}");
        System.Console.WriteLine($"Drive Size {dInfo.TotalSize}");
        System.Console.WriteLine($"Drive FreeSpace {dInfo.AvailableFreeSpace}");

    }

    public void PathDemoFunc()
    {
        string path = @"C:\temp\MyData.text\machine.config"; //@ is the path separator
        System.Console.WriteLine(Path.GetFileName(path));
        System.Console.WriteLine(Path.GetTempPath());
    }
    
}