namespace UseEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameOnWriter_Id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Writer_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "WriterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "WriterId", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Writer_Id");
        }
    }
}
