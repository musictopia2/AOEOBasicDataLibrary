namespace AOEOBasicDataLibrary.Helpers;
public static class BasicGameLocationHelpers //i think adding game is important this time.
{
    public static string OriginalAOEOPath { get; set; } = ""; //some processes may need it like transferring files.
    public static string NewGamePath { get; set; } = "";
    public static string OldQuestPath(string fileName) => @$"{NewQuestFileDirectory}\{fileName}.quest";
    public static string NewQuestPath => @$"{GameQuestFileDirectory}\current.quest"; //hopefully renaming is fine (?)
    public static string StandardAdvisorFileLocation => @$"{SpartanDirectoryPath}\DATA\advisors.xml"; //still okay.
    public static string RawUnitLocation => @$"{RawGameDataPath}\protoAge4.xml";
    public static string NewUnitLocation => @$"{SpartanDirectoryPath}\DATA\protoAge4.xml";
    public static string NewTechLocation => @$"{SpartanDirectoryPath}\DATA\techtreex.xml"; //now we need this as well.
    public static string RawExtraTraitsLocation => @$"{RawGameDataPath}\extratraits.xml";
    public static string TraitFileLocation => @$"{SpartanDirectoryPath}\DATA\traits.xml"; //since i made a backup, if any problems, just restore and do again.
    public static string RawTechLocation => @$"{RawGameDataPath}\techtreex.xml";
    public static string RawStringTableLocation => @$"{RawGameDataPath}\stringtablex.xml";
    public static string RawGameDataPath => Path.Combine(NewGamePath, "RawGameData");
    public static string RawCharacterLocations => $@"{NewGamePath}\RawCharacterData";
    public static string NewCharacterLocation(string civ) => @$"{SpartanDirectoryPath}\DATA\AI\!{civ}.character"; //no longer andy.
    public static BasicList<string> GetCharacters()
    {
        BasicList<string> output = ff1.FileList(@$"{SpartanDirectoryPath}\DATA\AI\");
        return output;
    }
    public static string SpartanDirectoryPath => Path.Combine(NewGamePath, "GameFiles");
    public static string NewStringTableLocation => @$"{SpartanDirectoryPath}\DATA\stringtablex.xml";
    public static string GameQuestFileDirectory => Path.Combine(SpartanDirectoryPath, "DATA", "Quests"); //i think
    //public static string RejectedQuestFileDirectory => Path.Combine(NewGamePath, "RejectedQuests");
    //public static string CustomQuestFileDirectory => Path.Combine(NewGamePath, "CustomEditedQuests");
    //public static string RawQuestFileDirectory => Path.Combine(NewGamePath, "OriginalQuestFiles"); //hopefully this simple.
    public static string NewQuestFileDirectory => Path.Combine(NewGamePath, "MyQuestFiles");
    //public static string ChampionModeFileDirectory => Path.Combine(NewGamePath, "ChampionQuests");
    //public static string QuestStringTableLocation => @$"{SpartanDirectoryPath}\DATA\QuestStringTable.xml"; //brand new
}