using SHSCC.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.Patient
{
    public partial class FrmViewAllPatient : Form
    {
        public EventHandler<int> PatientViewRequested;
      //  public EventHandler<PatientModel> 
        //List<PatientModel> Data.LoadedDataFiles.AllPatients = new List<PatientModel>();
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
            Data.LoadedDataFiles.AllPatients = SHSCCTextDataOperationTasks.getPatientList();

            StyleDataGridView();
            setdatatoTable(Data.LoadedDataFiles.AllPatients);
          //  this.dataGridView1.Sort(this.dataGridView1.Columns["reg_no"], ListSortDirection.Descending);
           



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                try
                {
                   
                    PatientViewRequested?.Invoke(this,e.RowIndex+1);
                    //FrmAddNew frmAdd = new FrmAddNew(ok);
                    ////frmAdd.MdiParent = this;
                    ////frmAdd.WindowState = FormWindowState.Maximized;
                    //frmAdd.Show();
                    this.Dispose();
                }
                catch (Exception)
                {

                }

            }
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmViewAllPatient_Activated(object sender, EventArgs e)
        {
            Data.LoadedDataFiles.AllPatients = SHSCCTextDataOperationTasks.getPatientList();

            StyleDataGridView();
            setdatatoTable(Data.LoadedDataFiles.AllPatients);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tosearch = tbname.Text.ToLower();

            try
            {
             
                

                    //todo check which tab is selected
                    List<PatientModel> fillterdCandi = new List<PatientModel>();

                    foreach (PatientModel searchCandi in Data.LoadedDataFiles.AllPatients)
                    {
                        //Candidate Name , Enrollment , Ip address
                        string contactNO = searchCandi.ContactNo;
                        if(contactNO == null)
                        {
                            contactNO = "";
                        }

                        if (searchCandi.RegNo.ToLower().Contains(tosearch) || searchCandi.Name.ToLower().Contains(tosearch) || contactNO.Contains(tosearch))
                        {
                            fillterdCandi.Add(searchCandi);
                        }

                        //search
                    }
                    setdatatoTable(fillterdCandi);

                
            }
            catch (Exception)
            {

            }
          
        }

        public void setdatatoTable(List<PatientModel> fillterdCandi)
        {
            dataGridView1.Rows.Clear();
            foreach (var patient in fillterdCandi.Select((value, i) => new { i, value }))
            {
                var ap = patient.value;
                try
                {

                    int regno = Convert.ToInt32(ap.RegNo.Trim());

                    dataGridView1.Rows.Add(
                      regno
                      , ap.Name, ap.ContactNo, ap.Adhar, ap.Gender, ap.Age);
                }
                catch (Exception)
                {

                    dataGridView1.Rows.Add(
                         ap.RegNo
                        , ap.Name, ap.ContactNo, ap.Adhar, ap.Gender, ap.Age);

                };
            }
        }

      
    }
    }
