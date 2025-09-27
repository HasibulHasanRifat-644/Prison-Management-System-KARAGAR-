namespace PrisonManagementSystem_KARAGOR_
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.lbprisonernid = new System.Windows.Forms.Label();
            this.tbnid = new System.Windows.Forms.TextBox();
            this.lbrole = new System.Windows.Forms.Label();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.btback = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.cbrelation = new System.Windows.Forms.ComboBox();
            this.lbforget = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btconfirm = new System.Windows.Forms.Button();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbnid = new System.Windows.Forms.Label();
            this.jail_Logo = new System.Windows.Forms.PictureBox();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.lblsignin = new System.Windows.Forms.Label();
            this.lbrelation = new System.Windows.Forms.Label();
            this.bd_Logo = new System.Windows.Forms.PictureBox();
            this.tbprisonernid = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblnid = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblprinid = new System.Windows.Forms.Label();
            this.lblrltn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbprisonernid
            // 
            this.lbprisonernid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbprisonernid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprisonernid.Location = new System.Drawing.Point(362, 333);
            this.lbprisonernid.Name = "lbprisonernid";
            this.lbprisonernid.Size = new System.Drawing.Size(128, 52);
            this.lbprisonernid.TabIndex = 46;
            this.lbprisonernid.Text = "PRISONER\'S NID:";
            this.lbprisonernid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbnid
            // 
            this.tbnid.Location = new System.Drawing.Point(530, 177);
            this.tbnid.Name = "tbnid";
            this.tbnid.Size = new System.Drawing.Size(214, 20);
            this.tbnid.TabIndex = 44;
            // 
            // lbrole
            // 
            this.lbrole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrole.Location = new System.Drawing.Point(362, 113);
            this.lbrole.Name = "lbrole";
            this.lbrole.Size = new System.Drawing.Size(128, 21);
            this.lbrole.TabIndex = 27;
            this.lbrole.Text = "ROLE:";
            this.lbrole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbshow
            // 
            this.cbshow.Location = new System.Drawing.Point(530, 303);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(134, 17);
            this.cbshow.TabIndex = 45;
            this.cbshow.Text = "Show Password";
            this.cbshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.SystemColors.Menu;
            this.btback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.Location = new System.Drawing.Point(530, 500);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(86, 39);
            this.btback.TabIndex = 36;
            this.btback.Text = "BACK";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // lbname
            // 
            this.lbname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(362, 226);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(128, 20);
            this.lbname.TabIndex = 39;
            this.lbname.Text = "USERNAME:";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(530, 280);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(214, 20);
            this.tbpass.TabIndex = 42;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // cbrelation
            // 
            this.cbrelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrelation.FormattingEnabled = true;
            this.cbrelation.Items.AddRange(new object[] {
            "PARENT",
            "SIBILING",
            "WIFE",
            "FRIEND",
            "OTHERS"});
            this.cbrelation.Location = new System.Drawing.Point(530, 412);
            this.cbrelation.Name = "cbrelation";
            this.cbrelation.Size = new System.Drawing.Size(214, 21);
            this.cbrelation.TabIndex = 49;
            // 
            // lbforget
            // 
            this.lbforget.AutoSize = true;
            this.lbforget.BackColor = System.Drawing.Color.Transparent;
            this.lbforget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbforget.ForeColor = System.Drawing.Color.Red;
            this.lbforget.Location = new System.Drawing.Point(584, 465);
            this.lbforget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbforget.Name = "lbforget";
            this.lbforget.Size = new System.Drawing.Size(114, 15);
            this.lbforget.TabIndex = 50;
            this.lbforget.Text = "Forget Password";
            this.lbforget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbforget.Click += new System.EventHandler(this.lbforget_Click_1);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(530, 226);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(214, 20);
            this.tbname.TabIndex = 40;
            // 
            // btconfirm
            // 
            this.btconfirm.BackColor = System.Drawing.SystemColors.Menu;
            this.btconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirm.Location = new System.Drawing.Point(654, 500);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.Size = new System.Drawing.Size(90, 39);
            this.btconfirm.TabIndex = 35;
            this.btconfirm.Text = "CONFIRM";
            this.btconfirm.UseVisualStyleBackColor = false;
            this.btconfirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // lbpass
            // 
            this.lbpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(362, 280);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(128, 20);
            this.lbpass.TabIndex = 41;
            this.lbpass.Text = "PASSWORD:";
            this.lbpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnid
            // 
            this.lbnid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnid.Location = new System.Drawing.Point(362, 176);
            this.lbnid.Name = "lbnid";
            this.lbnid.Size = new System.Drawing.Size(128, 20);
            this.lbnid.TabIndex = 43;
            this.lbnid.Text = "NID:";
            this.lbnid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jail_Logo
            // 
            this.jail_Logo.BackColor = System.Drawing.Color.White;
            this.jail_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jail_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jail_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_jail_logo_png_seeklogo_271280_removebg_preview;
            this.jail_Logo.Location = new System.Drawing.Point(710, 22);
            this.jail_Logo.Name = "jail_Logo";
            this.jail_Logo.Size = new System.Drawing.Size(62, 62);
            this.jail_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jail_Logo.TabIndex = 33;
            this.jail_Logo.TabStop = false;
            // 
            // cbrole
            // 
            this.cbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "ADMIN",
            "STAFF",
            "FAMILY"});
            this.cbrole.Location = new System.Drawing.Point(530, 113);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(214, 21);
            this.cbrole.TabIndex = 28;
            this.cbrole.SelectedIndexChanged += new System.EventHandler(this.cbrole_SelectedIndexChanged);
            // 
            // lblsignin
            // 
            this.lblsignin.BackColor = System.Drawing.Color.Transparent;
            this.lblsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignin.Location = new System.Drawing.Point(447, 23);
            this.lblsignin.Name = "lblsignin";
            this.lblsignin.Size = new System.Drawing.Size(200, 43);
            this.lblsignin.TabIndex = 37;
            this.lblsignin.Text = "SIGN IN";
            this.lblsignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbrelation
            // 
            this.lbrelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbrelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrelation.Location = new System.Drawing.Point(362, 412);
            this.lbrelation.Name = "lbrelation";
            this.lbrelation.Size = new System.Drawing.Size(128, 20);
            this.lbrelation.TabIndex = 48;
            this.lbrelation.Text = "RELATION:";
            this.lbrelation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bd_Logo
            // 
            this.bd_Logo.BackColor = System.Drawing.Color.Transparent;
            this.bd_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bd_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bd_Logo.Image = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.bangladesh_govt_logo_png_seeklogo_196441_removebg_preview;
            this.bd_Logo.Location = new System.Drawing.Point(12, 21);
            this.bd_Logo.Name = "bd_Logo";
            this.bd_Logo.Size = new System.Drawing.Size(62, 62);
            this.bd_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bd_Logo.TabIndex = 34;
            this.bd_Logo.TabStop = false;
            this.bd_Logo.Click += new System.EventHandler(this.bd_Logo_Click);
            // 
            // tbprisonernid
            // 
            this.tbprisonernid.Location = new System.Drawing.Point(530, 353);
            this.tbprisonernid.Name = "tbprisonernid";
            this.tbprisonernid.Size = new System.Drawing.Size(214, 20);
            this.tbprisonernid.TabIndex = 47;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Location = new System.Drawing.Point(527, 137);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(204, 12);
            this.lblRole.TabIndex = 51;
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnid
            // 
            this.lblnid.BackColor = System.Drawing.Color.Transparent;
            this.lblnid.Location = new System.Drawing.Point(527, 200);
            this.lblnid.Name = "lblnid";
            this.lblnid.Size = new System.Drawing.Size(204, 14);
            this.lblnid.TabIndex = 52;
            this.lblnid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluname
            // 
            this.lbluname.BackColor = System.Drawing.Color.Transparent;
            this.lbluname.Location = new System.Drawing.Point(527, 249);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(204, 15);
            this.lbluname.TabIndex = 53;
            this.lbluname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpass
            // 
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Location = new System.Drawing.Point(527, 323);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(204, 16);
            this.lblpass.TabIndex = 54;
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprinid
            // 
            this.lblprinid.BackColor = System.Drawing.Color.Transparent;
            this.lblprinid.Location = new System.Drawing.Point(530, 380);
            this.lblprinid.Name = "lblprinid";
            this.lblprinid.Size = new System.Drawing.Size(214, 23);
            this.lblprinid.TabIndex = 55;
            this.lblprinid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblrltn
            // 
            this.lblrltn.BackColor = System.Drawing.Color.Transparent;
            this.lblrltn.Location = new System.Drawing.Point(533, 442);
            this.lblrltn.Name = "lblrltn";
            this.lblrltn.Size = new System.Drawing.Size(198, 23);
            this.lblrltn.TabIndex = 56;
            this.lblrltn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bd_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 563);
            this.panel1.TabIndex = 57;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblrltn);
            this.Controls.Add(this.lblprinid);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblnid);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lbforget);
            this.Controls.Add(this.cbrelation);
            this.Controls.Add(this.lbrelation);
            this.Controls.Add(this.tbprisonernid);
            this.Controls.Add(this.lbprisonernid);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.tbnid);
            this.Controls.Add(this.lbnid);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lblsignin);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btconfirm);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.cbrole);
            this.Controls.Add(this.lbrole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInX";
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbprisonernid;
        private System.Windows.Forms.TextBox tbnid;
        private System.Windows.Forms.Label lbrole;
        private System.Windows.Forms.CheckBox cbshow;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.ComboBox cbrelation;
        private System.Windows.Forms.Label lbforget;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btconfirm;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbnid;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label lblsignin;
        private System.Windows.Forms.Label lbrelation;
        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.TextBox tbprisonernid;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblnid;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblprinid;
        private System.Windows.Forms.Label lblrltn;
        private System.Windows.Forms.Panel panel1;
    }
}