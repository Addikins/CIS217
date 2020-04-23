using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Information
{
    public partial class courseInfoForm : Form
    {
        string courseNumber;

        class CourseNumber
        {
            public string instructor { get; set; }
            public int roomNumber { get; set; }
            public string meetingTime { get; set; }
        }

        Dictionary<string, CourseNumber> courses;

        public courseInfoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hitting enter is the same as clicking the lookup button
            AcceptButton = courseLookupButton;

            // Merged course dictionaries into one, using a class to manage the various variables
            courses = new Dictionary<string, CourseNumber>()
            {
                { "CS101", new CourseNumber { instructor = "Haynes", roomNumber = 3004, meetingTime = "8:00 AM" } },
                { "CS102", new CourseNumber { instructor = "Alvarado", roomNumber = 4501, meetingTime = "9:00 AM" } },
                { "CS103", new CourseNumber { instructor = "Rich", roomNumber = 6755, meetingTime = "10:00 AM" } },
                { "NT110", new CourseNumber { instructor = "Burke", roomNumber = 1244, meetingTime = "11:00 AM" } },
                { "CM241", new CourseNumber { instructor = "Lee", roomNumber = 1411, meetingTime = "1:00 PM" } }

            };

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void courseLookupButton_Click(object sender, EventArgs e)
        {

            courseNumber = courseNumberInput.Text.ToUpper();

            // Checks to see if input is valid, otherwise displays invalid text label
            if (courses.ContainsKey(courseNumber))
            {
                invalidText.Visible = false;
                courseNumberLabel.Text = courseNumber;
                instructorLabel.Text = courses[courseNumber].instructor;
                roomNumberLabel.Text = courses[courseNumber].roomNumber.ToString();
                meetingTimeLabel.Text = courses[courseNumber].meetingTime;

            }
            else
            {
                invalidText.Visible = true;
            }
        }
    }
}
