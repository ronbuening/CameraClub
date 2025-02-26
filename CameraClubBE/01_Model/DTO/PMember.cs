sing System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class PMember {
    public Guid memberId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int? role { get; set; }
    public DateOnly? dateJoined { get; set; }

    public PMember() {}
    public PMember (Member _member) {
        memberId = _member.memberId;
        firstName = _member.firstName;
        lastName = _member.lastName;
        email = _member.email;
        password = _member.password;
        role = _member.role;
        dateJoined = _member.dateJoined;
    }
