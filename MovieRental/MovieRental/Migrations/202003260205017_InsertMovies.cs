namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Movies ( Name) Values ( 'Hangover')");
            Sql("Insert Into Movies (Name) Values ( 'Toystory')");
            Sql("Insert Into Movies (Name) Values ( 'GoldRush')");
        }
        
        public override void Down()
        {
        }
    }
}
