using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CILogsDetails.Model
{
    public partial class CILogsDetailContext : DbContext
    {
        public CILogsDetailContext()
        {
        }

        public CILogsDetailContext(DbContextOptions<CILogsDetailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AzureCilogsDetails> AzureCilogsDetails { get; set; }
        public virtual DbSet<AzureCiprojectDetails> AzureCiprojectDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:wmacm.database.windows.net,1433;Initial Catalog=wmacm;Persist Security Info=False;User ID=dev;Password=Admin1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AzureCilogsDetails>(entity =>
            {
                entity.Property(e => e.Approver).IsUnicode(false);

                entity.Property(e => e.BuildBy).IsUnicode(false);

                entity.Property(e => e.BuildDefinitionName).IsUnicode(false);

                entity.Property(e => e.BuildId).IsUnicode(false);

                entity.Property(e => e.BuildNumber).IsUnicode(false);

                entity.Property(e => e.BuildRepoName).IsUnicode(false);

                entity.Property(e => e.BuildRepositoryId).IsUnicode(false);

                entity.Property(e => e.BuildRepositoryName).IsUnicode(false);

                entity.Property(e => e.BuildRequester).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeplyAppServiceName).IsUnicode(false);

                entity.Property(e => e.DeplyAppSlotName).IsUnicode(false);

                entity.Property(e => e.DeplyEnvironmentName).IsUnicode(false);

                entity.Property(e => e.DeplyResourceGrpName).IsUnicode(false);

                entity.Property(e => e.DeplyStagename).IsUnicode(false);

                entity.Property(e => e.DeplySubscriptionName).IsUnicode(false);

                entity.Property(e => e.EventType).IsUnicode(false);

                entity.Property(e => e.Meta).IsUnicode(false);

                entity.Property(e => e.Org).IsUnicode(false);

                entity.Property(e => e.Project).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AzureCiprojectDetails>(entity =>
            {
                entity.Property(e => e.AppOwner).IsUnicode(false);

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.BuildConfiguration).IsUnicode(false);

                entity.Property(e => e.Meta).IsUnicode(false);

                entity.Property(e => e.Org).IsUnicode(false);

                entity.Property(e => e.Project).IsUnicode(false);

                entity.Property(e => e.ProjectPath).IsUnicode(false);
            });
        }
    }
}
