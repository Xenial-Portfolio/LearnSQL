using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LearnSQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DB database = new DB();
            SqlCommand command = new SqlCommand("SELECT * FROM Users.dbo.logincredits WHERE [username] = @usn and [password] = @pass and [hwid] = @hwid", database.GetConnection());
            DataTable table = new DataTable();
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string hwid = "";

            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@hwid", SqlDbType.NVarChar).Value = hwid;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim().Equals("Username") || usernameTB.Text.Trim().Equals("User Name"))
            {
                usernameTB.Text = "";
            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim().Equals(""))
            {
                usernameTB.Text = "Username";
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text.Trim().Equals("Password"))
            {
                passwordTB.Text = "";
                passwordTB.UseSystemPasswordChar = true;
            }   
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text.Trim().Equals(""))
            {
                passwordTB.Text = "Password";
                passwordTB.UseSystemPasswordChar = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.SignUpButton;
        }
    }
}
