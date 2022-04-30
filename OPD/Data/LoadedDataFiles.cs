using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSCC.OPD.Data
{
   public static class LoadedDataFiles
    {
        public static List<DataModels.PatientModel> AllPatients = new List<DataModels.PatientModel>();
        public static List<DataModels.Appointments> AllAppointments = new List<DataModels.Appointments>();
    }
}
