namespace AOEOBasicDataLibrary.Helpers;
public static class CharacterHelpers
{
    //now its public since it can be accessed from anywhere now.
    public static string GetCharacterPath(this string civ) => $@"{dd1.RawCharacterLocations}\{civ}.character"; //now needs this one
    public static void CleanCharacterFiles()
    {
        BasicList<string> olds = dd1.GetCharacters();
        olds.ForEach(ff1.DeleteFile);
    }
    public static void AddCharacterTech(this XElement techs, string techName, string value = "active")
    {
        XElement element = new("tech");
        element.SetAttributeValue("status", value);
        element.SetAttributeValue("persistentcitystatus", value);
        element.Value = techName; //hopefully this simple now.
        techs.Add(element); //these are additional techs being added.
    }
    //i can agree this is the best way to handle it.  its flexible where it gets the data but these are good names for the starting techs.
    public static IAddTechsToCharacterService AddTraitTechs(this IAddTechsToCharacterService techs)
    {
        techs.Tech!.AddCharacterTech("Traits");
        return techs;
    }
    public static IAddTechsToCharacterService AddMilestoneTechs(this IAddTechsToCharacterService techs)
    {
        techs.Tech!.AddCharacterTech("Milestones");
        return techs;
    }
    public static IAddTechsToCharacterService AddWonderTechs(this IAddTechsToCharacterService techs)
    {
        techs.Tech!.AddCharacterTech("PrepWonder");
        techs.Tech!.AddCharacterTech("EnableWonder", "Obtainable");
        return techs;
    }
    public static IAddTechsToCharacterService AddAdvisorTechs(this IAddTechsToCharacterService techs)
    {
        techs.Tech!.AddCharacterTech("Age1");
        techs.Tech!.AddCharacterTech("Age2", "Obtainable");
        techs.Tech!.AddCharacterTech("Age3", "Obtainable");
        techs.Tech!.AddCharacterTech("Age4", "Obtainable");
        return techs;
    }
    public static IAddTechsToCharacterService SaveTechs(this IAddTechsToCharacterService techs)
    {
        techs.Source!.Save(techs.CharacterPath);
        return techs;
    }
}