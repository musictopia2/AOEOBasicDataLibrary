namespace AOEOBasicDataLibrary.Helpers;
public static class QuestStringTableHelpers
{
    private static string QuestStringTableLocation => @$"{dd1.SpartanDirectoryPath}\DATA\QuestStringTable.xml";
    private static BasicList<XElement> _strings = [];
    private static void Startup()
    {
        if (_strings.Count > 0)
        {
            return;
        }
        XElement source = XElement.Load(QuestStringTableLocation);
        _strings = source.Descendants("language").Descendants("string").ToBasicList();
        if (_strings.Count == 0)
        {
            throw new CustomBasicException("Must have at least one string");
        }
    }
    public static string GetQuestStringValue(this int lookup)
    {
        Startup();
        return _strings.Single(xx => xx.Attribute("_locid")!.Value == lookup.ToString()).Value; //hopefully this simple.
    }
}