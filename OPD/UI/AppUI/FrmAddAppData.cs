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
    public partial class FrmAddAppData : Form
    {
        DataModels.ModelTypes modelTypes;
        public FrmAddAppData(DataModels.ModelTypes datatype)
        {
            InitializeComponent();
            modelTypes = datatype;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataModels.AppData.SaveData(modelTypes, textBox1.Text);
            this.Dispose();

        }
    }
}
