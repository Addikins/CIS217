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
        int members;
        int currentPersonIndex = 0;

        Dictionary<int, Person> people = new Dictionary<int, Person>();

        public personalInfoForm()
        {
            InitializeComponent();
        }

        private void personalInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void lNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (fNameText.Text == "" || lNameText.Text == "" || phoneText.Text == "" || addressInput.Text == "")
            {
                invalidText.Visible = true;
            }
            else
            {
                invalidText.Visible = false;

                people[currentPersonIndex].SetPersonInfo(fNameText.Text, lNameText.Text, decimal.ToInt32(ageInput.Value),
                    phoneText.Text, addressInput.Text);

                AddToResults();

                if (currentPersonIndex < people.Count - 1)
                {
                    ResetForm();
                    currentPersonIndex++;
                    currentPerson.Text = "Household Member " + (currentPersonIndex + 1);
                }
                else
                {
                    currentPerson.Visible = false;
                    results.Visible = true;
                }
            }
        }

        private void AddToResults()
        {

            ListViewGroup householdMember people[currentPersonIndex].

            resultsList.Groups.Add()
                resultsList.Items.Add(people[currentPersonIndex]);
        }

        private void ResetForm()
        {
            fNameText.ResetText();
            lNameText.ResetText();
            ageInput.Value = 1;
            addressInput.ResetText();
            phoneText.ResetText();
        }

        private void membersSubmitButton_Click(object sender, EventArgs e)
        {
            members = decimal.ToInt32(membersInput.Value);

            currentPerson.Visible = true;

            // Dynamically create Person class instances
            for (int i = 0; i < members; i++)
            {
                people.Add(i, new Person());
            }

            membersLabel.Visible = false;
            membersInput.Visible = false;
            membersSubmitButton.Visible = false;
        }

        private void resultsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void results_Enter(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        public string fName;
        public string lName;
        public int age;
        public string phoneNumber;
        public string address;

        public void SetPersonInfo(string first, string last, int fAge, string phone, string fAddress)
        {
            fName = first;
            lName = last;
            age = fAge;
            phoneNumber = phone;
            address = fAddress;
        }
    }
}
