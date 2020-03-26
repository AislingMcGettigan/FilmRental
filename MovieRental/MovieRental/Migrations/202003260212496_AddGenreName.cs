namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreName : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies Set Genre = 'Comedy' where id = 1");
            Sql("Update Movies Set Genre = 'Action' where id = 2");
            Sql("Update Movies Set Genre = 'Romance' where id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
