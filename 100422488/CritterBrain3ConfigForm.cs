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
    public partial class CritterBrain3ConfigForm : Form
    {
        CritterBrain3 brain;

        public CritterBrain3ConfigForm(CritterBrain3 brain)
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

        private void CritterBrain3ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}