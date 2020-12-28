namespace STD_Contact_Board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJurisdictionToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Jurisdiction", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Jurisdiction");
        }
    }
}
