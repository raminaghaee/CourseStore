using CourseStore.Model.Tags.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Tags;
internal class TagConfig : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(c => c.TagName).IsRequired().HasMaxLength(20);
        builder.ToTable("Tags", c => c.IsTemporal());
    }
}

