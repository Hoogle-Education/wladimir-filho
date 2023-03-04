using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Model;

namespace Survey.Infra.Mapping; 

public class StaffMapping : IEntityTypeConfiguration<Staff> {

    public void Configure(EntityTypeBuilder<Staff> builder) {

        builder.HasIndex(staff => staff.Id);

        builder.Property(staff => staff.Username).HasColumnName("USERNAME");
        builder.Property(staff => staff.Password).HasColumnName("PASSWORD");

        builder.ToTable("STAFFS", "RESEARCH_BASE");
    }
}