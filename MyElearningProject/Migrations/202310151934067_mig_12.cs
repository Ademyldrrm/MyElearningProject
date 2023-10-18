namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminRegisters",
                c => new
                    {
                        AdminRegisterID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminRegisterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminRegisters");
        }
    }
}
