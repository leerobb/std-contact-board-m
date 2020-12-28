namespace STD_Contact_Board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.STD_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Contacts", "Role_Id", c => c.Int());
            CreateIndex("dbo.Contacts", "Role_Id");
            AddForeignKey("dbo.Contacts", "Role_Id", "dbo.STD_Role", "Id");
            DropColumn("dbo.Contacts", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Role", c => c.String());
            DropForeignKey("dbo.Contacts", "Role_Id", "dbo.STD_Role");
            DropIndex("dbo.Contacts", new[] { "Role_Id" });
            DropColumn("dbo.Contacts", "Role_Id");
            DropTable("dbo.STD_Role");
        }
    }
}
