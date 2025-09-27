namespace PrisonManagementSystem_KARAGOR_
{
    partial class Report
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
            this.lbl_report = new System.Windows.Forms.Label();
            this.jail_Logo = new System.Windows.Forms.PictureBox();
            this.bd_Logo = new System.Windows.Forms.PictureBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.rdbgreen = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbred = new System.Windows.Forms.RadioButton();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_report
            // 
            this.lbl_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report.Location = new System.Drawing.Point(395, 15);
            this.lbl_report.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Size = new System.Drawing.Size(223, 81);
            this.lbl_report.TabIndex = 33;
            this.lbl_report.Text = "REPORT PRISONER";
            this.lbl_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jail_Logo
            // 
            this.jail_Logo.BackColor = System.Drawing.Color.White;
            this.jail_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jail_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jail_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_jail_logo_png_seeklogo_271280_removebg_preview;
            this.jail_Logo.Location = new System.Drawing.Point(947, 15);
            this.jail_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.jail_Logo.Name = "jail_Logo";
            this.jail_Logo.Size = new System.Drawing.Size(82, 76);
            this.jail_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jail_Logo.TabIndex = 35;
            this.jail_Logo.TabStop = false;
            // 
            // bd_Logo
            // 
            this.bd_Logo.BackColor = System.Drawing.Color.White;
            this.bd_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bd_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bd_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_govt_logo_png_seeklogo_196441_removebg_preview;
            this.bd_Logo.Location = new System.Drawing.Point(16, 15);
            this.bd_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.bd_Logo.Name = "bd_Logo";
            this.bd_Logo.Size = new System.Drawing.Size(82, 76);
            this.bd_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bd_Logo.TabIndex = 36;
            this.bd_Logo.TabStop = false;
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(213, 226);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(181, 73);
            this.lblsearch.TabIndex = 37;
            this.lblsearch.Text = "SEARCH BY PRISONER\'S ID:";
            this.lblsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(456, 244);
            this.tbid.Margin = new System.Windows.Forms.Padding(4);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(276, 22);
            this.tbid.TabIndex = 38;
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(217, 335);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(181, 55);
            this.lblstatus.TabIndex = 41;
            this.lblstatus.Text = "STATUS:";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbgreen
            // 
            this.rdbgreen.AutoSize = true;
            this.rdbgreen.Location = new System.Drawing.Point(19, 18);
            this.rdbgreen.Margin = new System.Windows.Forms.Padding(4);
            this.rdbgreen.Name = "rdbgreen";
            this.rdbgreen.Size = new System.Drawing.Size(76, 20);
            this.rdbgreen.TabIndex = 42;
            this.rdbgreen.TabStop = true;
            this.rdbgreen.Text = "GREEN";
            this.rdbgreen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbred);
            this.panel1.Controls.Add(this.rdbgreen);
            this.panel1.Location = new System.Drawing.Point(456, 335);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 55);
            this.panel1.TabIndex = 43;
            // 
            // rdbred
            // 
            this.rdbred.AutoSize = true;
            this.rdbred.Location = new System.Drawing.Point(140, 18);
            this.rdbred.Margin = new System.Windows.Forms.Padding(4);
            this.rdbred.Name = "rdbred";
            this.rdbred.Size = new System.Drawing.Size(57, 20);
            this.rdbred.TabIndex = 43;
            this.rdbred.TabStop = true;
            this.rdbred.Text = "RED";
            this.rdbred.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(460, 476);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 28);
            this.btnback.TabIndex = 44;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(637, 476);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 28);
            this.btnexit.TabIndex = 45;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(543, 417);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(100, 28);
            this.btnconfirm.TabIndex = 46;
            this.btnconfirm.Text = "CONFIRM";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.report;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.bd_Logo);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.lbl_report);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_report;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.RadioButton rdbgreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbred;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnconfirm;
    }
}