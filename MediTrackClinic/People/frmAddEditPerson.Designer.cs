namespace MediTrackClinic.People
{
    partial class frmAddEditPerson
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
            this.components = new System.ComponentModel.Container();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lblSetImage = new System.Windows.Forms.LinkLabel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.mtbLastName = new System.Windows.Forms.MaskedTextBox();
            this.mtbSecondName = new System.Windows.Forms.MaskedTextBox();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtbNationalNo = new System.Windows.Forms.MaskedTextBox();
            this.mtbName = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(279, 92);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(42, 24);
            this.lblPersonID.TabIndex = 109;
            this.lblPersonID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 108;
            this.label2.Text = "Person ApplicationID:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMode.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMode.Location = new System.Drawing.Point(409, 25);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(287, 40);
            this.lblMode.TabIndex = 107;
            this.lblMode.Text = "Add New Person";
            // 
            // lblRemoveImage
            // 
            this.lblRemoveImage.AutoSize = true;
            this.lblRemoveImage.Location = new System.Drawing.Point(929, 538);
            this.lblRemoveImage.Name = "lblRemoveImage";
            this.lblRemoveImage.Size = new System.Drawing.Size(81, 24);
            this.lblRemoveImage.TabIndex = 106;
            this.lblRemoveImage.TabStop = true;
            this.lblRemoveImage.Text = "Remove";
            this.lblRemoveImage.Visible = false;
            this.lblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemoveImage_LinkClicked_1);
            // 
            // lblSetImage
            // 
            this.lblSetImage.AutoSize = true;
            this.lblSetImage.Location = new System.Drawing.Point(912, 486);
            this.lblSetImage.Name = "lblSetImage";
            this.lblSetImage.Size = new System.Drawing.Size(94, 24);
            this.lblSetImage.TabIndex = 89;
            this.lblSetImage.TabStop = true;
            this.lblSetImage.Text = "Set Image";
            this.lblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSetImage_LinkClicked_1);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(646, 257);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(180, 29);
            this.dtpDateOfBirth.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 24);
            this.label11.TabIndex = 105;
            this.label11.Text = "Last";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 103;
            this.label9.Text = "Middle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 102;
            this.label8.Text = "First";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(509, 388);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 24);
            this.lblCountry.TabIndex = 101;
            this.lblCountry.Text = "Country:";
            this.lblCountry.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(521, 332);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 24);
            this.lblPhone.TabIndex = 100;
            this.lblPhone.Text = "Phone:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(467, 262);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 24);
            this.lblDateOfBirth.TabIndex = 99;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(547, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 38);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(697, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 38);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(200, 452);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(626, 102);
            this.rtbAddress.TabIndex = 90;
            this.rtbAddress.Text = "";
            this.rtbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.rtbAddress_Validating_1);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(646, 380);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(180, 32);
            this.cmbCountry.TabIndex = 88;
            this.cmbCountry.Visible = false;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(646, 326);
            this.mtbPhone.Mask = "9999999999999";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(180, 29);
            this.mtbPhone.TabIndex = 86;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(331, 327);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(92, 28);
            this.rbFemale.TabIndex = 85;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(200, 325);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(69, 28);
            this.rbMale.TabIndex = 84;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged_1);
            // 
            // mtbLastName
            // 
            this.mtbLastName.Location = new System.Drawing.Point(646, 188);
            this.mtbLastName.Mask = "LLLLLLLLLLLLLLLL";
            this.mtbLastName.Name = "mtbLastName";
            this.mtbLastName.Size = new System.Drawing.Size(180, 29);
            this.mtbLastName.TabIndex = 81;
            // 
            // mtbSecondName
            // 
            this.mtbSecondName.Location = new System.Drawing.Point(416, 185);
            this.mtbSecondName.Mask = "LLLLLLLLLLLLLLLL";
            this.mtbSecondName.Name = "mtbSecondName";
            this.mtbSecondName.Size = new System.Drawing.Size(180, 29);
            this.mtbSecondName.TabIndex = 79;
            // 
            // mtbEmail
            // 
            this.mtbEmail.Location = new System.Drawing.Point(200, 383);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(180, 29);
            this.mtbEmail.TabIndex = 87;
            this.mtbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.mtbEmail_Validating_1);
            // 
            // mtbNationalNo
            // 
            this.mtbNationalNo.Location = new System.Drawing.Point(200, 249);
            this.mtbNationalNo.Name = "mtbNationalNo";
            this.mtbNationalNo.Size = new System.Drawing.Size(180, 29);
            this.mtbNationalNo.TabIndex = 82;
            this.mtbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.mtbNationalNo_Validating_1);
            // 
            // mtbName
            // 
            this.mtbName.Location = new System.Drawing.Point(200, 187);
            this.mtbName.Mask = "LLLLLLLLLLLLLLLL";
            this.mtbName.Name = "mtbName";
            this.mtbName.Size = new System.Drawing.Size(180, 29);
            this.mtbName.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 97;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 96;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 95;
            this.label5.Text = "Gendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "National No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Name:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::MediTrackClinic.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(152, 186);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 31);
            this.pictureBox10.TabIndex = 119;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MediTrackClinic.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(228, 87);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 31);
            this.pictureBox9.TabIndex = 118;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MediTrackClinic.Properties.Resources.Woman_32;
            this.pictureBox8.Location = new System.Drawing.Point(283, 323);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 31);
            this.pictureBox8.TabIndex = 117;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediTrackClinic.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(152, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 31);
            this.pictureBox7.TabIndex = 116;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MediTrackClinic.Properties.Resources.Email_32;
            this.pictureBox6.Location = new System.Drawing.Point(152, 383);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 31);
            this.pictureBox6.TabIndex = 115;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MediTrackClinic.Properties.Resources.Address_32;
            this.pictureBox5.Location = new System.Drawing.Point(152, 452);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 31);
            this.pictureBox5.TabIndex = 114;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(598, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 31);
            this.pictureBox4.TabIndex = 113;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MediTrackClinic.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(598, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 31);
            this.pictureBox3.TabIndex = 112;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MediTrackClinic.Properties.Resources.Phone_32;
            this.pictureBox2.Location = new System.Drawing.Point(598, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediTrackClinic.Properties.Resources.Man_32;
            this.pictureBox1.Location = new System.Drawing.Point(152, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Location = new System.Drawing.Point(876, 254);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(180, 208);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 98;
            this.pbPersonImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1108, 637);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblRemoveImage);
            this.Controls.Add(this.lblSetImage);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.mtbLastName);
            this.Controls.Add(this.mtbSecondName);
            this.Controls.Add(this.mtbEmail);
            this.Controls.Add(this.mtbNationalNo);
            this.Controls.Add(this.mtbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPerson";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add & Edit Person";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.LinkLabel lblRemoveImage;
        private System.Windows.Forms.LinkLabel lblSetImage;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.MaskedTextBox mtbLastName;
        private System.Windows.Forms.MaskedTextBox mtbSecondName;
        private System.Windows.Forms.MaskedTextBox mtbEmail;
        private System.Windows.Forms.MaskedTextBox mtbNationalNo;
        private System.Windows.Forms.MaskedTextBox mtbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}