namespace ESH_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Authority : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmanHospitalId = c.Int(nullable: false),
                        EmployeeDoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmanHospitals", t => t.DepartmanHospitalId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeDoctors", t => t.EmployeeDoctorId, cascadeDelete: true)
                .Index(t => t.DepartmanHospitalId)
                .Index(t => t.EmployeeDoctorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authorities", "EmployeeDoctorId", "dbo.EmployeeDoctors");
            DropForeignKey("dbo.Authorities", "DepartmanHospitalId", "dbo.DepartmanHospitals");
            DropIndex("dbo.Authorities", new[] { "EmployeeDoctorId" });
            DropIndex("dbo.Authorities", new[] { "DepartmanHospitalId" });
            DropTable("dbo.Authorities");
        }
    }
}
