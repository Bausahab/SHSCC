using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.AppUI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
           
            fillChart();
        }
        private void fillChart()
        {
            //AddXY value in chart1 in series named as PATIENTS  
            chart1.Series["PATIENTS"].Points.AddXY("Ajay", "10000");
            chart1.Series["PATIENTS"].Points.AddXY("Ramesh", "8000");
            chart1.Series["PATIENTS"].Points.AddXY("Ankit", "7000");
            chart1.Series["PATIENTS"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["PATIENTS"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("PATIENTS Chart");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataModels.PatientModel pt = new DataModels.PatientModel();
            pt.DateReg = dateTimePicker1.Value;
            MessageBox.Show(pt.DateReg.ToShortDateString());
        }
    }
}
