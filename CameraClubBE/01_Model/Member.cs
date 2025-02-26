using System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class Member {
    public Guid memberId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int? role { get; set; }
    public DateOnly? dateJoined { get; set; }

    public Member() {}
    public Member (string _email, string _password, string _firstName, string _lastName) {
        email = _email;
        password = _password;
        firstName = _firstName;
        lastName = _lastName;
        memberId = Guid.NewGuid();
        dateJoined = DateOnly.FromDateTime(DateTime.Now);
        role = 4;
    }
    public Member (CMember _member) {
        memberId = _member.memberId;
        firstName = _member.firstName;
        lastName = _member.lastName;
        email = _member.email;
        password = _member.password;
        role = _member.role;
        dateJoined = _member.dateJoined;
    }
    public Member (CQMember _member) {
        memberId = _member.memberId;
        firstName = _member.firstName;
        lastName = _member.lastName;
        email = _member.email;
        password = _member.password;
        role = 4;
    }
}