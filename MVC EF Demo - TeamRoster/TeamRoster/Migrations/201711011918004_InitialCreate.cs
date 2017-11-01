namespace TeamRoster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        Player_Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DateAdded = c.DateTime(nullable: false),
                        PlayerTeam_Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Player_Id)
                .ForeignKey("dbo.Team", t => t.PlayerTeam_Team_Id)
                .Index(t => t.PlayerTeam_Team_Id);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Team_Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "PlayerTeam_Team_Id", "dbo.Team");
            DropIndex("dbo.Player", new[] { "PlayerTeam_Team_Id" });
            DropTable("dbo.Team");
            DropTable("dbo.Player");
        }
    }
}
