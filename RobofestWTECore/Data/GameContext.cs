using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RobofestWTE.Models;

namespace RobofestWTECore.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> context)
            : base(context)
        {
        }
        public DbSet<RoundEntry> RoundEntries { get; set; }
        public DbSet<GAME> GAMES { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<StudentTeam> StudentTeams { get; set; }
        public DbSet<ScoreMethod> ScoreMethods { get; set; }
        public DbSet<ScoreAmount> ScoreAmounts { get; set; }
        public DbSet<CompField> Fields { get; set; }
    }
}
