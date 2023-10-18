namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contactadds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactInformations", "Phone", c => c.String());
            AddColumn("dbo.ContactInformations", "Mail", c => c.String());
            AddColumn("dbo.ContactInformations", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactInformations", "Adress");
            DropColumn("dbo.ContactInformations", "Mail");
            DropColumn("dbo.ContactInformations", "Phone");
        }
    }
}
