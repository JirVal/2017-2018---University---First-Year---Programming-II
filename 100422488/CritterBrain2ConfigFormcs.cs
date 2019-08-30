using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100422488
{
    public partial class CritterBrain2ConfigForm : Form
    {
        CritterBrain2 brain;

        public CritterBrain2ConfigForm(CritterBrain2 brain)
        {
            this.brain = brain;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CritterBrain2ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}

