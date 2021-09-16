using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace payment_record
{
    public partial class records : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public records()
        {


            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'E:\Programming\Projects\C# projects\live c# payment_inventory system\payment_record_project CURRENT\payment_record\payment_record\payment_record.accdb'; Persist Security Info = True";

            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\payment_record.accdb;Persist Security Info=False";


            InitializeComponent();
        }

        void Fillgrid()
        {
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from payment_record", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                MessageBox.Show("Fill the form to Add!");
            }
            else { 
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM payment_record where Deposit_slip_number = '" + txt_Deposit_slip_number.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                
            }

            if (count >= 1)
            {
                //MessageBox.Show("Username and Password is Correct");
                connection.Close();
                MessageBox.Show("Multiple Deposit Slip numbers cannot exist");
                txt_Deposit_slip_number.Clear();
                //connection.Dispose();
                //this.Hide();
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
            }
            else if (count < 1)
            {
                //connection.Open();
                string query = "insert into payment_record (Title,Amount,Deposit_slip_number,Bank) Values('" + txt_Title.Text + "','" + txt_Amount.Text + "','" + txt_Deposit_slip_number.Text + "','" + bank_comboBox.Text + "')";
                OleDbCommand command1 = new OleDbCommand(query, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Added!");
                Fillgrid();
                txt_Title.Clear();
                txt_Amount.Clear();
                txt_Deposit_slip_number.Clear();
                bank_comboBox.Text = " ";
                txt_Title.Focus();
            }
           
            connection.Close();
            }



















        }


        


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Title.Text))
                {
                    MessageBox.Show("Select a row to Delete!");
                }
                else
                {
                    connection.Open();
                    string query = "delete from payment_record where id = " + txt_id.Text + "";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Deleted Successfully");
                    Fillgrid();
                    txt_Title.Clear();
                    txt_Amount.Clear();
                    txt_Deposit_slip_number.Clear();
                    bank_comboBox.Text = " ";
                    txt_Title.Focus();
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show("Error " + xe);
            }
        }

        private void records_Load(object sender, EventArgs e)
        {
            

            try
            {
                connection.Open();
                string query = "select * from banks_table";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bank_comboBox.Items.Add(reader["bank_name"].ToString());

                }


                connection.Close();

               //Fillgrid();


            }
            catch (Exception xe)
            {
                MessageBox.Show("Error " + xe);
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Deposit_slip_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                MessageBox.Show("Select a row to Update!");
            }
            else
            {








                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM payment_record where Deposit_slip_number = '" + txt_Deposit_slip_number.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                    string a = count.ToString();
                    MessageBox.Show(a);

                if (count >= 1)
                {
                    //MessageBox.Show("Username and Password is Correct");
                    connection.Close();
                    MessageBox.Show("Multiple Deposit Slip numbers cannot exist");
                    txt_Deposit_slip_number.Clear();
                    //connection.Dispose();
                    //this.Hide();
                    //Form2 form2 = new Form2();
                    //form2.ShowDialog();
                }
                else if (count == 0)
                {
                    //connection.Open();
                    string query = "update payment_record set Title = '" + txt_Title.Text + "', Amount = '" + txt_Amount.Text + "',Deposit_slip_number = '" + txt_Deposit_slip_number.Text + "', Bank = '" + bank_comboBox.Text + "' where ID = " + txt_id.Text + "";
                    OleDbCommand command1 = new OleDbCommand(query, connection);
                    command1.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Updated!");
                    Fillgrid();
                    txt_Title.Clear();
                    txt_Amount.Clear();
                    txt_Deposit_slip_number.Clear();
                    bank_comboBox.Text = " ";
                    txt_Title.Focus();
                }
                else if (count == 1) {
                    //connection.Open();
                    string query = "update payment_record set Title = '" + txt_Title.Text + "', Amount = '" + txt_Amount.Text + "',Deposit_slip_number = '" + txt_Deposit_slip_number.Text + "', Bank = '" + bank_comboBox.Text + "' where ID = " + txt_id.Text + "";
                    OleDbCommand command1 = new OleDbCommand(query, connection);
                    command1.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Updated!");
                    Fillgrid();
                    txt_Title.Clear();
                    txt_Amount.Clear();
                    txt_Deposit_slip_number.Clear();
                    bank_comboBox.Text = " ";
                    txt_Title.Focus();



                }

                connection.Close();

            }


            

















        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_Title.Text = row.Cells[1].Value.ToString();
                txt_Amount.Text = row.Cells[2].Value.ToString();
                txt_Deposit_slip_number.Text = row.Cells[3].Value.ToString();
                bank_comboBox.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void txt_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_clearFields_Click(object sender, EventArgs e)
        {
            txt_Title.Clear();
            txt_Amount.Clear();
            txt_Deposit_slip_number.Clear();
            bank_comboBox.Text = " ";
            txt_Title.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "select * from banks_table";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                bank_comboBox.Items.Clear();
                while (reader.Read())
                {
                    bank_comboBox.Items.Add(reader["bank_name"].ToString());

                }


                connection.Close();



            }
            catch (Exception xe)
            {
                MessageBox.Show("Error " + xe);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fillgrid();
            txt_Title.Clear();
            txt_Amount.Clear();
            txt_Deposit_slip_number.Clear();
            bank_comboBox.Text = " ";
            txt_Title.Focus();
        }
    }
}
