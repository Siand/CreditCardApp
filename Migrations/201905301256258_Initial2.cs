namespace CreditCardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "solution", c => c.String());
            AddColumn("dbo.Results", "sol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Results", "sol");
            DropColumn("dbo.Requests", "solution");
        }
    }
}
