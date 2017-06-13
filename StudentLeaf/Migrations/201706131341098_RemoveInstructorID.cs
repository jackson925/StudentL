namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveInstructorID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SessonRecords", "InstructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SessonRecords", "InstructorId", c => c.Int(nullable: false));
        }
    }
}
