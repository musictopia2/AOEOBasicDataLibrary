namespace AOEOBasicDataLibrary.Civs.ViewModels;
public interface IChooseCivViewModel
{
    Task InitAsync(); //this will initialize the lists.
    BasicList<CivilizationBasicModel> Civilizations { get; set; } //looks like i need to write to it because can be filtered list
    CivilizationBasicModel? CivilizationChosen { get; set; } //i like it done this way even better
}