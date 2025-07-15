using CleanArch.Domain.Entities;
using CleanArch.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infraestructure.EntityConfigurations;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName).HasMaxLength(60);
        builder.Property(x => x.LastName).HasMaxLength(60);
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Gender).IsRequired();
        builder.Property(x => x.IsActive).IsRequired();

        builder.HasData(
            new Member("Marcia","Neves",EGender.Male,"teste@gmail.com",true),
            new Member("Paulo","Silva",EGender.Male,"teste1@gmail.com",true),
            new Member("Marta","Maria",EGender.Male,"teste2@gmail.com",false),
            new Member("Felca","Cabeludo",EGender.Male,"teste3@gmail.com",false)
        );
    }
}
