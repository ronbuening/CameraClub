using System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class Evaluation
{
    public Guid evaluationId { get; set; }
    public Guid photoId { get; set; }
    public Guid judgeId { get; set; }
    public Guid competitionId { get; set; }
    public int score { get; set; }
    public string? comment { get; set; }
    public DateTime evaluationDate { get; set; }

    public Evaluation() { }
    public Evaluation(Guid _photoId, Guid _judgeId, Guid _competitionId, int _score, string _comment)
    {
        photoId = _photoId;
        judgeId = _judgeId;
        competitionId = _competitionId;
        score = _score;
        comment = _comment;
        evaluationDate = DateTime.Now;
        evaluationId = Guid.NewGuid();
    }
    public Evaluation(Guid _photoId, Guid _judgeId, Guid _competitionId, int _score)
    {
        photoId = _photoId;
        judgeId = _judgeId;
        competitionId = _competitionId;
        score = _score;
        evaluationDate = DateTime.Now;
        evaluationId = Guid.NewGuid();
    }
}