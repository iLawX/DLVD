using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Applications;
using DVLD.Applications.InternationalDrivingLicense;
using DVLD.Applications.LocalDrivingLicense;
using DVLD.Applications.ReleaseDetainedLicense;
using DVLD.Applications.RenewLocalLicense;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Drivers;
using DVLD.General;
using DVLD.Licenses.DetainLicense;
using DVLD.People;
using DVLD.Questions;
using DVLD.Tests;
using DVLD.Tests.WrittenTestTypes;
using DVLD.Users;

namespace DVLD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople form = new ManagePeople();
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers();
            form.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            this.Close();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails form = new UserDetails(Global.CurrentUser.UserID);
            form.ShowDialog();
        }

        private void changePaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword(Global.CurrentUser.UserID);
            form.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes form = new ManageApplicationTypes();
            form.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes form = new ManageTestTypes();
            form.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditLocalDrivingLicenseApplication form = new AddEditLocalDrivingLicenseApplication();
            form.ShowDialog();
        }

        private void localDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplcations form = new ManageLocalDrivingLicenseApplcations();
            form.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication form = new NewInternationalLicenseApplication();
            form.ShowDialog();
        }

        private void internationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalLicesnesApplications form = new ManageInternationalLicesnesApplications();
            form.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers form = new ManageDrivers();
            form.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicenses form = new ManageDetainedLicenses();
            form.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicense form = new DetainLicense();
            form.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense form = new ReleaseDetainedLicense();
            form.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLocalLicense form = new RenewLocalLicense();
            form.ShowDialog();
        }

        private void replaceLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceLostOrDamagedLicense form = new ReplaceLostOrDamagedLicense();
            form.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense form = new ReleaseDetainedLicense();
            form.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplcations form = new ManageLocalDrivingLicenseApplcations();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageQuestions form = new ManageQuestions();
            form.ShowDialog();
        }

        private void manageWrittenTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageWrittenTestTypes form = new ManageWrittenTestTypes();
            form.ShowDialog();
        }
    }
}
