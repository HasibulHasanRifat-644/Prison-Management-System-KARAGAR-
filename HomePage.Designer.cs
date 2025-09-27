namespace PrisonManagementSystem_KARAGOR_
{
    partial class HomePage
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
            this.jail_Logo = new System.Windows.Forms.PictureBox();
            this.bd_Logo = new System.Windows.Forms.PictureBox();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Sign_Up = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).BeginInit();
            this.SuspendLayout();
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
            this.jail_Logo.TabIndex = 1;
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
            this.bd_Logo.TabIndex = 0;
            this.bd_Logo.TabStop = false;
            this.bd_Logo.Click += new System.EventHandler(this.Homepage_Pic_Click);
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.Color.Transparent;
            this.Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In.ForeColor = System.Drawing.Color.Red;
            this.Sign_In.Location = new System.Drawing.Point(601, 238);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(132, 48);
            this.Sign_In.TabIndex = 2;
            this.Sign_In.Text = "SIGN IN";
            this.Sign_In.UseVisualStyleBackColor = false;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Sign_Up
            // 
            this.Sign_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up.ForeColor = System.Drawing.Color.Red;
            this.Sign_Up.Location = new System.Drawing.Point(407, 238);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(132, 48);
            this.Sign_Up.TabIndex = 3;
            this.Sign_Up.Text = "SIGN UP";
            this.Sign_Up.UseVisualStyleBackColor = true;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(518, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(154, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "\"রাখিব নিরাপদ, দেখাব আলোর পথ\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(154, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "কারাগার";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagementSystem_KARAGOR_.Properties.Resources.middle_aged_man_spending_time_jail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.jail_Logo);
            this.Controls.Add(this.bd_Logo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jail_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bd_Logo;
        private System.Windows.Forms.PictureBox jail_Logo;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

