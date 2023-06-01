namespace AOEOBasicDataLibrary.ViewModels;
public class TestPlayQuestViewModel : IPlayQuestViewModel
{
    private readonly IChooseCivViewModel _civVM;
    private readonly IQuestLocatorService _questService;
    private readonly IPlayQuestService _playService;
    private readonly ICharacterBusinessService _characterService;
    private readonly ITechBusinessService _businessService;
    public static string TestingProcess { get; set; } = "Testing Quest";
    public TestPlayQuestViewModel(IChooseCivViewModel civVM,
        IQuestLocatorService questService,
        IPlayQuestService playService,
        ICharacterBusinessService characterService,
        ITechBusinessService businessService
        )
    {
        _civVM = civVM;
        _questService = questService;
        _playService = playService;
        _characterService = characterService;
        _businessService = businessService;
    }
    private string SpecialTitle() => $"{TestingProcess} For Civilization {_civVM.CivilizationChosen!.FullName}";
    string IPlayQuestViewModel.Title => _civVM.Title(SpecialTitle);
    bool IPlayQuestViewModel.CanGoBack => _civVM.CanGoBack();
    async Task IPlayQuestViewModel.PlayCivAsync()
    {
        //this means you chose to play the quest.  everything that is needed so it can open to play is needed.
        if (ll1.MainLocation == "")
        {
            throw new CustomBasicException("Must set up ahead of time now.  Since locations can change");
        }
        if (dd1.NewGamePath == "")
        {
            throw new CustomBasicException("Must set the new game path ahead of time now");
        }
        await _businessService.DoAllTechsAsync();
        await _characterService.CopyCharacterFilesAsync();
        _questService.CopyQuest();
        _playService.OpenOfflineGame(dd1.SpartanDirectoryPath);
    }
    void IPlayQuestViewModel.ResetCiv()
    {
        _civVM.ResetCiv();
    }
}