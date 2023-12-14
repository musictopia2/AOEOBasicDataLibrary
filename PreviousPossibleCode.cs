//if i ever need the testing hard codes, then will be here.
//obviously needs civ stuff.



//namespace AOEOBasicDataLibrary.Models;
//public interface ISelectableTech //still need this just in case we need to choose different advisors, milestones.
//{
//    bool DidChoose { get; set; }
//    string Title { get; }
//    string Description { get; }
//}


//namespace AOEOBasicDataLibrary.ViewModels;
//public class TestPlayQuestViewModel : IPlayQuestViewModel
//{
//    private readonly IChooseCivViewModel _civVM;
//    private readonly IQuestLocatorService _questService;
//    private readonly IPlayQuestService _playService;
//    private readonly ICharacterBusinessService _characterService;
//    private readonly ITechBusinessService _businessService;
//    public static string TestingProcess { get; set; } = "Testing Quest";
//    public TestPlayQuestViewModel(IChooseCivViewModel civVM,
//        IQuestLocatorService questService,
//        IPlayQuestService playService,
//        ICharacterBusinessService characterService,
//        ITechBusinessService businessService
//        )
//    {
//        _civVM = civVM;
//        _questService = questService;
//        _playService = playService;
//        _characterService = characterService;
//        _businessService = businessService;
//    }
//    private string SpecialTitle() => $"{TestingProcess} For Civilization {_civVM.CivilizationChosen!.FullName}";
//    string IPlayQuestViewModel.Title => _civVM.Title(SpecialTitle);
//    bool IPlayQuestViewModel.CanGoBack => _civVM.CanGoBack();
//    async Task IPlayQuestViewModel.PlayCivAsync()
//    {
//        //this means you chose to play the quest.  everything that is needed so it can open to play is needed.
//        if (ll1.MainLocation == "")
//        {
//            throw new CustomBasicException("Must set up ahead of time now.  Since locations can change");
//        }
//        if (dd1.NewGamePath == "")
//        {
//            throw new CustomBasicException("Must set the new game path ahead of time now");
//        }
//        await _businessService.DoAllTechsAsync();
//        await _characterService.CopyCharacterFilesAsync();
//        _questService.CopyQuest();
//        _playService.OpenOfflineGame(dd1.SpartanDirectoryPath);
//    }
//    void IPlayQuestViewModel.ResetCiv()
//    {
//        _civVM.ResetCiv();
//    }
//}


//namespace AOEOBasicDataLibrary.ViewModels;
//public interface IPlayQuestViewModel
//{
//    //decided to have the main here now.
//    Task PlayCivAsync();
//    string Title { get; }
//    bool CanGoBack { get; }
//    void ResetCiv();
//}


//namespace AOEOBasicDataLibrary.TestUtilities;
//public static class MiscExtensions
//{
//    public static void CopyQuest(this IQuestLocatorService quest)
//    {
//        string oldPath = quest.OldQuestPath;
//        string newPath = dd1.NewQuestPath;
//        ff1.FileCopy(oldPath, newPath);
//    }
//    public static string Title(this IChooseCivViewModel viewModel, Func<string> extras)
//    {
//        if (viewModel.CivilizationChosen is null)
//        {
//            return "Choose Civilization";
//        }
//        return extras.Invoke();
//    }
//    public static bool CanGoBack(this IChooseCivViewModel viewModel) => viewModel.CivilizationChosen is not null;
//    public static void ResetCiv(this IChooseCivViewModel viewModel)
//    {
//        viewModel.CivilizationChosen = null;
//    }
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public class AccumulateNoStoneOptionalLocatorService : IQuestLocatorService
//{
//    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Argos_S43_Laconia_Bandits_Legendary.quest");
//    string IQuestLocatorService.OldQuestTitle => "Sample Breaking Bandits";
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public class Age1QuestLocatorService : IQuestLocatorService
//{
//    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2020_M024_BigQuest4.quest");
//    string IQuestLocatorService.OldQuestTitle => "Sample Bring Out Your Dead";
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public class Age2QuestLocatorService : IQuestLocatorService
//{
//    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2020_M024_BigQuest5.quest");
//    string IQuestLocatorService.OldQuestTitle => "Sample Only The Gourd Die Young";
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public class Age3QuestLocatorService : IQuestLocatorService
//{
//    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2019_M023_BigQuest3.quest");
//    string IQuestLocatorService.OldQuestTitle => "Sample Finest Horror";
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public class Hardest5StarQuestLocatorService : IQuestLocatorService
//{
//    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Rhakotis_M0109_Quest_8_Legendary.quest");
//    string IQuestLocatorService.OldQuestTitle => "Sample Valley Of The Kings";
//}

//namespace AOEOBasicDataLibrary.TestUtilities;
//public interface IQuestLocatorService
//{
//    string OldQuestPath { get; } //this is where we decide what old quest to play.
//    string OldQuestTitle { get; } //also needs the old quest title as well.  i could decide to hard code.
//}

