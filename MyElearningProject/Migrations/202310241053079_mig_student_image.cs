namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_student_image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ImageUrl");
        }
    }
}
