namespace AOEOBasicDataLibrary.Models;
public interface ISelectableTech
{
    bool DidChoose { get; set; }
    string Title { get; }
    string Description { get; }
}