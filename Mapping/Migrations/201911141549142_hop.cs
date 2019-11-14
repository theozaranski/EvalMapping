namespace Mapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Echanges", "DateEchange", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "DateReservation", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "DateReservation");
            DropColumn("dbo.Echanges", "DateEchange");
        }
    }
}
