using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infra.Persistence.Config
{
    public class ProjectCommentConfigurations : IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
            builder
               .HasKey(p => p.Id);

            builder
                .HasOne(p => p.Project)
                .WithMany(p => p.Comemnts)
                .HasForeignKey(p => p.IdProject);

            builder
               .HasOne(p => p.User)
               .WithMany(p => p.Comments)
               .HasForeignKey(p => p.IdUser);
        }
    }
}
