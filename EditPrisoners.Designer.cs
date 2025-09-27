namespace PrisonManagementSystem_KARAGOR_
{
    partial class EditPrisoners
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbrelease = new System.Windows.Forms.Label();
            this.lbtrial = new System.Windows.Forms.Label();
            this.lbverdict = new System.Windows.Forms.Label();
            this.lbcrime = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbnid = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnid = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.tbcrime = new System.Windows.Forms.TextBox();
            this.tbverdict = new System.Windows.Forms.TextBox();
            this.tbtrial = new System.Windows.Forms.TextBox();
            this.tbrelease = new System.Windows.Forms.TextBox();
            this.tbprisoner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(364, 514);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 38;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(203, 514);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 37;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(364, 457);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 36;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(203, 457);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(203, 405);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(236, 20);
            this.tbsearch.TabIndex = 34;
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(11, 396);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(173, 37);
            this.lblsearch.TabIndex = 33;
            this.lblsearch.Text = "SEARCH BY ID:";
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
            this.dgvView.Location = new System.Drawing.Point(12, 90);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(452, 279);
            this.dgvView.TabIndex = 32;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
          //  this.dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentClick);
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
            this.lblview.Location = new System.Drawing.Point(329, 29);
            this.lblview.Name = "lblview";
            this.lblview.Size = new System.Drawing.Size(149, 45);
            this.lblview.TabIndex = 29;
            this.lblview.Text = "LIST OF PRISONERS";
            this.lblview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      //      this.lblview.Click += new System.EventHandler(this.lblview_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(478, 495);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(697, 495);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(592, 495);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(488, 96);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(55, 18);
            this.lbname.TabIndex = 42;
            this.lbname.Text = "NAME:";
            // 
            // lbrelease
            // 
            this.lbrelease.AutoSize = true;
            this.lbrelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrelease.Location = new System.Drawing.Point(488, 440);
            this.lbrelease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrelease.Name = "lbrelease";
            this.lbrelease.Size = new System.Drawing.Size(123, 18);
            this.lbrelease.TabIndex = 43;
            this.lbrelease.Text = "RELEASE DATE:";
            // 
            // lbtrial
            // 
            this.lbtrial.AutoSize = true;
            this.lbtrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrial.Location = new System.Drawing.Point(488, 397);
            this.lbtrial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtrial.Name = "lbtrial";
            this.lbtrial.Size = new System.Drawing.Size(95, 18);
            this.lbtrial.TabIndex = 44;
            this.lbtrial.Text = "TRIAL DATE:";
            // 
            // lbverdict
            // 
            this.lbverdict.AutoSize = true;
            this.lbverdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbverdict.Location = new System.Drawing.Point(488, 352);
            this.lbverdict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbverdict.Name = "lbverdict";
            this.lbverdict.Size = new System.Drawing.Size(76, 18);
            this.lbverdict.TabIndex = 45;
            this.lbverdict.Text = "VERDICT:";
            // 
            // lbcrime
            // 
            this.lbcrime.AutoSize = true;
            this.lbcrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcrime.Location = new System.Drawing.Point(488, 306);
            this.lbcrime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcrime.Name = "lbcrime";
            this.lbcrime.Size = new System.Drawing.Size(60, 18);
            this.lbcrime.TabIndex = 46;
            this.lbcrime.Text = "CRIME:";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(488, 262);
            this.lbstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(70, 18);
            this.lbstatus.TabIndex = 47;
            this.lbstatus.Text = "STATUS:";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(488, 218);
            this.lbpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(100, 18);
            this.lbpass.TabIndex = 48;
            this.lbpass.Text = "PASSWORD:";
            // 
            // lbnid
            // 
            this.lbnid.AutoSize = true;
            this.lbnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnid.Location = new System.Drawing.Point(488, 134);
            this.lbnid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnid.Name = "lbnid";
            this.lbnid.Size = new System.Drawing.Size(37, 18);
            this.lbnid.TabIndex = 49;
            this.lbnid.Text = "NID:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(632, 95);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(140, 20);
            this.tbname.TabIndex = 50;
            // 
            // tbnid
            // 
            this.tbnid.Location = new System.Drawing.Point(632, 134);
            this.tbnid.Margin = new System.Windows.Forms.Padding(2);
            this.tbnid.Name = "tbnid";
            this.tbnid.ReadOnly = true;
            this.tbnid.Size = new System.Drawing.Size(140, 20);
            this.tbnid.TabIndex = 51;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(632, 218);
            this.tbpass.Margin = new System.Windows.Forms.Padding(2);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(140, 20);
            this.tbpass.TabIndex = 52;
            // 
            // tbstatus
            // 
            this.tbstatus.Location = new System.Drawing.Point(632, 264);
            this.tbstatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(140, 20);
            this.tbstatus.TabIndex = 53;
            // 
            // tbcrime
            // 
            this.tbcrime.Location = new System.Drawing.Point(632, 308);
            this.tbcrime.Margin = new System.Windows.Forms.Padding(2);
            this.tbcrime.Name = "tbcrime";
            this.tbcrime.Size = new System.Drawing.Size(140, 20);
            this.tbcrime.TabIndex = 54;
            // 
            // tbverdict
            // 
            this.tbverdict.Location = new System.Drawing.Point(632, 353);
            this.tbverdict.Margin = new System.Windows.Forms.Padding(2);
            this.tbverdict.Name = "tbverdict";
            this.tbverdict.Size = new System.Drawing.Size(140, 20);
            this.tbverdict.TabIndex = 55;
            // 
            // tbtrial
            // 
            this.tbtrial.Location = new System.Drawing.Point(635, 399);
            this.tbtrial.Margin = new System.Windows.Forms.Padding(2);
            this.tbtrial.Name = "tbtrial";
            this.tbtrial.Size = new System.Drawing.Size(140, 20);
            this.tbtrial.TabIndex = 56;
            // 
            // tbrelease
            // 
            this.tbrelease.Location = new System.Drawing.Point(632, 441);
            this.tbrelease.Margin = new System.Windows.Forms.Padding(2);
            this.tbrelease.Name = "tbrelease";
            this.tbrelease.Size = new System.Drawing.Size(140, 20);
            this.tbrelease.TabIndex = 57;
            // 
            // tbprisoner
            // 
            this.tbprisoner.Location = new System.Drawing.Point(635, 175);
            this.tbprisoner.Margin = new System.Windows.Forms.Padding(2);
            this.tbprisoner.Name = "tbprisoner";
            this.tbprisoner.ReadOnly = true;
            this.tbprisoner.Size = new System.Drawing.Size(140, 20);
            this.tbprisoner.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "PRISONER\'S ID:";
            // 
            // EditPrisoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.staff_view1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbprisoner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbrelease);
            this.Controls.Add(this.tbtrial);
            this.Controls.Add(this.tbverdict);
            this.Controls.Add(this.tbcrime);
            this.Controls.Add(this.tbstatus);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbnid);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbnid);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.lbcrime);
            this.Controls.Add(this.lbverdict);
            this.Controls.Add(this.lbtrial);
            this.Controls.Add(this.lbrelease);
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
            this.Name = "EditPrisoners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPrisoners";
         //   this.Load += new System.EventHandler(this.EditPrisoners_Load_1);
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
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbrelease;
        private System.Windows.Forms.Label lbtrial;
        private System.Windows.Forms.Label lbverdict;
        private System.Windows.Forms.Label lbcrime;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbnid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbnid;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.TextBox tbcrime;
        private System.Windows.Forms.TextBox tbverdict;
        private System.Windows.Forms.TextBox tbtrial;
        private System.Windows.Forms.TextBox tbrelease;
        private System.Windows.Forms.TextBox tbprisoner;
        private System.Windows.Forms.Label label1;
    }
}