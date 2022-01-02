using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Maps
{
    internal class LetraMap : IEntityTypeConfiguration<LetraModel>
    {
        public void Configure(EntityTypeBuilder<LetraModel> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Letra);
        }
    }
}
