namespace BarrieXPress.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "MemberId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "MemberId", c => c.Int(nullable: false));
        }
    }
}
