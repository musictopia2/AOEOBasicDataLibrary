namespace AOEOBasicDataLibrary.Services;
public interface IAddTechsToCharacterService
{
    string CharacterPath { get; set; }
    XElement? Source { get; set; }
    XElement? Tech { get; set; }
    void AddTechs();
}