﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSurfer
{
    public class FileDirectoryInfo
    {
        public FileDirectoryInfo() { }
        public FileDirectoryInfo(string name, string type, string adress, string fileSize,   string date )
        {
            Size = fileSize;
            Type = type;
            Name = name;
            Date = date;
            Address = adress;
        }

        public string Size { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
    }
}
