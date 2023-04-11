namespace ESH_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grardListMonth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GuardLists", "Month", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GuardLists", "Month");
        }
    }
}
