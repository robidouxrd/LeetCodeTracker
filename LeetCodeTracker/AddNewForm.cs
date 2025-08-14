using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCodeTracker
{
    public partial class AddNewForm : Form
    {
        public string ProblemName => problemNameTB.Text;
        public string ProblemDescripion => problemDescriptionTB.Text;
        public int ProblemDifficulty = 1;

        public AddNewForm()
        {
            InitializeComponent();
        }

        private void AddProblemBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (easyRadio.Checked)
            {
                ProblemDifficulty = 1;
            }
            else if (medRadio.Checked)
            {
                ProblemDifficulty = 2;
            }
            else if (hardRadio.Checked)
            {
                ProblemDifficulty = 3;
            }
                this.Close();
        }
    }
}
