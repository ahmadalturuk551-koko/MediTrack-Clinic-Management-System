using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediTrackBussinesLayer;
using MediTrackClinic.People;

namespace MediTrackClinic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // MessageBox.Show(clsPerson.koko());
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void kokoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople frmPeople = new frmPeople();
            frmPeople.ShowDialog();
        }
    }
}
