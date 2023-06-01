namespace AOEOBasicDataLibrary.Civs.Constants;
public static class EgyptianUnits
{
    public const string TempleOfRa = "Eg_Bldg_Temple1";
    public const string PriestOfRa = "Eg_Spc_PriestRa";
    public const string TempleOfSet = "Eg_Bldg_Temple2";
    public const string TempleOfPtah = "Eg_Bldg_Temple3";
    public const string PriestOfPtah = "Eg_Spc_PriestPtah";
    public const string PriestOfSet = "Eg_Spc_PriestSet";
    public const string ChariotArcher = "Eg_Arc_ChariotArcher";
    public const string ElephantArcher = "Eg_Arc_ElephantArcher";
    public const string Slinger = "Eg_Arc_Slinger"; //since i can't use archery range as egyptians, decided to not have that one.
    public const string Armory = "Eg_Bldg_Armory";
    public const string Barracks = "Eg_Bldg_Barracks";
    public const string Dock = "Eg_Bldg_Dock";
    public const string Farm = "Eg_Bldg_Farm";
    public const string Fortress = "Eg_Bldg_Fortress";
    public const string GuardTower = "Eg_Bldg_GuardTower";
    public const string House = "Eg_Bldg_House";
    public const string WatchPost = "Eg_Bldg_LookoutTower";
    public const string Market = "Eg_Bldg_Market";
    public const string SiegeWorkshop = "Eg_Bldg_SiegeWorkshop";
    public const string Stables = "Eg_Bldg_Stables";
    public const string TownCenter = "Eg_Bldg_TownCenter";
    public const string Wonder = "Eg_Bldg_Wonder";
    public const string Storehouse = "Eg_Bldg_StoreHouse";
    public const string Scout = "Eg_Cav_Scout";
    public const string CamelRider = "Eg_Cav_CamelRider";
    public const string WarElephant = "Eg_Cav_WarElephant";
    public const string Caravan = "Eg_Civ_Caravan";
    public const string FishingBoat = "Eg_Civ_FishingBoat";
    public const string MerchantTransport = "Eg_Civ_UtilityBoat";
    public const string Villager = "Eg_Civ_Villager";
    public const string Axeman = "Eg_Inf_Axeman";
    public const string Spearman = "Eg_Inf_Spearman";
    public const string CatapultTrireme = "Eg_Shp_CatTrireme";
    public const string Trireme = "Eg_Shp_Trireme";
    public const string FireShip = "Eg_Shp_FireShip";
    public const string SiegeTower = "Eg_Sie_SiegeTower";
    public const string Catapult = "Eg_Sie_Catapult";
    public const string Palintonon = "Eg_Sie_Trebuchet";
    public const string Wall = "Eg_WallConnector";
    public const string Gate = "Eg_WallGate";
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
            TempleOfPtah,
            TempleOfRa,
            TempleOfSet,
            Barracks,
            Market,
            Armory,
            Stables,
            Wonder,
            Storehouse,
            SiegeWorkshop
        };
    }
}