using HotelManagement.Context2;
using LoginEF;
using EFDay15;
using LoginEF.Context;
//using FrontEF;

namespace HotelManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void LicenseButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }

        Login_ManagementContext Context = new();
        private void signinButton_Click(object sender, EventArgs e)
        {
            var UserNameResultsFrontend = (from l in Context.FrontEnds
                                           select l.UserName).ToList();
            var PassWordResultsFrontend = (from l in Context.FrontEnds
                                           select l.Password).ToList();

            var UserNameResultsKitchen = (from l in Context.Kitchen
                                          select l.UserName).ToList();
            var PassWordResultsKitchen = (from l in Context.Kitchen
                                          select l.Password).ToList();
            for (int i = 0; i < UserNameResultsFrontend.Count; i++)
            {
                try
                {

                    if (UserNameResultsFrontend[i] == usernameTextBox?.Text && PassWordResultsFrontend[i] == passwordTextBox?.Text)
                    {
                        this.Hide();
                        FrontEnd hotel_management = new FrontEnd();
                        hotel_management.Show();
                        break;
                    }

                    else if (UserNameResultsKitchen[i] == usernameTextBox?.Text && PassWordResultsKitchen[i] == passwordTextBox?.Text)
                    {
                        this.Hide();
                        Kitchen kitchen_management = new Kitchen();
                        kitchen_management.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}