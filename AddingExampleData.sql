INSERT INTO "Persons"
    ("FirstName","MiddleName","LastName","PhoneNumber","Email",
     "DateOfBirth","Address","NationalNumber","Gender","ImagePath")
VALUES
    ('Omar',   'Hamza', 'Hassan',  '0538000001', 'omar.hassan@example.com',
     DATE '1990-01-10', 'Istanbul - Fatih',       'N1', TRUE,  'C:\Users\ahmed\OneDrive\Desktop\me.jpg'),
    ('Sara',   NULL, 'Ali',     '0538000002', 'sara.ali@example.com',
     DATE '1988-05-20', 'Istanbul - Kadikoy',     'N2', FALSE, NULL),
    ('Mahmoud',NULL, 'Saleh',   '0538000003', 'mahmoud.saleh@example.com',
     DATE '1992-03-15', 'Ankara',                'N3', TRUE,  NULL),
    ('Lina',   'Omar', 'Khalid',  '0538000004', 'lina.khalid@example.com',
     DATE '1994-09-01', 'Izmir',                 'N4', FALSE, NULL),
    ('Khaled', NULL, 'Yousef',  '0538000005', 'khaled.yousef@example.com',
     DATE '1985-12-05', 'Istanbul - Basaksehir', 'N5', TRUE,  NULL),
    ('Mariam', 'Husyen', 'Ahmad',   '0538000006', NULL,
     DATE '2000-07-18', 'Istanbul - Esenyurt',    'N6', FALSE, NULL),
    ('Yousef', NULL, 'Ibrahim', '0538000007', 'yousef.ibrahim@example.com',
     DATE '1998-11-11', 'Bursa',                 'N7', TRUE,  NULL),
    ('Fatima', 'Omar', 'Nazli',    '0538000008', 'fatima.Nazli@example.com',
     DATE '1991-04-22', 'Istanbul - Sisli',       'N8', FALSE, 'C:\Users\ahmed\OneDrive\Desktop\me.jpg'); 

	 select * from "Persons";

	 UPDATE "Persons" set "NationalNumber" = 'N0'
	 WHERE "PersonID" = 1;

--------------------------------
	 INSERT INTO "Employees"
    ("PersonID","Salary","YearsOfExperience","HireDate",
     "TerminationDate","EmploymentStatus","Notes")
	VALUES
    (1, 12000.0000, 5, DATE '2020-01-01', NULL, 1, 'System administrator'),
    (2, 15000.0000, 7, DATE '2018-03-10', NULL, 1, 'Doctor'),
    (3,  9000.0000, 3, DATE '2021-06-15', NULL, 1, 'Nurse'),
    (4,  9500.0000, 4, DATE '2019-09-01', NULL, 1, 'Lab technician'),
    (5,  6000.0000, 8, DATE '2016-02-20', '2020-05-09', 3, 'Cleaner'),
	(6, 11000.0000, 6, DATE '2019-01-05', NULL, 1, 'Doctor'),
    (7, 7000.000, 6, DATE '2025-03-01', NULL, 1, 'Nurse');
-------------------------------

INSERT INTO "MedicalSpecialties"
    ("SpecialtyName","Code","AppointmentFee","IsActive")
VALUES
	('Cardiology',   'CARD', 300.0000, TRUE),
    ('Pediatrics',   'PED',  250.0000, TRUE),
    ('Internal Med', 'INT',  220.0000, TRUE),
    ('General Practice',     'GP',    180.0000, TRUE),
    ('Dermatology',          'DERM',  220.0000, TRUE),
    ('Orthopedics',          'ORTH',  260.0000, FALSE),
    ('Neurology',            'NEUR',  280.0000, TRUE),
    ('Ophthalmology',        'OPHT',  240.0000, TRUE),
    ('Ear Nose Throat',      'ENT',   230.0000, TRUE),
    ('Gynecology',           'GYN',   250.0000, TRUE),
    ('Psychiatry',           'PSY',   270.0000, FALSE),
    ('Radiology',            'RAD',   260.0000, TRUE),
    ('Emergency Medicine',   'ER',    300.0000, TRUE);

------------------------------

INSERT INTO "Administrators"
    ("EmployeeID","AdminName","PasswordHash",
     "CreatedByAdminID","CreatedDate","IsActive")
VALUES
   
    (1, 'Ahmed',     '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1, DATE '2020-01-01', TRUE),
    (6, 'koko',        '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1,    DATE '2021-05-10', FALSE);
-------------------------------

INSERT INTO "SystemSettings"
    ("Setting","Value","Description","CreatedByAdminID")
VALUES
    ('ClinicName',        'MediTrack Clinic',  'Name shown in the system',          1),
    ('Working Hours',    '12',                'per day',    1),
    ('DefaultCity',       'Istanbul',          'Default city for addresses',        2);

-------------------------------

INSERT INTO "Doctors"
    ("EmployeeID","MedicalSpecialtyID","DoctorLicenseNumber",
     "CreatedByAdminID","CreatedDate","IsActive")
VALUES
    (2, 1, 'LIC-CARD-001', 1, NOW(), TRUE),
	(6, 2, 'LIC-CARD-002', 1, NOW(), TRUE);

	select * from "Doctors"

	--------------
	INSERT INTO "Nurses"
    ("EmployeeID","NurseLicenseNumber",
     "CreatedByAdminID","CreatedDate","IsActive")
VALUES
    (3, 'NUR-1001', 1, DATE '2021-06-15', TRUE),
	(7, 'NUR-1002', 1, DATE '2025-03-01', TRUE)
	----
	INSERT INTO "LabTechnicians"
    ("EmployeeID","LabLicenseNumber",
     "CreatedByAdminID","CreatedDate","IsActive")
VALUES
    (4, 'LAB-2001', 1, DATE '2019-09-01', TRUE);


-----------------------------
INSERT INTO "Cleaners"
    ("EmployeeID","CreatedDate","CreatedByAdminID","IsActive")
VALUES
    (5, DATE '2016-02-20', 1, TRUE);

	-------
	select * from "Doctors"
	INSERT INTO "DoctorDailySchedules"
    ("DoctorID","DayOfWeek","WorkingStartTime","WorkingEndTime",
     "CreatedByAdminID","CreatedDate","IsActive")
VALUES
  
	(2, 'Friday', TIME '09:00', TIME '17:00', 1, NOW(), TRUE),
	(1, 'Thursday', TIME '09:00', TIME '17:00', 1, NOW(), TRUE);
------	
INSERT INTO "AppointmentTypes"
    ("AppointmentTypeTitle", "Description", "BaseFee")
VALUES
    ('Specialist Check',     'Detailed specialist checkup',  300.0000),
	('Lab Follow-up',        'Review of lab results',        150.0000),
    ('Follow-up Visit', 'Review appointment after a previous visit',0);
--------------------------
select* from "Employees"
------------------
	INSERT INTO "Patients"
    ("Allergies","BloodType","PersonID",
     "CreatedByAdminID","CreatedDate","IsActive","Notes")
VALUES
    ('Penicillin', 'A+', 8, 1, NOW(), TRUE,
     'Chronic diabetes patient'),
    (NULL,        'O-', 9, 1,  NOW(), TRUE,
     'Rare visitor, annual checkup only');
-------------------

INSERT INTO "Appointments"
    ("AppointmentStatus","AppointmentDateTime",
     "PatientID","DoctorID","AppointmentTypeID",
     "AmountsDue","CreatedDate")
VALUES
    (1, DATE '2025-01-10', 1, 1, 1, 200.0000, DATE '2024-12-20'),
    (2, DATE '2024-12-01', 2, 1, 2, 150.0000, DATE '2024-11-25'),
    (3, DATE '2024-11-15', 1, 1, 3, 300.0000, DATE '2024-11-10');
-------------------------------
	INSERT INTO "MedicalRecords"
    ("DoctorID","AppointmentID","PatientID",
     "Diagnosis","VisitSummary")
VALUES
    (1, 1, 1, 'High blood pressure',
     'Medication adjusted, follow-up in one month'),
    (1, 2, 2, 'All tests normal',
     'No treatment required, routine check in one year');
----------

INSERT INTO "Prescriptions"
    ("Notes","MedicalRecordID","PatientID","DoctorID",
     "CreatedDate","IsActive")
VALUES
    ('Blood pressure medication for 30 days', 1, 1, 1,
     DATE '2025-01-10', TRUE),
    ('Vitamins for 14 days',                  2, 2, 1,
     DATE '2024-12-01', TRUE);
------------------------
INSERT INTO "PrescriptionItems"
    ("PrescriptionID","MedicationName","Dosage","Frequency",
     "StartDate","EndDate")
VALUES
    (1, 'Atenolol',  '50 mg', 'Once daily',
     DATE '2025-01-10', DATE '2025-02-08'),
    (1, 'Aspirin',   '100 mg','Once daily',
     DATE '2025-01-10', DATE '2025-02-08'),
    (2, 'Vitamin D', '1000 IU','Once daily',
     DATE '2024-12-01', DATE '2024-12-14');
	 ------------------------

	 INSERT INTO "PaymentMethods"
    ("MethodName","Description","IsActive")
VALUES
    ('Cash',        'Cash payment at the clinic', TRUE),
    ('Credit Card', 'POS credit card payment',    TRUE),
    ('Online',      'Online payment gateway',     TRUE);

------------------------
INSERT INTO "Payments"
    ("AppointmentID","PaidTotalAmount","ReferenceNumber",
     "PaymentMethodID","PaymentDate")
VALUES
    (1, 200.0000, 'PAY-0001', 2, DATE '2024-12-20'),
    (2, 150.0000, 'PAY-0002', 1, DATE '2024-12-01');
------------------

	INSERT INTO "TestTypes"
    ("TypeName","Description","StandardCost")
VALUES
    ('Blood Test', 'Standard blood analysis', 100.0000),
    ('X-Ray',      'Standard chest X-ray',    180.0000),
	('COVID-19 PCR',          'PCR test for SARS-CoV-2',               200.0000),
	('Blood Sugar Test',      'Fasting or random blood glucose test',  90.0000);
---------------------------
INSERT INTO "MedicalTests"
    ("AppointmentID","TestTypeID","LabTechnicianID",
     "ResultSummary","IsCompleted","OrderedDate")
VALUES
    (1, 1, 1, 'High cholesterol, other values normal', TRUE,
     DATE '2025-01-10'),
    (2, 2, 1, 'No abnormal findings', TRUE,
     DATE '2024-12-01');
	
