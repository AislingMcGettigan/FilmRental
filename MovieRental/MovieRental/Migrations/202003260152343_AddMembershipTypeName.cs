namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay As You Go' WHERE id = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' WHERE id = 2");
            Sql("Update MembershipTypes Set Name = 'Quarterly' WHERE id = 3");
            Sql("Update MembershipTypes Set Name = 'Yearly' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
