using SHSCC.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.Patient
{
    public partial class FrmViewAllPatient : Form
    {
        List<PatientModel> patientModels = new List<PatientModel>();
        public FrmViewAllPatient()
        {
            InitializeComponent();
            StyleDataGridView();
        }



        public void StyleDataGridView()
        {
            dataGridView1.Rows.Clear();
            // dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 237, 239);
             dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
          //  dataGridView1.BackgroundColor = Color.FromArgb(174, 182, 191);
           // dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmViewAllPatient_Load(object sender, EventArgs e)
        {
            patientModels = SHSCCTextDataOperationTasks.getPatientList();

            StyleDataGridView();

            foreach (var patient in patientModels.Select((value, i) => new { i, value }))
            {
                var ap = patient.value;
                dataGridView1.Rows.Add(patient.i + 1,
                     ap.RegNo
                    , ap.Name, ap.ContactNo, ap.Adhar,ap.Gender,ap.Age);

            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
               var ok = patientModels[e.RowIndex];
                
                
                FrmAddNew frmAdd = new FrmAddNew(ok);
                frmAdd.Show();
                this.Dispose();
            }
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
