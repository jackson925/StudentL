namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baselinehourssessionrecordlength : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActiveLessons", "BaselineHours", c => c.Int(nullable: false));
            AddColumn("dbo.SessonRecords", "Length", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessonRecords", "Length");
            DropColumn("dbo.ActiveLessons", "BaselineHours");
        }
    }
}
