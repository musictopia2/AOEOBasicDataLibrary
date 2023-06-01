namespace AOEOBasicDataLibrary.Services;
public class PlayQuestService : IPlayQuestService
{
    void IPlayQuestService.OpenOfflineGame(string gamePath)
    {
        ProcessStartInfo starts = new();
        //for now, this is fine.
        starts.WorkingDirectory = gamePath;
        starts.FileName = @$"{gamePath}\Spartan.exe"; //this will make it useful for any project now.  if this works out, then refactor for next version.
        starts.Arguments = " --offline --ignore_rest LauncherLang=en-US LauncherLocale=1033";
        starts.CreateNoWindow = true;
        starts.UseShellExecute = false;
        Process procs = new();
        procs.StartInfo = starts;
        procs.Start();
        procs.Close();
        procs.Dispose();
    }
}