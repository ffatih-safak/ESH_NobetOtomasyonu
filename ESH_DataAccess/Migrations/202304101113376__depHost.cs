namespace ESH_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _depHost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmanHospitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DepartmanHospitals");
        }
    }
}
