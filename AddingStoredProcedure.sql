
CREATE OR REPLACE PROCEDURE "SP_AddPerson" 
(
    IN _FirstName VARCHAR(50),
    IN _LastName VARCHAR ,
    IN _PhoneNumber VARCHAR(20),
    IN _DateOfBirth DATE,
    IN _NationalNumber VARCHAR(20),
    IN _Gender BOOLEAN,    
    IN _Email VARCHAR(70) DEFAULT NULL,
    IN _MiddleName VARCHAR(50) DEFAULT NULL,
    IN _Address VARCHAR(200) DEFAULT NULL,
    IN _ImagePath TEXT DEFAULT NULL,
    INOUT _NewPersonID INT DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO "People" (
        "FirstName",
        "MiddleName",
        "LastName",
        "PhoneNumber",
        "Email",
        "DateOfBirth",
        "Address",
        "NationalNumber",
        "Gender",
        "ImagePath"
    )
    VALUES (
        _FirstName,
        _MiddleName,
        _LastName,
        _PhoneNumber,
        _Email,
        _DateOfBirth,
        _Address,
        _NationalNumber,
        _Gender,
        _ImagePath
    )
    RETURNING "PersonID" INTO _NewPersonID; 
END;
$$;


CALL "SP_AddPerson"(
    'John',           
    'Doe',            
    '555-0199',       
    DATE '1990-01-01',
    'N123456',        
    TRUE,             
    'john@test.com',  
    'A.',             
    '123 Main St',    
    NULL,             
    NULL              
);

----------------

CREATE OR REPLACE PROCEDURE "SP_AddAuditLog"

    IN _Action           VARCHAR(50), 
    IN _TableName        VARCHAR(100),  
    IN _RecordID         INTEGER,       
    IN _NewData          TEXT,          
    IN _OldData          TEXT,          
    IN _CreatedByAdminID INTEGER,       
    IN _Description      TEXT DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO "AuditLogs"
    (
        "Action",
        "TableName",
        "RecordID",
        "NewData",
        "OldData",
        "CreatedByAdminID",
        "Description",
        "LoggedDate"
    )
    VALUES
    (
        _Action,
        _TableName,
        _RecordID,
        _NewData,
        _OldData,
        _CreatedByAdminID,
        _Description,
        NOW()
    );
END;
$$;

------------------------

CALL "SP_AddPerson"(
    'Koko',           -- FirstName
    'le',            -- LastName
    '555-01992',       -- PhoneNumber
    DATE '1990-01-01',-- DateOfBirth
    'N1234567',        -- NationalNumber
    TRUE,             -- Gender
    'koko@test.com',  -- Email
    NULL,             -- MiddleName
    '123 Main St',    -- Address
    NULL,             -- ImagePath
    NULL              -- NewPersonID  INOUT
);

-----------------

CREATE OR REPLACE PROCEDURE "SP_AddEmployee"
(
    IN  _PersonID          INT,
    IN  _Salary            NUMERIC(10,4),
    IN  _YearsOfExperience SMALLINT      DEFAULT 0,
    IN  _HireDate          DATE          DEFAULT CURRENT_DATE,
    IN  _TerminationDate   DATE          DEFAULT NULL,
    IN  _EmploymentStatus  SMALLINT      DEFAULT 1,     
    IN  _Notes             VARCHAR(150)  DEFAULT NULL,
    INOUT _NewEmployeeID   INT           DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN  
   
 IF NOT EXISTS (
        SELECT 1 FROM "Persons" WHERE "PersonID" = _PersonID
    ) THEN
        RAISE EXCEPTION 'Person with ID % does not exist', _PersonID;
    END IF;

    INSERT INTO "Employees"
    (
        "PersonID",
        "Salary",
        "YearsOfExperience",
        "HireDate",
        "TerminationDate",
        "EmploymentStatus",
        "Notes"
    )
    VALUES
    (
        _PersonID,
        _Salary,
        _YearsOfExperience,
        _HireDate,
        _TerminationDate,
        _EmploymentStatus,
        _Notes
    )
    RETURNING "EmployeeID" INTO _NewEmployeeID;
END;
$$;

CALL "SP_AddEmployee"
(
    9,                 
    25000.0000,        
    3::smallint,       
    CURRENT_DATE,      
    NULL::date,        
    1::smallint,       
    'Full-time nurse', 
    NULL::int          
)

select * from "People" where "PersonID" = 2;
select * from "Employees" where "PersonID" = 2;

select * from "Doctors" where "PersonID" = 2;
-------------------
CREATE OR REPLACE PROCEDURE "SP_AddDoctor"
(
    IN  _EmployeeID          INT,
    IN  _MedicalSpecialtyID  INT,
    IN  _DoctorLicenseNumber VARCHAR(50),
    IN  _CreatedByAdminID    INT,
    IN  _IsActive            BOOLEAN      DEFAULT TRUE,
    INOUT _NewDoctorID       INT          DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
    -- Check Employee exists
    IF NOT EXISTS (
        SELECT 1 FROM "Employees" WHERE "EmployeeID" = _EmployeeID
    ) THEN
        RAISE EXCEPTION 'Employee with ID % does not exist', _EmployeeID;
    END IF;

    -- Check MedicalSpecialty exists
    IF NOT EXISTS (
        SELECT 1 FROM "MedicalSpecialties" WHERE "MedicalSpecialtyID" = _MedicalSpecialtyID
    ) THEN
        RAISE EXCEPTION 'MedicalSpecialty with ID % does not exist', _MedicalSpecialtyID;
    END IF;

    -- Optional: check Admin exists
    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "Doctors"
    (
        "EmployeeID",
        "MedicalSpecialtyID",
        "DoctorLicenseNumber",
        "CreatedByAdminID",
        "CreatedDate",
        "IsActive"
    )
    VALUES
    (
        _EmployeeID,
        _MedicalSpecialtyID,
        _DoctorLicenseNumber,
        _CreatedByAdminID,
        CURRENT_TIMESTAMP,
        _IsActive
    )
    RETURNING "DoctorID" INTO _NewDoctorID;
END;
$$;

------------------


CALL "SP_AddPerson"
(
'Luna',
'lala',
'0500000008',
DATE '2005-10-02',
'N11',
FALSE,
NULL,
NULL,
'sakarya',
NULL,
NULL
);

select * from "People" where "PersonID" = '12';

CALL "SP_AddEmployee"
(
    9,                 
    25000.0000,        
    3::smallint,       
    CURRENT_DATE,      
    NULL::date,        
    1::smallint,       
    'Full-time nurse', 
    NULL::int          
);

CALL "SP_AddEmployee"(
14,
110000,
2::smallint,
CURRENT_DATE,
NULL::date,
1::smallint,
'Doctor',
NULL::int
)
select * from "Doctors"
select * from "Employees"

cALL "SP_AddDoctor"(13,2,'LIC-CARD-003',1,TRUE,NULL::int);
-----------------

CREATE OR REPLACE PROCEDURE "SP_AddAdministrator"
(
    IN  _EmployeeID       INT,
    IN  _AdminName        VARCHAR(50),
    IN  _PasswordHash     VARCHAR(64),
    IN  _CreatedByAdminID INT,
    IN  _IsActive         BOOLEAN      DEFAULT TRUE,
    INOUT _NewAdminID     INT          DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
    -- Check Employee exists
    IF NOT EXISTS (
        SELECT 1 FROM "Employees" WHERE "EmployeeID" = _EmployeeID
    ) THEN
        RAISE EXCEPTION 'Employee with ID % does not exist', _EmployeeID;
    END IF;

    -- Optional: check Admin exists (creator)
    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "Administrators"
    (
        "EmployeeID",
        "AdminName",
        "PasswordHash",
        "CreatedByAdminID",
        "CreatedDate",
        "IsActive"
    )
    VALUES
    (
        _EmployeeID,
        _AdminName,
        _PasswordHash,
        _CreatedByAdminID,
        CURRENT_TIMESTAMP,
        _IsActive
    )
    RETURNING "AdminID" INTO _NewAdminID;
END;
$$;

CREATE OR REPLACE PROCEDURE "SP_AddCleaner"
(
    IN  _EmployeeID       INT,
    IN  _CreatedByAdminID INT,
    IN  _IsActive         BOOLEAN    DEFAULT TRUE,
    INOUT _NewCleanerID   INT        DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
    -- Check Employee exists
    IF NOT EXISTS (
        SELECT 1 FROM "Employees" WHERE "EmployeeID" = _EmployeeID
    ) THEN
        RAISE EXCEPTION 'Employee with ID % does not exist', _EmployeeID;
    END IF;

    -- Optional: check Admin exists
    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "Cleaners"
    (
        "EmployeeID",
        "CreatedDate",
        "CreatedByAdminID",
        "IsActive"
    )
    VALUES
    (
        _EmployeeID,
        CURRENT_TIMESTAMP,
        _CreatedByAdminID,
        _IsActive
    )
    RETURNING "CleanerID" INTO _NewCleanerID;
END;
$$;

-------

CREATE OR REPLACE PROCEDURE "SP_AddNurse"
(
    IN  _EmployeeID         INT,
    IN  _NurseLicenseNumber VARCHAR(30),
    IN  _CreatedByAdminID   INT,
    IN  _IsActive           BOOLEAN     DEFAULT TRUE,
    INOUT _NewNurseID       INT         DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
  
    IF NOT EXISTS (
        SELECT 1 FROM "Employees" WHERE "EmployeeID" = _EmployeeID
    ) THEN
        RAISE EXCEPTION 'Employee with ID % does not exist', _EmployeeID;
    END IF;

    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "Nurses"
    (
        "EmployeeID",
        "NurseLicenseNumber",
        "CreatedByAdminID",
        "CreatedDate",
        "IsActive"
    )
    VALUES
    (
        _EmployeeID,
        _NurseLicenseNumber,
        _CreatedByAdminID,
        CURRENT_TIMESTAMP,
        _IsActive
    )
    RETURNING "NurseID" INTO _NewNurseID;
END;
$$;

-----------------------
CREATE OR REPLACE PROCEDURE "SP_AddPatient"
(
    IN  _PersonID         INT,
    IN  _CreatedByAdminID INT,
    IN  _BloodType        VARCHAR(3)  DEFAULT NULL,
    IN  _Allergies        VARCHAR(150)        DEFAULT NULL,
    IN  _Notes            VARCHAR(150)        DEFAULT NULL,
	IN _CreatedDate       DATE DEFAULT NOW(),
    IN  _IsActive         BOOLEAN     DEFAULT TRUE,
    INOUT _NewPatientID   INT         DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
   
    IF NOT EXISTS (
        SELECT 1 FROM "Persons" WHERE "PersonID" = _PersonID
    ) THEN
        RAISE EXCEPTION 'Person with ID % does not exist', _PersonID;
    END IF;

 
    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "Patients"
    (
        "PersonID",
        "Allergies",
        "BloodType",
        "CreatedByAdminID",
        "CreatedDate",
        "IsActive",
        "Notes"
    )
    VALUES
    (
        _PersonID,
        _Allergies,
        _BloodType,
        _CreatedByAdminID,
        NOW(),
        _IsActive,
        _Notes
    )
    RETURNING "PatientID" INTO _NewPatientID;
END;
$$;

-----------------

CREATE OR REPLACE PROCEDURE "SP_AddAppointment"
(
    IN  _PatientID          INT,
    IN  _DoctorID           INT,
    IN  _AppointmentTypeID  INT,
    IN  _AppointmentDateTime TIMESTAMP,
    IN  _AppointmentStatus  SMALLINT      DEFAULT 0,      
    IN  _AmountsDue         NUMERIC(10,2) DEFAULT 0,
    INOUT _NewAppointmentID INT           DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN

    IF NOT EXISTS (
        SELECT 1 FROM "Patients" WHERE "PatientID" = _PatientID
    ) THEN
        RAISE EXCEPTION 'Patient with ID % does not exist', _PatientID;
    END IF;

   
    IF NOT EXISTS (
        SELECT 1 FROM "Doctors" WHERE "DoctorID" = _DoctorID
    ) THEN
        RAISE EXCEPTION 'Doctor with ID % does not exist', _DoctorID;
    END IF;

  
    IF NOT EXISTS (
        SELECT 1 FROM "AppointmentTypes" WHERE "AppointmentTypeID" = _AppointmentTypeID
    ) THEN
        RAISE EXCEPTION 'AppointmentType with ID % does not exist', _AppointmentTypeID;
    END IF;

    

    INSERT INTO "Appointments"
    (
        "AppointmentStatus",
        "AppointmentDateTime",
        "PatientID",
        "DoctorID",
        "AppointmentTypeID",
        "AmountsDue",
        "CreatedDate"
    )
    VALUES
    (
        _AppointmentStatus,
        _AppointmentDateTime,
        _PatientID,
        _DoctorID,
        _AppointmentTypeID,
        _AmountsDue,
        CURRENT_TIMESTAMP
    )
    RETURNING "AppointmentID" INTO _NewAppointmentID;
END;
$$;

-------------
CREATE OR REPLACE PROCEDURE "SP_AddAuditLog"
(
    IN  _Action           VARCHAR(50),   
    IN  _TableName        VARCHAR(20),     
    IN  _RecordID         INT,             
    IN  _NewData          TEXT    DEFAULT NULL, 
    IN  _OldData          TEXT    DEFAULT NULL,  
    IN  _CreatedByAdminID INT     DEFAULT NULL, 
    IN  _Description      TEXT    DEFAULT NULL,
    INOUT _NewAuditLogID  INT     DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN
   
    IF _CreatedByAdminID IS NOT NULL AND NOT EXISTS (
        SELECT 1 FROM "Administrators"
        WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

    INSERT INTO "AuditLogs"
    (
        "Action",
        "TableName",
        "RecordID",
        "NewData",
        "OldData",
        "CreatedByAdminID",
        "Description",
        "LoggedDate"
    )
    VALUES
    (
        _Action,
        _TableName,
        _RecordID,
        _NewData,
        _OldData,
        _CreatedByAdminID,
        _Description,
        CURRENT_TIMESTAMP
    )
    RETURNING "AuditLogID" INTO _NewAuditLogID;
END;
$$;

----------

CREATE OR REPLACE PROCEDURE "SP_AddLabTechnician"
(
    IN  _EmployeeID        INT,
    IN  _LabLicenseNumber  VARCHAR(30),
    IN  _CreatedByAdminID  INT,
    IN  _IsActive          BOOLEAN     DEFAULT TRUE,
    INOUT _NewLabTechnicianID INT      DEFAULT NULL
)
LANGUAGE plpgsql
AS $$
BEGIN

    IF NOT EXISTS (
        SELECT 1 FROM "Employees" WHERE "EmployeeID" = _EmployeeID
    ) THEN
        RAISE EXCEPTION 'Employee with ID % does not exist', _EmployeeID;
    END IF;

  
    IF NOT EXISTS (
        SELECT 1 FROM "Administrators" WHERE "AdminID" = _CreatedByAdminID
    ) THEN
        RAISE EXCEPTION 'Admin with ID % does not exist', _CreatedByAdminID;
    END IF;

  
    IF EXISTS (
        SELECT 1 FROM "LabTechnicians"
        WHERE "LabLicenseNumber" = _LabLicenseNumber
    ) THEN
        RAISE EXCEPTION 'LabLicenseNumber % already exists', _LabLicenseNumber;
    END IF;

    INSERT INTO "LabTechnicians"
    (
        "EmployeeID",
        "LabLicenseNumber",
        "CreatedByAdminID",
        "CreatedDate",
        "IsActive"
    )
    VALUES
    (
        _EmployeeID,
        _LabLicenseNumber,
        _CreatedByAdminID,
        NOW(),
        _IsActive
    )
    RETURNING "LabTechnicianID" INTO _NewLabTechnicianID;
END;
$$;


