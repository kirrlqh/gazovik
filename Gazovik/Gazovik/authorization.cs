using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazovik
{
    public partial class authorization : Form
    {
        public static int? currentUserId;   
        private User userR = new User();
        public authorization()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '•';
            txtLogIn.Text = "Введите логин";
            txtLogIn.ForeColor = Color.Gray;
            txtPassword.Text = "Введите пароль";
            txtPassword.ForeColor = Color.Gray;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtLogIn.Text;
            string password = txtPassword.Text;

            currentUserId = userR.GetUserId(username, password);

            if (currentUserId != null)
            {
                MessageBox.Show($"Welcome, User ID: {currentUserId}");
                addDetailsAndMarking form2 = new addDetailsAndMarking(currentUserId);
                form2.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный.");
            }
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            admLogIn admLogIn = new admLogIn();
            admLogIn.Show();
        }

        private void txtLogIn_Enter(object sender, EventArgs e)
        {
            if (txtLogIn.Text == "Введите логин")
            {
                txtLogIn.Text = "";
                txtLogIn.ForeColor = Color.Black;
            }
        }

        private void txtLogIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogIn.Text))
            {
                txtLogIn.Text = "Введите логин";
                txtLogIn.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Введите пароль")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Введите пароль";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }

    public class User
    {
        public int? GetUserId(string username, string password)
        {
            int? userId = null;
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM login WHERE login=@login AND password=@pass";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", username);
                    command.Parameters.AddWithValue("@pass", password);
                    userId = command.ExecuteScalar() as int?;
                }
            }
            return userId;
        }
    }
}