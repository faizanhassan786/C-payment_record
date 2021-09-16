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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            


           
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'E:\Programming\Projects\C# projects\live c# payment_inventory system\payment_record_project CURRENT\payment_record\payment_record\payment_record.accdb'; Persist Security Info = True";
            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\payment_record.accdb;Persist Security Info=False";


            InitializeComponent();
        }



        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Users_table where user_name = '" + txt_username.Text + "' and user_password = '" + txt_password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                //MessageBox.Show("Username and Password is Correct");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate users found!");
            }
            else
            {
                MessageBox.Show("Credidentials incorrect");
            }

            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
