namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admintel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminRegisters", "EMail", c => c.String());
            AddColumn("dbo.AdminRegisters", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminRegisters", "Phone");
            DropColumn("dbo.AdminRegisters", "EMail");
        }
    }
}
