namespace AOEOBasicDataLibrary.Civs.Constants;
public static class CeltUnits
{
    public const string Spearman = "Ce_Inf_Spearman";
    public const string LongSwordsman = "Ce_Inf_LongSwordsman";
    public const string WoadRaider = "Ce_Inf_WoadRaider";
    public const string Champion = "Ce_Inf_Champion";
    public const string Slinger = "Ce_Arc_Slinger";
    public const string Bowman = "Ce_Arc_Bowman";
    public const string Scout = "Ce_Cav_Scout";
    public const string Horseman = "Ce_Cav_Horseman";
    public const string Swanship = "Ce_Shp_Warship";
    public const string Druid = "Ce_Spc_Druid";
    public const string Augur = "Ce_Spc_DruidAugur";
    public const string Villager = "Ce_Civ_Villager";
    public const string FishingBoat = "Ce_Civ_FishingBoat";
    public const string MerchantTransport = "Ce_Civ_UtilityBoat";
    public const string Caravan = "Ce_Civ_Caravan";
    public const string TownCenter = "Ce_Bldg_TownCenter";
    public const string Dock = "Ce_Bldg_Dock";
    public const string WatchPost = "Ce_Bldg_LookoutTower";
    public const string StoreHouse = "Ce_Bldg_StoreHouse";
    public const string House = "Ce_Bldg_House";
    public const string Barracks = "Ce_Bldg_Barracks";
    public const string Farm = "Ce_Bldg_Farm";
    public const string Market = "Ce_Bldg_Market";
    public const string GuardTower = "Ce_Bldg_GuardTower";
    public const string Armory = "Ce_Bldg_Armory";
    public const string ArcheryRange = "Ce_Bldg_ArcheryRange";
    public const string Stables = "Ce_Bldg_Stables";
    public const string SacredGrove = "Ce_Bldg_SacredGrove";
    public const string BardHall = "Ce_Bldg_BardHall";
    public const string Fortress = "Ce_Bldg_Fortress";
    public const string Ram = "Ce_Sie_Ram";
    public const string Wonder = "Ce_Bldg_Wonder";
    public const string Wall = "Ce_WallConnector";
    public const string Gate = "Ce_WallGate";
    public const string GoldMine = "Ce_Bldg_GoldMine";
    public const string Carpentom = "Ce_Arc_Carpentom";
    public const string StoneThrower = "Ce_Sie_Palintonon";
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
            StoreHouse,
            BardHall,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            SacredGrove,
            Stables,
            Wonder,
            GoldMine
        };
    }
}