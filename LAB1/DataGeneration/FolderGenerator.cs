using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.DataGeneration
{
    class FolderGenerator
    {
        public static String createFolder(string folder_name)
        {
            Directory.CreateDirectory(@"..\..\..\DataGeneration\" + folder_name);
            return @"..\..\..\DataGeneration\" + folder_name;
        }
    }
}
