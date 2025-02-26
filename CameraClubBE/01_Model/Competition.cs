using System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class Competition
{
    public Guid competitionId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Tag { get; set; }

    public Competition() { }
    public Competition(string _name, string _description, DateTime _startDate, DateTime _endDate, string _tag)
    {
        Name = _name;
        Description = _description;
        StartDate = _startDate;
        EndDate = _endDate;
        Tag = _tag;
        competitionId = Guid.NewGuid();
    }
}
