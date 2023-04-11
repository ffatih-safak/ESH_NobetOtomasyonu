namespace ESH_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmanHospitalTotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartmanHospitals", "TotalPerson", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartmanHospitals", "TotalPerson");
        }
    }
}
