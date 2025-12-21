using DataAccessLayer;
using MeditrackDataAccessLayer;
using System;
using System.Data;

namespace MediTrackBussinesLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }        
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public string FullName
        {
            get
            {
              
                string fullName = FirstName;

                if (!string.IsNullOrWhiteSpace(MiddleName))
                    fullName += " " + MiddleName;

                fullName += " " + LastName;

                return fullName;
            }
        }

        public string GenderText
        {
            get
            {
               
                return Gender ? "Male" : "Female";
            }
        }

        public enum enMode { AddNew = 1, Update = 2 }

        private enMode Mode = enMode.AddNew;



        private clsPerson(int personID,string nationalNumber,string firstName,string middleName,string lastName,
            DateTime dateOfBirth,bool gender,string address,string phoneNumber,string email,string imagePath)
        {
            PersonID = personID;
            NationalNumber = nationalNumber;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public clsPerson()
        {
            PersonID = -1;
            NationalNumber = string.Empty;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = true;          // مثلاً default = Male
            Address = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }



        public static clsPerson Find(int personID)
        {
            string firstName = "";
            string middleName = "";
            string lastName = "";
            string nationalNumber = "";
            DateTime dateOfBirth = DateTime.MinValue;
            bool gender = true;
            string address = "";
            string phoneNumber = "";
            string email = "";
            string imagePath = "";

            bool isFound = clsPersonData.GetPersonInfoByID(personID,ref firstName,ref middleName,ref lastName,ref nationalNumber,
                ref dateOfBirth,ref gender,ref address,ref phoneNumber,ref email,ref imagePath);

            if (!isFound)
                return null;

            return new clsPerson(personID,nationalNumber,firstName,middleName,lastName,dateOfBirth,gender,address,phoneNumber,email,imagePath);
        }

        public static clsPerson Find(string nationalNumber)
        {
            int personID = -1;
            string firstName = "";
            string middleName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.MinValue;
            bool gender = true;
            string address = "";
            string phoneNumber = "";
            string email = "";
            string imagePath = "";

            bool isFound = clsPersonData.GetPersonInfoByNationalNumber(nationalNumber,ref personID,ref firstName,ref middleName,ref lastName,
                ref dateOfBirth,ref gender,ref address,ref phoneNumber,ref email,ref imagePath);

            if (!isFound)
                return null;

            return new clsPerson(personID,nationalNumber,firstName,middleName,lastName,dateOfBirth,gender,address,phoneNumber,email,imagePath);
        }

        public static bool DeletePerson(int personID)
        {
            return clsPersonData.DeletePerson(personID);
        }

        public static bool IsPersonExist(int personID)
        {
            return clsPersonData.IsPersonExist(personID);
        }

        public static bool IsPersonExistByNationalNumber(string nationalNumber)
        {
            return clsPersonData.IsPersonExistByNationalNumber(nationalNumber);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }  

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID,this.NationalNumber,this.FirstName,this.MiddleName,this.LastName,this.DateOfBirth,
                this.Gender,this.Address,this.PhoneNumber, this.Email,this.ImagePath);
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNumber,this.FirstName,this.MiddleName,this.LastName,this.DateOfBirth,
                this.Gender,this.Address,this.PhoneNumber,this.Email,this.ImagePath);
            return (this.PersonID != -1);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

      
    }
}

