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
    public partial class addDetailsAndMarking : Form
    {
        private int? userId;
        public addDetailsAndMarking(int? userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet1.Детали". При необходимости она может быть перемещена или удалена.
            this.деталиTableAdapter1.Fill(this.gazovikDataSet1.Детали);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.gazovikDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Производители". При необходимости она может быть перемещена или удалена.
            this.производителиTableAdapter.Fill(this.gazovikDataSet.Производители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Детали". При необходимости она может быть перемещена или удалена.
            this.деталиTableAdapter.Fill(this.gazovikDataSet.Детали);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Детали (Маркировка, Наименование, Тип, ID_Производителя, ID_Поставщика, Год_выпуска, ID_Оборудования) VALUES (@Marking, @Name, @type, @ID_Proiz, @ID_Post, @god, @ID_Oborud)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Marking", txtMarking.Text);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@type", cmbType.Text);
                command.Parameters.AddWithValue("@ID_Proiz", cmbManufacturer.Text);
                command.Parameters.AddWithValue("@ID_Post", userId); 
                command.Parameters.AddWithValue("@god", txtYears.Text);
                command.Parameters.AddWithValue("@ID_Oborud", cmbEquipment.Text);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int index = dGWdetails.CurrentCell.RowIndex;
                string Message = "tochno?";

                if (MessageBox.Show(Message, "vnimanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {   
                    return;
                }
                var id = Convert.ToInt32(dGWdetails.Rows[index].Cells[0].Value);
                string query = "delete from Детали WHERE id =" + id;
                ExecSQL(query);

                if (dGWdetails.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dGWdetails.Rows[index].Cells[8].Value = DataRowState.Deleted;
                }

                void ExecSQL(string query1)
                {
                    connection.Open();
                    var command = new SqlCommand(query1, connection);
                    command.CommandText = query1;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";

            string queryDetails = "select * from Детали";
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapterDetails = new SqlDataAdapter(queryDetails, connection);
                DataTable dtDetails = new DataTable();
                try
                {
                    connection.Open();
                    dtDetails.Clear();
                    adapterDetails.Fill(dtDetails);
                    dGWdetails.DataSource = dtDetails;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Детали SET Маркировка = @mark, Наименование = @name, Тип = @type, ID_Производителя = @idPr, ID_Поставщика = @idPo, Год_выпуска = @god, ID_Оборудования = @idOb WHERE ID = @Id", connection);

                foreach (DataGridViewRow row in dGWdetails.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", row.Cells[0].Value);
                        command.Parameters.AddWithValue("@mark", row.Cells[1].Value);
                        command.Parameters.AddWithValue("@name", row.Cells[2].Value);
                        command.Parameters.AddWithValue("@type", row.Cells[3].Value);
                        command.Parameters.AddWithValue("@idPr", row.Cells[4].Value);
                        command.Parameters.AddWithValue("@idPo", row.Cells[5].Value);
                        command.Parameters.AddWithValue("@god", row.Cells[6].Value);
                        command.Parameters.AddWithValue("@idOb", row.Cells[7].Value);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Деталь успешно отредактирована");
            }
        }
    }
    
}
