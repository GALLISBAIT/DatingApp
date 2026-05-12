using API.Entities;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<MemberLike?> GetMemberLike(string sourceMemberId, string targetMemberId);
        Task<IReadOnlyList<Member>> GetMembersLikes(string predicate, string memberId);

        Task<IReadOnlyList<string>> GetCurrentMembersLikeIds(string memberId);

        void DeleteLike(MemberLike like);

        void AddLike(MemberLike like);

        Task<bool> SaveAllChanges();
    }

}
