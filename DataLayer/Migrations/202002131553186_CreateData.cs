namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Available = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Employee_EmployeeId = c.Int(),
                        Admin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.ActivityID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .ForeignKey("dbo.Admins", t => t.Admin_AdminId)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.Admin_AdminId);
            
            CreateTable(
                "dbo.Alumni",
                c => new
                    {
                        AlumnusId = c.Int(nullable: false, identity: true),
                        Registered = c.Boolean(nullable: false),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        SocialSecurityNumber = c.String(),
                        Admin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.AlumnusId)
                .ForeignKey("dbo.Admins", t => t.Admin_AdminId)
                .Index(t => t.Admin_AdminId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Signature = c.String(),
                        EmployeeNumber = c.String(),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        SocialSecurityNumber = c.String(),
                        Admin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Admins", t => t.Admin_AdminId)
                .Index(t => t.Admin_AdminId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        EmployeeNumber = c.String(),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        SocialSecurityNumber = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.AlumnusActivities",
                c => new
                    {
                        Alumnus_AlumnusId = c.Int(nullable: false),
                        Activity_ActivityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Alumnus_AlumnusId, t.Activity_ActivityID })
                .ForeignKey("dbo.Alumni", t => t.Alumnus_AlumnusId, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_ActivityID, cascadeDelete: true)
                .Index(t => t.Alumnus_AlumnusId)
                .Index(t => t.Activity_ActivityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Admin_AdminId", "dbo.Admins");
            DropForeignKey("dbo.Alumni", "Admin_AdminId", "dbo.Admins");
            DropForeignKey("dbo.Activities", "Admin_AdminId", "dbo.Admins");
            DropForeignKey("dbo.Activities", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.AlumnusActivities", "Activity_ActivityID", "dbo.Activities");
            DropForeignKey("dbo.AlumnusActivities", "Alumnus_AlumnusId", "dbo.Alumni");
            DropIndex("dbo.AlumnusActivities", new[] { "Activity_ActivityID" });
            DropIndex("dbo.AlumnusActivities", new[] { "Alumnus_AlumnusId" });
            DropIndex("dbo.Employees", new[] { "Admin_AdminId" });
            DropIndex("dbo.Alumni", new[] { "Admin_AdminId" });
            DropIndex("dbo.Activities", new[] { "Admin_AdminId" });
            DropIndex("dbo.Activities", new[] { "Employee_EmployeeId" });
            DropTable("dbo.AlumnusActivities");
            DropTable("dbo.Admins");
            DropTable("dbo.Employees");
            DropTable("dbo.Alumni");
            DropTable("dbo.Activities");
        }
    }
}
