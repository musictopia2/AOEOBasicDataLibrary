namespace AOEOBasicDataLibrary.Civs.Helpers;
public static class GlobalCivHelperClass
{
    //any civ you are currently working with should be here.
    public static string CurrentCivAbb { get; set; } = "";
    //this means if you are testing a civ and its populated, then some ui can do something with it.
    public static bool CurrentlyTestingSingle { get; set; }
}