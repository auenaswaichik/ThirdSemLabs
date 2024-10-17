using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Services;
public class FileManagerSerice
{

    private List<string> filePaths = new List<string>();
    private List<string> fileExtensions = new List<string>();

    public void AddExtension(string extension) { fileExtensions.Add(extension); }

    public void CreateFile(string filePath, string fileName, int fileExtension) {

        if(fileExtension > fileExtensions.Count) throw new Exception("No such exstension");

        var path = filePath + "/" + fileName + fileExtensions[fileExtension];

        filePaths.Add(path);

        File.Create(path);

    }

    public string GetLastPath() { return filePaths.Last(); }
    public string GetPath(int pathNumber) {

        if( pathNumber > filePaths.Count) throw new Exception("This file is not exists");

        return filePaths[pathNumber];

    }

}
