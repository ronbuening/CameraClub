using System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class Competition
{
    public Guid competitionId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public DateTime startEntryDate { get; set; }
    public DateTime endEntryDate { get; set; }
    public DateTime startJudgeDate { get; set; }
    public DateTime endJudgeDate { get; set; }
    public string tag { get; set; }
    public List<Photo>? entries { get; set; }
    public List<Member> judges { get; set; }

    public Competition() { }
    public Competition(string _name, string _description, DateTime _startEntryDate, DateTime _endEntryDate, DateTime _startJudgeDate, DateTime _endJudgeDate, string _tag, List<Member> _judges)
    {
        name = _name;
        description = _description;
        startEntryDate = _startEntryDate;
        endEntryDate = _endEntryDate;
        startJudgeDate = _startJudgeDate;
        endJudgeDate = _endJudgeDate;
        tag = _tag;
        judges = _judges;
        competitionId = Guid.NewGuid();
    }
        public Competition(string _name, string _description, DateTime _startEntryDate, DateTime _startJudgeDate, string _tag, List<Member> _judges)
    {
        name = _name;
        description = _description;
        startEntryDate = _startEntryDate;
        endEntryDate = _startEntryDate+TimeSpan.FromDays(7);
        startJudgeDate = _startJudgeDate;
        endJudgeDate = _startEntryDate+TimeSpan.FromDays(7);
        tag = _tag;
        judges = _judges;
        competitionId = Guid.NewGuid();
    }
}
