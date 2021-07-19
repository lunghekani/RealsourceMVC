namespace RealsourceMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles VALUES (1, 'Administrator')");
            Sql("INSERT INTO AspNetRoles VALUES (2, 'Customer')");
            Sql("INSERT INTO AspNetRoles VALUES (3, 'Expert')");
        }
        
        public override void Down()
        {
        }
    }
}
