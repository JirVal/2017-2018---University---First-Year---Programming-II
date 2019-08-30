using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CritterBrains;

namespace _100422488
{
    public partial class CritterBrain1ConfigForm : Form
    {
        private TextBox textBoxSpeed;
        private Label label1;
        private Button button1;
        private Button button2;
        CritterBrain1 brain;

        public CritterBrain1ConfigForm(CritterBrain1 brain)
        {
            this.brain = brain;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSpeed.Text, out int speed))
            {
                MessageBox.Show("Speed must be a whole number.", "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to set speed: " + ex.Message, "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CritterBrain1ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void InitializeComponent()
        {
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(135, 44);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SetSpeed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ButtonCancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ButtonOk";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CritterBrain1ConfigForm
            // 
            this.AccessibleName = "Set Speed Aramis";
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpeed);
            this.Name = "CritterBrain1ConfigForm";
            this.Load += new System.EventHandler(this.CritterBrain1ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CritterBrain1ConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
