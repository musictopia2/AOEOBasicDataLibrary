namespace AOEOBasicDataLibrary.Civs.Constants;
public static class RomanUnits
{
    public const string House = "Ro_Bldg_House";
    public const string Fortress = "Ro_Bldg_Fortress";
    public const string TownCenter = "Ro_Bldg_TownCenter";
    public const string Castellum = "Ro_Bldg_Barracks";
    public const string AuxiliaCamp = "Ro_Bldg_AuxiliaCamp";
    public const string Praetorium = "Ro_Bldg_OfficerTent";
    public const string SiegeWorkshop = "Ro_Bldg_SiegeWorkshop";
    public const string Armory = "Ro_Bldg_Armory";
    public const string Farm = "Ro_Bldg_Farm";
    public const string Storehouse = "Ro_Bldg_StoreHouse";
    public const string Forum = "Ro_Bldg_Forum";
    public const string Market = "Ro_Bldg_Market";
    public const string Templum = "Ro_Bldg_Templum";
    public const string GuardTower = "Ro_Bldg_GuardTower";
    public const string Wall = "Ro_WallConnector";
    public const string Gate = "Ro_WallGate";
    public const string Dock = "Ro_Bldg_Dock";
    public const string WatchPost = "Ro_Bldg_LookoutTower";
    public const string Wonder = "Ro_Bldg_Wonder";
    public const string Villager = "Ro_Civ_Villager";
    public const string Engineer = "Ro_Civ_Engineer";
    public const string Clinicus = "Ro_Spc_Clinicus";
    public const string Caravan = "Ro_Civ_Caravan";
    public const string FishingBoat = "Ro_Civ_FishingBoat";
    public const string MerchantTransport = "Ro_Civ_UtilityBoat";
    public const string Liburnian = "Ro_Shp_Liburnian";
    public const string Enneris = "Ro_Shp_Enneris";
    public const string Spearman = "Ro_Inf_Spearman";
    public const string Legionary = "Ro_Inf_Legionary";
    public const string Eques = "Ro_Cav_Eques";
    public const string BalearicSlinger = "Ro_Arc_Slinger";
    public const string CretanBowman = "Ro_Arc_Bowman";
    public const string GallicHorseman = "Ro_Cav_Horseman";
    public const string Aquilifer = "Ro_Inf_Aquilifer";
    public const string Centurion = "Ro_Inf_Centurion";
    public const string Decurion = "Ro_Cav_Decurion";
    public const string PrimusPilus = "Ro_Cav_PrimusPilus";
    public const string BatteringRam = "Ro_Sie_BatteringRam";
    public const string Scorpio = "Ro_Sie_Scorpio";
    public const string Onager = "Ro_Sie_Onager";
    public const string Palintonon = "Ro_Sie_Palintonon";
    public const string Pontifex = "Ro_Spc_Priest";
    public const string Scout = "Ro_Cav_Scout";
    public const string Millarium = "Ro_Bldg_Millarium";
    public static BasicList<string> GetFarmsAndHouses()
    {
        return new()
        {
            Farm,
            House
        };
    }
    public static BasicList<string> GetSpecialBuildings()
    {
        return new()
        {
            Dock,
            Templum,
            Forum,
            Castellum,
            Market,
            Armory,
            Praetorium,
            AuxiliaCamp,
            Wonder,
            Storehouse,
            SiegeWorkshop,
            Millarium
        };
    }
    public static BasicList<string> GetOfficers()
    {
        return new()
        {
            Aquilifer,
            Decurion,
            PrimusPilus,
            Centurion
        };
    }
}