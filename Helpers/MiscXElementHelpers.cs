namespace AOEOBasicDataLibrary.Helpers;
public static class MiscXElementHelpers
{
    //i think this may still be fine (?)
    public static BasicList<XElement> GetUnits(this XElement source) => source.Descendants("Unit").ToBasicList();
    /// <summary>
    /// this can be used for either tech or unit since they use the same xml
    /// </summary>
    /// <param name="list"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static XElement GetName(this BasicList<XElement> list, string name, string category) => list.Single(xx => xx.Attribute("name")!.Value == name && (xx.Attribute("category")!.Value == category || xx.Attribute("category")!.Value == "Any"));
    public static XElement GetName(this BasicList<XElement> list, string name) => list.Single(xx => xx.Attribute("name")!.Value == name);
    public static string GetName(this XElement element) => element.Attribute("name")!.Value;
    public static XElement StartNewHiddenTech(this BasicList<XElement> list, string name)
    {
        XElement element = list.GetName(name);
        element.SetTechElement();
        return element;
    }
    //this now has to be public since its not always a simple hidden tech anymore.
    public static void SetTechElement(this XElement element)
    {
        element.SetAttributeValue("type", "Normal");
        element.SetElementValue("DBID", "4728");
        element.SetElementValue("Status", "UNOBTAINABLE");
        element.SetElementValue("ContentPack", "22");
        element.SetElementValue("Flag", "IsAward");
    }
    public static XElement StartNewHiddenTech(this BasicList<XElement> list, string name, string category)
    {
        XElement element = list.GetName(name, category);
        element.SetTechElement();
        return element;
    }
}