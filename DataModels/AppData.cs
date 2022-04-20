using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSCC.DataModels
{
    public static class AppData
    {

        public static void SaveData(this ModelTypes _type, string valuestosave)
        {
            switch (_type)
            {
                case ModelTypes.Complaint:
                    {
                        Properties.Settings.Default.Complaints.Add(valuestosave.Trim());
                        Properties.Settings.Default.Save();
                        break;
                    }

                case ModelTypes.Symptoms:

                    {
                        Properties.Settings.Default.Symptoms.Add(valuestosave.Trim());
                        Properties.Settings.Default.Save();
                        break;
                    }
                case ModelTypes.BodyPart:
                    {
                        Properties.Settings.Default.BodyParts.Add(valuestosave.Trim());
                        Properties.Settings.Default.Save();
                        break;
                    }
                case ModelTypes.Discharge:
                    {
                        Properties.Settings.Default.Discharge.Add(valuestosave.Trim());
                        Properties.Settings.Default.Save();
                        break;
                    }
                case ModelTypes.Modality:
                    {
                        Properties.Settings.Default.Modalities.Add(valuestosave.Trim());
                        Properties.Settings.Default.Save();
                        break;
                    }
                default:
                    break;
            }

            //Properties.Settings.Default.Save();
            //Invoke(new Action(() =>
            //{
            //    checkedListBox1.Items.Clear();
            //    int uu = Properties.Settings.Default.Modalities.Count;
            //    string[] data = new string[uu];
            //    Properties.Settings.Default.Modalities.CopyTo(data, 0);
            //    checkedListBox1.Items.AddRange(data);
            //}));
        }
        public static string[] LoadData(this ModelTypes _type)
        {
            string[] ReturnValues = new string[] { };
            switch (_type)
            {
                case ModelTypes.Complaint:
                    {
                        int i = Properties.Settings.Default.Complaints.Count;
                        ReturnValues = new string[i];
                        Properties.Settings.Default.Complaints.CopyTo(ReturnValues, 0);
                        break;
                    }


                case ModelTypes.Symptoms:

                    {
                        int i = Properties.Settings.Default.Symptoms.Count;
                        ReturnValues = new string[i];
                        Properties.Settings.Default.Symptoms.CopyTo(ReturnValues, 0);
                        break;
                    }
                case ModelTypes.BodyPart:
                    {
                        int i = Properties.Settings.Default.BodyParts.Count;
                        ReturnValues = new string[i];
                        Properties.Settings.Default.BodyParts.CopyTo(ReturnValues, 0);
                        break;
                    }
                case ModelTypes.Discharge:
                    {
                        int i = Properties.Settings.Default.Discharge.Count;
                        ReturnValues = new string[i];
                        Properties.Settings.Default.Discharge.CopyTo(ReturnValues, 0);
                        break;
                    }
                case ModelTypes.Modality:
                    {
                        int i = Properties.Settings.Default.Modalities.Count;
                        ReturnValues = new string[i];
                        Properties.Settings.Default.Modalities.CopyTo(ReturnValues, 0);
                        break;
                    }
                default:
                    break;

            }

            return ReturnValues;
        }
    }
    public enum ModelTypes
    {
        Complaint,
        Symptoms,
        BodyPart,
        Discharge,
        Modality
    }
}
