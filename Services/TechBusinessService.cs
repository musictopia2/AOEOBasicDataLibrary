namespace AOEOBasicDataLibrary.Services;
public class TechBusinessService(IAddTechsToTechTreeService add) : ITechBusinessService
{
    Task ITechBusinessService.DoAllTechsAsync()
    {
        XElement element = XElement.Load(dd1.RawTechLocation); //looks like i have to do raw location.  otherwise gets hosed.
        add.Source = element;
        add.AddTechs();
        element.Save(dd1.NewTechLocation);
        return Task.CompletedTask;
    }
}