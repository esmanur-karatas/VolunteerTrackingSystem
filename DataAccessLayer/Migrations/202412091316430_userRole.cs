namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Users", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Role");
            DropColumn("dbo.Users", "ConfirmPassword");
        }
    }
}
