namespace SwiftClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisableStaffRequiredAttribute : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.AssignSpecializations", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.ConsultantRecords", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Dischages", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.PreliminaryExaminations", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.StaffAcademicHistories", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.HealthSchemes", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Patients", "Staff_StaffNumber", "dbo.Staffs");
            DropIndex("dbo.Patients", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Appointments", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.PreliminaryExaminations", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.AssignSpecializations", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.ConsultantRecords", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Dischages", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.StaffAcademicHistories", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.HealthSchemes", new[] { "Staff_StaffNumber" });
            DropColumn("dbo.Appointments", "StaffNumber");
            DropColumn("dbo.PreliminaryExaminations", "StaffNumber");
            DropColumn("dbo.AssignSpecializations", "StaffNumber");
            DropColumn("dbo.ConsultantRecords", "StaffNumber");
            DropColumn("dbo.Dischages", "StaffNumber");
            DropColumn("dbo.StaffAcademicHistories", "StaffNumber");
            DropColumn("dbo.HealthSchemes", "StaffNumber");
            RenameColumn(table: "dbo.Appointments", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.PreliminaryExaminations", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.AssignSpecializations", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.ConsultantRecords", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.Dischages", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.StaffAcademicHistories", name: "Staff_StaffNumber", newName: "StaffNumber");
            RenameColumn(table: "dbo.HealthSchemes", name: "Staff_StaffNumber", newName: "StaffNumber");
            DropPrimaryKey("dbo.Staffs");
            AlterColumn("dbo.Patients", "Staff_StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Appointments", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Appointments", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.PreliminaryExaminations", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.PreliminaryExaminations", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Staffs", "StaffNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AssignSpecializations", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.AssignSpecializations", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.ConsultantRecords", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.ConsultantRecords", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Dischages", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Dischages", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffAcademicHistories", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffAcademicHistories", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.HealthSchemes", "StaffNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.HealthSchemes", "StaffNumber", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Staffs", "StaffNumber");
            CreateIndex("dbo.Appointments", "StaffNumber");
            CreateIndex("dbo.Patients", "Staff_StaffNumber");
            CreateIndex("dbo.ConsultantRecords", "StaffNumber");
            CreateIndex("dbo.AssignSpecializations", "StaffNumber");
            CreateIndex("dbo.Dischages", "StaffNumber");
            CreateIndex("dbo.PreliminaryExaminations", "StaffNumber");
            CreateIndex("dbo.StaffAcademicHistories", "StaffNumber");
            CreateIndex("dbo.HealthSchemes", "StaffNumber");
            AddForeignKey("dbo.Appointments", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.AssignSpecializations", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.ConsultantRecords", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.Dischages", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.PreliminaryExaminations", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.StaffAcademicHistories", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.HealthSchemes", "StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.Patients", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Staff_StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.HealthSchemes", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.StaffAcademicHistories", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.PreliminaryExaminations", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Dischages", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.ConsultantRecords", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.AssignSpecializations", "StaffNumber", "dbo.Staffs");
            DropForeignKey("dbo.Appointments", "StaffNumber", "dbo.Staffs");
            DropIndex("dbo.HealthSchemes", new[] { "StaffNumber" });
            DropIndex("dbo.StaffAcademicHistories", new[] { "StaffNumber" });
            DropIndex("dbo.PreliminaryExaminations", new[] { "StaffNumber" });
            DropIndex("dbo.Dischages", new[] { "StaffNumber" });
            DropIndex("dbo.AssignSpecializations", new[] { "StaffNumber" });
            DropIndex("dbo.ConsultantRecords", new[] { "StaffNumber" });
            DropIndex("dbo.Patients", new[] { "Staff_StaffNumber" });
            DropIndex("dbo.Appointments", new[] { "StaffNumber" });
            DropPrimaryKey("dbo.Staffs");
            AlterColumn("dbo.HealthSchemes", "StaffNumber", c => c.Int());
            AlterColumn("dbo.HealthSchemes", "StaffNumber", c => c.String(nullable: false));
            AlterColumn("dbo.StaffAcademicHistories", "StaffNumber", c => c.Int());
            AlterColumn("dbo.StaffAcademicHistories", "StaffNumber", c => c.String());
            AlterColumn("dbo.Dischages", "StaffNumber", c => c.Int());
            AlterColumn("dbo.Dischages", "StaffNumber", c => c.String());
            AlterColumn("dbo.ConsultantRecords", "StaffNumber", c => c.Int());
            AlterColumn("dbo.ConsultantRecords", "StaffNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AssignSpecializations", "StaffNumber", c => c.Int());
            AlterColumn("dbo.AssignSpecializations", "StaffNumber", c => c.String());
            AlterColumn("dbo.Staffs", "StaffNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.PreliminaryExaminations", "StaffNumber", c => c.Int());
            AlterColumn("dbo.PreliminaryExaminations", "StaffNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "StaffNumber", c => c.Int());
            AlterColumn("dbo.Appointments", "StaffNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Staff_StaffNumber", c => c.Int());
            AddPrimaryKey("dbo.Staffs", "StaffNumber");
            RenameColumn(table: "dbo.HealthSchemes", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.StaffAcademicHistories", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.Dischages", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.ConsultantRecords", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.AssignSpecializations", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.PreliminaryExaminations", name: "StaffNumber", newName: "Staff_StaffNumber");
            RenameColumn(table: "dbo.Appointments", name: "StaffNumber", newName: "Staff_StaffNumber");
            AddColumn("dbo.HealthSchemes", "StaffNumber", c => c.String(nullable: false));
            AddColumn("dbo.StaffAcademicHistories", "StaffNumber", c => c.String());
            AddColumn("dbo.Dischages", "StaffNumber", c => c.String());
            AddColumn("dbo.ConsultantRecords", "StaffNumber", c => c.String(nullable: false));
            AddColumn("dbo.AssignSpecializations", "StaffNumber", c => c.String());
            AddColumn("dbo.PreliminaryExaminations", "StaffNumber", c => c.String(nullable: false));
            AddColumn("dbo.Appointments", "StaffNumber", c => c.String(nullable: false));
            CreateIndex("dbo.HealthSchemes", "Staff_StaffNumber");
            CreateIndex("dbo.StaffAcademicHistories", "Staff_StaffNumber");
            CreateIndex("dbo.Dischages", "Staff_StaffNumber");
            CreateIndex("dbo.ConsultantRecords", "Staff_StaffNumber");
            CreateIndex("dbo.AssignSpecializations", "Staff_StaffNumber");
            CreateIndex("dbo.PreliminaryExaminations", "Staff_StaffNumber");
            CreateIndex("dbo.Appointments", "Staff_StaffNumber");
            CreateIndex("dbo.Patients", "Staff_StaffNumber");
            AddForeignKey("dbo.Patients", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.HealthSchemes", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.StaffAcademicHistories", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.PreliminaryExaminations", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.Dischages", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.ConsultantRecords", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.AssignSpecializations", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
            AddForeignKey("dbo.Appointments", "Staff_StaffNumber", "dbo.Staffs", "StaffNumber");
        }
    }
}
