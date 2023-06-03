namespace AOEOBasicDataLibrary.Models;
public class TechValuePairModel
{
    public string OriginalValue { get; set; } = "";
    public string ModifiedValue { get; set; } = "";
    public bool ExcludeFromAutomation { get; set; } //now if marked true, then automation can't help  used for cases especially for low build limits
}