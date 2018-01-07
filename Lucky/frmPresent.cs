using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky
{
    public partial class frmPresent : Form
    {
        public frmPresent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.objfrmPresent = null;
        }
    }
}
