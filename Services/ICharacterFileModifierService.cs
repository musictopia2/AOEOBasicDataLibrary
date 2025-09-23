namespace AOEOBasicDataLibrary.Services;
public interface ICharacterFileModifierService
{
    string CharacterPath { get; set; }
    XElement? Source { get; set; }
    XElement? Tech { get; set; }
    void ModifyCharacterFile();
}