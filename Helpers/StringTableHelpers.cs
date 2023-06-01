namespace AOEOBasicDataLibrary.Helpers;
public static class StringTableHelpers
{
    private static BasicList<XElement> _strings = new();
    private static void Startup()
    {
        if (_strings.Count > 0)
        {
            return;
        }
        XElement source = XElement.Load(dd1.NewStringTableLocation);
        _strings = source.Descendants("language").Descendants("string").ToBasicList();
        if (_strings.Count == 0)
        {
            throw new CustomBasicException("Must have at least one string");
        }
    }
    public static string GetStringValue(this int lookup)
    {
        Startup();
        return _strings.Single(xx => xx.Attribute("_locid")!.Value == lookup.ToString()).Value; //hopefully this simple.
    }
}