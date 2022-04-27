using System;
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
            txtDataLocation.Text = Properties.Settings.Default.DefaultDir;
            lblDateTime.Text = $"{DateTime.Now.ToShortDateString()}-And Time-{DateTime.Now.ToShortTimeString()}";
            if (txtDataLocation.Text != "")
                btnBrows.Text = "Change Data Path";
            else
                btnStart.Enabled = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtDataLocation.Text = folderBrowserDialog1.SelectedPath;
                btnStart.Enabled = true;

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //saving datapath in settings
            Properties.Settings.Default.DefaultDir = txtDataLocation.Text;
            Properties.Settings.Default.Save();
            //checking if datapath exist
            if (Program.DataExist())
                AppStartClicked?.Invoke(this, null);
            else
                MessageBox.Show("Given DataPath is Unavailable,Please select correct data location");
        }

        private void txtDataLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtDataLocation.Text != "")
                btnBrows.Text = "Change Data Path";
            else
            {
                btnStart.Enabled = false;
                btnBrows.Text = "Select Data Path";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDataLocation.Clear();
        }
    }
}
