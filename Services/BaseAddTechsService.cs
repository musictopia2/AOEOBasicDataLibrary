namespace AOEOBasicDataLibrary.Services;
public abstract class BaseAddTechsService : IAddTechsToTechTreeService
{
    public XElement? Source { get; set; }
    public abstract void AddTechs();
}