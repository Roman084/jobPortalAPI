using jobPortalAPI.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace jobPortalAPI.Data
{
    public class DataDbContext : IdentityDbContext<User>
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) {}
        
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyAdditionalUsers> CompanyAdditionalUsers { get; set; }
        public DbSet<CompanyDocument> CompanyDocument { get; set; }
        public DbSet<CompanyLogo> CompanyLogo { get; set; }
        
        public DbSet<ApplicantDocument> ApplicantDocument { get; set; }
        public DbSet<ApplicantLogo> ApplicantLogo { get; set; }
        
        public DbSet<JobPost> JobPost { get; set; }
        public DbSet<JobPostAddress> JobPostAddress { get; set; }
        public DbSet<JobPostAmetitunnistus> JobPostAmetitunnistus { get; set; }
        public DbSet<JobPostDocuments> JobPostDocuments { get; set; }
        public DbSet<JobPostHaridus> JobPostHaridus { get; set; }
        public DbSet<JobPostJuhiluba> JobPostJuhiluba { get; set; }
        public DbSet<JobPostKeeleoskus> JobPostKeeleoskus { get; set; }
        public DbSet<JobPostKutsetunnistused> JobPostKutsetunnistus { get; set; }
        public DbSet<JobPostTooleasumine> JobPostTooleasumine { get; set; }
        public DbSet<JobPostAsukohaAddress> JobPostAsukohaAddress { get; set; }
        public DbSet<JobPostCategory> JobPostCategory { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<JobPostAsukohaAddress>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostAsukohaAddress)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostDocuments>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostDocuments)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostHaridus>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostHaridus)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostJuhiluba>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostJuhiluba)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostKeeleoskus>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostKeeleoskus)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostAmetitunnistus>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostAmetitunnistus)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<JobPostKutsetunnistused>()
                .HasOne(a => a.JobPost)
                .WithMany(d => d.JobPostKutsetunnistused)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}