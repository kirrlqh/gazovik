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
using System.Xml.Linq;

namespace Gazovik
{
    public partial class addSotrudnik : Form
    {
        public addSotrudnik()
        {
            InitializeComponent();
        }

        private void btnAddChel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Поставщики (Наименование, Контактное_лицо, Телефон, Email) VALUES (@Name, @chel, @number, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@chel", txtChel.Text);
                command.Parameters.AddWithValue("@number", txtNumber.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                connection.Open();
                command.ExecuteNonQuery();


                string query1 = "INSERT INTO login (login, password) VALUES (@login, @password)";
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@login", txtLogin.Text);
                command1.Parameters.AddWithValue("@password", txtPassword.Text);
                command1.ExecuteNonQuery();
            }
        }
    }
}
