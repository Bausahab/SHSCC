using System.IO;
using System.Threading.Tasks;

namespace SHSCC
{
    public static class SHSCCTextDataOperationTasks
    {
        public static string OperationDate { get; private set; }

      

       internal static async Task<bool> PathExist()
        {
            return await Task.FromResult(Directory.Exists(Properties.Settings.Default.DefaultDir));
        }

        public static Task<bool> ValidatePathStructure_CreateIfNotExist()
        {
            bool res = false;
            if (SHSCCTextDataOperationTasks.PathExist().GetAwaiter().GetResult())
            {
                if (Directory.Exists(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase")))
                {
                    res = true;
                    
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase"));
                    Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/Patient"));
                    Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/Images"));
                    Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/WereHouse"));
                    res = false;
                    // return Task.FromResult(true);
                }


            }
            else
            {
                res = false;
               
            }

            return Task.FromResult(res);
        }

        public static Task<bool> CreatePatient(string RegNo,string JsonString)
        {
            bool res = false;
            string pth = Path.Combine(Properties.Settings.Default.DefaultDir,"SHSCCDataBase\\Patient");
            if (!File.Exists(pth))
            {
                File.WriteAllText(Path.Combine(pth, RegNo), JsonString);
                res = true;
            }
            else
            {
                res = false;
            }
            return Task.FromResult(res);
        }
        public static  string ReadPatient(string pthh)
        {
           // string pthh = Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\" + RegnoASfilename + ".json");
            bool checkfile = File.Exists(pthh);
            if (checkfile)
                return File.ReadAllText(pthh);
            else
                return "File not found";

        }
        public static string[] GetAllFiles(string DirName)
        {
            string[] fileArray = Directory.GetFiles(DirName, "*.json");
            return fileArray;
        }
        
    }
}
