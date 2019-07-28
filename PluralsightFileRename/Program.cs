using System;
using System.IO;

namespace PluralsightFileRename
{
    class Program
    {
        static void Main(string[] args)
        {
            string coursePath=@"E:\Course\ASP.NET Core Path\03.Building an API with ASP.NET Core";

            var subFolders=Directory.GetDirectories(coursePath);

            foreach (var folderPath in subFolders)
            {
                var files=  Directory.GetFiles(folderPath);

                foreach (var filePath in files)
                {
                    var fileName=filePath.Split('\\')[filePath.Split('\\').Length-1];
                    var format=fileName.Split('.')[fileName.Split('.').Length-1];
                    var newName=string.Format("{0}.{1}", fileName.Split('-')[0],format);
                    var newPath=filePath.Replace(fileName,newName);
                    //Console.WriteLine(string.Format("{0} : {1}", newPath, filePath));
                    File.Move(filePath, newPath);
                }
            }
        }
    }
}
