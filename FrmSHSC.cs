using SHSCC.DataModels;
using SHSCC.OPD.Data;
using SHSCC.OPD.UI.Patient;
using System;
using System.Windows.Forms;

namespace SHSCC
{
    public partial class FrmSHSC : Form
    {

        OPD.UI.AppUI.FrmHome homepage;
        OPD.UI.Patient.FrmAddNew adnew;
        OPD.UI.AppUI.FrmStartup startup;
        public FrmSHSC()
        {
            InitializeComponent();
            startup = new OPD.UI.AppUI.FrmStartup();
            startup.AppStartClicked = AppStartRequested;
        }

        private void AppStartRequested(object sender, EventArgs e)
        {
            startup.Dispose();
            // this.Controls.Remove(startup);
            menuStrip1.Visible = true;
            ShowHomePage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowStartUpPage();
            menuStrip1.Visible = false;
        }
        void ShowStartUpPage()
        {

            startup.MdiParent = this;
            startup.Show();
        }
        void ShowHomePage()
        {
            homepage = new OPD.UI.AppUI.FrmHome();
            homepage.MdiParent = this;
            homepage.Dock = DockStyle.Fill;
            homepage.Show();
        }
      

        private void GeneratePatientView(object sender, int e)
        {
            var ok = LoadedDataFiles.AllPatients.Find(r => r.RegNo == e.ToString());
            FrmAddNew frmAdd = new FrmAddNew(ok);
            frmAdd.MdiParent = this;
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.Show();

        }

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            homepage.Dispose();
            OPD.UI.Patient.FrmAddNew frmAdd = new OPD.UI.Patient.FrmAddNew(null);
            frmAdd.MdiParent = this;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.WindowClosed = closedaddnewwindow;
            frmAdd.Show();
        }

        private void closedaddnewwindow(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void vIEWALLToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            OPD.UI.Patient.FrmViewAllPatient vap = new OPD.UI.Patient.FrmViewAllPatient();
            vap.MdiParent = this;
            vap.WindowState = FormWindowState.Maximized;
            vap.PatientViewRequested = GeneratePatientView;
            vap.Show();
        }
    }
}
