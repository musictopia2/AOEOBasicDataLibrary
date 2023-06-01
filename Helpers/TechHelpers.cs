namespace AOEOBasicDataLibrary.Helpers;
public static class TechHelpers
{
    public static BasicList<XElement> GetTechs(this XElement source) => source.Descendants("Tech").ToBasicList();
    public static string GetTechTitle(this XElement tech)
    {
        string output = tech.Element("DisplayNameID")!.Value;
        return StringTableHelpers.GetStringValue(int.Parse(output));
    }
    public static string GetTechDescription(this XElement tech)
    {
        string output = tech.Element("RolloverTextID")!.Value;
        return StringTableHelpers.GetStringValue(int.Parse(output));
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
    public static IAddTechsToTechTreeService AddAdvisorTechs(this IAddTechsToTechTreeService techs, string path)
    {
        //this is if you are using file storage
        BasicList<XElement> list = path.GetTechElements();
        if (list.Count != 4)
        {
            throw new CustomBasicException("Must have 4 techs for advisors");
        }
        int upto = techs.Source!.Elements().Count();
        foreach (XElement tech in list)
        {
            //tech.SetTechElement();
            //risk not doing the settechelement if i am wrong, rethink
            techs.Source.Add(tech);
            upto++;
        }
        return techs;
    }
    public static IAddTechsToTechTreeService AddMultipleMiscTechs(this IAddTechsToTechTreeService techs, string path)
    {
        BasicList<XElement> list = path.GetTechElements();
        foreach (var tech in list)
        {
            tech.SetTechElement();
            techs.Source!.Add(tech);
        }
        return techs;
    }
    public static IAddTechsToTechTreeService AddSingleTech(this IAddTechsToTechTreeService techs, string path)
    {
        XElement tech = path.GetSingleTechElement();
        tech.SetTechElement();
        techs!.Source!.Add(tech);
        return techs;
    }
}