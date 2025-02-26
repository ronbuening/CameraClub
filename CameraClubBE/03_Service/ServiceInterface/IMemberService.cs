using CameraClubBE.Data;
using CameraClubBE.Model;
using Microsoft.AspNetCore.Mvc;

namespace CameraClubBE.Service;
public interface IMemberServices
{
    public Task<Member> GetMemberByEmailAsync(string emailToFindFromFrontEnd);
    public Task<Member> GetMemberByIdAsync(Guid memberIdToFindFromFrontEnd);
    public Task<string?> InitHashPassword (Guid memberId, string rawPassword);
    public Task<string?> HashPassword (Guid memberId, string rawPassword);
    public Task<bool> VerifyPassword (string rawPassword, Member member);
    public Task<Member> UpdateMember(Member memberToUpdate);
    public Task<Guid> UpdateMemberInfo(MemberUpdate memberInfoFromController);
    public Task<Member> CreateNewMemberAsync(Member memberToCreateFromController);
    public Task<List<PMember>> GetAllMembersFromService();
    public Task<List<PMember>> GetAllJudgesFromService();
    public Task<bool> MemberExistsAsync(string email);
}