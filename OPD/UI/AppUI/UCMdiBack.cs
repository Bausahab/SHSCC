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
    public partial class UCMdiBack : UserControl
    {
        public EventHandler<string> MenuClicked;
        public UCMdiBack()
        {
            InitializeComponent();
        }

        private void UCMdiBack_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "New");
        }
    }
}
