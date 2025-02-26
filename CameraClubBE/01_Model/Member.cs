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
    public string? phone { get; set; }
    public string? addressLine1 { get; set; }
    public string? addressLine2 { get; set; }
    public string? city { get; set; }
    public string? state { get; set; }
    public string? postalCode { get; set; }
    public string? country { get; set; }
    public DateOnly? dateBirth { get; set; }
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
}