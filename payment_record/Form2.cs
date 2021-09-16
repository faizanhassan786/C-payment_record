using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payment_record
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        banks banks;
        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (banks == null)
            {
                banks = new banks();
                banks.MdiParent = this;
                banks.FormClosed += new FormClosedEventHandler(Banks_FormClosed);
                banks.Show();
            }else
            {
                banks.Activate();
            }
            //if (rec != null) {
            //    rec.Close();
            //}
        }

        private void Banks_FormClosed(object sender, FormClosedEventArgs e)
        {
            banks = null;
            //throw new NotImplementedException();
        }

        records rec;
        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rec == null)
            {
                rec = new records();
                rec.MdiParent = this;
                rec.FormClosed += new FormClosedEventHandler(Rec_FormClosed); 
                rec.Show();
            }
            else
            {

                rec.Activate();
                
               
            }
            
        }

        private void Rec_FormClosed(object sender, FormClosedEventArgs e)
        {
            rec = null;
            //throw new NotImplementedException();
        }

        private void txt_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
