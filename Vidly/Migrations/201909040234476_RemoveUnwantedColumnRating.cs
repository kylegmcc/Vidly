namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnwantedColumnRating : DbMigration
    {
        public override void Up()
        {
            DropColumn("MembershipTypes", "Rating");
        }
        
        public override void Down()
        {
        }
    }
}
