namespace AOEOBasicDataLibrary.Services;
public class TechBusinessService : ITechBusinessService
{
    private readonly IAddTechsToTechTreeService _add;
    public TechBusinessService(IAddTechsToTechTreeService add)
    {
        _add = add;
    }
    Task ITechBusinessService.DoAllTechsAsync()
    {
        XElement element = XElement.Load(dd1.RawTechLocation); //looks like i have to do raw location.  otherwise gets hosed.
        _add.Source = element;
        _add.AddTechs();
        element.Save(dd1.NewTechLocation);
        return Task.CompletedTask;
    }
}