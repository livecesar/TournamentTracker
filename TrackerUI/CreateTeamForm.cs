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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            //CreateSampleData();

            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Pepe", LastName = "Rola" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Lola", LastName = "Pareto" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Pito", LastName = "Pelukas"});
            selectedTeamMembers.Add(new PersonModel { FirstName = "Rama", LastName = "Ñañez" });
        }
        private void WireUpList()
        {
            teamMemberDropDown.DataSource = null;

            teamMemberDropDown.DataSource = availableTeamMembers;
            teamMemberDropDown.DisplayMember = "FullName";

            memberListbox.DataSource = null;

            memberListbox.DataSource = selectedTeamMembers;
            memberListbox.DisplayMember = "FullName";
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

                p = GlobalConfig.Connections.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpList();

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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList(); 
            }
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)memberListbox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpList(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamtNameTextbox.Text;
            t.TeamMenbers = selectedTeamMembers;

            GlobalConfig.Connections.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
