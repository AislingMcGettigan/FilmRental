namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'357327a3-bc1f-423b-b666-12917afd47ef', N'guest1@vidly.com', 0, N'AJatZ7Wl5PYJdipOz37VtLWOvos1m2Zm+9m/tF0pY4j2OlKwV8PFW5J+jEXlJWPR6Q==', N'd84a497d-ed3a-4fc4-a2da-68a018ebbd47', NULL, 0, 0, NULL, 1, 0, N'guest1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'43eeaa7b-ed33-47a9-af00-a578c6ae2c27', N'guest@vidly.com', 0, N'AJ4qTvSoX16afyVGg1CwRZH9tw51NkeYTIC2fn45pHhxbvdydaRudWIQEyL9lgSlxw==', N'8c6c1f3f-e291-4c9e-9ee5-17e61dc17f1d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'679b935f-8274-40be-8b1e-c332c511b716', N'admin@vidly.com', 0, N'AHIW2tjEsgKfBUWH/eG/VQ+8eSpK3B4ZzYO9jWdHAJFiKUdMzcbl4AOUBR59rwRwgw==', N'627ed087-9f0d-48bc-b846-b510bc6c6f55', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'42150b51-29ea-489c-9719-1449a915eaf6', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'679b935f-8274-40be-8b1e-c332c511b716', N'42150b51-29ea-489c-9719-1449a915eaf6')

");
        }
        
        public override void Down()
        {
        }
    }
}
