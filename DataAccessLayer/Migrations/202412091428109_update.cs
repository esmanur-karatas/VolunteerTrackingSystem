namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LoginLogoutRegisters", newName: "Logs");
            AddColumn("dbo.Logs", "WorkingTime", c => c.Double(nullable: false));
            AddColumn("dbo.Logs", "WorkDetails", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logs", "WorkDetails");
            DropColumn("dbo.Logs", "WorkingTime");
            RenameTable(name: "dbo.Logs", newName: "LoginLogoutRegisters");
        }
    }
}
