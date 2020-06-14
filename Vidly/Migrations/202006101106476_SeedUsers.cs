namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2dcc013f-929d-4171-9451-cfe6408d130e', N'admin@rental.com', 0, N'AAGYjyjCmDhBSlsJCugxZwA7PLg53jcFfyvUDnftkX6Uyz8oQgPsv/Ef4mqCbr6YGw==', N'be76fccd-f811-4db3-b819-9fb0ea24c904', NULL, 0, 0, NULL, 1, 0, N'admin@rental.com')
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd39798cb-7efa-4763-b7df-ae14e284e08e', N'guest@rental.com', 0, N'AIbv35C+z937b/o3doid2Lo+j19iaRak6abkN0Og8GQg5GqXEQv9p/Oo9RvhRADTSg==', N'56af32f5-ec60-4903-8c7a-640eba44e785', NULL, 0, 0, NULL, 1, 0, N'guest@rental.com')
           
             INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b743d68f-faee-44dc-87e5-7352cd9b6b42', N'CanManageMovies')

             INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2dcc013f-929d-4171-9451-cfe6408d130e', N'b743d68f-faee-44dc-87e5-7352cd9b6b42')

             ");
        }
        
        public override void Down()
        {
        }
    }
}
