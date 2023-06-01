namespace AOEOBasicDataLibrary.Civs.ViewModels;
public interface IChooseCivViewModel
{
    Task InitAsync(); //this will initialize the lists.
    BasicList<CivilizationBasicModel> Civilizations { get; } //readonly otherwise.
    CivilizationBasicModel? CivilizationChosen { get; set; } //i like it done this way even better
}