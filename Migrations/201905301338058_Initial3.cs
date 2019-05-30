namespace CreditCardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requests", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.Requests", "lastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requests", "lastName", c => c.String());
            AlterColumn("dbo.Requests", "firstName", c => c.String());
        }
    }
}
