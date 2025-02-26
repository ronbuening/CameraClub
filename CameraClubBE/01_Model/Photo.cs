using System;
using System.ComponentModel.DataAnnotations;
namespace CameraClubBE.Model;

public class Photo
{
    public Guid photoId { get; set; }
    public string filename { get; set; }
    public Guid ownerId { get; set; }
    public string author { get; set; }
    public string title { get; set; }
    public string? caption { get; set; }
    public DateOnly? captureDate { get; set; }
    public TimeOnly? captureTime { get; set; }
    public string? shutterSpeed { get; set; }
    public string? aperture { get; set; }
    public int? ISO { get; set; }
    public double? exposureBias { get; set; }
    public string? cameraMake { get; set; }
    public string? cameraModel { get; set; }
    public string? lensMake { get; set; }
    public string? lensModel { get; set; }
    public bool isColor { get; set; }
    public List<Competition>? competitions { get; set; }
    public List<Evaluation>? evaluations { get; set; }

    public Photo() { }
    public Photo(string _filename, Guid _ownerId, string _author, string _title)
    {
        filename = _filename;
        ownerId = _ownerId;
        author = _author;
        title = _title;
        photoId = Guid.NewGuid();
        isColor = true;
    }
    public Photo(string _filename, Guid _ownerId, string _author, string _title, bool _isColor)
    {
        filename = _filename;
        ownerId = _ownerId;
        author = _author;
        title = _title;
        photoId = Guid.NewGuid();
        isColor = _isColor;
    }
}
