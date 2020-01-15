using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RobofestWTECore.Data;
using System;
using System.Linq;
using RobofestWTECore.Models;

namespace RobofestWTECore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GameContext>>()))
            {

                context.StudentTeams.AddRange(
                    new RobofestWTE.Models.StudentTeam
                    {
                        TeamNumberBranch = 1001,
                        TeamNumberSpecific = 1,
                        TeamName = "Team Uno",
                        FieldR1 = 0,
                        FieldR2 = 0,
                        Location = "Plymouth"
                    },
                    new RobofestWTE.Models.StudentTeam
                    {
                        TeamNumberBranch = 1001,
                        TeamNumberSpecific = 2,
                        TeamName = "Team Dos",
                        FieldR1 = 0,
                        FieldR2 = 0,
                        Location = "Plymouth"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}