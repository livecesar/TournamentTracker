using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameTextbox.Text;
                p.LastName = lastNameTextBox.Text;
                p.EmailAddress = emailTextBox.Text;
                p.CellphoneNumber = cellphoneTextBox.Text;

                GlobalConfig.Connections.CreatePerson(p);

                firstNameTextbox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellphoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            // TODO: Add actual validation code
            if (firstNameTextbox.Text.Length == 0) 
            {
                return false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
