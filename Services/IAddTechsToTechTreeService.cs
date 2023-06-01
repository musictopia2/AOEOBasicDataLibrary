namespace AOEOBasicDataLibrary.Services;
public interface IAddTechsToTechTreeService
{
    XElement? Source { get; set; }
    void AddTechs();
}