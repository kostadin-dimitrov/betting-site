namespace BettingSite.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SportEvents",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        Name = c.String(),
                        HomeTeamOdds = c.Double(nullable: false),
                        AwayTeamOdds = c.Double(nullable: false),
                        DrawOdds = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SportEvents");
        }
    }
}
