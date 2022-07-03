using Newtonsoft.Json;
using SHSCC.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SHSCC
{
    public static class SHSCCTextDataOperationTasks
    {
        public static string OperationDate { get; private set; }
        static readonly string WorkingDirectory = (Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\"));


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
            //DirectoryInfo dirInfo = new DirectoryInfo(DirName);
            //FileSystemInfo[] allFiles = dirInfo.GetFileSystemInfos();
            //var orderedFiles = allFiles.OrderBy(f => f.Name);

            //string files = Directory.EnumerateFiles(DirName);//.OrderByDescending(filename => filename).ToList();

            string[] fileArray = Directory.GetFiles(DirName, "*.json");
            Array.Sort(fileArray);
            return fileArray;
            //  return new string[8];

        }

        public static List<PatientModel> getPatientList()
        {

            List<PatientModel> patientList = new List<PatientModel>();
            //DirectoryInfo place = new DirectoryInfo(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\"));
            //FileInfo[] Files = place.GetFiles();
            //foreach (FileInfo i in Files)
            //{
            //    string patientstr = ReadPatient(i.Name);
            //    if (patientstr != null)
            //    {
            //        patientList.Add(JsonConvert.DeserializeObject<PatientModel>(patientstr));
            //    }

            //}
          //  string[] fileArray = GetAllFiles(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\"));
            var fileArray = Directory.GetFiles(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\")).OrderBy(f => int.Parse(Path.GetFileNameWithoutExtension(f)));

            foreach (string filename in fileArray)
            {
                //  string filename1 =  Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\" + filename );
                string patientstr = ReadPatient(filename);
                if (patientstr != null)
                {
                    patientList.Add(JsonConvert.DeserializeObject<PatientModel>(patientstr));
                }

            }
            OPD.Data.LoadedDataFiles.AllPatients.Clear();
            OPD.Data.LoadedDataFiles.AllPatients.AddRange(patientList);
            return OPD.Data.LoadedDataFiles.AllPatients;
        }


    }
}
