using CleanArch.Domain.Abstractions;
using CleanArch.Domain.Entities;
using CleanArch.Infraestructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infraestructure.Context;

public class AppDbContext : DbContext, IUnityOfwork
{
    public DbSet<Member> Members { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MemberConfiguration());
    }
    public Task CommitAsync()
    {
        throw new NotImplementedException();
    }

    public void RollBack()
    {
        throw new NotImplementedException();
    }
}
