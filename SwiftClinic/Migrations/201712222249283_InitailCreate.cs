namespace SwiftClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        AuditId = c.Guid(nullable: false),
                        SessionId = c.String(),
                        UserName = c.String(),
                        IpAddress = c.String(),
                        UrlAccessed = c.String(),
                        TimeAccessed = c.DateTime(nullable: false),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.AuditId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientNumber = c.String(nullable: false, maxLength: 128),
                        PatientId = c.Int(nullable: false, identity: true),
                        Tribe = c.String(nullable: false),
                        PatientType = c.String(),
                        IsDead = c.Boolean(nullable: false),
                        Salutation = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        MiddleName = c.String(),
                        LastName = c.String(maxLength: 50),
                        Gender = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(nullable: false, maxLength: 50),
                        Religion = c.String(),
                        TownOfBirth = c.String(),
                        StateOfOrigin = c.String(),
                        Nationality = c.String(),
                        CountryOfBirth = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Passport = c.Binary(),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.PatientNumber)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.Antenatals",
                c => new
                    {
                        AntenatalId = c.Int(nullable: false, identity: true),
                        PatientNumber = c.String(maxLength: 128),
                        RegisteredDate = c.DateTime(nullable: false),
                        HasDelivered = c.Boolean(nullable: false),
                        IsSuccessful = c.Boolean(nullable: false),
                        IsCesereanSection = c.Boolean(nullable: false),
                        Survival = c.String(),
                        SurvivalRate = c.String(),
                    })
                .PrimaryKey(t => t.AntenatalId)
                .ForeignKey("dbo.Patients", t => t.PatientNumber)
                .Index(t => t.PatientNumber);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false),
                        DateVisited = c.DateTime(),
                        AppointmentDate = c.DateTime(nullable: false),
                        StaffNumber = c.String(nullable: false),
                        Detail = c.String(maxLength: 200),
                        DepartmentId = c.Int(nullable: false),
                        PatientNumber = c.String(nullable: false, maxLength: 128),
                        IsCancelled = c.Boolean(nullable: false),
                        IsAttendedTo = c.Boolean(nullable: false),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .ForeignKey("dbo.Patients", t => t.PatientNumber, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.PatientNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentCode = c.String(maxLength: 200),
                        DepartmentName = c.String(maxLength: 200),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .Index(t => t.DepartmentCode, unique: true)
                .Index(t => t.DepartmentName, unique: true);
            
            CreateTable(
                "dbo.PreliminaryExaminations",
                c => new
                    {
                        PreliminaryExaminationId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BloodPressure = c.String(nullable: false, maxLength: 40),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StaffNumber = c.String(nullable: false),
                        PatientNumber = c.String(nullable: false, maxLength: 128),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.PreliminaryExaminationId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientNumber, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.DepartmentId)
                .Index(t => t.PatientNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffNumber = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false, identity: true),
                        Specialization = c.String(),
                        StaffRole = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        Salutation = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        MiddleName = c.String(),
                        LastName = c.String(maxLength: 50),
                        Gender = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(nullable: false, maxLength: 50),
                        Religion = c.String(),
                        TownOfBirth = c.String(),
                        StateOfOrigin = c.String(),
                        Nationality = c.String(),
                        CountryOfBirth = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Passport = c.Binary(),
                    })
                .PrimaryKey(t => t.StaffNumber)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.AssignSpecializations",
                c => new
                    {
                        AssignSpecializationId = c.Int(nullable: false, identity: true),
                        SpecializationId = c.Int(nullable: false),
                        StaffNumber = c.String(),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.AssignSpecializationId)
                .ForeignKey("dbo.Specializations", t => t.SpecializationId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.SpecializationId)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        SpecializationId = c.Int(nullable: false, identity: true),
                        SpecializationCode = c.String(maxLength: 20),
                        SpecializationName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.SpecializationId)
                .Index(t => t.SpecializationCode, unique: true)
                .Index(t => t.SpecializationName, unique: true);
            
            CreateTable(
                "dbo.ConsultantRecords",
                c => new
                    {
                        ConsultantRecordId = c.Int(nullable: false, identity: true),
                        PatientNumber = c.Int(nullable: false),
                        StaffNumber = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ConsultantInfo = c.String(),
                        Patients_PatientNumber = c.String(maxLength: 128),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.ConsultantRecordId)
                .ForeignKey("dbo.Patients", t => t.Patients_PatientNumber)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.Patients_PatientNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.PatientDiagnosis",
                c => new
                    {
                        PatientDiagnosisId = c.Int(nullable: false, identity: true),
                        ConsultantRecordId = c.Int(nullable: false),
                        DiagnosisId = c.Int(nullable: false),
                        DiagnosisType = c.String(),
                    })
                .PrimaryKey(t => t.PatientDiagnosisId)
                .ForeignKey("dbo.ConsultantRecords", t => t.ConsultantRecordId, cascadeDelete: true)
                .ForeignKey("dbo.Diagnosis", t => t.DiagnosisId, cascadeDelete: true)
                .Index(t => t.ConsultantRecordId)
                .Index(t => t.DiagnosisId);
            
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        DiagnosisId = c.Int(nullable: false, identity: true),
                        DiagnosisName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DiagnosisId)
                .Index(t => t.DiagnosisName, unique: true);
            
            CreateTable(
                "dbo.PatientDoDonts",
                c => new
                    {
                        PatientDoDontId = c.Int(nullable: false, identity: true),
                        ConsultantRecordId = c.Int(nullable: false),
                        Note = c.String(),
                        IsDoable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientDoDontId)
                .ForeignKey("dbo.ConsultantRecords", t => t.ConsultantRecordId, cascadeDelete: true)
                .Index(t => t.ConsultantRecordId);
            
            CreateTable(
                "dbo.PatientSymptoms",
                c => new
                    {
                        PatientSymptomId = c.Int(nullable: false, identity: true),
                        ConsultantRecordId = c.Int(nullable: false),
                        SymptomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientSymptomId)
                .ForeignKey("dbo.ConsultantRecords", t => t.ConsultantRecordId, cascadeDelete: true)
                .ForeignKey("dbo.Symptoms", t => t.SymptomId, cascadeDelete: true)
                .Index(t => t.ConsultantRecordId)
                .Index(t => t.SymptomId);
            
            CreateTable(
                "dbo.Symptoms",
                c => new
                    {
                        SymptomId = c.Int(nullable: false, identity: true),
                        SymptonName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.SymptomId)
                .Index(t => t.SymptonName, unique: true);
            
            CreateTable(
                "dbo.Pescriptions",
                c => new
                    {
                        PescriptionId = c.Int(nullable: false, identity: true),
                        ConsultantRecordId = c.Int(nullable: false),
                        DrugId = c.Int(nullable: false),
                        DrugName = c.String(),
                        DosageId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DosageNote = c.String(),
                        Duration = c.String(),
                        Date = c.DateTime(nullable: false),
                        Patient_PatientNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PescriptionId)
                .ForeignKey("dbo.ConsultantRecords", t => t.ConsultantRecordId, cascadeDelete: true)
                .ForeignKey("dbo.Dosages", t => t.DosageId, cascadeDelete: true)
                .ForeignKey("dbo.Drugs", t => t.DrugId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientNumber)
                .Index(t => t.ConsultantRecordId)
                .Index(t => t.DrugId)
                .Index(t => t.DosageId)
                .Index(t => t.Patient_PatientNumber);
            
            CreateTable(
                "dbo.Dosages",
                c => new
                    {
                        DosageId = c.Int(nullable: false, identity: true),
                        DosageName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DosageId)
                .Index(t => t.DosageName, unique: true);
            
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        DrugId = c.Int(nullable: false, identity: true),
                        DrugCategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 160),
                        AlternativeName = c.String(maxLength: 200),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Unit = c.String(),
                        OtherUnitName = c.String(),
                        Description = c.String(),
                        ProductDiscount = c.Decimal(precision: 18, scale: 2),
                        DiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsApproved = c.Boolean(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        StockQuantity = c.Int(),
                    })
                .PrimaryKey(t => t.DrugId)
                .ForeignKey("dbo.DrugCategories", t => t.DrugCategoryId, cascadeDelete: true)
                .Index(t => t.DrugCategoryId);
            
            CreateTable(
                "dbo.DrugCategories",
                c => new
                    {
                        DrugCategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.DrugCategoryId);
            
            CreateTable(
                "dbo.Dischages",
                c => new
                    {
                        DischageId = c.Int(nullable: false, identity: true),
                        PatientNumber = c.String(maxLength: 128),
                        StaffNumber = c.String(),
                        DischargeAdvice = c.String(),
                        ConditionOnDisCharge = c.String(),
                        DischargeDate = c.DateTime(nullable: false),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.DischageId)
                .ForeignKey("dbo.Patients", t => t.PatientNumber)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.PatientNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.StaffAcademicHistories",
                c => new
                    {
                        StaffAcademicHistoryId = c.Int(nullable: false, identity: true),
                        StaffNumber = c.String(),
                        QualificationType = c.Int(nullable: false),
                        QualificationName = c.String(nullable: false),
                        SchoolName = c.String(maxLength: 70),
                        ResultGrade = c.String(maxLength: 70),
                        DateObtained = c.DateTime(nullable: false),
                        Certificate = c.Binary(),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.StaffAcademicHistoryId)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.AssignBedSpaces",
                c => new
                    {
                        AssignBedSpaceId = c.Int(nullable: false, identity: true),
                        PatientNumber = c.String(maxLength: 128),
                        BuildingId = c.Int(),
                        WardId = c.Int(),
                        RoomId = c.Int(nullable: false),
                        BedSpace = c.String(),
                        PaymentStatus = c.Boolean(nullable: false),
                        AssignedDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.AssignBedSpaceId)
                .ForeignKey("dbo.Buildings", t => t.BuildingId)
                .ForeignKey("dbo.Wards", t => t.WardId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientNumber)
                .Index(t => t.PatientNumber)
                .Index(t => t.BuildingId)
                .Index(t => t.WardId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        BuildingId = c.Int(nullable: false, identity: true),
                        BuildingCode = c.String(),
                        BuildingName = c.String(),
                    })
                .PrimaryKey(t => t.BuildingId);
            
            CreateTable(
                "dbo.Wards",
                c => new
                    {
                        WardId = c.Int(nullable: false, identity: true),
                        BuildingId = c.Int(nullable: false),
                        WardCode = c.String(),
                        WardName = c.String(),
                    })
                .PrimaryKey(t => t.WardId)
                .ForeignKey("dbo.Buildings", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        WardId = c.Int(nullable: false),
                        RoomName = c.String(nullable: false),
                        RoomPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BedSpace = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Wards", t => t.WardId, cascadeDelete: true)
                .Index(t => t.WardId);
            
            CreateTable(
                "dbo.HealthSchemes",
                c => new
                    {
                        HealthSchemeId = c.Int(nullable: false, identity: true),
                        SchemeName = c.Int(nullable: false),
                        AccountNumber = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        StaffNumber = c.String(nullable: false),
                        PatientNumber = c.String(nullable: false, maxLength: 128),
                        Staff_StaffNumber = c.Int(),
                    })
                .PrimaryKey(t => t.HealthSchemeId)
                .ForeignKey("dbo.Patients", t => t.PatientNumber, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffNumber)
                .Index(t => t.PatientNumber)
                .Index(t => t.Staff_StaffNumber);
            
            CreateTable(
                "dbo.PatientAllergies",
                c => new
                    {
                        PatientAllergyId = c.Int(nullable: false, identity: true),
                        AllergyId = c.Int(nullable: false),
                        DrugId = c.Int(),
                        PatientNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientAllergyId)
                .ForeignKey("dbo.Allergies", t => t.AllergyId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientNumber)
                .Index(t => t.AllergyId)
                .Index(t => t.PatientNumber);
            
            CreateTable(
                "dbo.Allergies",
                c => new
                    {
                        AllergyId = c.Int(nullable: false, identity: true),
                        AllergyName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.AllergyId)
                .Index(t => t.AllergyName, unique: true);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Patients", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Pescriptions", "Patient_PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.PatientAllergies", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.PatientAllergies", "AllergyId", "dbo.Allergies");
            DropForeignKey("dbo.HealthSchemes", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.HealthSchemes", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.AssignBedSpaces", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.Rooms", "WardId", "dbo.Wards");
            DropForeignKey("dbo.AssignBedSpaces", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Wards", "BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.AssignBedSpaces", "WardId", "dbo.Wards");
            DropForeignKey("dbo.AssignBedSpaces", "BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.Appointments", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.StaffAcademicHistories", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.PreliminaryExaminations", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Dischages", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Dischages", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.Staffs", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.ConsultantRecords", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Pescriptions", "DrugId", "dbo.Drugs");
            DropForeignKey("dbo.Drugs", "DrugCategoryId", "dbo.DrugCategories");
            DropForeignKey("dbo.Pescriptions", "DosageId", "dbo.Dosages");
            DropForeignKey("dbo.Pescriptions", "ConsultantRecordId", "dbo.ConsultantRecords");
            DropForeignKey("dbo.PatientSymptoms", "SymptomId", "dbo.Symptoms");
            DropForeignKey("dbo.PatientSymptoms", "ConsultantRecordId", "dbo.ConsultantRecords");
            DropForeignKey("dbo.ConsultantRecords", "Patients_PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.PatientDoDonts", "ConsultantRecordId", "dbo.ConsultantRecords");
            DropForeignKey("dbo.PatientDiagnosis", "DiagnosisId", "dbo.Diagnosis");
            DropForeignKey("dbo.PatientDiagnosis", "ConsultantRecordId", "dbo.ConsultantRecords");
            DropForeignKey("dbo.AssignSpecializations", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.AssignSpecializations", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.Appointments", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.PreliminaryExaminations", "PatientNumber", "dbo.Patients");
            DropForeignKey("dbo.PreliminaryExaminations", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Appointments", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Antenatals", "PatientNumber", "dbo.Patients");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Allergies", new[] { "AllergyName" });
            DropIndex("dbo.PatientAllergies", new[] { "PatientNumber" });
            DropIndex("dbo.PatientAllergies", new[] { "AllergyId" });
            DropIndex("dbo.HealthSchemes", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.HealthSchemes", new[] { "PatientNumber" });
            DropIndex("dbo.Rooms", new[] { "WardId" });
            DropIndex("dbo.Wards", new[] { "BuildingId" });
            DropIndex("dbo.AssignBedSpaces", new[] { "RoomId" });
            DropIndex("dbo.AssignBedSpaces", new[] { "WardId" });
            DropIndex("dbo.AssignBedSpaces", new[] { "BuildingId" });
            DropIndex("dbo.AssignBedSpaces", new[] { "PatientNumber" });
            DropIndex("dbo.StaffAcademicHistories", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Dischages", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Dischages", new[] { "PatientNumber" });
            DropIndex("dbo.Drugs", new[] { "DrugCategoryId" });
            DropIndex("dbo.Dosages", new[] { "DosageName" });
            DropIndex("dbo.Pescriptions", new[] { "Patient_PatientNumber" });
            DropIndex("dbo.Pescriptions", new[] { "DosageId" });
            DropIndex("dbo.Pescriptions", new[] { "DrugId" });
            DropIndex("dbo.Pescriptions", new[] { "ConsultantRecordId" });
            DropIndex("dbo.Symptoms", new[] { "SymptonName" });
            DropIndex("dbo.PatientSymptoms", new[] { "SymptomId" });
            DropIndex("dbo.PatientSymptoms", new[] { "ConsultantRecordId" });
            DropIndex("dbo.PatientDoDonts", new[] { "ConsultantRecordId" });
            DropIndex("dbo.Diagnosis", new[] { "DiagnosisName" });
            DropIndex("dbo.PatientDiagnosis", new[] { "DiagnosisId" });
            DropIndex("dbo.PatientDiagnosis", new[] { "ConsultantRecordId" });
            DropIndex("dbo.ConsultantRecords", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.ConsultantRecords", new[] { "Patients_PatientNumber" });
            DropIndex("dbo.Specializations", new[] { "SpecializationName" });
            DropIndex("dbo.Specializations", new[] { "SpecializationCode" });
            DropIndex("dbo.AssignSpecializations", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.AssignSpecializations", new[] { "SpecializationId" });
            DropIndex("dbo.Staffs", new[] { "DepartmentId" });
            DropIndex("dbo.PreliminaryExaminations", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.PreliminaryExaminations", new[] { "PatientNumber" });
            DropIndex("dbo.PreliminaryExaminations", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            DropIndex("dbo.Departments", new[] { "DepartmentCode" });
            DropIndex("dbo.Appointments", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Appointments", new[] { "PatientNumber" });
            DropIndex("dbo.Appointments", new[] { "DepartmentId" });
            DropIndex("dbo.Antenatals", new[] { "PatientNumber" });
            DropIndex("dbo.Patients", new[] { "Staff_StaffNumber" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Allergies");
            DropTable("dbo.PatientAllergies");
            DropTable("dbo.HealthSchemes");
            DropTable("dbo.Rooms");
            DropTable("dbo.Wards");
            DropTable("dbo.Buildings");
            DropTable("dbo.AssignBedSpaces");
            DropTable("dbo.StaffAcademicHistories");
            DropTable("dbo.Dischages");
            DropTable("dbo.DrugCategories");
            DropTable("dbo.Drugs");
            DropTable("dbo.Dosages");
            DropTable("dbo.Pescriptions");
            DropTable("dbo.Symptoms");
            DropTable("dbo.PatientSymptoms");
            DropTable("dbo.PatientDoDonts");
            DropTable("dbo.Diagnosis");
            DropTable("dbo.PatientDiagnosis");
            DropTable("dbo.ConsultantRecords");
            DropTable("dbo.Specializations");
            DropTable("dbo.AssignSpecializations");
            DropTable("dbo.Staffs");
            DropTable("dbo.PreliminaryExaminations");
            DropTable("dbo.Departments");
            DropTable("dbo.Appointments");
            DropTable("dbo.Antenatals");
            DropTable("dbo.Patients");
            DropTable("dbo.Audits");
        }
    }
}
