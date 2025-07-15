using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Abstractions
{
    public interface IMemberRepository
    {
        public Task<IEnumerable<Member>>GetMembers();
        public Task<Member> GetMemberById(int id);
        public Task<Member> CreateMember(Member member);
        public Task<Member> UpdateMember(Member member);
        public Task DeleteMember(int Id);
    }
}
