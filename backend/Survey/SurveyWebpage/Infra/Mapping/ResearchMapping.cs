using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Model;


namespace Survey.Infra.Mapping; 

public class ResearchMapping : IEntityTypeConfiguration<Research> {

    public void Configure(EntityTypeBuilder<Research> builder) {
        
        builder.HasKey(r => r.Id);

        builder.HasOne(r => r.Person)
            .WithOne(p => p.Research)
            .HasForeignKey<Person>(p => p.ResearchId);
        
        builder.HasOne(r => r.Adress)
            .WithOne(a => a.Research)
            .HasForeignKey<Person>(p => p.ResearchId);

        builder.Property(r => r.Newspaper).HasColumnName("NEWSPAPER");
        builder.Property(r => r.IpAdress).HasColumnName("IP_ADRESS");
        builder.Property(r => r.RespondedAt).HasColumnName("RESPONDED_AT");

        builder.ToTable("RESEARCHES", "RESEARCH_BASE");
    }
}