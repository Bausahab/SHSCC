using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHSCC
{
    public class ShsccDbContext : DbContext
    {
        public DbSet<DataModels.PatientModel> PAITENTS { get; set; }
        public DbSet<DataModels.Appointments> PAITENTAPPOINTMENTS { get; set; }

        public DbSet<DataModels.PatientImages> PATIENTIMAGES { get; set; }


        public ShsccDbContext() : base("name=Default")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ShsccDbContext>());
        }
    }
}
