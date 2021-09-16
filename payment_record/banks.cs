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
    public partial class banks : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public banks()
        {
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'E:\Programming\Projects\C# projects\live c# payment_inventory system\payment_record_project CURRENT\payment_record\payment_record\payment_record.accdb'; Persist Security Info = True";


            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\payment_record.accdb;Persist Security Info=False";


            InitializeComponent();
        }

        void Fillgrid() {
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from banks_table", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void banks_Load(object sender, EventArgs e)
        {
            Fillgrid();

        }

        private void txt_addBank_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_updateBank_Click(object sender, EventArgs e)
        { 
           
        }

        private void txt_id_Click(object sender, EventArgs e)
        {

        }
        // SELECT FROM CELLS
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txt_updateDelete.Text = row.Cells[1].Value.ToString();

            }
        }
        // DELETE
        private void btn_deleteBank_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(txt_updateDelete.Text))
                {
                    MessageBox.Show("Select a Row to Delete!");

                }
                else
                {
                    connection.Open();
                    string query = "delete from banks_table where id = " + txt_id.Text + "";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Deleted Successfully");
                    Fillgrid();
                    txt_addBank.Clear();
                    txt_updateDelete.Clear();
                    txt_addBank.Focus();
                }
            }
            catch (Exception xe) 
            {
                MessageBox.Show("Error " + xe);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_updateDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_addBank_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        // UPDATE
        private void btn_updateBank_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_updateDelete.Text)) {
                    MessageBox.Show("Select a Row to Update!");

                }
                else { 

                connection.Open();
                string query = "update banks_table set bank_name = '" + txt_updateDelete.Text + "' where ID = " + txt_id.Text + "";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("BankName Updated Successfully!");
                Fillgrid();
                txt_addBank.Clear();
                txt_updateDelete.Clear();
                txt_addBank.Focus();
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show("Error " + xe);
                connection.Close();
            }
        }
        //ADD / INSERT

        
        private void btn_addBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_addBank.Text)) {
                    MessageBox.Show("Add Bank Field Cannot be left Empty!");
                }
                else
                {

                connection.Open();
                string query = "insert into banks_table (bank_name) Values('" + txt_addBank.Text + "')";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New Bank Added Successfully!");
                Fillgrid();
                txt_addBank.Clear();
                txt_addBank.Focus();
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show("Error " + xe);
            }
                       
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_id_Click_1(object sender, EventArgs e)
        {

        }
    }
}
