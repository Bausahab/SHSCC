using System;
using System.IO;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.AppUI
{
    public partial class FrmStartup : Form
    {
        public EventHandler AppStartClicked;
        public FrmStartup()
        {
            InitializeComponent();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {
            lblSeltedDriveinfo.Text = $"{Properties.Settings.Default.DefaultDir} is Selected Data Drive";
            lblDateTime.Text = $"{DateTime.Now.ToShortDateString()}-And Time-{DateTime.Now.ToShortTimeString()}";
            //if (txtDataLocation.Text != "")
            //    btnBrows.Text = "Change Data Path";
            //else
            //    btnStart.Enabled = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.txtDataLocation.Text = folderBrowserDialog1.SelectedPath;
            //    btnStart.Enabled = true;

            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (SHSCCTextDataOperationTasks.DriveExist().GetAwaiter().GetResult())
            {
                if (SHSCCTextDataOperationTasks.ValidatePathStructure().GetAwaiter().GetResult())
                {
                    //load data
                    AppStartClicked?.Invoke(this, null);
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("No Data Directories Found on Selected Drive! Do you want to create new?", "Data Not Found", MessageBoxButtons.YesNo))
                    {
                        Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase"));
                        Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/Patient"));
                        Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/Images"));
                        Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.DefaultDir, "SHSCCDataBase/WereHouse"));
                        MessageBox.Show("New Data Setup Complete");
                        AppStartClicked?.Invoke(this, null);
                    }
                    else
                    {
                        MessageBox.Show("DataBase not availabale,Restart Application");
                        Application.Exit();
                    }
                }

            }
            else
            {

                MessageBox.Show("Drive is not availabale.Either select new or attatch data drive");
            }

        }

        private void txtDataLocation_TextChanged(object sender, EventArgs e)
        {
            //if (txtDataLocation.Text != "")
            //    btnBrows.Text = "Change Data Path";
            //else
            //{
            //    btnStart.Enabled = false;
            //    btnBrows.Text = "Select Data Path";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtDataLocation.Clear();
        }

        private void kryptonComboBox1_DropDown(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            kryptonComboBox1.Items.Clear();
            kryptonComboBox1.Items.AddRange(allDrives);
        }

        private void kryptonComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultDir = kryptonComboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            lblSeltedDriveinfo.Text = $"{Properties.Settings.Default.DefaultDir} is Selected Data Drive";
        }
    }
}
