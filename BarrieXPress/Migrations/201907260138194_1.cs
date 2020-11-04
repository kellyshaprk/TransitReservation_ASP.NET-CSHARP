namespace BarrieXPress.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fares",
                c => new
                    {
                        FareId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FareInfo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FareId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fares");
        }
    }
}
