CREATE OR REPLACE FUNCTION "TRG_Admins_Password_Update"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
   
    IF NEW."PasswordHash" IS DISTINCT FROM OLD."PasswordHash" THEN--değiştiyse
        
        INSERT INTO "Logs"
        (
            "Action",
            "TableName",
            "RecordID",
            "NewData",
            "OldData",        
            "Description",
            "LoggedDate"
        )
        VALUES
        (
            'UPDATE',              
            'Administrators',      
            NEW."AdminID",         
           NEW."PasswordHash",                  
            OLD."PasswordHash",                                      
            'Password changed',    
            CURRENT_TIMESTAMP      
        );
    END IF;

    RETURN NEW;
END;
$$;

CREATE TRIGGER "TRG_Administrators_Password_Update"
AFTER UPDATE OF "PasswordHash" ON "Administrators"
FOR EACH ROW
EXECUTE FUNCTION "TRG_Admins_Password_Update"();


select * from "Administrators"

UPDATE "Administrators"
SET "PasswordHash" = 'New_koko2233'
WHERE "AdminName" = 'koko';

select * from "Logs"

CREATE OR REPLACE FUNCTION "TRG_Appointments_Prevent_DoubleBooking"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
    IF EXISTS (
        SELECT 1 FROM "Appointments"
        WHERE "DoctorID" = NEW."DoctorID"
          AND "AppointmentDateTime" = NEW."AppointmentDateTime"
          AND "AppointmentID" <> COALESCE(NEW."AppointmentID", -1)
    ) THEN
        RAISE EXCEPTION 'Doctor already has an appointment at this time';
    END IF;

    RETURN NEW;
END;
$$;


CREATE TRIGGER "TRG_Appointments_NoDoubleBooking"
BEFORE INSERT OR UPDATE ON "Appointments"
FOR EACH ROW
EXECUTE FUNCTION "TRG_Appointments_Prevent_DoubleBooking"();


CREATE OR REPLACE FUNCTION "TRG_Doctors_SoftDelete"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
   
    IF OLD."IsActive" = TRUE THEN
        UPDATE "Doctors"
        SET "IsActive" = FALSE
        WHERE "DoctorID" = OLD."DoctorID";
    END IF;

    
    RETURN NULL;
END;
$$;

CREATE TRIGGER "TRG_Doctors_BeforeDelete_SoftDelete"
BEFORE DELETE ON "Doctors"
FOR EACH ROW
EXECUTE FUNCTION "TRG_Doctors_SoftDelete"();


CREATE OR REPLACE FUNCTION "TRG_TerminateEmployee"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
   
    UPDATE "Employees"
    SET 
        "TerminationDate"  = NOW(),  
        "EmploymentStatus" = 3                                         
    WHERE "EmployeeID" = OLD."EmployeeID";

  
    RETURN OLD;
END;
$$;

CREATE TRIGGER "TRG_Doctors_TerminateEmployee"
BEFORE DELETE ON "Doctors"
FOR EACH ROW
EXECUTE FUNCTION "TRG_TerminateEmployee"();

-------------------------

CREATE OR REPLACE FUNCTION "TRG_Doctors_SoftDeleteAndTerminate"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
    -- Doctor: soft delete
    UPDATE "Doctors"
    SET "IsActive" = FALSE
    WHERE "DoctorID" = OLD."DoctorID";

    -- Employee: set termination
    UPDATE "Employees"
    SET 
        "TerminationDate"  = COALESCE("TerminationDate", CURRENT_DATE),
        "EmploymentStatus" = 0
    WHERE "EmployeeID" = OLD."EmployeeID";

    -- cancel real DELETE
    RETURN NULL;
END;
$$;

CREATE TRIGGER "TRG_Doctors_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "Doctors"
FOR EACH ROW
EXECUTE FUNCTION "TRG_Doctors_SoftDeleteAndTerminate"();

select * from "Doctors"
select * from "Employees"

DELETE FROM "Doctors"
WHERE "DoctorID" = 2;

CREATE OR REPLACE FUNCTION "TRG_SoftDeleteEmployeeForRole"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
BEGIN
   
    EXECUTE format(
        'UPDATE %I SET "IsActive" = FALSE WHERE "EmployeeID" = $1',
        TG_TABLE_NAME
    )
    USING OLD."EmployeeID";

   
    UPDATE "Employees"
    SET 
        "TerminationDate"  = COALESCE("TerminationDate", CURRENT_DATE),
        "EmploymentStatus" = 3   
    WHERE "EmployeeID" = OLD."EmployeeID";

   
    RETURN NULL;
END;
$$;

CREATE TRIGGER "TRG_Doctors_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "Doctors"
FOR EACH ROW
EXECUTE FUNCTION "TRG_SoftDeleteEmployeeForRole"();

CREATE TRIGGER "TRG_Nurses_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "Nurses"
FOR EACH ROW
EXECUTE FUNCTION "TRG_SoftDeleteEmployeeForRole"();

CREATE TRIGGER "TRG_Cleaners_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "Cleaners"
FOR EACH ROW
EXECUTE FUNCTION "TRG_SoftDeleteEmployeeForRole"();

CREATE TRIGGER "TRG_LabTechnicians_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "LabTechnicians"
FOR EACH ROW
EXECUTE FUNCTION "TRG_SoftDeleteEmployeeForRole"();

CREATE TRIGGER "TRG_Administrators_BeforeDelete_SoftDeleteAndTerminate"
BEFORE DELETE ON "Administrators"
FOR EACH ROW
EXECUTE FUNCTION "TRG_SoftDeleteEmployeeForRole"();

select * from "Cleaners"
select * from "Employees"

delete from "Cleaners" where "Cleaners"."CleanerID" = 1

CREATE OR REPLACE FUNCTION "TRG_Appointments_CheckActiveDoctorPatient"()
RETURNS trigger
LANGUAGE plpgsql
AS $$
DECLARE
    v_doctor_active  BOOLEAN;
    v_patient_active BOOLEAN;
BEGIN
    SELECT "IsActive" INTO v_doctor_active
    FROM "Doctors"
    WHERE "DoctorID" = NEW."DoctorID";

    IF v_doctor_active IS NOT TRUE THEN
        RAISE EXCEPTION 'Doctor % is not active', NEW."DoctorID";
    END IF;

    SELECT "IsActive" INTO v_patient_active
    FROM "Patients"
    WHERE "PatientID" = NEW."PatientID";

    IF v_patient_active IS NOT TRUE THEN
        RAISE EXCEPTION 'Patient % is not active', NEW."PatientID";
    END IF;

    RETURN NEW;
END;
$$;

CREATE TRIGGER "TRG_Appointments_BeforeInsert_CheckActive"
BEFORE INSERT OR UPDATE ON "Appointments"
FOR EACH ROW
EXECUTE FUNCTION "TRG_Appointments_CheckActiveDoctorPatient"();

