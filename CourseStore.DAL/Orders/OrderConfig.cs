using CourseStore.Model.Orders.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Orders;
public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        //builder.Property(c => c.Course).IsRequired();
        builder.Property(c => c.OrderDate).HasColumnType("datetime2");
        builder.Property(c => c.CustomerEmail).IsRequired().HasMaxLength(50);
        builder.Property(c => c.TotalPrice).IsRequired().HasPrecision(14, 2);
        builder.ToTable("Orders", c => c.IsTemporal());
    }
}

