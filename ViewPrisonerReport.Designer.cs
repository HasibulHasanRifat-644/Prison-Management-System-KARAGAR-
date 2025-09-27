namespace PrisonManagementSystem_KARAGOR_
{
    partial class ViewPrisonerReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.lblappointment = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_report
            // 
            this.lbl_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_report.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report.Location = new System.Drawing.Point(395, 15);
            this.lbl_report.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Size = new System.Drawing.Size(246, 107);
            this.lbl_report.TabIndex = 149;
            this.lbl_report.Text = "PRISONER REPORT DASHBOARD";
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
            this.jail_Logo.TabIndex = 148;
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
            this.bd_Logo.TabIndex = 147;
            this.bd_Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtpid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.txtsid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.dgvView);
            this.panel1.Controls.Add(this.lblappointment);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.tbsearch);
            this.panel1.Controls.Add(this.lblsearch);
            this.panel1.Location = new System.Drawing.Point(1, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 521);
            this.panel1.TabIndex = 150;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(744, 178);
            this.txtpid.Margin = new System.Windows.Forms.Padding(4);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(276, 22);
            this.txtpid.TabIndex = 183;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 55);
            this.label6.TabIndex = 182;
            this.label6.Text = "PRISONER ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(833, 479);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 28);
            this.btnback.TabIndex = 181;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(744, 401);
            this.txtsid.Margin = new System.Windows.Forms.Padding(4);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(276, 22);
            this.txtsid.TabIndex = 180;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 55);
            this.label4.TabIndex = 179;
            this.label4.Text = "STAFF NID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(744, 329);
            this.txtsname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(276, 22);
            this.txtsname.TabIndex = 178;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 55);
            this.label3.TabIndex = 177;
            this.label3.Text = "STAFF NAME:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(744, 102);
            this.txtpname.Margin = new System.Windows.Forms.Padding(4);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(276, 22);
            this.txtpname.TabIndex = 176;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 55);
            this.label2.TabIndex = 175;
            this.label2.Text = "PRISONER NAME:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(744, 33);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(276, 22);
            this.txtid.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 55);
            this.label1.TabIndex = 173;
            this.label1.Text = "REPORT DATE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(744, 255);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(276, 22);
            this.txtstatus.TabIndex = 172;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(312, 479);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(100, 28);
            this.btnrefresh.TabIndex = 171;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click_1);
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(21, 20);
            this.dgvView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(469, 303);
            this.dgvView.TabIndex = 170;
            this.dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentClick_1);
            // 
            // lblappointment
            // 
            this.lblappointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblappointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappointment.Location = new System.Drawing.Point(541, 234);
            this.lblappointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblappointment.Name = "lblappointment";
            this.lblappointment.Size = new System.Drawing.Size(182, 62);
            this.lblappointment.TabIndex = 169;
            this.lblappointment.Text = "STATUS:";
            this.lblappointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(312, 425);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 28);
            this.btnsearch.TabIndex = 168;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(224, 378);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(265, 22);
            this.tbsearch.TabIndex = 167;
            // 
            // lblsearch
            // 
            this.lblsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(21, 345);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(182, 86);
            this.lblsearch.TabIndex = 166;
            this.lblsearch.Text = "SEARCH BY REPORT ID:";
            this.lblsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewPrisonerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_report);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.bd_Logo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPrisonerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPrisonerReport";
            this.Load += new System.EventHandler(this.ViewPrisonerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_report;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label lblappointment;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label lblsearch;
    }
}