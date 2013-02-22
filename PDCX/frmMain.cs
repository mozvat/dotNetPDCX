using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDCX
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            string response2 = DSIPDCXWrapper.Instance.Class.ProcessTransaction(Credit.SwipedSaleXML(txtAmount.Text, "1235", "5555").ToString(), (short)ProcessControl.NoDialogBoxes, string.Empty, string.Empty);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }
    }
}
