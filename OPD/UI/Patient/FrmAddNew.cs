using Newtonsoft.Json;
using SHSCC.DataModels;
using SHSCC.OPD.UI.AppUI;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.Patient
{
    public partial class FrmAddNew : Form
    {

        //public EventHandler<DataModels.PatientModel> PatientData;
        static DataModels.PatientModel patentoadd = null;
        DataModels.Appointments appont;
        //  DataModels.PatientImages ok;
        // ShsccDbContext dbcontext;
        OPD.UI.AppUI.FrmAddAppData ShowAddAppData;
       string CurrentPatientRegno { get; set; }
        public FrmAddNew()
        {
            InitializeComponent();
        }
        public FrmAddNew(string regNo) : this()
        {
            if (regNo != null)
            {
                patentoadd = new DataModels.PatientModel();
                patentoadd = Data.LoadedDataFiles.AllPatients.Find(u => u.RegNo == regNo);

            }
            else
            {
                //fill all data 
            }

        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
          //  errorProvider1.Clear();

            tabControl1.Enabled = false;
           // dataGridView1.DataSource = Data.LoadedDataFiles.AllAppointments.ToList();
            
        }



        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Cbpain_DropDown(object sender, EventArgs e)
        {

        }

        private void CbComp_DropDown(object sender, EventArgs e)
        {
            CbComp.DataSource = DataModels.AppData.LoadData(DataModels.ModelTypes.Complaint);
        }
        private void CbDis_DropDown(object sender, EventArgs e)
        {
            CbDis.DataSource = DataModels.AppData.LoadData(DataModels.ModelTypes.Discharge);
        }
        private void CbBody_DropDown(object sender, EventArgs e)
        {
            CbBody.DataSource = DataModels.AppData.LoadData(DataModels.ModelTypes.BodyPart);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private async void btnAddPatDtl_Click(object sender, EventArgs e)
        {
            //appont = new DataModels.Appointments();
            //appont.AppointmentDate = dateTimePicker1.Value;
            //appont.AppointmentNext = dateTimePicker1.Value.AddDays(10);

            if ((string.IsNullOrEmpty(tbregno.Text)) || (string.IsNullOrEmpty(tbname.Text)))
            {

                errorProvider1.SetError(tbregno, "Registration number is required");
                errorProvider1.SetError(tbname, "Full name is required");
                return;
            }
            else
            {
                errorProvider1.Clear();
                await Task.Run(() =>
                {
                    patentoadd = new DataModels.PatientModel();
                    patentoadd.RegNo = tbregno.Text;
                    patentoadd.Name = tbname.Text;
                    patentoadd.DateReg = dateTimePicker1.Value.Date;

                    appont = new DataModels.Appointments();
                    appont.AppointmentDate = dateTimePicker1.Value;
                    appont.AppointmentNext = dateTimePicker1.Value.AddDays(10);

                    patentoadd.AppointmentsForPatient.Add(appont);

                    SHSCCTextDataOperationTasks.CreatePatient(tbregno.Text + ".json", JsonConvert.SerializeObject(patentoadd));
                }).ContinueWith((Task) =>
                {
                    Invoke(new Action(() =>
                    {
                        enableTabs();
                    }));
                });
            }
           
        }

        private void tbregno_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            using (ShowAddAppData = new AppUI.FrmAddAppData(DataModels.ModelTypes.Complaint))
            {
                ShowAddAppData.ShowDialog();
            }
        }

        private void btnAddDis_Click(object sender, EventArgs e)
        {
            using (ShowAddAppData = new AppUI.FrmAddAppData(DataModels.ModelTypes.Discharge))
            {
                ShowAddAppData.ShowDialog();
            }
        }

        private void btnAdBody_Click(object sender, EventArgs e)
        {
            using (ShowAddAppData = new AppUI.FrmAddAppData(DataModels.ModelTypes.BodyPart))
            {
                ShowAddAppData.ShowDialog();
            }
        }

        private void btnAddscab_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Scab already defined!");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripTextBox1.Text))
            {

                Properties.Settings.Default.Modalities.Add(toolStripTextBox1.Text.Trim());
                Properties.Settings.Default.Save();
                Invoke(new Action(() =>
                {
                    checkedListBox1.Items.Clear();
                    int uu = Properties.Settings.Default.Modalities.Count;
                    string[] data = new string[uu];
                    Properties.Settings.Default.Modalities.CopyTo(data, 0);
                    checkedListBox1.Items.AddRange(data);
                }));

            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(DataModels.AppData.LoadData(DataModels.ModelTypes.Modality));
            //button3.Text = "Save Modalities for:-" + PatientName;
            //Text = "ADDING MODALITIES FOR:" + PatientName;
        }

        private void ammulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int uu = checkedListBox1.CheckedItems.Count;
            string[] ValueArray = new string[uu];
            for (int i = 0; i < uu; i++)
            {
                ValueArray[i] = checkedListBox1.CheckedItems[i].ToString();
            }
            listBoxAmmu.Items.AddRange(ValueArray);
        }

        private void aggravationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int uu = checkedListBox1.CheckedItems.Count;
            string[] ValueArray = new string[uu];
            for (int i = 0; i < uu; i++)
            {
                ValueArray[i] = checkedListBox1.CheckedItems[i].ToString();
            }
            listBoxAggra.Items.AddRange(ValueArray);
        }

        private void bothToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int uu = checkedListBox1.CheckedItems.Count;
            string[] ValueArray = new string[uu];
            for (int i = 0; i < uu; i++)
            {
                ValueArray[i] = checkedListBox1.CheckedItems[i].ToString();
            }
            listBoxAmmu.Items.AddRange(ValueArray);
            listBoxAggra.Items.AddRange(ValueArray);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(string ok in listBoxAmmu.Items)
            {
                patentoadd.ModEmmu.Add(ok);
            }

            foreach (string ok in listBoxAggra.Items)
            {
                patentoadd.ModAggra.Add(ok);
            }

        }

        private  void btnSaveRegDtl_Click(object sender, EventArgs e)
        {
            try
            {
                if ((pictureBox1.Image != null))
                {
                    patentoadd.Image = pictureBox1.ImageLocation;

                }
                if (tbCo.Text != null)
                {
                    patentoadd.CareOf = tbCo.Text;
                }
                if (tbAdahr.Text != null)
                {
                    patentoadd.Adhar = tbAdahr.Text;
                }
                if (cbgen.SelectedItem != null)
                {
                    patentoadd.Gender = cbgen.Text;
                    patentoadd.Age = (int)numericUpDownAge.Value;
                }
                if (tbcont.Text != null)
                {
                    patentoadd.ContactNo = tbcont.Text;
                }
                if (tbaddress.Text != null)
                {
                    patentoadd.Address = tbaddress.Text;
                }
                
              // await SHSCCTextDataOperationTasks.CreatePatient(tbregno.Text + ".json", JsonConvert.SerializeObject(patentoadd));
            }
            catch (Exception uu)
            {
                MessageBox.Show(this, $"An Error Appeared {uu.Message},This window will be close.Try Reopen and save data again");
            }

        }

        private  void btnSaveDiaDtl_Click(object sender, EventArgs e)
        {
            DataModels.Diagnostics di = new DataModels.Diagnostics();
            if (!String.IsNullOrEmpty(tbRptSumery.Text))
                di.ReportSummery = tbRptSumery.Text;
            if (!string.IsNullOrEmpty(tbComplaintSince.Text))
                di.ComplaintSince = tbComplaintSince.Text;
            if (!string.IsNullOrEmpty(tbFamHis.Text))
                di.Family = tbFamHis.Text;
            if (!string.IsNullOrEmpty(Cbscab.Text))
                di.Scab = Cbscab.Text;
            if (!string.IsNullOrEmpty(tbpulse.Text))
                di.Pulse = tbpulse.Text;
            if (!string.IsNullOrEmpty(tbbp.Text))
                di.BP = tbbp.Text;
            if (!string.IsNullOrEmpty(tbwate.Text))
                di.Weight = Convert.ToInt32(tbwate.Text);
            if (!string.IsNullOrEmpty(Cbpain.Text))
                di.Pain = Cbpain.Text;
            if (!string.IsNullOrEmpty(Cbburn.Text))
                di.Burning = Cbburn.Text;
            if (!string.IsNullOrEmpty(Cbredness.Text))
                di.Redness = Cbredness.Text;
            if (!string.IsNullOrEmpty(CbComp.Text))
                di.ComplaintType = CbComp.Text;
            if (!string.IsNullOrEmpty(CbDis.Text))
                di.Discharge = CbDis.Text;
            if (!string.IsNullOrEmpty(CbBody.Text))
                di.BodyPart = CbBody.Text;
            appont.DiagnosedOnAppointment = di;
            patentoadd.AppointmentsForPatient.Add(appont);
            //await SHSCCTextDataOperationTasks.CreatePatient(tbregno.Text + ".json", JsonConvert.SerializeObject(patentoadd));

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            SHSCCTextDataOperationTasks.CreatePatient(tbregno.Text + ".json", JsonConvert.SerializeObject(patentoadd));

            Form_Alert form_Alert2 = new Form_Alert();
            form_Alert2.showAlert("Data Saved", Form_Alert.enmType.Success);
            //using (dbcontext = new ShsccDbContext())
            //{

            //    dbcontext.PAITENTS.Add(patentoadd);
            //    dbcontext.SaveChanges();
            //    dbcontext.PATIENTIMAGES.Add(ok);
            //    dbcontext.SaveChanges();
            //    MessageBox.Show(patentoadd.Name + "Saved");
            //}
        }

        private void tbpulse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


       

        private void Lbldate_Click(object sender, EventArgs e)
        {
          
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            kryptonListBox1.Items.AddRange(SHSCCTextDataOperationTasks.GetAllFiles(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient")));

        }

        private void kryptonListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string kk = kryptonListBox1.SelectedItem.ToString();
            kryptonRichTextBox1.Text = SHSCCTextDataOperationTasks.ReadPatient(kk);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(10);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            appont.MedicineName = textBox1.Text;
            appont.MedicinePotential = textBox2.Text;

            ////var jook = ProdList.Select(b => new { b.ID, b.ProductName, b.ProductSize, b.UnitsCount }).SingleOrDefault(u=>u.ID == 1);
            //patentoadd.AppointmentsForPatient.Select(a=> a.AppointmentDate
            //{
                
            //}).ToList();
         //   dataGridView1.DataSource = patentoadd.AppointmentsForPatient.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
               // pictureBox2.ImageLocation = openFileDialog1.FileName;
                appont.DeaseaseImagesForPatient.Add(openFileDialog1.FileName);
                updateDiagnosUI();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
               // pictureBox3.ImageLocation = openFileDialog1.FileName;
                appont.ReportImagesForPatient.Add(openFileDialog1.FileName);
                updateDiagnosUI();
            }
        }

        int currentDeasindex = 0;
        int currentReportindex = 0;

        public void changeDeasImg()
        {

            if (currentDeasindex >= 0 && currentDeasindex < appont.DeaseaseImagesForPatient.Count)
            {
                pictureBox2.ImageLocation = appont.DeaseaseImagesForPatient[currentDeasindex];
            }
          
            kryptonButton6.Text = "" + (currentDeasindex + 1);
        }
     
        public void changeReportImg()
        {

            if (currentReportindex >= 0 && currentReportindex < appont.ReportImagesForPatient.Count)
            {
                pictureBox3.ImageLocation = appont.ReportImagesForPatient[currentReportindex];
            }   
            kryptonButton7.Text = "" + (currentReportindex + 1);
        }


        public void updateDiagnosUI()
        {

            int deasimg = appont.DeaseaseImagesForPatient.Count();
            int reportimg = appont.ReportImagesForPatient.Count();

            label26.Text = "Desease image {"+ deasimg +"}";
            label27.Text = "Report image {" + reportimg + "}";


            currentDeasindex = deasimg - 1;
            currentReportindex = reportimg - 1;
            changeDeasImg();
            changeReportImg();


            
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if(currentDeasindex > 0 )
            {
                --currentDeasindex;
                changeDeasImg();
            }

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            if (currentDeasindex < appont.DeaseaseImagesForPatient.Count-1)
            {
                ++currentDeasindex;
                changeDeasImg();
            }
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            if (currentReportindex > 0)
            {
                --currentReportindex;
                changeReportImg();
            }
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            if (currentReportindex < appont.ReportImagesForPatient.Count -1)
            {
                ++currentReportindex;
                changeReportImg();
            }

        }

        private void tbregno_Leave(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(tbregno.Text)))
            {
              string paitientfilepth =  Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase\\Patient\\" + tbregno.Text + ".json");
                string patientdata = SHSCCTextDataOperationTasks.ReadPatient(paitientfilepth);


                if (patientdata != null)
                {
                    Form_Alert form_Alert1 = new Form_Alert();
                    form_Alert1.showAlert($"Reg No.{tbregno.Text} Already Exist",Form_Alert.enmType.Info);
                  
                    displayPatient(JsonConvert.DeserializeObject<PatientModel>(patientdata));
                }
            }
          
        }


        public void displayPatient(PatientModel patientModel)
        {
            //patentoadd
            patentoadd = patientModel;
            tbname.Text = patientModel.Name;
            enableTabs();
            tbCo.Text = patientModel.CareOf;
            tbAdahr.Text = patientModel.Adhar;
            cbgen.Text = patientModel.Gender;
            numericUpDownAge.Value = patientModel.Age;
            tbcont.Text = patientModel.ContactNo;
            tbaddress.Text = patientModel.Address;
            try
            {
                pictureBox1.ImageLocation = patientModel.Image;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Image Not Found Exception " + e);
            }
            addDiagnosDate();


        }

        public void addDiagnosDate()
        {
            this.flowLayoutPanel1.Controls.Clear();
            
            foreach(var appointments in patentoadd.AppointmentsForPatient.Select((value,i)=> new {i,value }))
            {
                DateBtn dateBtn = new DateBtn(appointments.value.AppointmentDate,appointments.i);
                this.flowLayoutPanel1.Controls.Add(dateBtn);

                appont = appointments.value;
            }
            // 
           
        }


        public void displayDiagnoseData()
        {

        }


        public void enableTabs()
        {
            tabControl1.Enabled = true;
            btnSave.Enabled = false;
             CurrentPatientRegno = patentoadd.RegNo;
        }

      
    }


}
