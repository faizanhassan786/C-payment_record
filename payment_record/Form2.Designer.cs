
namespace payment_record
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_close = new System.Windows.Forms.PictureBox();
            this.txt_minimize = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banksToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.banksToolStripMenuItem.Text = "Banks";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // txt_close
            // 
            this.txt_close.Image = ((System.Drawing.Image)(resources.GetObject("txt_close.Image")));
            this.txt_close.Location = new System.Drawing.Point(1015, 0);
            this.txt_close.Name = "txt_close";
            this.txt_close.Size = new System.Drawing.Size(24, 24);
            this.txt_close.TabIndex = 3;
            this.txt_close.TabStop = false;
            this.txt_close.Click += new System.EventHandler(this.txt_close_Click);
            // 
            // txt_minimize
            // 
            this.txt_minimize.Image = ((System.Drawing.Image)(resources.GetObject("txt_minimize.Image")));
            this.txt_minimize.Location = new System.Drawing.Point(985, 0);
            this.txt_minimize.Name = "txt_minimize";
            this.txt_minimize.Size = new System.Drawing.Size(30, 24);
            this.txt_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txt_minimize.TabIndex = 4;
            this.txt_minimize.TabStop = false;
            this.txt_minimize.Click += new System.EventHandler(this.txt_minimize_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 549);
            this.Controls.Add(this.txt_minimize);
            this.Controls.Add(this.txt_close);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.PictureBox txt_close;
        private System.Windows.Forms.PictureBox txt_minimize;
    }
}