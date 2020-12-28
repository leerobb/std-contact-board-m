namespace STD_Contact_Board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTableUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contacts", "Jurisdiction_Id", "dbo.Jurisdictions");
            DropForeignKey("dbo.Contacts", "Role_Id", "dbo.STD_Role");
            DropIndex("dbo.Contacts", new[] { "Jurisdiction_Id" });
            DropIndex("dbo.Contacts", new[] { "Role_Id" });
            AlterColumn("dbo.Contacts", "Jurisdiction_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Jurisdiction_Id", c => c.Int());
            CreateIndex("dbo.Contacts", "Role_Id");
            CreateIndex("dbo.Contacts", "Jurisdiction_Id");
            AddForeignKey("dbo.Contacts", "Role_Id", "dbo.STD_Role", "Id");
            AddForeignKey("dbo.Contacts", "Jurisdiction_Id", "dbo.Jurisdictions", "Id");
        }
    }
}
