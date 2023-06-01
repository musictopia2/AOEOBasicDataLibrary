namespace AOEOBasicDataLibrary.Civs.DataServices;
public interface ICivilizationDataService //decided to make this under basics.  because this has nothing to do with accomodations.  this is just civ specific.
{
    Task<BasicList<CivilizationBasicModel>> GetCivilizationsAsync();
}