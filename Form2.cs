using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//каждый метод подключается бд
//Нет try и catch в местах подключения к Бд


namespace DONOR3
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=authorization_registration;User ID=root;Password=fs!if3nj#wkr32jrf/9/329fjwfgsgf3t@r23#8t32trh32ht2!3@ht832532";
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM bloodsamples";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Создаем команду для добавления данных в таблицу
            string query = "INSERT INTO bloodsamples (id, collection_date, donor_id, storage_id, employee_id, quantity, storage_period, hemoglobin, leukocytes, thrombocytes) " +
                           "VALUES (@id, @collection_date, @donor_id, @storage_id, @employee_id, @quantity, @storage_period, @hemoglobin, @leukocytes, @thrombocytes)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Добавляем параметры для команды
            command.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            command.Parameters.AddWithValue("@collection_date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@donor_id", int.Parse(textBox2.Text));
            command.Parameters.AddWithValue("@storage_id", int.Parse(textBox3.Text));
            command.Parameters.AddWithValue("@employee_id", int.Parse(textBox4.Text));
            command.Parameters.AddWithValue("@quantity", int.Parse(textBox5.Text));
            command.Parameters.AddWithValue("@storage_period", int.Parse(textBox6.Text));
            command.Parameters.AddWithValue("@hemoglobin", double.Parse(textBox7.Text));
            command.Parameters.AddWithValue("@leukocytes", double.Parse(textBox8.Text));
            command.Parameters.AddWithValue("@thrombocytes", double.Parse(textBox9.Text));

            // Выполняем команду
            command.ExecuteNonQuery();

            // Закрываем соединение
            connection.Close();

            // Обновляем данные в DataGridView
            string selectQuery = "SELECT * FROM bloodsamples";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO blooddonors (id, full_name, birth_date, passport_number, gender, phone_number, rh_factor_id) " +
                           "VALUES (@id, @full_name, @birth_date, @passport_number, @gender, @phone_number, @rh_factor_id)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox10.Text));
            command.Parameters.AddWithValue("@full_name", textBox11.Text);
            command.Parameters.AddWithValue("@birth_date", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@passport_number", textBox12.Text);
            command.Parameters.AddWithValue("@gender", comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("@phone_number", textBox13.Text);
            command.Parameters.AddWithValue("@rh_factor_id", int.Parse(textBox14.Text));

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM blooddonors";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM blooddonors";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO employees (id, full_name, positions_id, clinics_id) " +
                           "VALUES (@id, @full_name, @positions_id, @clinics_id)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox15.Text));
            command.Parameters.AddWithValue("@full_name", textBox16.Text);
            command.Parameters.AddWithValue("@positions_id", int.Parse(textBox17.Text));
            command.Parameters.AddWithValue("@clinics_id", int.Parse(textBox18.Text));

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM employees";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM employees";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO clinics (id, name, location, phone_number) " +
                           "VALUES (@id, @name, @location, @phone_number)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox19.Text));
            command.Parameters.AddWithValue("@name", textBox20.Text);
            command.Parameters.AddWithValue("@location", textBox21.Text);
            command.Parameters.AddWithValue("@phone_number", textBox22.Text);

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM clinics";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView4.DataSource = dataTable;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM clinics";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO rhfactors (id, blood_group) " +
                           "VALUES (@id, @blood_group)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox23.Text));
            command.Parameters.AddWithValue("@blood_group", textBox24.Text);

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM rhfactors";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView5.DataSource = dataTable;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM rhfactors";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO positions (id, title) " +
                           "VALUES (@id, @title)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox25.Text));
            command.Parameters.AddWithValue("@title", textBox26.Text);

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM positions";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView6.DataSource = dataTable;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM positions";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a command to add data to the table
            string query = "INSERT INTO storage (id, storage_location, clinics_id) " +
                           "VALUES (@id, @storage_location, @clinics_id)";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Add parameters for the command
            command.Parameters.AddWithValue("@id", int.Parse(textBox27.Text));
            command.Parameters.AddWithValue("@storage_location", textBox28.Text);
            command.Parameters.AddWithValue("@clinics_id", int.Parse(textBox29.Text));

            // Execute the command
            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Update the data in DataGridView
            string selectQuery = "SELECT * FROM storage";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView7.DataSource = dataTable;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM storage";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }

    }
}
