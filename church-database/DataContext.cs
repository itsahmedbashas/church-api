using System;
using church_models.Entities;
using Microsoft.EntityFrameworkCore;

namespace church_database
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProjectStatus> ProjectStatus { get; set; }

        public DbSet<ProjectType> ProjectTypes { get; set; }

        public DbSet<CompletionStatus> CompletionStatus { get; set; }

        public DbSet<ApplyingEntity> ApplyingEntity { get; set; }

        public DbSet<ApplicantCommunity> ApplicantCommunity { get; set; }
    }
}

