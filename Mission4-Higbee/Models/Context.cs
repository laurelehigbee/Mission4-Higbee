using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_Higbee.Models 
{
    public class Context : DbContext //context for the database
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<MovieResponse> Responses { get; set; } //where to get what's going into the database
        protected override void OnModelCreating(ModelBuilder mb) //allows seeding the db to happen
        {
            mb.Entity<MovieResponse>().HasData( //assigns the data to the db
                new MovieResponse //first response seeded in
                {
                    MovieSubmissionId=1,
                    Category = "Family",
                    Title = "Frozen",
                    Year = 2013,
                    Director = "Chris Buck and Jennifer Lee",
                    Rating = "PG",
                    Edited = false,
                    Lent_to = "",
                    Notes = ""
                },
                new MovieResponse //second response seeded in
                {
                    MovieSubmissionId=2,
                    Category = "Action/Adventure",
                    Title = "Captain America: The Winter Soldier",
                    Year = 2014,
                    Director = "Joe and Anthony Russo",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_to = "",
                    Notes = ""
                },
                new MovieResponse //final movie response seeded in
                {
                    MovieSubmissionId=3,
                    Category = "Action/Adventure",
                    Title = "Demon Slayer: Mugen Train",
                    Year = 2020,
                    Director = "Haruo Sotozaki",
                    Rating = "R",
                    Edited = false,
                    Lent_to = "",
                    Notes = ""
                }
            );
        }
    }
}

