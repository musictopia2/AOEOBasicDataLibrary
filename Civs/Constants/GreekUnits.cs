namespace AOEOBasicDataLibrary.Civs.Constants;
public static class GreekUnits
{
    public const string Farm = "Gr_Bldg_Farm";
    public const string Gate = "CWallGate";
    public const string Wall = "WallConnector";
    public const string TownCenter = "Gr_Bldg_TownCenter";
    public const string Villager = "Gr_Civ_Villager";
    public const string Spearman = "Gr_Inf_Spearman";
    public const string Hoplite = "Gr_Inf_Hoplite";
    public const string Hypaspist = "Gr_Inf_Hypaspist";
    public const string Toxotes = "Gr_Arc_Toxotai";
    public const string Hippikon = "Gr_Cav_Hippikon";
    public const string Peltast = "Gr_Arc_Peltast";
    public const string Prodromos = "Gr_Cav_Podromos";
    public const string Ballista = "Gr_Sie_Ballista";
    public const string BatteringRam = "Gr_Sie_BatteringRam";
    public const string Barracks = "Gr_Bldg_Barracks";
    public const string Academy = "Gr_Bldg_Academy";
    public const string ArcheryRange = "Gr_Bldg_ArcheryRange";
    public const string Dock = "Gr_Bldg_Dock";
    public const string House = "Gr_Bldg_House";
    public const string Market = "Gr_Bldg_Market";
    public const string SiegeWorkshop = "Gr_Bldg_SiegeWorkshop";
    public const string Storehouse = "Gr_Bldg_StoreHouse";
    public const string Temple = "Gr_Bldg_Temple";
    public const string WatchPost = "Gr_Bldg_LookoutTower";
    public const string GuardTower = "Gr_Bldg_GuardTower";
    public const string Armory = "Gr_Bldg_Armory";
    public const string Stables = "Gr_Bldg_Stables";
    public const string Caravan = "Gr_Civ_Caravan";
    public const string FishingBoat = "Gr_Civ_FishingBoat";
    public const string MerchantTransport = "Gr_Civ_UtilityBoat";
    public const string Priest = "Gr_Spc_Priest";
    public const string Trireme = "Gr_Shp_Trireme";
    public const string BallistaTrireme = "Gr_Shp_CatTrireme";
    public const string Fortress = "Gr_Bldg_Fortress";
    public const string Palintonon = "Gr_Sie_Palintonon";
    public const string Scout = "Gr_Cav_Scout";
    public const string Wonder = "Gr_Bldg_Wonder";
    public const string Sarissophoroi = "Gr_Cav_Sarissophoroi";
    public const string Gastraphetes = "Gr_Arc_Gastrophes";
    public const string FireShip = "Gr_Shp_FireShip";
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
            Temple,
            Academy,
            Barracks,
            Market,
            ArcheryRange,
            Armory,
            Stables,
            Wonder,
            Storehouse,
            SiegeWorkshop
        };
    }
}