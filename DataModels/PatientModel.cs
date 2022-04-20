using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHSCC.DataModels
{
    public class PatientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime DateReg { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string CareOf { get; set; }
        public string Adhar { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Scab { get; set; }
        public string Pulse { get; set; }
        public string BP { get; set; }
        public int Weight { get; set; }
        public string Complaint { get; set; }
        public string BodyPart { get; set; }
        public string Discharge { get; set; }
        public string Family { get; set; }
        public string Pain { get; set; }
        public string Redness { get; set; }
        public string Burning { get; set; }
        public string Symptom { get; set; }
        public List<string[]> ModAggra { get; set; }
        public List<string[]> ModEmmu { get; set; }
        public List<PatientImages> ImagesForPatient { get; set; }
        public List<Appointments> AppointmentsForPatient { get; set; }
        public PatientModel()
        {
            ImagesForPatient = new List<PatientImages>();
            AppointmentsForPatient = new List<Appointments>();
        }

    }
    public class Account
    {
        public string AppID { get; set; }
        public string User { get; set; }
        public string Key { get; set; }
        public string Error { get; set; }
        public Account()
        {
            this.AppID = new Guid().ToString();
            this.User = "Rohit";
            this.Key = "sscarehomiopath@manishrajsinghattheratelivedotin";
            this.Error = string.Empty;
        }


    }
    public class Appointments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int PatientID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentNext { get; set; }
        public string MedicineName { get; set; }
        public string MedicinePotential { get; set; }

    }
    public class PatientImages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int PatientID { get; set; }
        public ImageTypes ImageType { get; set; }
        public byte[] ImageRecord { get; set; }
        
    }
    public enum ImageTypes
    {
        PatientImage,
        PatientDeseaseImage,
        PatientReportImage
    }



}