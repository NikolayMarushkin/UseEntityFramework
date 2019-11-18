namespace UseEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameColumn : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Writors", newName: "Writers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Writers", newName: "Writors");
        }
    }
}
