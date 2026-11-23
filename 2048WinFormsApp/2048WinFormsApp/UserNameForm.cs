using _2048GameLibrary;
using System;

namespace _2048WinFormsApp
{
    public partial class UserNameForm : Form
    {
        public UserNameForm()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveUserNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsValidUserName(userNameTextBox.Text))
                    this.Close();
            }
            catch (ArgumentException errorMessage)
            {
                userNameTextBox.Clear();
                MessageBox.Show(errorMessage.Message);
            }
            catch (Exception errorMessage)
            {
                userNameTextBox.Clear();
                MessageBox.Show(errorMessage.Message);
            }
        }
    }
}
