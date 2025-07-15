using CleanArch.Domain.Abstractions;
using CleanArch.Domain.Entities;
using CleanArch.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infraestructure.Repositories;
public class MemberRepository : IMemberRepository
{
    private readonly AppDbContext _db;
    public MemberRepository(AppDbContext db)
    {
        this._db = db;
    }

    public async Task<Member> CreateMember(Member member)
    {
        if (member is null)
            throw new NullReferenceException(nameof(Member));
        await _db.AddAsync(member);
        return member;
    }

    public async Task DeleteMember(int id)
    {
        var member = await GetMemberById(id);
        _db.Members.Remove(member);
    }

    public async Task<Member> GetMemberById(int id)
    {
        var member = await _db.Members.FindAsync(id);
        if (member is null)
            throw new InvalidOperationException("Member not found");
        return member;
    }

    public async Task<IEnumerable<Member>> GetMembers()
    {
        var memberList = await _db.Members.AsNoTracking().ToListAsync();
        return memberList ?? Enumerable.Empty<Member>(); 
    }

    public async Task<Member> UpdateMember(Member member)
    {
        if (member is null)
            throw new NullReferenceException(nameof(member));
        _db.Members.Entry(member).State = EntityState.Modified;
        return member;
    }
}
