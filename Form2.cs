using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            txtMobile.Text = Mobile;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;

            if (Sex == "Male") rdoMale.Checked = true;
            else if (Sex == "Female") rdoFemale.Checked = true;

            cmbStatus.Text = Status;
            dtpBirthday.Text = Birthday;
            txtLocation.Text = Location;

            if (Photo != null)
                picPhoto.Image = Photo;

        }

        public string Mobile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }
        public string Birthday { get; set; }
        public string Location { get; set; }
        public Image Photo { get; set; }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
