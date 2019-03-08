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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void cmdManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudentsScreen manageStudent = new ManageStudentsScreen();
            this.Hide();
            manageStudent.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            DataBaseConnection.getInstance().conStr = "Data Source=UET\\SQLEXPRESS;Initial Catalog=DMC;Integrated Security=True";
            try
            {
                DataBaseConnection.getInstance().getConnection();
                MessageBox.Show("Database is connected");

            }
            catch(Exception exp)
            {
                MessageBox.Show("Error in "+ exp.ToString());
            }
            string total = "select count(RegNo) from StudentData";
            var readAll = DataBaseConnection.getInstance().getRowsCount(total);

        string BStotal = "select count(RegNo) from StudentData where Degree='BS'";
            var readBS = DataBaseConnection.getInstance().getRowsCount(BStotal);

            string BEtotal = "select count(RegNo) from StudentData where Degree='BE'";
            var readBE = DataBaseConnection.getInstance().getRowsCount(BEtotal);
            

            string MStotal = "select count(RegNo) from StudentData where Degree='MS'";
            var readMS = DataBaseConnection.getInstance().getRowsCount(MStotal);

            lblStudentsCount.Text = readAll.ToString();
            lblBSCount.Text = readBS.ToString();
            lblBECount.Text = readBE.ToString();
            lblMSCount.Text = readMS.ToString();
            lblStudentName.Text = "Muhammad Numan Arshad";
            lblRegNo.Text = "2016-CS-311";
            lblDept.Text = "CSE Dept.";
            lblUniversity.Text = "Uet Lahote";

        }
    }
}
