using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CameraClubBE.Data;
using CameraClubBE.Model;
using Microsoft.AspNetCore.Mvc;

namespace CameraClubBE.Service;
public class MemberService : IMemberService
{
    private readonly IMemberStorage _memberStorage;
    public MemberService(){}
    public MemberService(IMemberStorage memberStorageFromBuilder)
    {
        _memberStorage = efRepoFromBuilder;
    }
    const int keySize = 128;
    const int iterations = 500000;
    public Task<Member> GetMemberByEmailAsync(string emailToFindFromFrontEnd);
    public Task<Member> GetMemberByIdAsync(Guid memberIdToFindFromFrontEnd);
    public Task<string?> InitHashPassword (Guid memberId, string rawPassword)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(keySize);
        await _employeeStorage.StoreSeasoningAsync(employeeId, salt);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(rawPassword),
            salt,
            iterations,
            HashAlgorithmName.SHA512,
            keySize
        );

        return Convert.ToHexString(hash);
    }
    public Task<string?> HashPassword (Guid memberId, string rawPassword)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(keySize);
        Console.WriteLine($"New salt is {Convert.ToHexString(salt)}");
        await _memberStorage.UpdateSeasoningAsync(memberId, salt);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(rawPassword),
            salt,
            iterations,
            HashAlgorithmName.SHA512,
            keySize
        );
        Console.WriteLine($"New hash is {Convert.ToHexString(hash)}");
        return Convert.ToHexString(hash);
    }
    public Task<bool> VerifyPassword (string rawPassword, Member member)
    {
        string salt = "";
        salt = await _memberStorage.GetSaltAsync(member);

        var comparisonHash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(rawPassword),
            Convert.FromHexString(salt),
            iterations,
            HashAlgorithmName.SHA512,
            keySize
        );

        return CryptographicOperations.FixedTimeEquals(comparisonHash, Convert.FromHexString(employee.Password));
    }
    public Task<Member> UpdateMember(Member memberToUpdate);
    public Task<Guid> UpdateMemberInfo(MemberUpdate memberInfoFromController);
    public Task<Member> CreateNewMemberAsync(Member memberToCreateFromController);
    public Task<List<PMember>> GetAllMembersFromService();
    public Task<List<PMember>> GetAllJudgesFromService();
    public Task<bool> MemberExistsAsync(string email);
}