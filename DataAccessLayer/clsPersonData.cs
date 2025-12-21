using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditrackDataAccessLayer
{
    public class clsPersonData
    {

        private static OdbcConnection _GetConnection()
        {
            return new OdbcConnection(clsDataAccessSettings.ConnectionString);
        }

        public static string koko()
        {
            using (OdbcConnection connection = _GetConnection())
            {
                connection.Open();
                return "State: " + connection.State.ToString();
            }
        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            const string query = @"SELECT * from ""v_People""";

            using (OdbcConnection connection = new OdbcConnection(clsDataAccessSettings.ConnectionString))
            using (var command = new OdbcCommand(query, connection))

            {
                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch
                {
                    // return empty table
                }
            }

            return dt;
        }

        public static bool GetPersonInfoByID(
     int personID,
     ref string firstName,
     ref string middleName,
     ref string lastName,
     ref string nationalNumber,
     ref DateTime dateOfBirth,
     ref bool gender,
     ref string address,
     ref string phoneNumber,
     ref string email,
     ref string imagePath)
        {
            bool isFound = false;

            const string query = @"SELECT * FROM ""People"" WHERE ""PersonID"" = ?;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            firstName = reader["FirstName"] as string ?? string.Empty;
                            middleName = reader["MiddleName"] as string ?? string.Empty;
                            lastName = reader["LastName"] as string ?? string.Empty;
                            nationalNumber = reader["NationalNumber"] as string ?? string.Empty;

                            // DateOfBirth
                            if (reader["DateOfBirth"] != DBNull.Value)
                                dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            else
                                dateOfBirth = DateTime.MinValue;

                            // Gender
                            // Gender
                            if (reader["Gender"] == DBNull.Value)
                            {
                                gender = false; // أو القيمة الافتراضية اللي تحبها
                            }
                            else
                            {
                                object gVal = reader["Gender"];

                                if (gVal is bool b)
                                {
                                    gender = b;
                                }
                                else
                                {
                                    string s = gVal.ToString().Trim().ToLower();

                                    // PostgreSQL via ODBC غالبًا ترجع "t" / "f"
                                    if (s == "t" || s == "true" || s == "1")
                                        gender = true;
                                    else
                                        gender = false;
                                }
                            }


                            address = reader["Address"] as string ?? string.Empty;
                            phoneNumber = reader["PhoneNumber"] as string ?? string.Empty;
                            email = reader["Email"] as string ?? string.Empty;
                            imagePath = reader["ImagePath"] as string ?? string.Empty;
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("SQL Error in GetPersonInfoByID: " + ex.Message);
                    isFound = false;
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine("Cast Error in GetPersonInfoByID: " + ex.Message);
                    isFound = false;
                }
            }

            return isFound;
        }


        // public static int AddNewPerson(
        //string nationalNumber,
        //string firstName,
        //string middleName,
        //string lastName,
        //DateTime dateOfBirth,
        //bool gender,
        //string address,
        //string phoneNumber,
        //string email,
        //string imagePath)
        // {
        //     int personID = -1;

        //     // بالضبط 11 برامتر بنفس ترتيب الـ procedure
        //     const string sql =
        //         @"CALL ""SP_AddPerson""(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";

        //     using (var connection = _GetConnection())
        //     using (var command = new OdbcCommand(sql, connection))
        //     {
        //         command.CommandType = CommandType.Text;   // مهم: Text، مو StoredProcedure

        //         // 1) _NationalNumber
        //         command.Parameters.AddWithValue("@NationalNumber", nationalNumber);

        //         // 2) _FirstName
        //         command.Parameters.AddWithValue("@FirstName", firstName);

        //         // 3) _MiddleName
        //         command.Parameters.AddWithValue("@MiddleName",
        //             string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName);

        //         // 4) _LastName
        //         command.Parameters.AddWithValue("@LastName", lastName);

        //         // 5) _DateOfBirth
        //         command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

        //         // 6) _Gender
        //         command.Parameters.AddWithValue("@Gender", gender);

        //         // 7) _Address
        //         command.Parameters.AddWithValue("@Address",
        //             string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);

        //         // 8) _PhoneNumber
        //         command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

        //         // 9) _Email
        //         command.Parameters.AddWithValue("@Email",
        //             string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);

        //         // 10) _ImagePath
        //         command.Parameters.AddWithValue("@ImagePath",
        //             string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);

        //         // 11) _NewPersonID (INOUT)
        //         var pNewId = command.Parameters.Add("@NewPersonID", OdbcType.Int);
        //         pNewId.Direction = ParameterDirection.InputOutput;
        //         pNewId.Value = DBNull.Value;

        //         try
        //         {
        //             connection.Open();
        //             command.ExecuteNonQuery();

        //             if (pNewId.Value != DBNull.Value &&
        //                 int.TryParse(pNewId.Value.ToString(), out int insertedID))
        //             {
        //                 personID = insertedID;
        //             }
        //         }
        //         catch (OdbcException ex)
        //         {
        //             Console.WriteLine("SQL Error in AddNewPerson: " + ex.Message);
        //             personID = -1;
        //         }
        //     }

        //     return personID;
        // }


        public static int AddNewPerson(
    string nationalNumber,
    string firstName,
    string middleName,
    string lastName,
    DateTime dateOfBirth,
    bool gender,
    string address,
    string phoneNumber,
    string email,
    string imagePath)
        {
            int personID = -1;

            const string sql = @"
        INSERT INTO ""People""
        (
            ""NationalNumber"",
            ""FirstName"",
            ""MiddleName"",
            ""LastName"",
            ""DateOfBirth"",
            ""Gender"",
            ""Address"",
            ""PhoneNumber"",
            ""Email"",
            ""ImagePath""
        )
        VALUES
        (
            ?, ?, ?, ?, ?, ?, ?, ?, ?, ?
        )
        RETURNING ""PersonID"";";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(sql, connection))
            {
                // ODBC يعتمد على الترتيب، مش أسماء البارامترات
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName",
                    string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address",
                    string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Email",
                    string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                command.Parameters.AddWithValue("@ImagePath",
                    string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        personID = insertedID;
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("SQL Error in AddNewPerson: " + ex.Message);
                    personID = -1;
                }
            }

            return personID;
        }

        public static bool GetPersonInfoByNationalNumber(string nationalNumber,ref int personID,ref string firstName,ref string middleName,ref
          string lastName,ref DateTime dateOfBirth,ref bool gender,ref string address,ref string phoneNumber,ref string email,ref string imagePath)
        {
            bool isFound = false;

            const string query = @"SELECT * FROM ""People"" WHERE ""NationalNumber"" = @NationalNumber;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            personID = (int)reader["PersonID"];
                            firstName = reader["FirstName"] as string;
                            middleName = reader["MiddleName"] as string ?? string.Empty;
                            lastName = reader["LastName"] as string;
                            nationalNumber = reader["NationalNumber"] as string;
                            dateOfBirth = (DateTime)reader["DateOfBirth"];
                            gender = reader["Gender"] != DBNull.Value &&
                                             (bool)reader["Gender"];
                            address = reader["Address"] as string ?? string.Empty;
                            phoneNumber = reader["PhoneNumber"] as string;
                            email = reader["Email"] as string ?? string.Empty;
                            imagePath = reader["ImagePath"] as string ?? string.Empty;
                        }
                    }
                }
                catch
                {
                    isFound = false;
                }
            }

            return isFound;
        }

        public static bool UpdatePerson(int personID,string nationalNumber,string firstName,string middleName,string lastName,
            DateTime dateOfBirth,bool gender,string address,string phoneNumber,string email,string imagePath)
        {
            int affectedRows = 0;

            const string query = @"
                UPDATE ""People"" SET
                    ""NationalNumber"" = ?,
                    ""FirstName""      = ?,
                    ""MiddleName""     = ?,
                    ""LastName""       = ?,
                    ""DateOfBirth""    = ?,
                    ""Gender""         = ?,
                    ""Address""        = ?,
                    ""PhoneNumber""    = ?,
                    ""Email""          = ?,
                    ""ImagePath""      = ?
                WHERE ""PersonID"" = ?;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName",
                string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address",
                string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Email",
                string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                command.Parameters.AddWithValue("@ImagePath",
                string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
                catch
                {
                    affectedRows = 0;
                }
            }

            return (affectedRows > 0);
        }

        public static bool DeletePerson(int personID)
        {
            int affectedRows = 0;

            string query = @"DELETE FROM ""People"" WHERE ""PersonID"" = ?;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
                catch(OdbcException ex)
                {
                    affectedRows = 0;
                }
            }

            return (affectedRows > 0);
        }

        public static bool IsPersonExist(int personID)
        {
            bool exists = false;

            const string query = @"SELECT 1 FROM ""People"" WHERE ""PersonID"" = @PersonID;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        exists = reader.HasRows;
                    }
                }
                catch
                {
                    exists = false;
                }
            }

            return exists;
        }

        public static bool IsPersonExistByNationalNumber(string nationalNumber)
        {
            bool exists = false;

            const string query = @"SELECT 1 FROM ""People"" WHERE ""NationalNumber"" = @PersonID;";

            using (var connection = _GetConnection())
            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        exists = reader.HasRows;
                    }
                }
                catch
                {
                    exists = false;
                }
            }

            return exists;
        }


    }
}