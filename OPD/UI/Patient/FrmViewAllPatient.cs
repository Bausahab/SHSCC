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

           
            StyleDataGridView();
            this.dataGridView1.DataSource = OPD.Data.LoadedDataFiles.AllPatients.ToList();

        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
