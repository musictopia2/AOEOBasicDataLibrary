namespace AOEOBasicDataLibrary.Helpers;
public static class StringTableHelpers
{
    private static BasicList<XElement> _strings = [];
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
    extension (int lookup)
    {
        public string GetStringValue()
        {
            Startup();
            return _strings.Single(xx => xx.Attribute("_locid")!.Value == lookup.ToString()).Value; //hopefully this simple.
        }
    }
}