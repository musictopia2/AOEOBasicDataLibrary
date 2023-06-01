namespace AOEOBasicDataLibrary.Services;
public abstract class BaseTechsCharacterService : IAddTechsToCharacterService
{
    string IAddTechsToCharacterService.CharacterPath { get; set; } = "";
    XElement? IAddTechsToCharacterService.Source { get; set; }
    XElement? IAddTechsToCharacterService.Tech { get; set; }
    public abstract void AddTechs();
}