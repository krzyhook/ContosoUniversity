namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthAndRequiredOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String());
            AlterColumn("dbo.Student", "FirstMidName", c => c.String());
        }
    }
}
