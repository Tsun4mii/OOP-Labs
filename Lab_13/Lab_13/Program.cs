using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            SYODiskinfo.FreeSpace("C:\\");
            SYODiskinfo.FileSystem("C:\\");
            SYODiskinfo.DrivesFullInfo();

            string path = @"E:\ООП\Lab_13\Lab_13";
            SYODirInfo.FileCount(path);
            SYODirInfo.CreationTime(path);
            SYODirInfo.ParentDirectory(path);
            SYODirInfo.SubdirectoriesCount(path);

            string path2 = @"E:\ООП\Lab_13\Lab_13\Program.cs";
            SYOFileInfo.FullPath(path2);
            SYOFileInfo.BasicFileInfo(path2);
            SYOFileInfo.CreationTime(path2);

            SYOFileManager.InspectDrive(@"E:\ООП");
            SYOFileManager.CopyFiles(@"FOLDER", ".txt");
            SYOFileManager.ArchiveUnarchive();

            Console.WriteLine("Удалить каталоги? 1 - да");
            int key = int.Parse(Console.ReadLine());

            if (key == 1)
            {
                System.IO.Directory.Delete("SYOInspect", true);
                System.IO.Directory.Delete("Unzipped", true);
            }
        }
    }
}
