namespace AOEOBasicDataLibrary.Civs.Constants;
public static class BabylonUnits
{
    public const string Villager = "Ba_Civ_Villager";
    public const string FishingBoat = "Ba_Civ_FishingBoat";
    public const string Caravan = "Ba_Civ_Caravan";
    public const string MerchantTransport = "Ba_Civ_UtilityBoat";
    public const string OxCart = "Ba_Civ_OxCart";
    public const string Spearman = "Ba_Inf_Spearman";
    public const string RoyalGuard = "Ba_Inf_RoyalGuard";
    public const string Bowman = "Ba_Arc_Bowman";
    public const string Scout = "Ba_Cav_Scout";
    public const string Lancer = "Ba_Cav_Lancer";
    public const string Palintonon = "Ba_Sie_Palintonon";
    public const string Priest = "Ba_Spc_Priest";
    public const string TownCenter = "Ba_Bldg_TownCenter";
    public const string Dock = "Ba_Bldg_Dock";
    public const string WatchPost = "Ba_Bldg_LookoutTower";
    public const string House = "Ba_Bldg_House";
    public const string Barracks = "Ba_Bldg_Barracks";
    public const string Farm = "Ba_Bldg_Farm";
    public const string Market = "Ba_Bldg_Market";
    public const string GuardTower = "Ba_Bldg_GuardTower";
    public const string Armory = "Ba_Bldg_Armory";
    public const string ArcheryRange = "Ba_Bldg_ArcheryRange";
    public const string Stables = "Ba_Bldg_Stables";
    public const string Ziggurat = "Ba_Bldg_Ziggurat";
    public const string SiegeWorkshop = "Ba_Bldg_SiegeWorkshop";
    public const string Fortress = "Ba_Bldg_Fortress";
    public const string Wonder = "Ba_Bldg_Wonder";
    public const string ClayWall = "Ba_WallConnector";
    public const string Gate = "Ba_WallGate";
    public const string Slinger = "Ba_Arc_Slinger";
    public const string ChariotArcher = "Ba_Arc_ChariotArcher";
    public const string Sapper = "Ba_Inf_Sapper";
    public const string SiegeTower = "Ba_Sie_SiegeTower";
    public const string WarChariot = "Ba_Arc_WarChariot";
    public const string MountedArcher = "Ba_Arc_MountedArcher";
    public const string Bireme = "Ba_Shp_Bireme";
    public const string RamShip = "Ba_Shp_RamShip";
    public const string ShieldBearer = "Ba_Inf_ShieldBearer";
    public const string Garden = "Ba_Bldg_Garden"; //since the babylon storehouse is not valid, then ignore that one.
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
            Ziggurat,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            Stables,
            Wonder,
            Garden,
            SiegeWorkshop
        };
    }
}