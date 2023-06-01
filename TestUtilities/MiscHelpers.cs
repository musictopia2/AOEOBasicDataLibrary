namespace AOEOBasicDataLibrary.TestUtilities;
public static class MiscHelpers
{
    public static async Task CopyTechsAsync()
    {
        await ff1.FileCopyAsync(dd1.RawTechLocation, dd1.NewTechLocation);
    }
}