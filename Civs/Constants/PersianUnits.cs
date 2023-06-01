namespace AOEOBasicDataLibrary.Civs.Constants;
public static class PersianUnits
{
    public const string Sparabara = "Pe_Inf_Sparabara";
    public const string Spearman = "Pe_Inf_Spearman";
    public const string Immortal = "Pe_Inf_Immortal";
    public const string Bowman = "Pe_Arc_Bowman";
    public const string Takabara = "Pe_Arc_Takabara";
    public const string Scout = "Pe_Cav_Scout";
    public const string Asabara = "Pe_Cav_Asabara";
    public const string MountedArcher = "Pe_Arc_MountedArcher";
    public const string Cataphract = "Pe_Cav_Cataphract";
    public const string BatteringRam = "Pe_Sie_BatteringRam";
    public const string WarWagon = "Pe_Sie_WarWagon";
    public const string Palintonon = "Pe_Sie_Palintonon";
    public const string Galley = "Pe_Shp_Galley";
    public const string RamShip = "Pe_Shp_RamShip";
    public const string Magus = "Pe_Spc_Magus";
    public const string Villager = "Pe_Civ_Villager";
    public const string FishingBoat = "Pe_Civ_FishingBoat";
    public const string Caravan = "Pe_Civ_Caravan";
    public const string MerchantTransport = "Pe_Civ_UtilityBoat";
    public const string MangonelGalley = "Pe_Shp_MangonelGalley";
    public const string WarAcademy = "Pe_Bldg_WarAcademy";
    public const string ArcheryRange = "Pe_Bldg_ArcheryRange";
    public const string Armory = "Pe_Bldg_Armory";
    public const string Barracks = "Pe_Bldg_Barracks";
    public const string Dock = "Pe_Bldg_Dock";
    public const string Farm = "Pe_Bldg_Farm";
    public const string Fortress = "Pe_Bldg_Fortress";
    public const string GuardTower = "Pe_Bldg_GuardTower";
    public const string House = "Pe_Bldg_House";
    public const string WatchPost = "Pe_Bldg_LookoutTower";
    public const string Market = "Pe_Bldg_Market";
    public const string SiegeWorkshop = "Pe_Bldg_SiegeWorkshop";
    public const string Stables = "Pe_Bldg_Stables";
    public const string Storehouse = "Pe_Bldg_StoreHouse";
    public const string TownCenter = "Pe_Bldg_TownCenter";
    public const string Wonder = "Pe_Bldg_Wonder";
    public const string Wall = "Pe_WallConnector";
    public const string Gate = "Pe_WallGate";
    public const string ImmortalCamp = "Pe_Bldg_ImmortalCamp";
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
            WarAcademy,
            ImmortalCamp,
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