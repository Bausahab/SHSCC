using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.Patient
{
    public partial class FrmAddNew : Form
    {
        public static List<DataModels.Appointments> AllAppointments = new List<DataModels.Appointments>();
        public EventHandler<DataModels.PatientModel> PatientData;
        static DataModels.PatientModel patentoadd = null;
        DataModels.PatientImages ok;
       // ShsccDbContext dbcontext;
        OPD.UI.AppUI.FrmAddAppData ShowAddAppData;
        int CurrentPatientID { get; set; }
        public FrmAddNew()
        {
            InitializeComponent();
        }
        public FrmAddNew(int patID) : this()
        {
            if (patID == 0)
            {
                patentoadd = new DataModels.PatientModel();
                ok = new DataModels.PatientImages();
            }
            else
            {
                //fill all data 
            }

        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
             tabControl1.Enabled = false;
            dataGridView1.DataSource = AllAppointments.ToList();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

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
            await Task.Run(() =>
             {
                 if ((string.IsNullOrEmpty(tbregno.Text)) || (string.IsNullOrEmpty(tbname.Text)))
                 {
                     tbregno.BackColor = Color.Orange;
                     tbname.BackColor = Color.Orange;
                 }
                 else
                 {
                    // using (dbcontext = new ShsccDbContext())
                    // {
                    //     tbregno.BackColor = Color.White;
                    //     tbname.BackColor = Color.White;
                    //    //  patentoadd = new DataModels.PatientModel();
                    //    patentoadd.RegNo = tbregno.Text;
                    //     patentoadd.Name = tbname.Text;
                    //     patentoadd.DateReg = dateTimePicker1.Value.Date;
                    //    //dbcontext.PAITENTS.Add(patentoadd);
                    //    //dbcontext.SaveChanges();
                    //}

                 }
             }).ContinueWith((Task) =>
             {
                 Invoke(new Action(() =>
                 {
                     tabControl1.Enabled = true;
                     btnAddPatDtl.Enabled = false;
                     CurrentPatientID = patentoadd.ID;
                 }));
             });
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

        }

        private void btnSaveRegDtl_Click(object sender, EventArgs e)
        {
            try
            {
                //if ((pictureBox1.Image != null) && (CurrentPatientID != 0))
                //{
                //    using (dbcontext = new ShsccDbContext())
                //    {
                //        ok.ImageRecord = ImageToByte(pictureBox1.Image);
                //        ok.ImageType = DataModels.ImageTypes.PatientImage;
                //        ok.PatientID = CurrentPatientID;
                       
                //    }

                //}
                //if (tbCo.Text != null)
                //    patentoadd.CareOf = tbCo.Text;
                //if (tbAdahr.Text != null)
                //    patentoadd.Adhar = tbAdahr.Text;
                //if (cbgen.SelectedItem != null)
                //    patentoadd.Gender = cbgen.Text;
                //patentoadd.Age = (int)numericUpDownAge.Value;
                //if (tbcont.Text != null)
                //    patentoadd.ContactNo = tbcont.Text;
                //if (tbaddress.Text != null)
                //    patentoadd.Address = tbaddress.Text;
            }
            catch (Exception uu)
            {
                MessageBox.Show(this, $"An Error Appeared {uu.Message},This window will be close.Try Reopen and save data again");
            }
            //finally
            //{
            //    this.Dispose();
            //}
        }

        private void btnSaveDiaDtl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //using (dbcontext = new ShsccDbContext())
            //{
               
            //    dbcontext.PAITENTS.Add(patentoadd);
            //    dbcontext.SaveChanges();
            //    dbcontext.PATIENTIMAGES.Add(ok);
            //    dbcontext.SaveChanges();
            //    MessageBox.Show(patentoadd.Name + "Saved");
            //}
        }
    }


}
