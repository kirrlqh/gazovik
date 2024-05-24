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
    public partial class admLogIn : Form
    {
        public admLogIn()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                DataTable table = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                String query = "SELECT * FROM alogin WHERE login=@login AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, connection);
                sqlCmd.Parameters.AddWithValue("@login", txtLogIn.Text);
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                sda.SelectCommand = sqlCmd;
                sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    adminForm form3 = new adminForm();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Логин или пароль неверный.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
