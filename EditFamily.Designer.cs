namespace PrisonManagementSystem_KARAGOR_
{
    partial class EditFamily
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.jail_Logo = new System.Windows.Forms.PictureBox();
            this.bd_Logo = new System.Windows.Forms.PictureBox();
            this.lblview = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbprisoner = new System.Windows.Forms.Label();
            this.lbrelation = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbnid = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnid = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.tbrelation = new System.Windows.Forms.TextBox();
            this.tbprisoner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(394, 496);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 51;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(233, 496);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 50;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(394, 446);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 49;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(233, 446);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 48;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(233, 369);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(236, 20);
            this.tbsearch.TabIndex = 47;
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(41, 359);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(173, 37);
            this.lblsearch.TabIndex = 46;
            this.lblsearch.Text = "SEARCH BY NID:";
            this.lblsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvView.Location = new System.Drawing.Point(12, 98);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(458, 246);
            this.dgvView.TabIndex = 45;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // jail_Logo
            // 
            this.jail_Logo.BackColor = System.Drawing.Color.White;
            this.jail_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jail_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jail_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_jail_logo_png_seeklogo_271280;
            this.jail_Logo.Location = new System.Drawing.Point(710, 12);
            this.jail_Logo.Name = "jail_Logo";
            this.jail_Logo.Size = new System.Drawing.Size(62, 62);
            this.jail_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jail_Logo.TabIndex = 44;
            this.jail_Logo.TabStop = false;
            // 
            // bd_Logo
            // 
            this.bd_Logo.BackColor = System.Drawing.Color.White;
            this.bd_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bd_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bd_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_govt_logo_png_seeklogo_196441;
            this.bd_Logo.Location = new System.Drawing.Point(12, 12);
            this.bd_Logo.Name = "bd_Logo";
            this.bd_Logo.Size = new System.Drawing.Size(62, 62);
            this.bd_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bd_Logo.TabIndex = 43;
            this.bd_Logo.TabStop = false;
            // 
            // lblview
            // 
            this.lblview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblview.Location = new System.Drawing.Point(312, 39);
            this.lblview.Name = "lblview";
            this.lblview.Size = new System.Drawing.Size(149, 45);
            this.lblview.TabIndex = 42;
            this.lblview.Text = "LIST OF FAMILY MEMBERS";
            this.lblview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(489, 118);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(55, 18);
            this.lbname.TabIndex = 55;
            this.lbname.Text = "NAME:";
            // 
            // lbprisoner
            // 
            this.lbprisoner.AutoSize = true;
            this.lbprisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprisoner.Location = new System.Drawing.Point(489, 340);
            this.lbprisoner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbprisoner.Name = "lbprisoner";
            this.lbprisoner.Size = new System.Drawing.Size(121, 18);
            this.lbprisoner.TabIndex = 56;
            this.lbprisoner.Text = "PRISONER\'S ID:";
            // 
            // lbrelation
            // 
            this.lbrelation.AutoSize = true;
            this.lbrelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrelation.Location = new System.Drawing.Point(489, 296);
            this.lbrelation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrelation.Name = "lbrelation";
            this.lbrelation.Size = new System.Drawing.Size(85, 18);
            this.lbrelation.TabIndex = 57;
            this.lbrelation.Text = "RELATION:";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(489, 208);
            this.lbpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(100, 18);
            this.lbpass.TabIndex = 58;
            this.lbpass.Text = "PASSWORD:";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.Location = new System.Drawing.Point(489, 250);
            this.lbdob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(124, 18);
            this.lbdob.TabIndex = 59;
            this.lbdob.Text = "DATE OF BIRTH:";
            this.lbdob.Click += new System.EventHandler(this.lbdob_Click);
            // 
            // lbnid
            // 
            this.lbnid.AutoSize = true;
            this.lbnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnid.Location = new System.Drawing.Point(489, 161);
            this.lbnid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnid.Name = "lbnid";
            this.lbnid.Size = new System.Drawing.Size(37, 18);
            this.lbnid.TabIndex = 60;
            this.lbnid.Text = "NID:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(631, 118);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(140, 20);
            this.tbname.TabIndex = 61;
            // 
            // tbnid
            // 
            this.tbnid.Location = new System.Drawing.Point(631, 161);
            this.tbnid.Margin = new System.Windows.Forms.Padding(2);
            this.tbnid.Name = "tbnid";
            this.tbnid.Size = new System.Drawing.Size(140, 20);
            this.tbnid.TabIndex = 62;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(631, 210);
            this.tbpass.Margin = new System.Windows.Forms.Padding(2);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(140, 20);
            this.tbpass.TabIndex = 63;
            // 
            // tbdob
            // 
            this.tbdob.Location = new System.Drawing.Point(631, 250);
            this.tbdob.Margin = new System.Windows.Forms.Padding(2);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(140, 20);
            this.tbdob.TabIndex = 64;
            // 
            // tbrelation
            // 
            this.tbrelation.Location = new System.Drawing.Point(631, 296);
            this.tbrelation.Margin = new System.Windows.Forms.Padding(2);
            this.tbrelation.Name = "tbrelation";
            this.tbrelation.Size = new System.Drawing.Size(140, 20);
            this.tbrelation.TabIndex = 65;
            // 
            // tbprisoner
            // 
            this.tbprisoner.Location = new System.Drawing.Point(631, 341);
            this.tbprisoner.Margin = new System.Windows.Forms.Padding(2);
            this.tbprisoner.Name = "tbprisoner";
            this.tbprisoner.Size = new System.Drawing.Size(140, 20);
            this.tbprisoner.TabIndex = 66;
            // 
            // EditFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.edit_family;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbprisoner);
            this.Controls.Add(this.tbrelation);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbnid);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbnid);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbrelation);
            this.Controls.Add(this.lbprisoner);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.bd_Logo);
            this.Controls.Add(this.lblview);
            this.Name = "EditFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFamily";
            this.Load += new System.EventHandler(this.EditFamily_Load);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.Label lblview;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbprisoner;
        private System.Windows.Forms.Label lbrelation;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbnid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbnid;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.TextBox tbrelation;
        private System.Windows.Forms.TextBox tbprisoner;
    }
}