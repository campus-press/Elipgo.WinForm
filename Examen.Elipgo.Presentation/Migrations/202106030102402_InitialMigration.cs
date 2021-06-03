namespace Examen.Elipgo.Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        url_connection_rest_api = c.String(nullable: false, maxLength: 60),
                        IsFirstExecution = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(maxLength: 50),
                        value = c.String(maxLength: 50),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        user_name = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 50),
                        roles = c.String(nullable: false, maxLength: 100),
                        token = c.String(maxLength: 500),
                        expiration_token = c.DateTime(nullable: false),
                        last_access = c.DateTime(nullable: false),
                        is_active_session = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "UserId", "dbo.Users");
            DropIndex("dbo.Permissions", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Permissions");
            DropTable("dbo.ApplicationSettings");
        }
    }
}
