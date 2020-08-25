using System.Data.Entity.Migrations;

namespace BoxingChampionship.Migrations
{
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Battles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstBoxerName = c.String(),
                        SecondBoxerName = c.String(),
                        WinnerName = c.String(),
                        Battlefield = c.String(),
                        Date = c.DateTime(nullable: false),
                        AmountOfRounds = c.Int(nullable: false),
                        RefereePoints = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Boxers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Boxers");
            DropTable("dbo.Battles");
        }
    }
}
