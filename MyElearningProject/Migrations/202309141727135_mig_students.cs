namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_students : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Password", c => c.Int(nullable: false));
        }
    }
}
