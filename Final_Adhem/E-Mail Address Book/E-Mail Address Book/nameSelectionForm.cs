using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Mail_Address_Book
{
    public partial class NameSelectionForm : Form
    {
        PersonDisplayForm personDisplayForm = new PersonDisplayForm();
        List<PersonEntry> personList = new List<PersonEntry>();
        string currentDirectory;

        public NameSelectionForm()
        {
            InitializeComponent();

            // Text file is in the same directory as the returned directory, this is to avoid hardcoding a path.
            currentDirectory = Directory.GetCurrentDirectory();
            string[] lines = File.ReadAllLines(currentDirectory + "\\People.txt");

            foreach (string line in lines)
            {
                // Splits each line into a set of words. Not the most reusable code,
                // but it works for this even if we add new entries to the text file.
                string[] words = line.Split(' ');

                // Creates a new instance of PersonEntry for each entry in the text file.
                personList.Add(new PersonEntry
                {
                    firstName = words[0],
                    lastName = words[1],
                    emailAddress = words[2],
                    phoneNumber = words[3]
                });
            }
            // Displays each person entry's first and last name in the listbox.
            // As a side note, I realize a Regex could have helped create a more generic and reusable program.
            foreach (PersonEntry person in personList)
            {
                personListBox.Items.Add(person);
            }

            for (int i = 0; i < personList.Count; i++)
            {
                personList[i].SetFullName();
            }

            personListBox.DisplayMember = "fullName";
        }

        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personDisplayForm.Close();
            personDisplayForm = new PersonDisplayForm();
            personDisplayForm.Show();
            personDisplayForm.SetPersonInfo((PersonEntry)personListBox.SelectedItem);


        }
    }
    public class PersonEntry
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string fullName { get; set; }

        public void SetFullName()
        {
            fullName = firstName + " " + lastName;
        }
    }
}
