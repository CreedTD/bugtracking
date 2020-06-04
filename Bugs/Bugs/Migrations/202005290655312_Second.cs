namespace Bugs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WORKERs", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WORKERs", "Password", c => c.Int(nullable: false));
        }
    }
}
