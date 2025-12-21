using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediTrackBussinesLayer;

namespace MediTrackClinic.People
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataGridView1.DataSource = clsPerson.GetAllPeople();
            lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson();
            addEditPerson.ShowDialog();
            _LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsPerson.DeletePerson(Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value)))
                {
                    MessageBox.Show("Person deleted successfully.");
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Error: Person is not deleted.");
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson(Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value));
            addEditPerson.ShowDialog();
            _LoadData();
        }
    }
}
