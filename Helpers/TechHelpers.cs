namespace AOEOBasicDataLibrary.Helpers;
public static class TechHelpers
{
    public static BasicList<XElement> GetTechs(this XElement source) => source.Descendants("Tech").ToBasicList();
    public static string GetTechTitle(this XElement tech)
    {
        string output = tech.Element("DisplayNameID")!.Value;
        return QuestStringTableHelpers.GetQuestStringValue(int.Parse(output));
    }
    public static string GetTechDescription(this XElement tech)
    {
        string output = tech.Element("RolloverTextID")!.Value;
        return QuestStringTableHelpers.GetQuestStringValue(int.Parse(output));
    }
    public static string GetTechName(this XElement tech)
    {
        return tech.Attribute("name")!.Value;
    }
    public static XElement GetTechElements()
    {
        return XElement.Load(dd1.NewTechLocation); //i think.
    }
    //this will allow for any implementation of processing tech files that involve getting additional techs from file.
    //since file is a common way to store data (obviously, a person is not limited to just file storage).
    public static BasicList<XElement> GetTechElements(this string path)
    {
        XElement firsts = XElement.Load(ll1.GetLocation(path));
        return firsts.Elements("Tech").ToBasicList();
    }
    public static XElement GetSingleTechElement(this string path)
    {
        XElement firsts = XElement.Load(ll1.GetLocation(path));
        return firsts.Elements("Tech").Single();
    }
    public static bool OptionalOnlyAllowEffectsAccumulateNoStone(this XElement element)
    {
        var firsts = element.Attribute("subtype");
        if (firsts is null)
        {
            return true;
        }
        if (firsts.Value == "Cost")
        {
            return true; //doing something with stone cost is proper.
        }
        var item = element.Attribute("resource");
        if (item is null)
        {
            return true;
        }
        if (item.Value == "Stone")
        {
            return false;
        }
        return true;
    }
    public static Func<XElement, bool>? EffectAllowed { get; set; }
    public static IAddTechsToTechTreeService AddAdvisorTechs(this IAddTechsToTechTreeService techs, string path)
    {
        //this is if you are using file storage
        BasicList<XElement> list = path.GetTechElements();
        if (list.Count != 4)
        {
            throw new CustomBasicException("Must have 4 techs for advisors");
        }
        foreach (XElement tech in list)
        {
            techs.AddEffects(tech);
        }
        return techs;
    }
    private static void AddEffects(this IAddTechsToTechTreeService techs, XElement tech)
    {
        tech.SetTechElement();
        //risk not doing the settechelement if i am wrong, rethink

        BasicList<XElement> effects = tech.Elements("Effects").Single().Elements().ToBasicList();
        BasicList<XElement> others = effects.ToBasicList();
        foreach (var effect in effects)
        {
            if (EffectAllowed is not null)
            {
                bool rets = EffectAllowed(effect);
                if (rets == false)
                {
                    others.RemoveSpecificItem(effect);
                }
            }
        }
        tech.Elements("Effects").Single().ReplaceAll(others);
        techs.Source!.Add(tech);
    }
    public static IAddTechsToTechTreeService AddMultipleMiscTechs(this IAddTechsToTechTreeService techs, string path)
    {
        BasicList<XElement> list = path.GetTechElements();
        foreach (var tech in list)
        {
            techs.AddEffects(tech);
        }
        return techs;
    }
    public static IAddTechsToTechTreeService AddSingleTech(this IAddTechsToTechTreeService techs, string path)
    {
        XElement tech = path.GetSingleTechElement();
        techs.AddEffects(tech);
        return techs;
    }
    public static async Task CopyTechsAsync()
    {
        await ff1.FileCopyAsync(dd1.RawTechLocation, dd1.NewTechLocation);
    }
}