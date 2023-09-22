using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LearnSQL
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DB database = new DB();
            SqlCommand checkCommand = new SqlCommand("SELECT * FROM Users.dbo.logincredits WHERE [username] = @usn or [email] = @em", database.GetConnection());
            SqlCommand command = new SqlCommand("INSERT INTO Users.dbo.logincredits ([id], [username], [password], [email], [rank]) VALUES (@uid, @usn, @pass, @em, @rnk)", database.GetConnection());

            DataTable table = new DataTable();
            Random rand = new Random();
            string username = usernameTB.Text;
            string defaultRank = "user";
            int uid = rand.Next(1, 999999);
            string hwid = "";

            checkCommand.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;
            checkCommand.Parameters.Add("@em", SqlDbType.NVarChar).Value = emailTB.Text;

            adapter.SelectCommand = checkCommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Username or Email Adress is already in use! Please Try Again");
                return;
            }

            if (confirmPassTB.Text != passwordTB.Text)
            {
                MessageBox.Show("Failed To Sign Up Passwords Do Not Match!");
                return;
            }

            command.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = usernameTB.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = passwordTB.Text;
            command.Parameters.Add("@em", SqlDbType.NVarChar).Value = emailTB.Text;
            command.Parameters.Add("@rnk", SqlDbType.NVarChar).Value = defaultRank;

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account Created!");
            }
            else
            {
                MessageBox.Show("Failed To Create Account!");
            }

            database.CloseConnection();
        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            if (emailTB.Text.Trim().Equals("Email Adress"))
            {
                emailTB.Text = "";
            }
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (emailTB.Text.Trim().Equals("") || emailTB.Text.Trim().Equals("Email Adress"))
            {
                emailTB.Text = "Email Adress";
            }
        }

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim().Equals("Username"))
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

            if (passwordTB.Text.Trim().Equals("Password") || passwordTB.Text.Trim().Equals("password"))
            {
                MessageBox.Show("Your Password Can't Be Password and Can't Be Blank! Please Change It and Try Again");
                this.ActiveControl = this.passwordTB;
            }
        }

        private void confirmPassTB_Enter(object sender, EventArgs e)
        {
            if (confirmPassTB.Text.Trim().Equals("Confirm Password"))
            {
                confirmPassTB.Text = "";
                confirmPassTB.UseSystemPasswordChar = true;
            }
        }

        private void confirmPassTB_Leave(object sender, EventArgs e)
        {
            if (confirmPassTB.Text.Trim().Equals(""))
            {
                confirmPassTB.Text = "Confirm Password";
                confirmPassTB.UseSystemPasswordChar = false;
            }
           
            if (confirmPassTB.Text != passwordTB.Text)
            {
                MessageBox.Show("Passwords Do Not Match!");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.SignUpButton;
        }
    }
}
