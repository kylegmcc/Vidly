namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 'Comedy', '1-1-1990', '9-8-2019', 1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 'Action', '1-1-1990', '9-8-2019', 2)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 'Drama', '1-1-1990', '9-8-2019', 3)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Snatch', 'Action Comedy', '1-1-1990', '9-8-2019', 4)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek', 'Animated', '1-1-1990', '9-8-2019', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
