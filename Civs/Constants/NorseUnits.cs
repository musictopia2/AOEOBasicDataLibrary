namespace AOEOBasicDataLibrary.Civs.Constants;
public static class NorseUnits
{
    public const string Villager = "No_Civ_Villager";
    public const string FishingBoat = "No_Civ_FishingBoat";
    public const string Caravan = "No_Civ_Caravan";
    public const string MerchantTransport = "No_Civ_UtilityBoat";
    public const string Scout1 = "No_Inf_Scout1";
    public const string Scout2 = "No_Inf_Scout2";
    public const string Skirmisher = "No_Arc_Skirmisher";
    public const string Harjar = "No_Inf_Axeman";
    public const string Berzerker = "No_Inf_Berserker";
    public const string Ulfhednar = "No_Inf_Ulfhednar";
    public const string Chief = "No_Inf_Chief";
    public const string Bowman = "No_Arc_Bowman";
    public const string Raider = "No_Cav_Raider";
    public const string Horseman = "No_Cav_Horseman";
    public const string Farbjor = "No_Sie_Ram";
    public const string LogThrower = "No_Sie_Palintonon";
    public const string Rhapsode = "No_Spc_Bard";
    public const string Longship = "No_Shp_Longship";
    public const string Fireship = "No_Shp_FireShip";
    public const string Seer = "No_Spc_Seer";
    public const string ThrowingAxeman = "No_Inf_ThrowingAxeman";
    public const string WarDog = "No_Cav_WarDog";
    public const string TownCenter = "No_Bldg_TownCenter";
    public const string Dock = "No_Bldg_Dock";
    public const string Outpost = "No_Bldg_LookoutTower";
    public const string Storehouse = "No_Bldg_StoreHouse";
    public const string Longhouse = "No_Bldg_House";
    public const string Barracks = "No_Bldg_Barracks";
    public const string Farm = "No_Bldg_Farm";
    public const string Market = "No_Bldg_Market";
    public const string GuardTower = "No_Bldg_GuardTower";
    public const string Armory = "No_Bldg_Armory";
    public const string ArcheryRange = "No_Bldg_ArcheryRange";
    public const string Stables = "No_Bldg_Stables";
    public const string GreatHall = "No_Bldg_GreatHall";
    public const string Fortress = "No_Bldg_Fortress";
    public const string Wonder = "No_Bldg_Wonder";
    public const string Wall = "No_WallConnector";
    public const string Gate = "No_WallGate";
    public const string Spearman = "No_Inf_Spearman";
    public const string Raven = "No_Raven";
    public static BasicList<string> GetFarmsAndHouses()
    {
        return new()
        {
            Farm,
            Longhouse
        };
    }
    public static BasicList<string> GetSpecialBuildings()
    {
        return new()
        {
            Dock,
            GreatHall,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            Stables,
            Wonder,
            Storehouse,
        };
    }
}