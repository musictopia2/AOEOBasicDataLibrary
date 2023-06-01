namespace AOEOBasicDataLibrary.Civs.ViewModels;
public class ChooseCivViewModel : IChooseCivViewModel
{
    private readonly ICivilizationDataService _dataService;
    public ChooseCivViewModel(ICivilizationDataService dataService)
    {
        _dataService = dataService;
    }
    public BasicList<CivilizationBasicModel> Civilizations { get; private set; } = new();
    public CivilizationBasicModel? CivilizationChosen { get; set; }
    public async Task InitAsync()
    {
        Civilizations = await _dataService.GetCivilizationsAsync();
    }
}