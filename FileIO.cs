using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSCC
{
  public static  class FileIO
    {
        public static readonly string DIR_PATH = Environment.CurrentDirectory+"/DataFiles/";
        public static void createFile(String filename){
            FileStream fs = File.Create(DIR_PATH+filename);
            
        
        }

        public static void writeFile() { }

        public static void readFile() { }

        public static void deleteFile() { }
    }
}
