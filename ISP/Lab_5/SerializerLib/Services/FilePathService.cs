using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerializerLib.Services;
public static class FilePathService
{

    public static string GetPath(string path) {

        var curDirectory = Path.GetDirectoryName(path);
        return Path.Combine(curDirectory, path);

    }
        
}
