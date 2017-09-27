namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppleFacts", "Fiction", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppleFacts", "Fiction");
        }
    }
}
