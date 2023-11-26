using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=bookshopdb;User ID=sa;Password=1234qwer";
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM booktb", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // ADD Button
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO booktb VALUES (@id, @bookname, @author)", connection);
                cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@BookName", textBox3.Text);
                cmd.Parameters.AddWithValue("@Author", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData(); // Refresh the data grid after adding a new entry.
            }
        }

        private void button2_Click(object sender, EventArgs e) // UPDATE Button
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE booktb SET bookname=@bookname, author=@author WHERE id=@id", connection);
                cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@BookName", textBox3.Text);
                cmd.Parameters.AddWithValue("@Author", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData(); // Refresh the data grid after updating an entry.
            }
        }

        private void button3_Click(object sender, EventArgs e) // Delete Button
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM booktb WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData(); // Refresh the data grid after deleting an entry.
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Exit Button
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
