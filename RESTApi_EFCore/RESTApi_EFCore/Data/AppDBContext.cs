using Microsoft.EntityFrameworkCore;
using RESTApi_EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi_EFCore.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source= ./Data/AppDB.db");
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Question[] questionsExamples = new Question[5];

            for (int i = 1; i < 6; i++)
            {
                questionsExamples[i - 1] = new Question
                {
                    QuestionId = i,
                    LibelleQuestion = $"Question{i}"
                };
            }

            modelBuilder.Entity<Question>().HasData(questionsExamples);
        }
    }
    
}
