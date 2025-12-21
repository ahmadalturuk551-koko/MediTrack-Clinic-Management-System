namespace MediTrackClinic
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.adminsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1811, 79);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.AutoSize = false;
            this.peopleToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.icons8_crowd_48;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(146, 75);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.AutoSize = false;
            this.doctorsToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.icons8_doctors_32;
            this.doctorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(146, 75);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.AutoSize = false;
            this.appointmentsToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.icons8_tear_off_calendar_32;
            this.appointmentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(200, 75);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // adminsToolStripMenuItem
            // 
            this.adminsToolStripMenuItem.AutoSize = false;
            this.adminsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentAdminToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.adminsToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.icons8_user_32;
            this.adminsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            this.adminsToolStripMenuItem.Size = new System.Drawing.Size(146, 75);
            this.adminsToolStripMenuItem.Text = "Admins";
            // 
            // currentAdminToolStripMenuItem
            // 
            this.currentAdminToolStripMenuItem.Name = "currentAdminToolStripMenuItem";
            this.currentAdminToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.currentAdminToolStripMenuItem.Text = "Current Admin";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.Employees;
            this.employeesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(164, 75);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.AutoSize = false;
            this.closeToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.closeBlack32;
            this.closeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 75);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MediTrackClinic.Properties.Resources.health_still_life_with_copy_space;
            this.pictureBox2.Location = new System.Drawing.Point(0, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1811, 786);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1753, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1811, 865);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medi Track";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}

