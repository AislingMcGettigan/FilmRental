namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemovies : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies Set NumberInStock = 5 Where Id=1");
            Sql("Update Movies Set NumberInStock = 3 Where Id=2");
            Sql("Update Movies Set NumberInStock = 10 Where Id=3");

            Sql("Update Movies Set ReleaseDate = '2019/10/28' Where Id=1");
            Sql("Update Movies Set ReleaseDate = '2017/09/16' Where Id=2");
            Sql("Update Movies Set ReleaseDate = '2010/05/23' Where Id=3");

            Sql("Update Movies Set DateAdded = '2012/10/18' Where Id=1");
            Sql("Update Movies Set DateAdded = '2017/04/13' Where Id=2");
            Sql("Update Movies Set DateAdded = '2011/04/24' Where Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
