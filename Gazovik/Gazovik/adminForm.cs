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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.gazovikDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Производители". При необходимости она может быть перемещена или удалена.
            this.производителиTableAdapter.Fill(this.gazovikDataSet.Производители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.gazovikDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazovikDataSet.Детали". При необходимости она может быть перемещена или удалена.
            this.деталиTableAdapter.Fill(this.gazovikDataSet.Детали);


        }

        private void добавитьСотрудникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addSotrudnik addSotrudnik = new addSotrudnik();
            addSotrudnik.Show();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Детали SET Маркировка = @mark, Наименование = @name, Тип = @type, ID_Производителя = @idPr, ID_Поставщика = @idPo, ID_Оборудования = @idOb WHERE ID = @Id", connection);

                foreach (DataGridViewRow row in dGWdetailsAdm.Rows)
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
                        command.Parameters.AddWithValue("@idOb", row.Cells[6].Value);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Деталь успешно отредактирована");
            }
        }

        private void btnEditOborud_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Оборудование SET Наименование = @name, Описание = @opisanie, Дата_ввода_в_эксплуатацию = @date WHERE ID = @Id", connection);

                foreach (DataGridViewRow row in dGWoborudAdm.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", row.Cells[0].Value);
                        command.Parameters.AddWithValue("@name", row.Cells[1].Value);
                        command.Parameters.AddWithValue("@opisanie", row.Cells[2].Value);
                        command.Parameters.AddWithValue("@date", row.Cells[3].Value);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Оборудование успешно отредактировано");
            }
        }

        private void btnEditPostav_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Поставщики SET Наименование = @name, Контактное_лицо = @konFace, Телефон = @telephone, Email = @email WHERE ID = @Id", connection);

                foreach (DataGridViewRow row in dGWpostavAdm.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", row.Cells[0].Value);
                        command.Parameters.AddWithValue("@name", row.Cells[1].Value);
                        command.Parameters.AddWithValue("@konFace", row.Cells[2].Value);
                        command.Parameters.AddWithValue("@telephone", row.Cells[3].Value);
                        command.Parameters.AddWithValue("@email", row.Cells[4].Value);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Поставщик успешно отредактирован");
            }
        }

        private void btnEditProizvod_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Производители SET Наименование = @name WHERE ID = @Id", connection);

                foreach (DataGridViewRow row in dGWproizvodAdm.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", row.Cells[0].Value);
                        command.Parameters.AddWithValue("@name", row.Cells[1].Value);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("производитель успешно отредактирован");
            }
        }

        private void btnDelDetails_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int index = dGWdetailsAdm.CurrentCell.RowIndex;
                string Message = "tochno?";

                if (MessageBox.Show(Message, "vnimanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dGWdetailsAdm.Rows[index].Cells[0].Value);
                string query = "delete from Детали WHERE id =" + id;
                ExecSQL(query);

                if (dGWdetailsAdm.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dGWdetailsAdm.Rows[index].Cells[8].Value = DataRowState.Deleted;
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

        private void btnDelOborud_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int index = dGWoborudAdm.CurrentCell.RowIndex;
                string Message = "tochno?";

                if (MessageBox.Show(Message, "vnimanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dGWoborudAdm.Rows[index].Cells[0].Value);
                string query = "delete from Оборудование WHERE id =" + id;
                ExecSQL(query);

                if (dGWoborudAdm.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dGWoborudAdm.Rows[index].Cells[4].Value = DataRowState.Deleted;
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

        private void btnDelPostav_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int index = dGWpostavAdm.CurrentCell.RowIndex;
                string Message = "tochno?";

                if (MessageBox.Show(Message, "vnimanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dGWpostavAdm.Rows[index].Cells[0].Value);
                string query = "delete from Поставщики WHERE id =" + id;
                ExecSQL(query);

                if (dGWpostavAdm.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dGWpostavAdm.Rows[index].Cells[5].Value = DataRowState.Deleted;
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

        private void btnDelProizvod_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int index = dGWproizvodAdm.CurrentCell.RowIndex;
                string Message = "tochno?";

                if (MessageBox.Show(Message, "vnimanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dGWproizvodAdm.Rows[index].Cells[0].Value);
                string query = "delete from Производители WHERE id =" + id;
                ExecSQL(query);

                if (dGWproizvodAdm.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dGWproizvodAdm.Rows[index].Cells[2].Value = DataRowState.Deleted;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Lyudmila;Initial Catalog=gazovik;Integrated Security=True";

            string queryDetails = "select * from Детали";
            string queryOborud = "select * from Оборудование";
            string queryPostav = "select * from Поставщики";
            string queryProizvod = "select * from Производители";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapterDetails = new SqlDataAdapter(queryDetails, connection);
                DataTable dtDetails = new DataTable();
                SqlDataAdapter adapterOborud = new SqlDataAdapter(queryOborud, connection);
                DataTable dtOborud = new DataTable();
                SqlDataAdapter adapterPostav = new SqlDataAdapter(queryPostav, connection);
                DataTable dtPostav = new DataTable();
                SqlDataAdapter adapterProizvod = new SqlDataAdapter(queryProizvod, connection);
                DataTable dtProizvod = new DataTable();
                try
                {
                    connection.Open();
                    dtDetails.Clear();
                    adapterDetails.Fill(dtDetails);
                    dGWdetailsAdm.DataSource = dtDetails;

                    dtOborud.Clear();
                    adapterOborud.Fill(dtOborud);
                    dGWoborudAdm.DataSource = dtOborud;

                    dtPostav.Clear();
                    adapterPostav.Fill(dtPostav);
                    dGWpostavAdm.DataSource = dtPostav;

                    dtProizvod.Clear();
                    adapterProizvod.Fill(dtProizvod);
                    dGWproizvodAdm.DataSource = dtProizvod;
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
    }
}
