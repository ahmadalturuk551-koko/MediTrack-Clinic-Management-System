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
using System.IO;

using System.Text.RegularExpressions;
namespace MediTrackClinic.People
{


    public partial class frmAddEditPerson : Form
    {
        //declare delegate
        public delegate void SendBackPersonID(object sender, int PersonID);

        //انشئنا حبة منو
        public event SendBackPersonID BackPersonID;

        private int _PersonID;

        private clsPerson _Person;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enGendor { Female = 0, Male = 1};
        private enGendor _Gendor;

        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditPerson(int personID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = personID;
        }

        private void _LoadData()
        {
            //Add New Mode


            // _FillCountriesToCmb();

            if (_Mode == enMode.AddNew)
            {
                dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);

                dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

                _Gendor = enGendor.Male;


               // cmbCountry.Text = "Syria";

                pbPersonImage.Image = Properties.Resources.person_boy;

                _Person = new clsPerson();
                lblMode.Text = "Add New Person";


            }
            // Update Mode
            else
            {
                _Person = clsPerson.Find(_PersonID);

                //اذا كان في اكتر من يوسر شغالين عنفس السستم وواحد محا التاني كرمال مايضرب عندو بتاكد
                if (_Person == null)
                {
                    MessageBox.Show("this form will be closed because no person with ApplicationID" + _PersonID.ToString());
                    this.Close();
                    return;
                }

                lblMode.Text = "Update Person";
                mtbEmail.Text = _Person.Email;

                mtbLastName.Text = _Person.LastName;

                mtbName.Text = _Person.FirstName;

                mtbNationalNo.Text = _Person.NationalNumber;

                mtbPhone.Text = _Person.PhoneNumber;
                mtbSecondName.Text = _Person.MiddleName;

                lblPersonID.Text = _Person.PersonID.ToString();

                if (_Person.Gender == false)
                    rbFemale.Checked = true;
                else
                    rbMale.Checked = true;

                dtpDateOfBirth.Value = _Person.DateOfBirth;
                rtbAddress.Text = _Person.Address;
                //   cmbCountry.SelectedIndex = _Person.NationalityCountryID - 1;
                lblRemoveImage.Visible = true;
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    pbPersonImage.Load(_Person.ImagePath);
                }
                else
                {

                    if (_Person.Gender == false)
                       pbPersonImage.Image = Properties.Resources.person_girl;
                    else
                      
                       pbPersonImage.Image = Properties.Resources.person_boy;
                      
                }


            }
        }

        //Fill Countries to cmbCountry 

        //private void _FillCountriesToCmb()
        //{
        //    DataTable dt = clsCountry.GetAllCountries();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        cmbCountry.Items.Add(dr["CountryName"].ToString());
        //    }

        //}

        private void _FillPersonInfo()
        {

            if (mtbEmail.Text == null || mtbEmail.Text == "")
                _Person.Email = "";
            else
                _Person.Email = mtbEmail.Text;

            if (mtbSecondName.Text == null || mtbSecondName.Text == "")
                _Person.MiddleName = "";
            else
                _Person.MiddleName = mtbSecondName.Text;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";


            _Person.NationalNumber = mtbNationalNo.Text;
            _Person.Address = rtbAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbFemale.Checked)
            {
                _Gendor = enGendor.Female;
            }
            else
            {
                _Gendor = enGendor.Male;
            }

            _Person.Gender = Convert.ToBoolean(_Gendor);
            //  _Person.NationalityCountryID = cmbCountry.SelectedIndex + 1;
            _Person.NationalNumber = mtbNationalNo.Text;
            _Person.FirstName = mtbName.Text;
            _Person.PhoneNumber = mtbPhone.Text;
           
            _Person.LastName = mtbLastName.Text;


        }

        private void _HandleImage()

        {

            if (pbPersonImage.Image != null && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {

                string targetDir = @"C:\Users\ahmed\OneDrive\Desktop\MediTrack Clinic Management System";

                string extension = Path.GetExtension(openFileDialog1.FileName);

                string newFileName = Guid.NewGuid().ToString() + extension;

                // المسار الجديد كامل مع الاسم
                string targetPath = Path.Combine(targetDir, newFileName);

                _Person.ImagePath = targetPath;

                if (lblRemoveImage.Visible)
                {

                    if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                        File.Copy(openFileDialog1.FileName, targetPath, true);
                }

            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }



        private bool _IsValidEmail(string Email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            if (!Regex.IsMatch(mtbEmail.Text.Trim(), pattern) && !string.IsNullOrEmpty(Email))
                return false;

            else
                return true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                pbPersonImage.Image = Properties.Resources.person_boy;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                pbPersonImage.Image = Properties.Resources.person_girl;
        }

        private void lblSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select an image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.Image = Image.FromFile(openFileDialog1.FileName);

                lblRemoveImage.Visible = true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(rtbAddress.Text) || string.IsNullOrEmpty(mtbNationalNo.Text)
               || string.IsNullOrEmpty(mtbName.Text)
               || string.IsNullOrEmpty(mtbLastName.Text) || string.IsNullOrEmpty(mtbPhone.Text))

            {
                return;
            }
            else
            {

                _FillPersonInfo();

                if (_Person.Save())
                    MessageBox.Show("Data Saved Successfully.");
                else
                {

                    MessageBox.Show("Error: Data Is not Saved Successfully.");
                    return;
                }

                _Mode = enMode.Update;
                lblMode.Text = "Update Mode";
                lblPersonID.Text = _Person.PersonID.ToString();
              //  _HandleImage();

                BackPersonID?.Invoke(this, _Person.PersonID);
            }
        }

        private void rtbAddress_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtbAddress.Text))
                errorProvider1.SetError(rtbAddress, "Address should not be empty.");

            else
                errorProvider1.SetError(rtbAddress, "");
        }

        private void lblRemoveImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image = Properties.Resources.person_boy;
            _Person.ImagePath = "";
            lblRemoveImage.Visible = false;
        }

        private void mtbNationalNo_Validating_1(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsPersonExistByNationalNumber(mtbNationalNo.Text))
            {
                errorProvider1.SetError(mtbNationalNo, "Ntional Number is used to another person!");
            }
            else
            {
                errorProvider1.SetError(mtbNationalNo, "");
            }
        }

        private void mtbEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (!_IsValidEmail(mtbEmail.Text))
                errorProvider1.SetError(mtbEmail, "Invalid email format.");
            else
                errorProvider1.SetError(mtbEmail, "");
        }
    }
}

