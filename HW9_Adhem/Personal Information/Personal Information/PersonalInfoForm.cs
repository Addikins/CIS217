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
            AcceptButton = submitInfoButton;
            resultsList.View = View.Details;
            resultsList.GridLines = true;
            resultsList.FullRowSelect = true;
        }

        private void submitInfoButton_Click(object sender, EventArgs e)
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

                AddToResults(currentPersonIndex);

                if (currentPersonIndex < people.Count - 1)
                {
                    ResetForm();
                    currentPersonIndex++;
                    currentPerson.Text = "Household Member " + (currentPersonIndex + 1);
                }
                else
                {
                    currentPerson.Visible = false;
                    titleLabel.Visible = false;
                    results.Visible = true;
                }
            }
        }

        private void AddToResults(int index)
        {
            string[] information = new string[4];
            information[0] = people[index].fName + " " + people[index].lName;
            information[1] = people[index].age.ToString();
            information[2] = people[index].phoneNumber;
            information[3] = people[index].address;

            ListViewItem item = new ListViewItem(information);
            resultsList.Items.Add(item);
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
