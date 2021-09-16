
namespace payment_record
{
    partial class records
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(records));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Deposit_slip_number = new System.Windows.Forms.TextBox();
            this.bank_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_clearFields = new System.Windows.Forms.Label();
            this.txt_updatebank = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 73);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(375, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Payment Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(71, 101);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(175, 20);
            this.txt_Title.TabIndex = 2;
            this.txt_Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(8, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(71, 140);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(175, 20);
            this.txt_Amount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(-2, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DepositSlip";
            // 
            // txt_Deposit_slip_number
            // 
            this.txt_Deposit_slip_number.Location = new System.Drawing.Point(71, 179);
            this.txt_Deposit_slip_number.Name = "txt_Deposit_slip_number";
            this.txt_Deposit_slip_number.Size = new System.Drawing.Size(175, 20);
            this.txt_Deposit_slip_number.TabIndex = 7;
            this.txt_Deposit_slip_number.TextChanged += new System.EventHandler(this.txt_Deposit_slip_number_TextChanged);
            // 
            // bank_comboBox
            // 
            this.bank_comboBox.DropDownHeight = 120;
            this.bank_comboBox.FormattingEnabled = true;
            this.bank_comboBox.IntegralHeight = false;
            this.bank_comboBox.Location = new System.Drawing.Point(71, 218);
            this.bank_comboBox.Name = "bank_comboBox";
            this.bank_comboBox.Size = new System.Drawing.Size(175, 21);
            this.bank_comboBox.TabIndex = 8;
            this.bank_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(1, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BankName";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(152, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "      Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "     Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 457);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_id.Location = new System.Drawing.Point(23, 79);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(21, 15);
            this.txt_id.TabIndex = 14;
            this.txt_id.Text = "ID";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click);
            // 
            // txt_clearFields
            // 
            this.txt_clearFields.AutoSize = true;
            this.txt_clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clearFields.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_clearFields.Location = new System.Drawing.Point(173, 253);
            this.txt_clearFields.Name = "txt_clearFields";
            this.txt_clearFields.Size = new System.Drawing.Size(73, 13);
            this.txt_clearFields.TabIndex = 15;
            this.txt_clearFields.Text = "Clear Fields";
            this.txt_clearFields.Click += new System.EventHandler(this.txt_clearFields_Click);
            // 
            // txt_updatebank
            // 
            this.txt_updatebank.AutoSize = true;
            this.txt_updatebank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_updatebank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_updatebank.Location = new System.Drawing.Point(68, 242);
            this.txt_updatebank.Name = "txt_updatebank";
            this.txt_updatebank.Size = new System.Drawing.Size(44, 13);
            this.txt_updatebank.TabIndex = 16;
            this.txt_updatebank.Text = "Refresh";
            this.txt_updatebank.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(152, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 17;
            this.button4.Text = "Load Table";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 535);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_updatebank);
            this.Controls.Add(this.txt_clearFields);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bank_comboBox);
            this.Controls.Add(this.txt_Deposit_slip_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "records";
            this.Load += new System.EventHandler(this.records_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Deposit_slip_number;
        private System.Windows.Forms.ComboBox bank_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_clearFields;
        private System.Windows.Forms.Label txt_updatebank;
        private System.Windows.Forms.Button button4;
    }
}