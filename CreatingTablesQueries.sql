CREATE TABLE Persons 
(
    PersonID       SERIAL          PRIMARY KEY,
    FirstName      VARCHAR(50)     NOT NULL,
    MiddleName     VARCHAR(50),
    LastName       VARCHAR(50)     NOT NULL,
    PhoneNumber    VARCHAR(20)     NOT NULL,
    Email          VARCHAR(70),
    DateOfBirth    DATE 			   NOT NULL,
    Address        VARCHAR(200),
    NationalNumber VARCHAR(20)     UNIQUE NOT NULL,   
    Gender         BOOLEAN		    NOT NULL,
    ImagePath      TEXT
);

CREATE TABLE "Employees" 
(
    "EmployeeID"        SERIAL          PRIMARY KEY,
    "PersonID"          INTEGER,
    "Salary"            NUMERIC(10,4)   NOT NULL,
    "YearsOfExperience" SMALLINT,
    "HireDate"          DATE            NOT NULL,
    "TerminationDate"   DATE,
    "EmploymentStatus"  SMALLINT        NOT NULL,
    "Notes"             VARCHAR(150),

    CONSTRAINT "fkEmployeePersonID"
        FOREIGN KEY ("PersonID")
        REFERENCES "Persons"("PersonID")
);



CREATE TABLE "LabTechnicians"
(
    "LabTechnicianID"   SERIAL       PRIMARY KEY,
    "EmployeeID"        INTEGER      NOT NULL,
    "LabLicenseNumber"  VARCHAR(30)  UNIQUE NOT NULL,
    "CreatedByAdminID"  INTEGER      NOT NULL,
    "CreatedDate"       DATE         NOT NULL,
    "IsActive"          BOOLEAN      NOT NULL,

    CONSTRAINT "fkLabTechnicianEmployee"
        FOREIGN KEY ("EmployeeID")
        REFERENCES "Employees"("EmployeeID"),

    CONSTRAINT "fkLabTechnicianCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Employees"("EmployeeID")
);


CREATE TABLE "Cleaners"
(
    "CleanerID"        SERIAL      PRIMARY KEY,
    "EmployeeID"       INTEGER     NOT NULL,
    "CreatedDate"      DATE        NOT NULL,
    "CreatedByAdminID" INTEGER     NOT NULL,
    "IsActive"         BOOLEAN     NOT NULL,

    CONSTRAINT "fkCleanerEmployee"
        FOREIGN KEY ("EmployeeID")
        REFERENCES "Employees"("EmployeeID"),

    CONSTRAINT "fkCleanerCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Employees"("EmployeeID")
);


CREATE TABLE "Nurses"
(
    "NurseID"            SERIAL       PRIMARY KEY,
    "EmployeeID"         INTEGER      NOT NULL,
    "NurseLicenseNumber" VARCHAR(30)  UNIQUE NOT NULL,
    "CreatedByAdminID"   INTEGER      NOT NULL,
    "CreatedDate"        DATE         NOT NULL,
    "IsActive"           BOOLEAN      NOT NULL,

    CONSTRAINT "fkNurseEmployee"
        FOREIGN KEY ("EmployeeID")
        REFERENCES "Employees"("EmployeeID"),

    CONSTRAINT "fkNurseCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Employees"("EmployeeID")
);


CREATE TABLE "Administrators"
(
    "AdminID"          SERIAL        PRIMARY KEY,
    "EmployeeID"       INTEGER       NOT NULL,
    "AdminName"        VARCHAR(50)   NOT NULL,
    "PasswordHash"     VARCHAR(64)   NOT NULL,
    "CreatedByAdminID" INTEGER       NOT NULL ,   
    "CreatedDate"      DATE          NOT NULL,
    "IsActive"         BOOLEAN       NOT NULL,

    CONSTRAINT "fkAdminEmployee"
        FOREIGN KEY ("EmployeeID")
        REFERENCES "Employees"("EmployeeID"),

    CONSTRAINT "fkAdminCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);


CREATE TABLE "SystemSettings"
(
    "SettingID"        SERIAL        PRIMARY KEY,
    "Setting"          VARCHAR(50)   NOT NULL,
    "Value"            VARCHAR(150)  NOT NULL,
    "Description"      VARCHAR(150),
    "CreatedByAdminID" INTEGER       NOT NULL,

    CONSTRAINT "fkSystemSettingsCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);


CREATE TABLE "AuditLogs"
(
    "AuditLogID"       SERIAL        PRIMARY KEY,
    "Action"           VARCHAR(50)   NOT NULL,
    "TableName"        VARCHAR(20)   NOT NULL,
    "RecordID"         INTEGER       NOT NULL,
    "NewData"          VARCHAR(150),
    "OldData"          VARCHAR(150),
    "CreatedByAdminID" INTEGER       NOT NULL,
    "Description"      VARCHAR(150),
    "LoggedDate"       DATE          NOT NULL,

    CONSTRAINT "fkAuditLogsCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);


CREATE TABLE "MedicalSpecialties"
(
    "MedicalSpecialtyID" SERIAL        PRIMARY KEY,
    "SpecialtyName"      VARCHAR(50)   NOT NULL,
    "Code"               VARCHAR(15)   NOT NULL,
    "AppointmentFee"     NUMERIC(10,4) NOT NULL,
    "IsActive"           BOOLEAN       NOT NULL
);


CREATE TABLE "Doctors"
(
    "DoctorID"            SERIAL        PRIMARY KEY,
    "EmployeeID"          INTEGER       NOT NULL,
    "MedicalSpecialtyID"  INTEGER       NOT NULL,
    "DoctorLicenseNumber" VARCHAR(30)   UNIQUE NOT NULL,
    "CreatedByAdminID"    INTEGER       NOT NULL,
    "CreatedDate"         DATE          NOT NULL,
    "IsActive"            BOOLEAN       NOT NULL,

    CONSTRAINT "fkDoctorEmployee"
        FOREIGN KEY ("EmployeeID")
        REFERENCES "Employees"("EmployeeID"),

    CONSTRAINT "fkDoctorMedicalSpecialty"
        FOREIGN KEY ("MedicalSpecialtyID")
        REFERENCES "MedicalSpecialties"("MedicalSpecialtyID"),

    CONSTRAINT "fkDoctorCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);



CREATE TABLE "DoctorDailySchedules"
(
    "ScheduleID"        SERIAL        PRIMARY KEY,
    "DoctorID"          INTEGER       NOT NULL,
    "DayOfWeek"         VARCHAR(10)   NOT NULL,
    "WorkingStartTime"  TIME          NOT NULL,
    "WorkingEndTime"    TIME          NOT NULL,
    "CreatedByAdminID"  INTEGER       NOT NULL,
    "CreatedDate"       DATE          NOT NULL,
    "IsActive"          BOOLEAN       NOT NULL,

    CONSTRAINT "fkScheduleDoctor"
        FOREIGN KEY ("DoctorID")
        REFERENCES "Doctors"("DoctorID"),

    CONSTRAINT "fkScheduleCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);


CREATE TABLE "AppointmentTypes"
(
    "AppointmentTypeID"   SERIAL        PRIMARY KEY,
    "AppointmentTypeTitle" VARCHAR(50)  NOT NULL,
    "Description"         VARCHAR(150),
    "BaseFee"             NUMERIC(10,4) NOT NULL
);



CREATE TABLE "Patients"
(
    "PatientID"         SERIAL        PRIMARY KEY,
    "Allergies"         VARCHAR(150),
    "BloodType"         VARCHAR(3),
    "PersonID"          INTEGER       NOT NULL,
    "CreatedByAdminID"  INTEGER       NOT NULL,
    "CreatedDate"       DATE          NOT NULL,
    "IsActive"          BOOLEAN       NOT NULL,
    "Notes"             VARCHAR(150),

    CONSTRAINT "fkPatientPerson"
        FOREIGN KEY ("PersonID")
        REFERENCES "Persons"("PersonID"),

    CONSTRAINT "fkPatientCreatedByAdmin"
        FOREIGN KEY ("CreatedByAdminID")
        REFERENCES "Administrators"("AdminID")
);



CREATE TABLE "Appointments"
(
    "AppointmentID"       SERIAL        PRIMARY KEY,
    "AppointmentStatus"   SMALLINT      NOT NULL,
    "AppointmentDateTime" DATE          NOT NULL,
    "PatientID"           INTEGER       NOT NULL,
    "DoctorID"            INTEGER       NOT NULL,
    "AppointmentTypeID"   INTEGER       NOT NULL,
    "AmountsDue"          NUMERIC(10,4) NOT NULL,
    "CreatedDate"         DATE          NOT NULL,

    CONSTRAINT "fkAppointmentPatient"
        FOREIGN KEY ("PatientID")
        REFERENCES "Patients"("PatientID"),

    CONSTRAINT "fkAppointmentDoctor"
        FOREIGN KEY ("DoctorID")
        REFERENCES "Doctors"("DoctorID"),

    CONSTRAINT "fkAppointmentType"
        FOREIGN KEY ("AppointmentTypeID")
        REFERENCES "AppointmentTypes"("AppointmentTypeID")
);



CREATE TABLE "MedicalRecords"
(
    "MedicalRecordID"  SERIAL        PRIMARY KEY,
    "DoctorID"         INTEGER       NOT NULL,
    "AppointmentID"    INTEGER       NOT NULL,
    "PatientID"        INTEGER       NOT NULL,
    "Diagnosis"        VARCHAR(150),
    "VisitSummary"     VARCHAR(150),

    CONSTRAINT "fkMedicalRecordDoctor"
        FOREIGN KEY ("DoctorID")
        REFERENCES "Doctors"("DoctorID"),

    CONSTRAINT "fkMedicalRecordAppointment"
        FOREIGN KEY ("AppointmentID")
        REFERENCES "Appointments"("AppointmentID"),

    CONSTRAINT "fkMedicalRecordPatient"
        FOREIGN KEY ("PatientID")
        REFERENCES "Patients"("PatientID")
);


CREATE TABLE "Prescriptions"
(
    "PrescriptionID"   SERIAL        PRIMARY KEY,
    "Notes"            VARCHAR(150),
    "MedicalRecordID"  INTEGER       NOT NULL,
    "PatientID"        INTEGER       NOT NULL,
    "DoctorID"         INTEGER       NOT NULL,
    "CreatedDate"      DATE          NOT NULL,
    "IsActive"         BOOLEAN       NOT NULL,

    CONSTRAINT "fkPrescriptionMedicalRecord"
        FOREIGN KEY ("MedicalRecordID")
        REFERENCES "MedicalRecords"("MedicalRecordID"),

    CONSTRAINT "fkPrescriptionPatient"
        FOREIGN KEY ("PatientID")
        REFERENCES "Patients"("PatientID"),

    CONSTRAINT "fkPrescriptionDoctor"
        FOREIGN KEY ("DoctorID")
        REFERENCES "Doctors"("DoctorID")
);


CREATE TABLE "PaymentMethods"
(
    "PaymentMethodID" SERIAL        PRIMARY KEY,
    "MethodName"      VARCHAR(50)   NOT NULL,
    "Description"     VARCHAR(150),
    "IsActive"        BOOLEAN       NOT NULL
);


CREATE TABLE "Payments"
(
    "PaymentID"        SERIAL        PRIMARY KEY,
    "AppointmentID"    INTEGER       NOT NULL,
    "PaidTotalAmount"  NUMERIC(10,4) NOT NULL,
    "ReferenceNumber"  TEXT,
    "PaymentMethodID"  INTEGER       NOT NULL,
    "PaymentDate"      DATE          NOT NULL,

    CONSTRAINT "fkPaymentAppointment"
        FOREIGN KEY ("AppointmentID")
        REFERENCES "Appointments"("AppointmentID"),

    CONSTRAINT "fkPaymentMethod"
        FOREIGN KEY ("PaymentMethodID")
        REFERENCES "PaymentMethods"("PaymentMethodID")
);


CREATE TABLE "PrescriptionItems"
(
    "PrescriptionItemID" SERIAL       PRIMARY KEY,
    "PrescriptionID"     INTEGER      NOT NULL,
    "MedicationName"     VARCHAR(50)  NOT NULL,
    "Dosage"             VARCHAR(50),
    "Frequency"          VARCHAR(50),
    "StartDate"          DATE,
    "EndDate"            DATE,

    CONSTRAINT "fkPrescriptionItemPrescription"
        FOREIGN KEY ("PrescriptionID")
        REFERENCES "Prescriptions"("PrescriptionID")
);



CREATE TABLE "TestTypes"
(
    "TestTypeID"   SERIAL        PRIMARY KEY,
    "TypeName"     VARCHAR(50)   NOT NULL,
    "Description"  VARCHAR(150),
    "StandardCost" NUMERIC(10,4) NOT NULL
);



CREATE TABLE "MedicalTests"
(
    "TestID"          SERIAL        PRIMARY KEY,
    "AppointmentID"   INTEGER       NOT NULL,
    "TestTypeID"      INTEGER       NOT NULL,
    "LabTechnicianID" INTEGER       NOT NULL,
    "ResultSummary"   VARCHAR(150),
    "IsCompleted"     BOOLEAN       NOT NULL,
    "OrderedDate"     DATE          NOT NULL,

    CONSTRAINT "fkMedicalTestAppointment"
        FOREIGN KEY ("AppointmentID")
        REFERENCES "Appointments"("AppointmentID"),

    CONSTRAINT "fkMedicalTestType"
        FOREIGN KEY ("TestTypeID")
        REFERENCES "TestTypes"("TestTypeID"),

    CONSTRAINT "fkMedicalTestLabTechnician"
        FOREIGN KEY ("LabTechnicianID")
        REFERENCES "LabTechnicians"("LabTechnicianID")
);
