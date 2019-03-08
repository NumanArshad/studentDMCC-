using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDMC
{
    public partial class ShowDMC : Form
    {
        public ShowDMC()
        {
            InitializeComponent();
        }

        private void ShowDMC_Load(object sender, EventArgs e)
        {
            richtxtbxDMC.Text = Section.getInstance().ListofStudents().Last().toString();
        }

        private void cmdCloseDMC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
