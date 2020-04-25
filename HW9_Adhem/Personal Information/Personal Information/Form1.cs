using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class personalInfoForm : Form
    {
        PersonalData person1 = new PersonalData();

        int members;
        

        public personalInfoForm()
        {
            InitializeComponent();
        }

        private void personalInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void membersSubmitButton_Click(object sender, EventArgs e)
        {
            members = decimal.ToInt32(membersInput.Value);

            currentPerson.Visible = true;

            membersLabel.Visible = false;
            membersInput.Visible = false;
            membersSubmitButton.Visible = false;
        }
    }

    public class PersonalData
    {
        string fName { get; set; }
        string lName { get; set; }
        int age { get; set; }
        string phoneNumber { get; set; }
        string address { get; set; }
    }
}
