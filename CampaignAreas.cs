using LiveSplit.PathOfExile2AutoSplitter.Component.DTOs;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Constants
{
    public static class CampaignAreas
    {
        #region Act 1
        public static readonly CampaignAreaDto TheRiverbank = new CampaignAreaDto
        {
            AreaId = "G1_1",
            AreaName = "河岸",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ClearfellEncampment = new CampaignAreaDto
        {
            AreaId = "G1_town",
            AreaName = "皆伐營地",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Clearfell = new CampaignAreaDto
        {
            AreaId = "G1_2",
            AreaName = "皆伐",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MudBurrow = new CampaignAreaDto
        {
            AreaId = "G1_3",
            AreaName = "泥沼陋居",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheGrelwood = new CampaignAreaDto
        {
            AreaId = "G1_4",
            AreaName = "葛瑞爾林",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheRedVale = new CampaignAreaDto
        {
            AreaId = "G1_5",
            AreaName = "赤谷",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheGrimTangle = new CampaignAreaDto
        {
            AreaId = "G1_6",
            AreaName = "纏縛陰林",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto CemeteryOfTheEternals = new CampaignAreaDto
        {
            AreaId = "G1_7",
            AreaName = "不朽帝國之墓",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MausoleumOfThePraetor = new CampaignAreaDto
        {
            AreaId = "G1_8",
            AreaName = "政務官陵墓",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TombOfTheConsort = new CampaignAreaDto
        {
            AreaId = "G1_9",
            AreaName = "配偶的墓室",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HuntingGrounds = new CampaignAreaDto
        {
            AreaId = "G1_11",
            AreaName = "獵場",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Freythorn = new CampaignAreaDto
        {
            AreaId = "G1_12",
            AreaName = "弗雷索恩",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto OghamFarmlands = new CampaignAreaDto
        {
            AreaId = "G1_13_1",
            AreaName = "奧格姆農地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto OghamVillage = new CampaignAreaDto
        {
            AreaId = "G1_13_2",
            AreaName = "奧格姆村",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheManorRamparts = new CampaignAreaDto
        {
            AreaId = "G1_14",
            AreaName = "宅第壁壘",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto OghamManor = new CampaignAreaDto
        {
            AreaId = "G1_15",
            AreaName = "奧格姆宅第",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Act 2
        public static readonly CampaignAreaDto VastiriOutskirts = new CampaignAreaDto
        {
            AreaId = "G2_1",
            AreaName = "瓦斯提里郊區",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheArduraCaravan = new CampaignAreaDto
        {
            AreaId = "G2_town",
            AreaName = "阿杜拉車隊",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MawdunQuarry = new CampaignAreaDto
        {
            AreaId = "G2_10_1",
            AreaName = "莫頓挖石場",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MawdunMine = new CampaignAreaDto
        {
            AreaId = "G2_10_2",
            AreaName = "莫頓礦坑",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TraitorsPassage = new CampaignAreaDto
        {
            AreaId = "G2_2",
            AreaName = "叛徒之路",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheHalaniGates = new CampaignAreaDto
        {
            AreaId = "G2_3",
            AreaName = "哈拉妮關口",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Keth = new CampaignAreaDto
        {
            AreaId = "G2_4_1",
            AreaName = "凱斯城",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheLostCity = new CampaignAreaDto
        {
            AreaId = "G2_4_2",
            AreaName = "失落之城",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto BuriedShrines = new CampaignAreaDto
        {
            AreaId = "G2_4_3",
            AreaName = "掩埋神殿",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MastodonBadlands = new CampaignAreaDto
        {
            AreaId = "G2_5_1",
            AreaName = "乳齒象惡地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        // ----- Abyss League ----- //
        public static readonly CampaignAreaDto LightlessPassage = new CampaignAreaDto
        {
            AreaId = "Abyss_Intro",
            AreaName = "無光通道",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheWellOfSouls = new CampaignAreaDto
        {
            AreaId = "Abyss_Hub",
            AreaName = "靈魂深井",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        // ----- End ----- //
        
        public static readonly CampaignAreaDto TheBonePits = new CampaignAreaDto
        {
            AreaId = "G2_5_2",
            AreaName = "骨坑",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ValleyOfTheTitans = new CampaignAreaDto
        {
            AreaId = "G2_6",
            AreaName = "泰坦之谷",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheTitanGrotto = new CampaignAreaDto
        {
            AreaId = "G2_7",
            AreaName = "泰坦石窟",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Deshar = new CampaignAreaDto
        {
            AreaId = "G2_8",
            AreaName = "戴斯哈",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PathOfMourning = new CampaignAreaDto
        {
            AreaId = "G2_9_1",
            AreaName = "悼念之路",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheSpiresOfDeshar = new CampaignAreaDto
        {
            AreaId = "G2_9_2",
            AreaName = "戴斯哈尖塔",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheDreadnought = new CampaignAreaDto
        {
            AreaId = "G2_12_1",
            AreaName = "無畏隊",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto DreadnoughtVanguard = new CampaignAreaDto
        {
            AreaId = "G2_12_2",
            AreaName = "無畏隊先鋒",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TrialOfTheSekhemas = new CampaignAreaDto
        {
            AreaId = "G2_13",
            AreaName = "絲克瑪試煉",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Act 3
        public static readonly CampaignAreaDto SandsweptMarsh = new CampaignAreaDto
        {
            AreaId = "G3_1",
            AreaName = "風沙沼澤",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ZigguratEncampment = new CampaignAreaDto
        {
            AreaId = "G3_town",
            AreaName = "高地神塔營地",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JungleRuins = new CampaignAreaDto
        {
            AreaId = "G3_3",
            AreaName = "叢林遺跡",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheVenomCrypts = new CampaignAreaDto
        {
            AreaId = "G3_4",
            AreaName = "劇毒墓穴",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto InfestedBarrens = new CampaignAreaDto
        {
            AreaId = "G3_2_1",
            AreaName = "感染荒地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto AzakBog = new CampaignAreaDto
        {
            AreaId = "G3_7",
            AreaName = "阿札克泥沼",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto ChimeralWetlands = new CampaignAreaDto
        {
            AreaId = "G3_5",
            AreaName = "龍蜥濕地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JiquanisMachinarium = new CampaignAreaDto
        {
            AreaId = "G3_6_1",
            AreaName = "吉卡尼的機械迷城",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JiquanisSanctum = new CampaignAreaDto
        {
            AreaId = "G3_6_2",
            AreaName = "吉卡尼的聖域",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheMatlanWaterways = new CampaignAreaDto
        {
            AreaId = "G3_2_2",
            AreaName = "瑪特蘭水道",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheDrownedCity = new CampaignAreaDto
        {
            AreaId = "G3_8",
            AreaName = "淹沒之城",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheMoltenVault = new CampaignAreaDto
        {
            AreaId = "G3_9",
            AreaName = "熔岩寶庫",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto ApexOfFilth = new CampaignAreaDto
        {
            AreaId = "G3_11",
            AreaName = "污垢頂峰",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TempleOfKopec = new CampaignAreaDto
        {
            AreaId = "G3_12",
            AreaName = "科佩克神殿",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Utzaal = new CampaignAreaDto
        {
            AreaId = "G3_14",
            AreaName = "奧札爾",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Aggorat = new CampaignAreaDto
        {
            AreaId = "G3_16",
            AreaName = "阿戈拉",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheBlackChambers = new CampaignAreaDto
        {
            AreaId = "G3_17",
            AreaName = "漆黑密室",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheTempleOfChaos = new CampaignAreaDto
        {
            AreaId = "G3_10_Airlock",
            AreaName = "混沌神殿",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        #endregion
        
        #region Act 4
        public static readonly CampaignAreaDto Kingsmarch = new CampaignAreaDto
        {
            AreaId = "G4_town",
            AreaName = "金司馬區",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto IsleOfKin = new CampaignAreaDto
        {
            AreaId = "G4_1_1",
            AreaName = "金氏島",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto VolcanicWarrens = new CampaignAreaDto
        {
            AreaId = "G4_1_2",
            AreaName = "火山迷窟",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto EyeOfHinekora = new CampaignAreaDto
        {
            AreaId = "G4_4_1",
            AreaName = "悉妮蔻拉之眼",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto HallsOfTheDead = new CampaignAreaDto
        {
            AreaId = "G4_4_2",
            AreaName = "亡者之殿",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TrialOfTheAncestors = new CampaignAreaDto
        {
            AreaId = "G4_4_3",
            AreaName = "祖靈的試煉",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto KedgeBay = new CampaignAreaDto
        {
            AreaId = "G4_2_1",
            AreaName = "凱吉灣",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto JourneysEnd = new CampaignAreaDto
        {
            AreaId = "G4_2_2",
            AreaName = "旅程結束",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto AbandonedPrison = new CampaignAreaDto
        {
            AreaId = "G4_5_1",
            AreaName = "廢棄監獄",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto SolitaryConfinement = new CampaignAreaDto
        {
            AreaId = "G4_5_2",
            AreaName = "單獨禁閉",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto WhakapanuIsland = new CampaignAreaDto
        {
            AreaId = "G4_3_1",
            AreaName = "瓦卡帕努島",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto SingingCaverns = new CampaignAreaDto
        {
            AreaId = "G4_3_2",
            AreaName = "吟謠洞窟",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ShrikeIsland = new CampaignAreaDto
        {
            AreaId = "G4_7",
            AreaName = "伯勞鳥之島",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Arastas = new CampaignAreaDto
        {
            AreaId = "G4_8b",
            AreaName = "阿拉塔斯",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheExcavation = new CampaignAreaDto
        {
            AreaId = "G4_10",
            AreaName = "挖掘",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Ngakanu = new CampaignAreaDto
        {
            AreaId = "G4_11_1b",
            AreaName = "尼加卡努",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HeartOfTheTribe = new CampaignAreaDto
        {
            AreaId = "G4_11_2",
            AreaName = "部族之心",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PlundersPoint = new CampaignAreaDto
        {
            AreaId = "G4_13",
            AreaName = "掠奪者之角",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        #endregion
        
        #region Interlude 1
        public static readonly CampaignAreaDto TheRefuge = new CampaignAreaDto
        {
            AreaId = "P1_Town",
            AreaName = "庇護所",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ScorchedFarmlands = new CampaignAreaDto
        {
            AreaId = "P1_1",
            AreaName = "火噬農地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto StonesOfSerle = new CampaignAreaDto
        {
            AreaId = "P1_2",
            AreaName = "瑟雷之石",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheBlackwood = new CampaignAreaDto
        {
            AreaId = "P1_3",
            AreaName = "黑木林",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Holten = new CampaignAreaDto
        {
            AreaId = "P1_4",
            AreaName = "霍爾登",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Wolvenhold = new CampaignAreaDto
        {
            AreaId = "P1_5",
            AreaName = "狼之要塞",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HoltenEstate = new CampaignAreaDto
        {
            AreaId = "P1_6",
            AreaName = "霍爾登宅第",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Interlude 2
        public static readonly CampaignAreaDto TheKhariBazaar = new CampaignAreaDto
        {
            AreaId = "P2_Town",
            AreaName = "卡里市集",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheKhariCrossing = new CampaignAreaDto
        {
            AreaId = "P2_1",
            AreaName = "卡里交匯道",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PoolsOfKhatal = new CampaignAreaDto
        {
            AreaId = "P2_2",
            AreaName = "卡塔爾之塘",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto SelKhariSanctuary = new CampaignAreaDto
        {
            AreaId = "P2_3",
            AreaName = "塞爾卡里庇護所",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheGalaiGates = new CampaignAreaDto
        {
            AreaId = "P2_5",
            AreaName = "賈萊關口",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Qimah = new CampaignAreaDto
        {
            AreaId = "P2_6",
            AreaName = "奇瑪",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto QimahReservoir = new CampaignAreaDto
        {
            AreaId = "P2_7",
            AreaName = "奇瑪水源地",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Interlude 3
        public static readonly CampaignAreaDto TheGlade = new CampaignAreaDto
        {
            AreaId = "P3_Town",
            AreaName = "林間空地",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto AshenForest = new CampaignAreaDto
        {
            AreaId = "P3_1",
            AreaName = "灰燼森林",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto KriarVillage = new CampaignAreaDto
        {
            AreaId = "P3_2",
            AreaName = "庫萊亞村",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto GlacialTarn = new CampaignAreaDto
        {
            AreaId = "P3_3",
            AreaName = "冰川湖泊",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HowlingCaves = new CampaignAreaDto
        {
            AreaId = "P3_4",
            AreaName = "狂嗥洞穴",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto KriarPeaks = new CampaignAreaDto
        {
            AreaId = "P3_5",
            AreaName = "庫萊亞山巔",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto EtchedRavine = new CampaignAreaDto
        {
            AreaId = "P3_6",
            AreaName = "蝕刻溪谷",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto CuachicVault = new CampaignAreaDto
        {
            AreaId = "P3_7",
            AreaName = "庫阿西克寶庫",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Endgame
        public static readonly CampaignAreaDto TheZigguratRefuge = new CampaignAreaDto
        {
            AreaId = "G_Endgame_Town",
            AreaName = "高地神塔庇護所",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        #endregion
    }
}