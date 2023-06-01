namespace AOEOBasicDataLibrary.Helpers;
public static class FileHelperClass
{
    //can no longer do setup without a path.
    //a custom process can be single point of truth.
    public static void Setup(string path) //to make it more flexible (just in case its needed).
    {
        Check();
        ll1.MainLocation = path;
    }
    //public static void Setup()
    //{
    //    Check();
    //    ll1.MainLocation = @"\Code"; //this is most common.  however, not always this pattern.
    //}
    private static void Check()
    {
        if (dd1.NewGamePath == "")
        {
            throw new CustomBasicException("Needs to populate NewGamePath.  Hint.  Create a new library that will have the path you want to use.");
        }
    }
}