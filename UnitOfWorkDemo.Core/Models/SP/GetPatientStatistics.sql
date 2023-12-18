CREATE PROCEDURE GetPatientStatistics
AS
BEGIN
    -- Total Patients
    DECLARE @TotalPatients INT
    SELECT @TotalPatients = COUNT(*) FROM Patients;

    -- New Patients Today
    DECLARE @NewPatientsToday INT
    SELECT @NewPatientsToday = COUNT(*) FROM Patients WHERE CONVERT(DATE, RegisteredDate) = CONVERT(DATE, GETDATE());

    -- New Patients This Week
    DECLARE @NewPatientsThisWeek INT
    SELECT @NewPatientsThisWeek = COUNT(*) FROM Patients WHERE DATEPART(WEEK, RegisteredDate) = DATEPART(WEEK, GETDATE());

    -- Active Patients
    DECLARE @ActivePatients INT
    SELECT @ActivePatients = COUNT(*) FROM Patients WHERE isActive = 1;

    -- Return the results
    SELECT 
        TotalPatients = @TotalPatients,
        NewPatientsToday = @NewPatientsToday,
        NewPatientsThisWeek = @NewPatientsThisWeek,
        ActivePatients = @ActivePatients;
END;