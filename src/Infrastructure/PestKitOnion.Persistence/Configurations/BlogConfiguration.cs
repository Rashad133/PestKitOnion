using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Configurations
{
    internal class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(50);
        }
    }
}
