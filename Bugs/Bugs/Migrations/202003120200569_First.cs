namespace Bugs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ERRORs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                        Variety = c.String(),
                        Dataivremya = c.DateTime(nullable: false),
                        WorkerLogin = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WORKERs", t => t.WorkerLogin)
                .Index(t => t.WorkerLogin);
            
            CreateTable(
                "dbo.KEYWORDs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ErrorId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ERRORs", t => t.ErrorId, cascadeDelete: true)
                .Index(t => t.ErrorId);
            
            CreateTable(
                "dbo.SOLUTIONs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Raiting = c.Int(nullable: false),
                        ErrorId = c.Int(nullable: false),
                        WorkerLogin = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ERRORs", t => t.ErrorId, cascadeDelete: true)
                .ForeignKey("dbo.WORKERs", t => t.WorkerLogin)
                .Index(t => t.ErrorId)
                .Index(t => t.WorkerLogin);
            
            CreateTable(
                "dbo.WORKERs",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Role = c.Boolean(nullable: false),
                        Password = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Login);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ERRORs", "WorkerLogin", "dbo.WORKERs");
            DropForeignKey("dbo.SOLUTIONs", "WorkerLogin", "dbo.WORKERs");
            DropForeignKey("dbo.SOLUTIONs", "ErrorId", "dbo.ERRORs");
            DropForeignKey("dbo.KEYWORDs", "ErrorId", "dbo.ERRORs");
            DropIndex("dbo.SOLUTIONs", new[] { "WorkerLogin" });
            DropIndex("dbo.SOLUTIONs", new[] { "ErrorId" });
            DropIndex("dbo.KEYWORDs", new[] { "ErrorId" });
            DropIndex("dbo.ERRORs", new[] { "WorkerLogin" });
            DropTable("dbo.WORKERs");
            DropTable("dbo.SOLUTIONs");
            DropTable("dbo.KEYWORDs");
            DropTable("dbo.ERRORs");
        }
    }
}
