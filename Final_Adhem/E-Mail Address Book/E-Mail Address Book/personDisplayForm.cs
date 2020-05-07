using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Mail_Address_Book
{
    public partial class PersonDisplayForm : Form
    {
        public PersonDisplayForm()
        {
            InitializeComponent();
        }

        private void personDisplayForm_Load(object sender, EventArgs e)
        {
        }

        public void SetPersonInfo(PersonEntry person)
        {
            personDisplayBox.Text = person.fullName;
            emailDisplay.Text = person.emailAddress;
            phoneDisplay.Text = person.phoneNumber;

        }
    }
}
