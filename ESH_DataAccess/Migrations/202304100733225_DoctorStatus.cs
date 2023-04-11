namespace ESH_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDoctors", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeDoctors", "Status");
        }
    }
}
