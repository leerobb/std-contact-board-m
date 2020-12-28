namespace STD_Contact_Board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1f6ee977-fc05-4fd1-8a03-820a7c33b66c', N'rcarroll@cste.org', 0, N'AHxs2JrEmohB6Z/RYIZH33DYvj2Rnp848maBNUeDk8gQcLMDhhKdYVik5Z8Mbw2zyg==', N'f1bfc985-4dac-4f10-a94c-cf7f98058278', NULL, 0, 0, NULL, 1, 0, N'rcarroll@cste.org')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2ff7dbdd-df64-4820-a5cb-4afb9db305d8', N'robertcarroll1989@gmail.com', 0, N'AJRrxWCz+a1qlV+mMOvRvwfnSaHSsNuNftRZlYCuzH51c8XdTJy/fisIIMXf4H25Iw==', N'5c75f7eb-535f-4074-8505-9e3f55726d4a', NULL, 0, 0, NULL, 1, 0, N'robertcarroll1989@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'289c0033-659a-4d14-9916-973a84e3d9c2', N'EditAllContacts')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2ff7dbdd-df64-4820-a5cb-4afb9db305d8', N'289c0033-659a-4d14-9916-973a84e3d9c2')

");
        }
        
        public override void Down()
        {
        }
    }
}
