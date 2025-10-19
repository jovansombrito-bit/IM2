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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(ofd.FileName);
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image != null)
            {
                picPhoto.Image = picPhoto.Image;
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Please select a photo first.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Mobile = txtMobile.Text;
            form2.FirstName = txtFirstName.Text;
            form2.LastName = txtLastName.Text;
            form2.Sex = rdoMale.Checked ? "Male" : "Female";
            form2.Status = cmbStatus.Text;
            form2.Birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            form2.Location = txtLocation.Text;
            form2.Photo = picPhoto.Image;

            form2.Show();

        }
    }
}
