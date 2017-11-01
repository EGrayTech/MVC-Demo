namespace TeamRoster.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeamRoster.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamRoster.DAL.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TeamRoster.DAL.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Team team1 = new Team
            {
                Team_Id = 1,
                TeamName = "Jets"
            };

            Team team2 = new Team
            {
                Team_Id = 2,
                TeamName = "Rockets"
            };

            context.Teams.AddOrUpdate(t => t.Team_Id,
                team1,
                team2
            );

            context.Players.AddOrUpdate(p => p.Player_Id,
                new Player() { Player_Id = 1, FirstName = "Lee", LastName = "Puckett", PlayerTeam = team1 },
                new Player() { Player_Id = 2, FirstName = "Michael", LastName = "Brown", PlayerTeam = team2 },
                new Player() { Player_Id = 3, FirstName = "Elizabeth", LastName = "Gray", PlayerTeam = team1 },
                new Player() { Player_Id = 4, FirstName = "Irene", LastName = "Click", PlayerTeam = team2 },
                new Player() { Player_Id = 5, FirstName = "Lauren", LastName = "Wright", PlayerTeam = team1 },
                new Player() { Player_Id = 6, FirstName = "Chuck", LastName = "Winters", PlayerTeam = team2 },
                new Player() { Player_Id = 7, FirstName = "Amit", LastName = "Bania", PlayerTeam = team1 },
                new Player() { Player_Id = 8, FirstName = "Brad", LastName = "Hinton", PlayerTeam = team2 },
                new Player() { Player_Id = 9, FirstName = "Juanita", LastName = "Von Dwingelo", PlayerTeam = team1 },
                new Player() { Player_Id = 0, FirstName = "Peter", LastName = "Nelson", PlayerTeam = team2 }
            );

         }
    
    }
}
