namespace PrisonManagementSystem_KARAGOR_
{
    partial class EditStaff
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.jail_Logo = new System.Windows.Forms.PictureBox();
            this.bd_Logo = new System.Windows.Forms.PictureBox();
            this.lblview = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbnid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbnid = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbmanager = new System.Windows.Forms.TextBox();
            this.lbmanager = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(395, 510);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 38;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(234, 510);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 37;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(395, 454);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 36;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(234, 454);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(234, 402);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(236, 20);
            this.tbsearch.TabIndex = 34;
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(14, 392);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(173, 37);
            this.lblsearch.TabIndex = 33;
            this.lblsearch.Text = "SEARCH BY NID:";
            this.lblsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvView.Location = new System.Drawing.Point(12, 102);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(466, 268);
            this.dgvView.TabIndex = 32;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // jail_Logo
            // 
            this.jail_Logo.BackColor = System.Drawing.Color.White;
            this.jail_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jail_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jail_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_jail_logo_png_seeklogo_271280_removebg_preview;
            this.jail_Logo.Location = new System.Drawing.Point(710, 12);
            this.jail_Logo.Name = "jail_Logo";
            this.jail_Logo.Size = new System.Drawing.Size(62, 62);
            this.jail_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jail_Logo.TabIndex = 31;
            this.jail_Logo.TabStop = false;
            // 
            // bd_Logo
            // 
            this.bd_Logo.BackColor = System.Drawing.Color.White;
            this.bd_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bd_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bd_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_govt_logo_png_seeklogo_196441_removebg_preview;
            this.bd_Logo.Location = new System.Drawing.Point(12, 12);
            this.bd_Logo.Name = "bd_Logo";
            this.bd_Logo.Size = new System.Drawing.Size(62, 62);
            this.bd_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bd_Logo.TabIndex = 30;
            this.bd_Logo.TabStop = false;
            // 
            // lblview
            // 
            this.lblview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblview.Location = new System.Drawing.Point(322, 29);
            this.lblview.Name = "lblview";
            this.lblview.Size = new System.Drawing.Size(149, 45);
            this.lblview.TabIndex = 29;
            this.lblview.Text = "LIST OF STAFF";
            this.lblview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(506, 385);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 53;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(600, 385);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 54;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(698, 385);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 55;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // tbdob
            // 
            this.tbdob.Location = new System.Drawing.Point(633, 270);
            this.tbdob.Margin = new System.Windows.Forms.Padding(2);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(140, 20);
            this.tbdob.TabIndex = 76;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(633, 229);
            this.tbpass.Margin = new System.Windows.Forms.Padding(2);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(140, 20);
            this.tbpass.TabIndex = 75;
            // 
            // tbnid
            // 
            this.tbnid.Location = new System.Drawing.Point(633, 180);
            this.tbnid.Margin = new System.Windows.Forms.Padding(2);
            this.tbnid.Name = "tbnid";
            this.tbnid.Size = new System.Drawing.Size(140, 20);
            this.tbnid.TabIndex = 74;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(633, 137);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(140, 20);
            this.tbname.TabIndex = 73;
            // 
            // lbnid
            // 
            this.lbnid.AutoSize = true;
            this.lbnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnid.Location = new System.Drawing.Point(491, 180);
            this.lbnid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnid.Name = "lbnid";
            this.lbnid.Size = new System.Drawing.Size(37, 18);
            this.lbnid.TabIndex = 72;
            this.lbnid.Text = "NID:";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.Location = new System.Drawing.Point(491, 270);
            this.lbdob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(124, 18);
            this.lbdob.TabIndex = 71;
            this.lbdob.Text = "DATE OF BIRTH:";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(491, 228);
            this.lbpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(100, 18);
            this.lbpass.TabIndex = 70;
            this.lbpass.Text = "PASSWORD:";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(491, 137);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(55, 18);
            this.lbname.TabIndex = 67;
            this.lbname.Text = "NAME:";
            // 
            // tbmanager
            // 
            this.tbmanager.Location = new System.Drawing.Point(633, 315);
            this.tbmanager.Margin = new System.Windows.Forms.Padding(2);
            this.tbmanager.Name = "tbmanager";
            this.tbmanager.Size = new System.Drawing.Size(140, 20);
            this.tbmanager.TabIndex = 77;
            // 
            // lbmanager
            // 
            this.lbmanager.AutoSize = true;
            this.lbmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanager.Location = new System.Drawing.Point(491, 315);
            this.lbmanager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmanager.Name = "lbmanager";
            this.lbmanager.Size = new System.Drawing.Size(105, 18);
            this.lbmanager.TabIndex = 69;
            this.lbmanager.Text = "MANAGER ID:";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.edit_staff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbmanager);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbnid);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbnid);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbmanager);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.bd_Logo);
            this.Controls.Add(this.lblview);
            this.Name = "EditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStaff";
          //  this.Load += new System.EventHandler(this.EditStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.Label lblview;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbnid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbnid;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbmanager;
        private System.Windows.Forms.Label lbmanager;
    }
}