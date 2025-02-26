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
    public string? phone { get; set; }
    public string? addressLine1 { get; set; }
    public string? addressLine2 { get; set; }
    public string? city { get; set; }
    public string? state { get; set; }
    public string? postalCode { get; set; }
    public string? country { get; set; }
    public DateOnly? dateBirth { get; set; }
    public PMember() {}
    public PMember (Member _member) {
        memberId = _member.memberId;
        firstName = _member.firstName;
        lastName = _member.lastName;
        email = _member.email;
        password = _member.password;
        role = _member.role;
        dateJoined = _member.dateJoined;
        phone = _member.phone;
        addressLine1 = _member.addressLine1;
        addressLine2 = _member.addressLine2;
        city = _member.city;
        state = _member.state;
        postalCode = _member.postalCode;
        country = _member.country;
        dateBirth = _member.dateBirth;
    }
