using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else { 
                gender = "Female";
            }

            int BdateMonth = 0;
            int BdateDay = 0;
            int BdateYear = 0;

            BdateMonth = dtpBday.Value.Month;
            BdateDay = dtpBday.Value.Day;
            BdateYear= dtpBday.Value.Year;

            int age = 0;

            string hobbies = "";

            if (cbHobby1.Checked) {
                hobbies = hobbies + "\nListening to Music and Podcasts";
            }

            if (cbHobby2.Checked) {
                hobbies = hobbies + "\nWorking Out";
            }

            if (cbHobby3.Checked) {
                hobbies = hobbies + "\nReading";
            }

            if (cbHobby4.Checked) {
                hobbies = hobbies + "\nWatching Anime and/or Movies";
            }

            if (cbHobby5.Checked) {
                hobbies = hobbies + "\nPlaying Sports";
            }

            if (cbHobby6.Checked) {
                hobbies = hobbies + "\nDay Dreaming";
            }

            age = DateTime.Now.Year - dtpBday.Value.Year;
            if (dtpBday.Value.AddYears(age) > DateTime.Now) age--;

            


            string details = "Name: " + txtName.Text + "\nBirthday: " + BdateMonth + "/" + BdateDay + "/" + BdateYear + "\nAge: " + age + "\nGender: " + gender + "\n\nHobbies: " + hobbies + "";

            MessageBox.Show(details, "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                pBox.Image = new Bitmap(open.FileName);
            }
        }
    }
}
