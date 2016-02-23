namespace Remainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Waits", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Waits", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Waits", "CurrentCount", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AlterColumn("dbo.Waits", "ApplicationUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Waits", "ApplicationUserId");
            AddForeignKey("dbo.Waits", "ApplicationUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Waits", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Waits", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Waits", "ApplicationUserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Waits", "CurrentCount", c => c.Int(nullable: false));
            CreateIndex("dbo.Waits", "ApplicationUserId");
            AddForeignKey("dbo.Waits", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
