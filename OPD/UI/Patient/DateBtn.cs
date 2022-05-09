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
    public partial class DateBtn : UserControl
    {
        DateTime appdate;
        public EventHandler<int> datebtn_Click;
        int index;
        public DateBtn(DateTime dt,int ind)
        {
            InitializeComponent();
            appdate = dt;
            index = ind;

            instructionIcon.Text = String.Format("{0:yy/MM/dd}",appdate);
        }

        public DateBtn()
        {
            InitializeComponent();
        }

        private void instructionIcon_Click(object sender, EventArgs e)
        {
            datebtn_Click?.Invoke(this,index);
        }
    }
}
