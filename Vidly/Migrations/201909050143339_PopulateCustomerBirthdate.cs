namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate=1/4/1995 WHERE Id=1");
            Sql("UPDATE Customers SET Birthdate=NULL WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
