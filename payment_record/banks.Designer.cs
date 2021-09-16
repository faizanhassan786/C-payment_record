
namespace payment_record
{
    partial class banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banks));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_updateDelete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addBank = new System.Windows.Forms.TextBox();
            this.btn_deleteBank = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updateBank = new System.Windows.Forms.Button();
            this.btn_addBank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(73, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 362);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_id.Location = new System.Drawing.Point(12, 262);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(35, 13);
            this.txt_id.TabIndex = 11;
            this.txt_id.Text = "label4";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(635, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 1);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(108, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 1);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_updateDelete
            // 
            this.txt_updateDelete.BackColor = System.Drawing.SystemColors.Control;
            this.txt_updateDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_updateDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_updateDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_updateDelete.Location = new System.Drawing.Point(635, 98);
            this.txt_updateDelete.Name = "txt_updateDelete";
            this.txt_updateDelete.Size = new System.Drawing.Size(295, 19);
            this.txt_updateDelete.TabIndex = 2;
            this.txt_updateDelete.TextChanged += new System.EventHandler(this.txt_updateDelete_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(511, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Update / Delete";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_addBank
            // 
            this.txt_addBank.BackColor = System.Drawing.SystemColors.Control;
            this.txt_addBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_addBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_addBank.Location = new System.Drawing.Point(108, 98);
            this.txt_addBank.Name = "txt_addBank";
            this.txt_addBank.Size = new System.Drawing.Size(295, 19);
            this.txt_addBank.TabIndex = 0;
            this.txt_addBank.TextChanged += new System.EventHandler(this.txt_addBank_TextChanged_1);
            // 
            // btn_deleteBank
            // 
            this.btn_deleteBank.BackColor = System.Drawing.SystemColors.Window;
            this.btn_deleteBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_deleteBank.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteBank.Image")));
            this.btn_deleteBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteBank.Location = new System.Drawing.Point(829, 123);
            this.btn_deleteBank.Name = "btn_deleteBank";
            this.btn_deleteBank.Size = new System.Drawing.Size(101, 32);
            this.btn_deleteBank.TabIndex = 4;
            this.btn_deleteBank.Text = "   Delete";
            this.btn_deleteBank.UseVisualStyleBackColor = false;
            this.btn_deleteBank.Click += new System.EventHandler(this.btn_deleteBank_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btn_updateBank
            // 
            this.btn_updateBank.BackColor = System.Drawing.SystemColors.Window;
            this.btn_updateBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateBank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_updateBank.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateBank.Image")));
            this.btn_updateBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateBank.Location = new System.Drawing.Point(635, 123);
            this.btn_updateBank.Name = "btn_updateBank";
            this.btn_updateBank.Size = new System.Drawing.Size(101, 32);
            this.btn_updateBank.TabIndex = 3;
            this.btn_updateBank.Text = "    Update";
            this.btn_updateBank.UseVisualStyleBackColor = false;
            this.btn_updateBank.Click += new System.EventHandler(this.btn_updateBank_Click_1);
            // 
            // btn_addBank
            // 
            this.btn_addBank.BackColor = System.Drawing.SystemColors.Window;
            this.btn_addBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addBank.Image = ((System.Drawing.Image)(resources.GetObject("btn_addBank.Image")));
            this.btn_addBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addBank.Location = new System.Drawing.Point(302, 123);
            this.btn_addBank.Name = "btn_addBank";
            this.btn_addBank.Size = new System.Drawing.Size(101, 32);
            this.btn_addBank.TabIndex = 1;
            this.btn_addBank.Text = "Add";
            this.btn_addBank.UseVisualStyleBackColor = false;
            this.btn_addBank.Click += new System.EventHandler(this.btn_addBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(375, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bank Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 73);
            this.panel1.TabIndex = 22;
            // 
            // banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_updateDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_addBank);
            this.Controls.Add(this.btn_deleteBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_updateBank);
            this.Controls.Add(this.btn_addBank);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "banks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "banks";
            this.Load += new System.EventHandler(this.banks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_updateDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addBank;
        private System.Windows.Forms.Button btn_deleteBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_updateBank;
        private System.Windows.Forms.Button btn_addBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}