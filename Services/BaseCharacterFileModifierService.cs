namespace AOEOBasicDataLibrary.Services;
public abstract class BaseCharacterFileModifierService : ICharacterFileModifierService
{
    string ICharacterFileModifierService.CharacterPath { get; set; } = "";
    XElement? ICharacterFileModifierService.Source { get; set; }
    XElement? ICharacterFileModifierService.Tech { get; set; }
    public abstract void ModifyCharacterFile();
}