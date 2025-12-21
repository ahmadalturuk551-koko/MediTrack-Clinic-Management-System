namespace MediTrackClinic.People
{
    partial class frmPeople
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsPeople;
            this.dataGridView1.Location = new System.Drawing.Point(12, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1792, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(100, 832);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(20, 24);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 832);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Records:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediTrackClinic.Properties.Resources.icons8_crowd_80;
            this.pictureBox1.Location = new System.Drawing.Point(852, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::MediTrackClinic.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1725, 320);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(79, 57);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsPeople
            // 
            this.cmsPeople.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsPeople.Name = "cmsPeople";
            this.cmsPeople.Size = new System.Drawing.Size(208, 98);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::MediTrackClinic.Properties.Resources.edit_32;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1841, 865);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeople";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}