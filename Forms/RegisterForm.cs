using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ResQ.Forms
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
            pnlLeft.BackColor = Theme.Navy;
            lblStep1.BackColor = Theme.Red;
            lblStep2.BackColor = Theme.Amber;
            lblStep3.BackColor = Color.White;
            Theme.StylePrimary(btnRegister);
            Theme.StyleSecondary(btnBack);
            AcceptButton = btnRegister;  //Enter key registers
            CancelButton = btnBack;    //Esc goes back

            rdoResident.CheckedChanged += rdoChoice_CheckedChanged;
            rdoVolunteer.CheckedChanged += rdoChoice_CheckedChanged;
            rdoStandard.CheckedChanged += rdoChoice_CheckedChanged;
            rdoNeedsSupport.CheckedChanged += rdoChoice_CheckedChanged;
            UpdateChoices();
        }

        private void rdoChoice_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateChoices();
        }

        private void UpdateChoices()
        {
            Color pink = Color.FromArgb(0xF8, 0xD7, 0xD3);
            Color cream = Color.FromArgb(0xFB, 0xE9, 0xC8);
            Color lilac = Color.FromArgb(0xDC, 0xDD, 0xF3);

            StyleChoice(rdoResident, Theme.Red, pink);
            StyleChoice(rdoVolunteer, Theme.Amber, cream);
            StyleChoice(rdoStandard, Theme.Navy, lilac);
            StyleChoice(rdoNeedsSupport, Theme.Navy, lilac);

            bool resident = rdoResident.Checked;
            lblStatus.Visible = resident;
            pnlStatus.Visible = resident;
        }

        private static void StyleChoice(RadioButton radio, Color border, Color selected)
        {
            radio.FlatAppearance.BorderSize = 2;

            radio.FlatAppearance.BorderColor =
                radio.Checked ? border : Color.FromArgb(0x8B, 0x93, 0xB5);

            radio.FlatAppearance.CheckedBackColor = selected;
            radio.BackColor = radio.Checked ? selected : Color.White;
            radio.ForeColor = Theme.Ink;
        }

        //shows a message on the form instead of a blocking dialog.
        private void ShowMessage(string message, bool success)
        {
            lblMessage.ForeColor = success ? Theme.Green : Theme.Red;
            lblMessage.Text = message;
        }

        private void RegisterAccount()
        {
            string role = rdoVolunteer.Checked ? "Volunteer" : "Resident";
            string status = role == "Resident" && rdoNeedsSupport.Checked ? "Needs Supprot" : "Standard";

            // 1. Check what the person typed. Every rule lives in Validator.cs.
            string? problem = Validator.ValidateRegistration(
                txtFullName.Text,
                txtUsername.Text,
                txtPhone.Text,
                txtArea.Text,
                txtPassword.Text,
                txtConfirm.Text,
                role,
                status);

            if (problem != null)
            {
                ShowMessage(problem, false);
                return;
            }

            try
            {
                // 2. The username must be new.
                if (Database.UsernameExists(txtUsername.Text))
                {
                    ShowMessage("That username is taken. Try another.", false);
                    return;
                }

                // 3. Save. Volunteers wait for approval; residents can log in now.
                bool approved = role == "Resident";

                Database.AddUser(
                    txtFullName.Text,
                    txtUsername.Text,
                    txtPassword.Text,
                    txtPhone.Text,
                    txtArea.Text,
                    role,
                    status,
                    approved,
                    chkHelper.Checked);

                string message = approved
                    ? "Your account is ready. You can log in now."
                    : "Volunteer account created. An administrator must approve it.";

                MessageBox.Show(
                    this,
                    message,
                    "ResQ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                ShowMessage("That username is taken. Try another.", false);
            }
            catch (Exception)
            {
                ShowMessage("Your account could not be saved. Please try again.", false);
            }
        }

        

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
