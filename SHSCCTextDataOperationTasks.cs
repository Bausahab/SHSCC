using System.IO;
using System.Threading.Tasks;

namespace SHSCC
{
    public static class SHSCCTextDataOperationTasks
    {
        public static string OperationDate { get; private set; }

      

       public static async Task<bool> DriveExist()
        {
            return await Task.FromResult(Directory.Exists(Properties.Settings.Default.DefaultDir));
        }

        public static Task<bool> ValidatePathStructure()
        {
            bool res = false;
           
                if (Directory.Exists(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase")))
                {
                    res = true;
                    
                }
            else
            {
                res = false;
            }
                //else
                //{
                //   
                //    res = false;
                //    // return Task.FromResult(true);
                //}

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
                return null; //Please null he rahne do mai use kr rha hu ise or in future apko ye line dikha to mujhe btana pta to chale ke aap code kr rhe ho 

        }

 
        public static string[] GetAllFiles(string DirName)
        {
            string[] fileArray = Directory.GetFiles(DirName, "*.json");
            return fileArray;
        }
        

    }
}
