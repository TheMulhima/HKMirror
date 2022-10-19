namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that allows you to access PlayerData directly while also using PlayerData.Get/Set functions. Similar to <see cref="PlayerDataAccess">PlayerDataR</see> except that you have to provide an instance
/// </summary>
public class PlayerDataR : InstanceClassWrapper<PlayerData>
{
    public PlayerDataR(PlayerData orig) : base(orig)
    {
    }
    
    public string version
    {
        get => orig.GetString(nameof(PlayerData.version));
        set => orig.SetString(nameof(PlayerData.version), value);
    }

    public bool awardAllAchievements
    {
        get => orig.GetBool(nameof(PlayerData.awardAllAchievements));
        set => orig.SetBool(nameof(PlayerData.awardAllAchievements), value);
    }

    public int profileID
    {
        get => orig.GetInt(nameof(PlayerData.profileID));
        set => orig.SetInt(nameof(PlayerData.profileID), value);
    }

    public float playTime
    {
        get => orig.GetFloat(nameof(PlayerData.playTime));
        set => orig.SetFloat(nameof(PlayerData.playTime), value);
    }

    public float completionPercent
    {
        get => orig.GetFloat(nameof(PlayerData.completionPercent));
        set => orig.SetFloat(nameof(PlayerData.completionPercent), value);
    }

    public bool openingCreditsPlayed
    {
        get => orig.GetBool(nameof(PlayerData.openingCreditsPlayed));
        set => orig.SetBool(nameof(PlayerData.openingCreditsPlayed), value);
    }

    public int permadeathMode
    {
        get => orig.GetInt(nameof(PlayerData.permadeathMode));
        set => orig.SetInt(nameof(PlayerData.permadeathMode), value);
    }

    public int health
    {
        get => orig.GetInt(nameof(PlayerData.health));
        set => orig.SetInt(nameof(PlayerData.health), value);
    }

    public int maxHealth
    {
        get => orig.GetInt(nameof(PlayerData.maxHealth));
        set => orig.SetInt(nameof(PlayerData.maxHealth), value);
    }

    public int maxHealthBase
    {
        get => orig.GetInt(nameof(PlayerData.maxHealthBase));
        set => orig.SetInt(nameof(PlayerData.maxHealthBase), value);
    }

    public int healthBlue
    {
        get => orig.GetInt(nameof(PlayerData.healthBlue));
        set => orig.SetInt(nameof(PlayerData.healthBlue), value);
    }

    public int joniHealthBlue
    {
        get => orig.GetInt(nameof(PlayerData.joniHealthBlue));
        set => orig.SetInt(nameof(PlayerData.joniHealthBlue), value);
    }

    public bool damagedBlue
    {
        get => orig.GetBool(nameof(PlayerData.damagedBlue));
        set => orig.SetBool(nameof(PlayerData.damagedBlue), value);
    }

    public int heartPieces
    {
        get => orig.GetInt(nameof(PlayerData.heartPieces));
        set => orig.SetInt(nameof(PlayerData.heartPieces), value);
    }

    public bool heartPieceCollected
    {
        get => orig.GetBool(nameof(PlayerData.heartPieceCollected));
        set => orig.SetBool(nameof(PlayerData.heartPieceCollected), value);
    }

    public int maxHealthCap
    {
        get => orig.GetInt(nameof(PlayerData.maxHealthCap));
        set => orig.SetInt(nameof(PlayerData.maxHealthCap), value);
    }

    public bool heartPieceMax
    {
        get => orig.GetBool(nameof(PlayerData.heartPieceMax));
        set => orig.SetBool(nameof(PlayerData.heartPieceMax), value);
    }

    public int prevHealth
    {
        get => orig.GetInt(nameof(PlayerData.prevHealth));
        set => orig.SetInt(nameof(PlayerData.prevHealth), value);
    }

    public int blockerHits
    {
        get => orig.GetInt(nameof(PlayerData.blockerHits));
        set => orig.SetInt(nameof(PlayerData.blockerHits), value);
    }

    public bool firstGeo
    {
        get => orig.GetBool(nameof(PlayerData.firstGeo));
        set => orig.SetBool(nameof(PlayerData.firstGeo), value);
    }

    public int geo
    {
        get => orig.GetInt(nameof(PlayerData.geo));
        set => orig.SetInt(nameof(PlayerData.geo), value);
    }

    public int maxMP
    {
        get => orig.GetInt(nameof(PlayerData.maxMP));
        set => orig.SetInt(nameof(PlayerData.maxMP), value);
    }

    public int MPCharge
    {
        get => orig.GetInt(nameof(PlayerData.MPCharge));
        set => orig.SetInt(nameof(PlayerData.MPCharge), value);
    }

    public int MPReserve
    {
        get => orig.GetInt(nameof(PlayerData.MPReserve));
        set => orig.SetInt(nameof(PlayerData.MPReserve), value);
    }

    public int MPReserveMax
    {
        get => orig.GetInt(nameof(PlayerData.MPReserveMax));
        set => orig.SetInt(nameof(PlayerData.MPReserveMax), value);
    }

    public bool soulLimited
    {
        get => orig.GetBool(nameof(PlayerData.soulLimited));
        set => orig.SetBool(nameof(PlayerData.soulLimited), value);
    }

    public int vesselFragments
    {
        get => orig.GetInt(nameof(PlayerData.vesselFragments));
        set => orig.SetInt(nameof(PlayerData.vesselFragments), value);
    }

    public bool vesselFragmentCollected
    {
        get => orig.GetBool(nameof(PlayerData.vesselFragmentCollected));
        set => orig.SetBool(nameof(PlayerData.vesselFragmentCollected), value);
    }

    public int MPReserveCap
    {
        get => orig.GetInt(nameof(PlayerData.MPReserveCap));
        set => orig.SetInt(nameof(PlayerData.MPReserveCap), value);
    }

    public bool vesselFragmentMax
    {
        get => orig.GetBool(nameof(PlayerData.vesselFragmentMax));
        set => orig.SetBool(nameof(PlayerData.vesselFragmentMax), value);
    }

    public int focusMP_amount
    {
        get => orig.GetInt(nameof(PlayerData.focusMP_amount));
        set => orig.SetInt(nameof(PlayerData.focusMP_amount), value);
    }

    public bool atBench
    {
        get => orig.GetBool(nameof(PlayerData.atBench));
        set => orig.SetBool(nameof(PlayerData.atBench), value);
    }

    public string respawnScene
    {
        get => orig.GetString(nameof(PlayerData.respawnScene));
        set => orig.SetString(nameof(PlayerData.respawnScene), value);
    }

    public MapZone mapZone
    {
        get => orig.GetVariable<MapZone>(nameof(PlayerData.mapZone));
        set => orig.SetVariable(nameof(PlayerData.mapZone), value);
    }

    public string respawnMarkerName
    {
        get => orig.GetString(nameof(PlayerData.respawnMarkerName));
        set => orig.SetString(nameof(PlayerData.respawnMarkerName), value);
    }

    public int respawnType
    {
        get => orig.GetInt(nameof(PlayerData.respawnType));
        set => orig.SetInt(nameof(PlayerData.respawnType), value);
    }

    public bool respawnFacingRight
    {
        get => orig.GetBool(nameof(PlayerData.respawnFacingRight));
        set => orig.SetBool(nameof(PlayerData.respawnFacingRight), value);
    }

    public Vector3 hazardRespawnLocation
    {
        get => orig.GetVector3(nameof(PlayerData.hazardRespawnLocation));
        set => orig.SetVector3(nameof(PlayerData.hazardRespawnLocation), value);
    }

    public bool hazardRespawnFacingRight
    {
        get => orig.GetBool(nameof(PlayerData.hazardRespawnFacingRight));
        set => orig.SetBool(nameof(PlayerData.hazardRespawnFacingRight), value);
    }

    public string shadeScene
    {
        get => orig.GetString(nameof(PlayerData.shadeScene));
        set => orig.SetString(nameof(PlayerData.shadeScene), value);
    }

    public string shadeMapZone
    {
        get => orig.GetString(nameof(PlayerData.shadeMapZone));
        set => orig.SetString(nameof(PlayerData.shadeMapZone), value);
    }

    public float shadePositionX
    {
        get => orig.GetFloat(nameof(PlayerData.shadePositionX));
        set => orig.SetFloat(nameof(PlayerData.shadePositionX), value);
    }

    public float shadePositionY
    {
        get => orig.GetFloat(nameof(PlayerData.shadePositionY));
        set => orig.SetFloat(nameof(PlayerData.shadePositionY), value);
    }

    public int shadeHealth
    {
        get => orig.GetInt(nameof(PlayerData.shadeHealth));
        set => orig.SetInt(nameof(PlayerData.shadeHealth), value);
    }

    public int shadeMP
    {
        get => orig.GetInt(nameof(PlayerData.shadeMP));
        set => orig.SetInt(nameof(PlayerData.shadeMP), value);
    }

    public int shadeFireballLevel
    {
        get => orig.GetInt(nameof(PlayerData.shadeFireballLevel));
        set => orig.SetInt(nameof(PlayerData.shadeFireballLevel), value);
    }

    public int shadeQuakeLevel
    {
        get => orig.GetInt(nameof(PlayerData.shadeQuakeLevel));
        set => orig.SetInt(nameof(PlayerData.shadeQuakeLevel), value);
    }

    public int shadeScreamLevel
    {
        get => orig.GetInt(nameof(PlayerData.shadeScreamLevel));
        set => orig.SetInt(nameof(PlayerData.shadeScreamLevel), value);
    }

    public int shadeSpecialType
    {
        get => orig.GetInt(nameof(PlayerData.shadeSpecialType));
        set => orig.SetInt(nameof(PlayerData.shadeSpecialType), value);
    }

    public Vector3 shadeMapPos
    {
        get => orig.GetVector3(nameof(PlayerData.shadeMapPos));
        set => orig.SetVector3(nameof(PlayerData.shadeMapPos), value);
    }

    public Vector3 dreamgateMapPos
    {
        get => orig.GetVector3(nameof(PlayerData.dreamgateMapPos));
        set => orig.SetVector3(nameof(PlayerData.dreamgateMapPos), value);
    }

    public int geoPool
    {
        get => orig.GetInt(nameof(PlayerData.geoPool));
        set => orig.SetInt(nameof(PlayerData.geoPool), value);
    }

    public int nailDamage
    {
        get => orig.GetInt(nameof(PlayerData.nailDamage));
        set => orig.SetInt(nameof(PlayerData.nailDamage), value);
    }

    public int nailRange
    {
        get => orig.GetInt(nameof(PlayerData.nailRange));
        set => orig.SetInt(nameof(PlayerData.nailRange), value);
    }

    public int beamDamage
    {
        get => orig.GetInt(nameof(PlayerData.beamDamage));
        set => orig.SetInt(nameof(PlayerData.beamDamage), value);
    }

    public bool canDash
    {
        get => orig.GetBool(nameof(PlayerData.canDash));
        set => orig.SetBool(nameof(PlayerData.canDash), value);
    }

    public bool canBackDash
    {
        get => orig.GetBool(nameof(PlayerData.canBackDash));
        set => orig.SetBool(nameof(PlayerData.canBackDash), value);
    }

    public bool canWallJump
    {
        get => orig.GetBool(nameof(PlayerData.canWallJump));
        set => orig.SetBool(nameof(PlayerData.canWallJump), value);
    }

    public bool canSuperDash
    {
        get => orig.GetBool(nameof(PlayerData.canSuperDash));
        set => orig.SetBool(nameof(PlayerData.canSuperDash), value);
    }

    public bool canShadowDash
    {
        get => orig.GetBool(nameof(PlayerData.canShadowDash));
        set => orig.SetBool(nameof(PlayerData.canShadowDash), value);
    }

    public bool hasSpell
    {
        get => orig.GetBool(nameof(PlayerData.hasSpell));
        set => orig.SetBool(nameof(PlayerData.hasSpell), value);
    }

    public int fireballLevel
    {
        get => orig.GetInt(nameof(PlayerData.fireballLevel));
        set => orig.SetInt(nameof(PlayerData.fireballLevel), value);
    }

    public int quakeLevel
    {
        get => orig.GetInt(nameof(PlayerData.quakeLevel));
        set => orig.SetInt(nameof(PlayerData.quakeLevel), value);
    }

    public int screamLevel
    {
        get => orig.GetInt(nameof(PlayerData.screamLevel));
        set => orig.SetInt(nameof(PlayerData.screamLevel), value);
    }

    public bool hasNailArt
    {
        get => orig.GetBool(nameof(PlayerData.hasNailArt));
        set => orig.SetBool(nameof(PlayerData.hasNailArt), value);
    }

    public bool hasCyclone
    {
        get => orig.GetBool(nameof(PlayerData.hasCyclone));
        set => orig.SetBool(nameof(PlayerData.hasCyclone), value);
    }

    public bool hasDashSlash
    {
        get => orig.GetBool(nameof(PlayerData.hasDashSlash));
        set => orig.SetBool(nameof(PlayerData.hasDashSlash), value);
    }

    public bool hasUpwardSlash
    {
        get => orig.GetBool(nameof(PlayerData.hasUpwardSlash));
        set => orig.SetBool(nameof(PlayerData.hasUpwardSlash), value);
    }

    public bool hasAllNailArts
    {
        get => orig.GetBool(nameof(PlayerData.hasAllNailArts));
        set => orig.SetBool(nameof(PlayerData.hasAllNailArts), value);
    }

    public bool hasDreamNail
    {
        get => orig.GetBool(nameof(PlayerData.hasDreamNail));
        set => orig.SetBool(nameof(PlayerData.hasDreamNail), value);
    }

    public bool hasDreamGate
    {
        get => orig.GetBool(nameof(PlayerData.hasDreamGate));
        set => orig.SetBool(nameof(PlayerData.hasDreamGate), value);
    }

    public bool dreamNailUpgraded
    {
        get => orig.GetBool(nameof(PlayerData.dreamNailUpgraded));
        set => orig.SetBool(nameof(PlayerData.dreamNailUpgraded), value);
    }

    public int dreamOrbs
    {
        get => orig.GetInt(nameof(PlayerData.dreamOrbs));
        set => orig.SetInt(nameof(PlayerData.dreamOrbs), value);
    }

    public int dreamOrbsSpent
    {
        get => orig.GetInt(nameof(PlayerData.dreamOrbsSpent));
        set => orig.SetInt(nameof(PlayerData.dreamOrbsSpent), value);
    }

    public string dreamGateScene
    {
        get => orig.GetString(nameof(PlayerData.dreamGateScene));
        set => orig.SetString(nameof(PlayerData.dreamGateScene), value);
    }

    public float dreamGateX
    {
        get => orig.GetFloat(nameof(PlayerData.dreamGateX));
        set => orig.SetFloat(nameof(PlayerData.dreamGateX), value);
    }

    public float dreamGateY
    {
        get => orig.GetFloat(nameof(PlayerData.dreamGateY));
        set => orig.SetFloat(nameof(PlayerData.dreamGateY), value);
    }

    public bool hasDash
    {
        get => orig.GetBool(nameof(PlayerData.hasDash));
        set => orig.SetBool(nameof(PlayerData.hasDash), value);
    }

    public bool hasWalljump
    {
        get => orig.GetBool(nameof(PlayerData.hasWalljump));
        set => orig.SetBool(nameof(PlayerData.hasWalljump), value);
    }

    public bool hasSuperDash
    {
        get => orig.GetBool(nameof(PlayerData.hasSuperDash));
        set => orig.SetBool(nameof(PlayerData.hasSuperDash), value);
    }

    public bool hasShadowDash
    {
        get => orig.GetBool(nameof(PlayerData.hasShadowDash));
        set => orig.SetBool(nameof(PlayerData.hasShadowDash), value);
    }

    public bool hasAcidArmour
    {
        get => orig.GetBool(nameof(PlayerData.hasAcidArmour));
        set => orig.SetBool(nameof(PlayerData.hasAcidArmour), value);
    }

    public bool hasDoubleJump
    {
        get => orig.GetBool(nameof(PlayerData.hasDoubleJump));
        set => orig.SetBool(nameof(PlayerData.hasDoubleJump), value);
    }

    public bool hasLantern
    {
        get => orig.GetBool(nameof(PlayerData.hasLantern));
        set => orig.SetBool(nameof(PlayerData.hasLantern), value);
    }

    public bool hasTramPass
    {
        get => orig.GetBool(nameof(PlayerData.hasTramPass));
        set => orig.SetBool(nameof(PlayerData.hasTramPass), value);
    }

    public bool hasQuill
    {
        get => orig.GetBool(nameof(PlayerData.hasQuill));
        set => orig.SetBool(nameof(PlayerData.hasQuill), value);
    }

    public bool hasCityKey
    {
        get => orig.GetBool(nameof(PlayerData.hasCityKey));
        set => orig.SetBool(nameof(PlayerData.hasCityKey), value);
    }

    public bool hasSlykey
    {
        get => orig.GetBool(nameof(PlayerData.hasSlykey));
        set => orig.SetBool(nameof(PlayerData.hasSlykey), value);
    }

    public bool gaveSlykey
    {
        get => orig.GetBool(nameof(PlayerData.gaveSlykey));
        set => orig.SetBool(nameof(PlayerData.gaveSlykey), value);
    }

    public bool hasWhiteKey
    {
        get => orig.GetBool(nameof(PlayerData.hasWhiteKey));
        set => orig.SetBool(nameof(PlayerData.hasWhiteKey), value);
    }

    public bool usedWhiteKey
    {
        get => orig.GetBool(nameof(PlayerData.usedWhiteKey));
        set => orig.SetBool(nameof(PlayerData.usedWhiteKey), value);
    }

    public bool hasMenderKey
    {
        get => orig.GetBool(nameof(PlayerData.hasMenderKey));
        set => orig.SetBool(nameof(PlayerData.hasMenderKey), value);
    }

    public bool hasWaterwaysKey
    {
        get => orig.GetBool(nameof(PlayerData.hasWaterwaysKey));
        set => orig.SetBool(nameof(PlayerData.hasWaterwaysKey), value);
    }

    public bool hasSpaKey
    {
        get => orig.GetBool(nameof(PlayerData.hasSpaKey));
        set => orig.SetBool(nameof(PlayerData.hasSpaKey), value);
    }

    public bool hasLoveKey
    {
        get => orig.GetBool(nameof(PlayerData.hasLoveKey));
        set => orig.SetBool(nameof(PlayerData.hasLoveKey), value);
    }

    public bool hasKingsBrand
    {
        get => orig.GetBool(nameof(PlayerData.hasKingsBrand));
        set => orig.SetBool(nameof(PlayerData.hasKingsBrand), value);
    }

    public bool hasXunFlower
    {
        get => orig.GetBool(nameof(PlayerData.hasXunFlower));
        set => orig.SetBool(nameof(PlayerData.hasXunFlower), value);
    }

    public int ghostCoins
    {
        get => orig.GetInt(nameof(PlayerData.ghostCoins));
        set => orig.SetInt(nameof(PlayerData.ghostCoins), value);
    }

    public int ore
    {
        get => orig.GetInt(nameof(PlayerData.ore));
        set => orig.SetInt(nameof(PlayerData.ore), value);
    }

    public bool foundGhostCoin
    {
        get => orig.GetBool(nameof(PlayerData.foundGhostCoin));
        set => orig.SetBool(nameof(PlayerData.foundGhostCoin), value);
    }

    public int trinket1
    {
        get => orig.GetInt(nameof(PlayerData.trinket1));
        set => orig.SetInt(nameof(PlayerData.trinket1), value);
    }

    public bool foundTrinket1
    {
        get => orig.GetBool(nameof(PlayerData.foundTrinket1));
        set => orig.SetBool(nameof(PlayerData.foundTrinket1), value);
    }

    public int trinket2
    {
        get => orig.GetInt(nameof(PlayerData.trinket2));
        set => orig.SetInt(nameof(PlayerData.trinket2), value);
    }

    public bool foundTrinket2
    {
        get => orig.GetBool(nameof(PlayerData.foundTrinket2));
        set => orig.SetBool(nameof(PlayerData.foundTrinket2), value);
    }

    public int trinket3
    {
        get => orig.GetInt(nameof(PlayerData.trinket3));
        set => orig.SetInt(nameof(PlayerData.trinket3), value);
    }

    public bool foundTrinket3
    {
        get => orig.GetBool(nameof(PlayerData.foundTrinket3));
        set => orig.SetBool(nameof(PlayerData.foundTrinket3), value);
    }

    public int trinket4
    {
        get => orig.GetInt(nameof(PlayerData.trinket4));
        set => orig.SetInt(nameof(PlayerData.trinket4), value);
    }

    public bool foundTrinket4
    {
        get => orig.GetBool(nameof(PlayerData.foundTrinket4));
        set => orig.SetBool(nameof(PlayerData.foundTrinket4), value);
    }

    public bool noTrinket1
    {
        get => orig.GetBool(nameof(PlayerData.noTrinket1));
        set => orig.SetBool(nameof(PlayerData.noTrinket1), value);
    }

    public bool noTrinket2
    {
        get => orig.GetBool(nameof(PlayerData.noTrinket2));
        set => orig.SetBool(nameof(PlayerData.noTrinket2), value);
    }

    public bool noTrinket3
    {
        get => orig.GetBool(nameof(PlayerData.noTrinket3));
        set => orig.SetBool(nameof(PlayerData.noTrinket3), value);
    }

    public bool noTrinket4
    {
        get => orig.GetBool(nameof(PlayerData.noTrinket4));
        set => orig.SetBool(nameof(PlayerData.noTrinket4), value);
    }

    public int soldTrinket1
    {
        get => orig.GetInt(nameof(PlayerData.soldTrinket1));
        set => orig.SetInt(nameof(PlayerData.soldTrinket1), value);
    }

    public int soldTrinket2
    {
        get => orig.GetInt(nameof(PlayerData.soldTrinket2));
        set => orig.SetInt(nameof(PlayerData.soldTrinket2), value);
    }

    public int soldTrinket3
    {
        get => orig.GetInt(nameof(PlayerData.soldTrinket3));
        set => orig.SetInt(nameof(PlayerData.soldTrinket3), value);
    }

    public int soldTrinket4
    {
        get => orig.GetInt(nameof(PlayerData.soldTrinket4));
        set => orig.SetInt(nameof(PlayerData.soldTrinket4), value);
    }

    public int simpleKeys
    {
        get => orig.GetInt(nameof(PlayerData.simpleKeys));
        set => orig.SetInt(nameof(PlayerData.simpleKeys), value);
    }

    public int rancidEggs
    {
        get => orig.GetInt(nameof(PlayerData.rancidEggs));
        set => orig.SetInt(nameof(PlayerData.rancidEggs), value);
    }

    public bool notchShroomOgres
    {
        get => orig.GetBool(nameof(PlayerData.notchShroomOgres));
        set => orig.SetBool(nameof(PlayerData.notchShroomOgres), value);
    }

    public bool notchFogCanyon
    {
        get => orig.GetBool(nameof(PlayerData.notchFogCanyon));
        set => orig.SetBool(nameof(PlayerData.notchFogCanyon), value);
    }

    public bool gotLurkerKey
    {
        get => orig.GetBool(nameof(PlayerData.gotLurkerKey));
        set => orig.SetBool(nameof(PlayerData.gotLurkerKey), value);
    }

    public float gMap_doorX
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorX));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorX), value);
    }

    public float gMap_doorY
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorY));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorY), value);
    }

    public string gMap_doorScene
    {
        get => orig.GetString(nameof(PlayerData.gMap_doorScene));
        set => orig.SetString(nameof(PlayerData.gMap_doorScene), value);
    }

    public string gMap_doorMapZone
    {
        get => orig.GetString(nameof(PlayerData.gMap_doorMapZone));
        set => orig.SetString(nameof(PlayerData.gMap_doorMapZone), value);
    }

    public float gMap_doorOriginOffsetX
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorOriginOffsetX));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorOriginOffsetX), value);
    }

    public float gMap_doorOriginOffsetY
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorOriginOffsetY));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorOriginOffsetY), value);
    }

    public float gMap_doorSceneWidth
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorSceneWidth));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorSceneWidth), value);
    }

    public float gMap_doorSceneHeight
    {
        get => orig.GetFloat(nameof(PlayerData.gMap_doorSceneHeight));
        set => orig.SetFloat(nameof(PlayerData.gMap_doorSceneHeight), value);
    }

    public int guardiansDefeated
    {
        get => orig.GetInt(nameof(PlayerData.guardiansDefeated));
        set => orig.SetInt(nameof(PlayerData.guardiansDefeated), value);
    }

    public bool lurienDefeated
    {
        get => orig.GetBool(nameof(PlayerData.lurienDefeated));
        set => orig.SetBool(nameof(PlayerData.lurienDefeated), value);
    }

    public bool hegemolDefeated
    {
        get => orig.GetBool(nameof(PlayerData.hegemolDefeated));
        set => orig.SetBool(nameof(PlayerData.hegemolDefeated), value);
    }

    public bool monomonDefeated
    {
        get => orig.GetBool(nameof(PlayerData.monomonDefeated));
        set => orig.SetBool(nameof(PlayerData.monomonDefeated), value);
    }

    public bool maskBrokenLurien
    {
        get => orig.GetBool(nameof(PlayerData.maskBrokenLurien));
        set => orig.SetBool(nameof(PlayerData.maskBrokenLurien), value);
    }

    public bool maskBrokenHegemol
    {
        get => orig.GetBool(nameof(PlayerData.maskBrokenHegemol));
        set => orig.SetBool(nameof(PlayerData.maskBrokenHegemol), value);
    }

    public bool maskBrokenMonomon
    {
        get => orig.GetBool(nameof(PlayerData.maskBrokenMonomon));
        set => orig.SetBool(nameof(PlayerData.maskBrokenMonomon), value);
    }

    public int maskToBreak
    {
        get => orig.GetInt(nameof(PlayerData.maskToBreak));
        set => orig.SetInt(nameof(PlayerData.maskToBreak), value);
    }

    public int elderbug
    {
        get => orig.GetInt(nameof(PlayerData.elderbug));
        set => orig.SetInt(nameof(PlayerData.elderbug), value);
    }

    public bool metElderbug
    {
        get => orig.GetBool(nameof(PlayerData.metElderbug));
        set => orig.SetBool(nameof(PlayerData.metElderbug), value);
    }

    public bool elderbugReintro
    {
        get => orig.GetBool(nameof(PlayerData.elderbugReintro));
        set => orig.SetBool(nameof(PlayerData.elderbugReintro), value);
    }

    public int elderbugHistory
    {
        get => orig.GetInt(nameof(PlayerData.elderbugHistory));
        set => orig.SetInt(nameof(PlayerData.elderbugHistory), value);
    }

    public bool elderbugHistory1
    {
        get => orig.GetBool(nameof(PlayerData.elderbugHistory1));
        set => orig.SetBool(nameof(PlayerData.elderbugHistory1), value);
    }

    public bool elderbugHistory2
    {
        get => orig.GetBool(nameof(PlayerData.elderbugHistory2));
        set => orig.SetBool(nameof(PlayerData.elderbugHistory2), value);
    }

    public bool elderbugHistory3
    {
        get => orig.GetBool(nameof(PlayerData.elderbugHistory3));
        set => orig.SetBool(nameof(PlayerData.elderbugHistory3), value);
    }

    public bool elderbugSpeechSly
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechSly));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechSly), value);
    }

    public bool elderbugSpeechStation
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechStation));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechStation), value);
    }

    public bool elderbugSpeechEggTemple
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechEggTemple));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechEggTemple), value);
    }

    public bool elderbugSpeechMapShop
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechMapShop));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechMapShop), value);
    }

    public bool elderbugSpeechBretta
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechBretta));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechBretta), value);
    }

    public bool elderbugSpeechJiji
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechJiji));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechJiji), value);
    }

    public bool elderbugSpeechMinesLift
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechMinesLift));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechMinesLift), value);
    }

    public bool elderbugSpeechKingsPass
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechKingsPass));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechKingsPass), value);
    }

    public bool elderbugSpeechInfectedCrossroads
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads), value);
    }

    public bool elderbugSpeechFinalBossDoor
    {
        get => orig.GetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor));
        set => orig.SetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor), value);
    }

    public bool elderbugRequestedFlower
    {
        get => orig.GetBool(nameof(PlayerData.elderbugRequestedFlower));
        set => orig.SetBool(nameof(PlayerData.elderbugRequestedFlower), value);
    }

    public bool elderbugGaveFlower
    {
        get => orig.GetBool(nameof(PlayerData.elderbugGaveFlower));
        set => orig.SetBool(nameof(PlayerData.elderbugGaveFlower), value);
    }

    public bool elderbugFirstCall
    {
        get => orig.GetBool(nameof(PlayerData.elderbugFirstCall));
        set => orig.SetBool(nameof(PlayerData.elderbugFirstCall), value);
    }

    public bool metQuirrel
    {
        get => orig.GetBool(nameof(PlayerData.metQuirrel));
        set => orig.SetBool(nameof(PlayerData.metQuirrel), value);
    }

    public int quirrelEggTemple
    {
        get => orig.GetInt(nameof(PlayerData.quirrelEggTemple));
        set => orig.SetInt(nameof(PlayerData.quirrelEggTemple), value);
    }

    public int quirrelSlugShrine
    {
        get => orig.GetInt(nameof(PlayerData.quirrelSlugShrine));
        set => orig.SetInt(nameof(PlayerData.quirrelSlugShrine), value);
    }

    public int quirrelRuins
    {
        get => orig.GetInt(nameof(PlayerData.quirrelRuins));
        set => orig.SetInt(nameof(PlayerData.quirrelRuins), value);
    }

    public int quirrelMines
    {
        get => orig.GetInt(nameof(PlayerData.quirrelMines));
        set => orig.SetInt(nameof(PlayerData.quirrelMines), value);
    }

    public bool quirrelLeftStation
    {
        get => orig.GetBool(nameof(PlayerData.quirrelLeftStation));
        set => orig.SetBool(nameof(PlayerData.quirrelLeftStation), value);
    }

    public bool quirrelLeftEggTemple
    {
        get => orig.GetBool(nameof(PlayerData.quirrelLeftEggTemple));
        set => orig.SetBool(nameof(PlayerData.quirrelLeftEggTemple), value);
    }

    public bool quirrelCityEncountered
    {
        get => orig.GetBool(nameof(PlayerData.quirrelCityEncountered));
        set => orig.SetBool(nameof(PlayerData.quirrelCityEncountered), value);
    }

    public bool quirrelCityLeft
    {
        get => orig.GetBool(nameof(PlayerData.quirrelCityLeft));
        set => orig.SetBool(nameof(PlayerData.quirrelCityLeft), value);
    }

    public bool quirrelMinesEncountered
    {
        get => orig.GetBool(nameof(PlayerData.quirrelMinesEncountered));
        set => orig.SetBool(nameof(PlayerData.quirrelMinesEncountered), value);
    }

    public bool quirrelMinesLeft
    {
        get => orig.GetBool(nameof(PlayerData.quirrelMinesLeft));
        set => orig.SetBool(nameof(PlayerData.quirrelMinesLeft), value);
    }

    public bool quirrelMantisEncountered
    {
        get => orig.GetBool(nameof(PlayerData.quirrelMantisEncountered));
        set => orig.SetBool(nameof(PlayerData.quirrelMantisEncountered), value);
    }

    public bool enteredMantisLordArea
    {
        get => orig.GetBool(nameof(PlayerData.enteredMantisLordArea));
        set => orig.SetBool(nameof(PlayerData.enteredMantisLordArea), value);
    }

    public bool visitedDeepnestSpa
    {
        get => orig.GetBool(nameof(PlayerData.visitedDeepnestSpa));
        set => orig.SetBool(nameof(PlayerData.visitedDeepnestSpa), value);
    }

    public bool quirrelSpaReady
    {
        get => orig.GetBool(nameof(PlayerData.quirrelSpaReady));
        set => orig.SetBool(nameof(PlayerData.quirrelSpaReady), value);
    }

    public bool quirrelSpaEncountered
    {
        get => orig.GetBool(nameof(PlayerData.quirrelSpaEncountered));
        set => orig.SetBool(nameof(PlayerData.quirrelSpaEncountered), value);
    }

    public bool quirrelArchiveEncountered
    {
        get => orig.GetBool(nameof(PlayerData.quirrelArchiveEncountered));
        set => orig.SetBool(nameof(PlayerData.quirrelArchiveEncountered), value);
    }

    public bool quirrelEpilogueCompleted
    {
        get => orig.GetBool(nameof(PlayerData.quirrelEpilogueCompleted));
        set => orig.SetBool(nameof(PlayerData.quirrelEpilogueCompleted), value);
    }

    public bool metRelicDealer
    {
        get => orig.GetBool(nameof(PlayerData.metRelicDealer));
        set => orig.SetBool(nameof(PlayerData.metRelicDealer), value);
    }

    public bool metRelicDealerShop
    {
        get => orig.GetBool(nameof(PlayerData.metRelicDealerShop));
        set => orig.SetBool(nameof(PlayerData.metRelicDealerShop), value);
    }

    public bool marmOutside
    {
        get => orig.GetBool(nameof(PlayerData.marmOutside));
        set => orig.SetBool(nameof(PlayerData.marmOutside), value);
    }

    public bool marmOutsideConvo
    {
        get => orig.GetBool(nameof(PlayerData.marmOutsideConvo));
        set => orig.SetBool(nameof(PlayerData.marmOutsideConvo), value);
    }

    public bool marmConvo1
    {
        get => orig.GetBool(nameof(PlayerData.marmConvo1));
        set => orig.SetBool(nameof(PlayerData.marmConvo1), value);
    }

    public bool marmConvo2
    {
        get => orig.GetBool(nameof(PlayerData.marmConvo2));
        set => orig.SetBool(nameof(PlayerData.marmConvo2), value);
    }

    public bool marmConvo3
    {
        get => orig.GetBool(nameof(PlayerData.marmConvo3));
        set => orig.SetBool(nameof(PlayerData.marmConvo3), value);
    }

    public bool marmConvoNailsmith
    {
        get => orig.GetBool(nameof(PlayerData.marmConvoNailsmith));
        set => orig.SetBool(nameof(PlayerData.marmConvoNailsmith), value);
    }

    public int cornifer
    {
        get => orig.GetInt(nameof(PlayerData.cornifer));
        set => orig.SetInt(nameof(PlayerData.cornifer), value);
    }

    public bool metCornifer
    {
        get => orig.GetBool(nameof(PlayerData.metCornifer));
        set => orig.SetBool(nameof(PlayerData.metCornifer), value);
    }

    public bool corniferIntroduced
    {
        get => orig.GetBool(nameof(PlayerData.corniferIntroduced));
        set => orig.SetBool(nameof(PlayerData.corniferIntroduced), value);
    }

    public bool corniferAtHome
    {
        get => orig.GetBool(nameof(PlayerData.corniferAtHome));
        set => orig.SetBool(nameof(PlayerData.corniferAtHome), value);
    }

    public bool corn_crossroadsEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_crossroadsEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_crossroadsEncountered), value);
    }

    public bool corn_crossroadsLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_crossroadsLeft));
        set => orig.SetBool(nameof(PlayerData.corn_crossroadsLeft), value);
    }

    public bool corn_greenpathEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_greenpathEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_greenpathEncountered), value);
    }

    public bool corn_greenpathLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_greenpathLeft));
        set => orig.SetBool(nameof(PlayerData.corn_greenpathLeft), value);
    }

    public bool corn_fogCanyonEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_fogCanyonEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_fogCanyonEncountered), value);
    }

    public bool corn_fogCanyonLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_fogCanyonLeft));
        set => orig.SetBool(nameof(PlayerData.corn_fogCanyonLeft), value);
    }

    public bool corn_fungalWastesEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_fungalWastesEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_fungalWastesEncountered), value);
    }

    public bool corn_fungalWastesLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_fungalWastesLeft));
        set => orig.SetBool(nameof(PlayerData.corn_fungalWastesLeft), value);
    }

    public bool corn_cityEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_cityEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_cityEncountered), value);
    }

    public bool corn_cityLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_cityLeft));
        set => orig.SetBool(nameof(PlayerData.corn_cityLeft), value);
    }

    public bool corn_waterwaysEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_waterwaysEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_waterwaysEncountered), value);
    }

    public bool corn_waterwaysLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_waterwaysLeft));
        set => orig.SetBool(nameof(PlayerData.corn_waterwaysLeft), value);
    }

    public bool corn_minesEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_minesEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_minesEncountered), value);
    }

    public bool corn_minesLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_minesLeft));
        set => orig.SetBool(nameof(PlayerData.corn_minesLeft), value);
    }

    public bool corn_cliffsEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_cliffsEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_cliffsEncountered), value);
    }

    public bool corn_cliffsLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_cliffsLeft));
        set => orig.SetBool(nameof(PlayerData.corn_cliffsLeft), value);
    }

    public bool corn_deepnestEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_deepnestEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_deepnestEncountered), value);
    }

    public bool corn_deepnestLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_deepnestLeft));
        set => orig.SetBool(nameof(PlayerData.corn_deepnestLeft), value);
    }

    public bool corn_deepnestMet1
    {
        get => orig.GetBool(nameof(PlayerData.corn_deepnestMet1));
        set => orig.SetBool(nameof(PlayerData.corn_deepnestMet1), value);
    }

    public bool corn_deepnestMet2
    {
        get => orig.GetBool(nameof(PlayerData.corn_deepnestMet2));
        set => orig.SetBool(nameof(PlayerData.corn_deepnestMet2), value);
    }

    public bool corn_outskirtsEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_outskirtsEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_outskirtsEncountered), value);
    }

    public bool corn_outskirtsLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_outskirtsLeft));
        set => orig.SetBool(nameof(PlayerData.corn_outskirtsLeft), value);
    }

    public bool corn_royalGardensEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_royalGardensEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_royalGardensEncountered), value);
    }

    public bool corn_royalGardensLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_royalGardensLeft));
        set => orig.SetBool(nameof(PlayerData.corn_royalGardensLeft), value);
    }

    public bool corn_abyssEncountered
    {
        get => orig.GetBool(nameof(PlayerData.corn_abyssEncountered));
        set => orig.SetBool(nameof(PlayerData.corn_abyssEncountered), value);
    }

    public bool corn_abyssLeft
    {
        get => orig.GetBool(nameof(PlayerData.corn_abyssLeft));
        set => orig.SetBool(nameof(PlayerData.corn_abyssLeft), value);
    }

    public bool metIselda
    {
        get => orig.GetBool(nameof(PlayerData.metIselda));
        set => orig.SetBool(nameof(PlayerData.metIselda), value);
    }

    public bool iseldaCorniferHomeConvo
    {
        get => orig.GetBool(nameof(PlayerData.iseldaCorniferHomeConvo));
        set => orig.SetBool(nameof(PlayerData.iseldaCorniferHomeConvo), value);
    }

    public bool iseldaConvo1
    {
        get => orig.GetBool(nameof(PlayerData.iseldaConvo1));
        set => orig.SetBool(nameof(PlayerData.iseldaConvo1), value);
    }

    public bool brettaRescued
    {
        get => orig.GetBool(nameof(PlayerData.brettaRescued));
        set => orig.SetBool(nameof(PlayerData.brettaRescued), value);
    }

    public int brettaPosition
    {
        get => orig.GetInt(nameof(PlayerData.brettaPosition));
        set => orig.SetInt(nameof(PlayerData.brettaPosition), value);
    }

    public int brettaState
    {
        get => orig.GetInt(nameof(PlayerData.brettaState));
        set => orig.SetInt(nameof(PlayerData.brettaState), value);
    }

    public bool brettaSeenBench
    {
        get => orig.GetBool(nameof(PlayerData.brettaSeenBench));
        set => orig.SetBool(nameof(PlayerData.brettaSeenBench), value);
    }

    public bool brettaSeenBed
    {
        get => orig.GetBool(nameof(PlayerData.brettaSeenBed));
        set => orig.SetBool(nameof(PlayerData.brettaSeenBed), value);
    }

    public bool brettaSeenBenchDiary
    {
        get => orig.GetBool(nameof(PlayerData.brettaSeenBenchDiary));
        set => orig.SetBool(nameof(PlayerData.brettaSeenBenchDiary), value);
    }

    public bool brettaSeenBedDiary
    {
        get => orig.GetBool(nameof(PlayerData.brettaSeenBedDiary));
        set => orig.SetBool(nameof(PlayerData.brettaSeenBedDiary), value);
    }

    public bool brettaLeftTown
    {
        get => orig.GetBool(nameof(PlayerData.brettaLeftTown));
        set => orig.SetBool(nameof(PlayerData.brettaLeftTown), value);
    }

    public bool slyRescued
    {
        get => orig.GetBool(nameof(PlayerData.slyRescued));
        set => orig.SetBool(nameof(PlayerData.slyRescued), value);
    }

    public bool slyBeta
    {
        get => orig.GetBool(nameof(PlayerData.slyBeta));
        set => orig.SetBool(nameof(PlayerData.slyBeta), value);
    }

    public bool metSlyShop
    {
        get => orig.GetBool(nameof(PlayerData.metSlyShop));
        set => orig.SetBool(nameof(PlayerData.metSlyShop), value);
    }

    public bool gotSlyCharm
    {
        get => orig.GetBool(nameof(PlayerData.gotSlyCharm));
        set => orig.SetBool(nameof(PlayerData.gotSlyCharm), value);
    }

    public bool slyShellFrag1
    {
        get => orig.GetBool(nameof(PlayerData.slyShellFrag1));
        set => orig.SetBool(nameof(PlayerData.slyShellFrag1), value);
    }

    public bool slyShellFrag2
    {
        get => orig.GetBool(nameof(PlayerData.slyShellFrag2));
        set => orig.SetBool(nameof(PlayerData.slyShellFrag2), value);
    }

    public bool slyShellFrag3
    {
        get => orig.GetBool(nameof(PlayerData.slyShellFrag3));
        set => orig.SetBool(nameof(PlayerData.slyShellFrag3), value);
    }

    public bool slyShellFrag4
    {
        get => orig.GetBool(nameof(PlayerData.slyShellFrag4));
        set => orig.SetBool(nameof(PlayerData.slyShellFrag4), value);
    }

    public bool slyVesselFrag1
    {
        get => orig.GetBool(nameof(PlayerData.slyVesselFrag1));
        set => orig.SetBool(nameof(PlayerData.slyVesselFrag1), value);
    }

    public bool slyVesselFrag2
    {
        get => orig.GetBool(nameof(PlayerData.slyVesselFrag2));
        set => orig.SetBool(nameof(PlayerData.slyVesselFrag2), value);
    }

    public bool slyVesselFrag3
    {
        get => orig.GetBool(nameof(PlayerData.slyVesselFrag3));
        set => orig.SetBool(nameof(PlayerData.slyVesselFrag3), value);
    }

    public bool slyVesselFrag4
    {
        get => orig.GetBool(nameof(PlayerData.slyVesselFrag4));
        set => orig.SetBool(nameof(PlayerData.slyVesselFrag4), value);
    }

    public bool slyNotch1
    {
        get => orig.GetBool(nameof(PlayerData.slyNotch1));
        set => orig.SetBool(nameof(PlayerData.slyNotch1), value);
    }

    public bool slyNotch2
    {
        get => orig.GetBool(nameof(PlayerData.slyNotch2));
        set => orig.SetBool(nameof(PlayerData.slyNotch2), value);
    }

    public bool slySimpleKey
    {
        get => orig.GetBool(nameof(PlayerData.slySimpleKey));
        set => orig.SetBool(nameof(PlayerData.slySimpleKey), value);
    }

    public bool slyRancidEgg
    {
        get => orig.GetBool(nameof(PlayerData.slyRancidEgg));
        set => orig.SetBool(nameof(PlayerData.slyRancidEgg), value);
    }

    public bool slyConvoNailArt
    {
        get => orig.GetBool(nameof(PlayerData.slyConvoNailArt));
        set => orig.SetBool(nameof(PlayerData.slyConvoNailArt), value);
    }

    public bool slyConvoMapper
    {
        get => orig.GetBool(nameof(PlayerData.slyConvoMapper));
        set => orig.SetBool(nameof(PlayerData.slyConvoMapper), value);
    }

    public bool slyConvoNailHoned
    {
        get => orig.GetBool(nameof(PlayerData.slyConvoNailHoned));
        set => orig.SetBool(nameof(PlayerData.slyConvoNailHoned), value);
    }

    public bool jijiDoorUnlocked
    {
        get => orig.GetBool(nameof(PlayerData.jijiDoorUnlocked));
        set => orig.SetBool(nameof(PlayerData.jijiDoorUnlocked), value);
    }

    public bool jijiMet
    {
        get => orig.GetBool(nameof(PlayerData.jijiMet));
        set => orig.SetBool(nameof(PlayerData.jijiMet), value);
    }

    public bool jijiShadeOffered
    {
        get => orig.GetBool(nameof(PlayerData.jijiShadeOffered));
        set => orig.SetBool(nameof(PlayerData.jijiShadeOffered), value);
    }

    public bool jijiShadeCharmConvo
    {
        get => orig.GetBool(nameof(PlayerData.jijiShadeCharmConvo));
        set => orig.SetBool(nameof(PlayerData.jijiShadeCharmConvo), value);
    }

    public bool metJinn
    {
        get => orig.GetBool(nameof(PlayerData.metJinn));
        set => orig.SetBool(nameof(PlayerData.metJinn), value);
    }

    public bool jinnConvo1
    {
        get => orig.GetBool(nameof(PlayerData.jinnConvo1));
        set => orig.SetBool(nameof(PlayerData.jinnConvo1), value);
    }

    public bool jinnConvo2
    {
        get => orig.GetBool(nameof(PlayerData.jinnConvo2));
        set => orig.SetBool(nameof(PlayerData.jinnConvo2), value);
    }

    public bool jinnConvo3
    {
        get => orig.GetBool(nameof(PlayerData.jinnConvo3));
        set => orig.SetBool(nameof(PlayerData.jinnConvo3), value);
    }

    public bool jinnConvoKingBrand
    {
        get => orig.GetBool(nameof(PlayerData.jinnConvoKingBrand));
        set => orig.SetBool(nameof(PlayerData.jinnConvoKingBrand), value);
    }

    public bool jinnConvoShadeCharm
    {
        get => orig.GetBool(nameof(PlayerData.jinnConvoShadeCharm));
        set => orig.SetBool(nameof(PlayerData.jinnConvoShadeCharm), value);
    }

    public int jinnEggsSold
    {
        get => orig.GetInt(nameof(PlayerData.jinnEggsSold));
        set => orig.SetInt(nameof(PlayerData.jinnEggsSold), value);
    }

    public int zote
    {
        get => orig.GetInt(nameof(PlayerData.zote));
        set => orig.SetInt(nameof(PlayerData.zote), value);
    }

    public bool zoteRescuedBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.zoteRescuedBuzzer));
        set => orig.SetBool(nameof(PlayerData.zoteRescuedBuzzer), value);
    }

    public bool zoteDead
    {
        get => orig.GetBool(nameof(PlayerData.zoteDead));
        set => orig.SetBool(nameof(PlayerData.zoteDead), value);
    }

    public int zoteDeathPos
    {
        get => orig.GetInt(nameof(PlayerData.zoteDeathPos));
        set => orig.SetInt(nameof(PlayerData.zoteDeathPos), value);
    }

    public bool zoteSpokenCity
    {
        get => orig.GetBool(nameof(PlayerData.zoteSpokenCity));
        set => orig.SetBool(nameof(PlayerData.zoteSpokenCity), value);
    }

    public bool zoteLeftCity
    {
        get => orig.GetBool(nameof(PlayerData.zoteLeftCity));
        set => orig.SetBool(nameof(PlayerData.zoteLeftCity), value);
    }

    public bool zoteTrappedDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.zoteTrappedDeepnest));
        set => orig.SetBool(nameof(PlayerData.zoteTrappedDeepnest), value);
    }

    public bool zoteRescuedDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.zoteRescuedDeepnest));
        set => orig.SetBool(nameof(PlayerData.zoteRescuedDeepnest), value);
    }

    public bool zoteDefeated
    {
        get => orig.GetBool(nameof(PlayerData.zoteDefeated));
        set => orig.SetBool(nameof(PlayerData.zoteDefeated), value);
    }

    public bool zoteSpokenColosseum
    {
        get => orig.GetBool(nameof(PlayerData.zoteSpokenColosseum));
        set => orig.SetBool(nameof(PlayerData.zoteSpokenColosseum), value);
    }

    public int zotePrecept
    {
        get => orig.GetInt(nameof(PlayerData.zotePrecept));
        set => orig.SetInt(nameof(PlayerData.zotePrecept), value);
    }

    public int zoteTownConvo
    {
        get => orig.GetInt(nameof(PlayerData.zoteTownConvo));
        set => orig.SetInt(nameof(PlayerData.zoteTownConvo), value);
    }

    public int shaman
    {
        get => orig.GetInt(nameof(PlayerData.shaman));
        set => orig.SetInt(nameof(PlayerData.shaman), value);
    }

    public bool shamanScreamConvo
    {
        get => orig.GetBool(nameof(PlayerData.shamanScreamConvo));
        set => orig.SetBool(nameof(PlayerData.shamanScreamConvo), value);
    }

    public bool shamanQuakeConvo
    {
        get => orig.GetBool(nameof(PlayerData.shamanQuakeConvo));
        set => orig.SetBool(nameof(PlayerData.shamanQuakeConvo), value);
    }

    public bool shamanFireball2Convo
    {
        get => orig.GetBool(nameof(PlayerData.shamanFireball2Convo));
        set => orig.SetBool(nameof(PlayerData.shamanFireball2Convo), value);
    }

    public bool shamanScream2Convo
    {
        get => orig.GetBool(nameof(PlayerData.shamanScream2Convo));
        set => orig.SetBool(nameof(PlayerData.shamanScream2Convo), value);
    }

    public bool shamanQuake2Convo
    {
        get => orig.GetBool(nameof(PlayerData.shamanQuake2Convo));
        set => orig.SetBool(nameof(PlayerData.shamanQuake2Convo), value);
    }

    public bool metMiner
    {
        get => orig.GetBool(nameof(PlayerData.metMiner));
        set => orig.SetBool(nameof(PlayerData.metMiner), value);
    }

    public int miner
    {
        get => orig.GetInt(nameof(PlayerData.miner));
        set => orig.SetInt(nameof(PlayerData.miner), value);
    }

    public int minerEarly
    {
        get => orig.GetInt(nameof(PlayerData.minerEarly));
        set => orig.SetInt(nameof(PlayerData.minerEarly), value);
    }

    public int hornetGreenpath
    {
        get => orig.GetInt(nameof(PlayerData.hornetGreenpath));
        set => orig.SetInt(nameof(PlayerData.hornetGreenpath), value);
    }

    public int hornetFung
    {
        get => orig.GetInt(nameof(PlayerData.hornetFung));
        set => orig.SetInt(nameof(PlayerData.hornetFung), value);
    }

    public bool hornet_f19
    {
        get => orig.GetBool(nameof(PlayerData.hornet_f19));
        set => orig.SetBool(nameof(PlayerData.hornet_f19), value);
    }

    public bool hornetFountainEncounter
    {
        get => orig.GetBool(nameof(PlayerData.hornetFountainEncounter));
        set => orig.SetBool(nameof(PlayerData.hornetFountainEncounter), value);
    }

    public bool hornetCityBridge_ready
    {
        get => orig.GetBool(nameof(PlayerData.hornetCityBridge_ready));
        set => orig.SetBool(nameof(PlayerData.hornetCityBridge_ready), value);
    }

    public bool hornetCityBridge_completed
    {
        get => orig.GetBool(nameof(PlayerData.hornetCityBridge_completed));
        set => orig.SetBool(nameof(PlayerData.hornetCityBridge_completed), value);
    }

    public bool hornetAbyssEncounter
    {
        get => orig.GetBool(nameof(PlayerData.hornetAbyssEncounter));
        set => orig.SetBool(nameof(PlayerData.hornetAbyssEncounter), value);
    }

    public bool hornetDenEncounter
    {
        get => orig.GetBool(nameof(PlayerData.hornetDenEncounter));
        set => orig.SetBool(nameof(PlayerData.hornetDenEncounter), value);
    }

    public bool metMoth
    {
        get => orig.GetBool(nameof(PlayerData.metMoth));
        set => orig.SetBool(nameof(PlayerData.metMoth), value);
    }

    public bool ignoredMoth
    {
        get => orig.GetBool(nameof(PlayerData.ignoredMoth));
        set => orig.SetBool(nameof(PlayerData.ignoredMoth), value);
    }

    public bool gladeDoorOpened
    {
        get => orig.GetBool(nameof(PlayerData.gladeDoorOpened));
        set => orig.SetBool(nameof(PlayerData.gladeDoorOpened), value);
    }

    public bool mothDeparted
    {
        get => orig.GetBool(nameof(PlayerData.mothDeparted));
        set => orig.SetBool(nameof(PlayerData.mothDeparted), value);
    }

    public bool completedRGDreamPlant
    {
        get => orig.GetBool(nameof(PlayerData.completedRGDreamPlant));
        set => orig.SetBool(nameof(PlayerData.completedRGDreamPlant), value);
    }

    public bool dreamReward1
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward1));
        set => orig.SetBool(nameof(PlayerData.dreamReward1), value);
    }

    public bool dreamReward2
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward2));
        set => orig.SetBool(nameof(PlayerData.dreamReward2), value);
    }

    public bool dreamReward3
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward3));
        set => orig.SetBool(nameof(PlayerData.dreamReward3), value);
    }

    public bool dreamReward4
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward4));
        set => orig.SetBool(nameof(PlayerData.dreamReward4), value);
    }

    public bool dreamReward5
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward5));
        set => orig.SetBool(nameof(PlayerData.dreamReward5), value);
    }

    public bool dreamReward5b
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward5b));
        set => orig.SetBool(nameof(PlayerData.dreamReward5b), value);
    }

    public bool dreamReward6
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward6));
        set => orig.SetBool(nameof(PlayerData.dreamReward6), value);
    }

    public bool dreamReward7
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward7));
        set => orig.SetBool(nameof(PlayerData.dreamReward7), value);
    }

    public bool dreamReward8
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward8));
        set => orig.SetBool(nameof(PlayerData.dreamReward8), value);
    }

    public bool dreamReward9
    {
        get => orig.GetBool(nameof(PlayerData.dreamReward9));
        set => orig.SetBool(nameof(PlayerData.dreamReward9), value);
    }

    public bool dreamMothConvo1
    {
        get => orig.GetBool(nameof(PlayerData.dreamMothConvo1));
        set => orig.SetBool(nameof(PlayerData.dreamMothConvo1), value);
    }

    public bool bankerAccountPurchased
    {
        get => orig.GetBool(nameof(PlayerData.bankerAccountPurchased));
        set => orig.SetBool(nameof(PlayerData.bankerAccountPurchased), value);
    }

    public bool metBanker
    {
        get => orig.GetBool(nameof(PlayerData.metBanker));
        set => orig.SetBool(nameof(PlayerData.metBanker), value);
    }

    public int bankerBalance
    {
        get => orig.GetInt(nameof(PlayerData.bankerBalance));
        set => orig.SetInt(nameof(PlayerData.bankerBalance), value);
    }

    public bool bankerDeclined
    {
        get => orig.GetBool(nameof(PlayerData.bankerDeclined));
        set => orig.SetBool(nameof(PlayerData.bankerDeclined), value);
    }

    public bool bankerTheftCheck
    {
        get => orig.GetBool(nameof(PlayerData.bankerTheftCheck));
        set => orig.SetBool(nameof(PlayerData.bankerTheftCheck), value);
    }

    public int bankerTheft
    {
        get => orig.GetInt(nameof(PlayerData.bankerTheft));
        set => orig.SetInt(nameof(PlayerData.bankerTheft), value);
    }

    public bool bankerSpaMet
    {
        get => orig.GetBool(nameof(PlayerData.bankerSpaMet));
        set => orig.SetBool(nameof(PlayerData.bankerSpaMet), value);
    }

    public bool metGiraffe
    {
        get => orig.GetBool(nameof(PlayerData.metGiraffe));
        set => orig.SetBool(nameof(PlayerData.metGiraffe), value);
    }

    public bool metCharmSlug
    {
        get => orig.GetBool(nameof(PlayerData.metCharmSlug));
        set => orig.SetBool(nameof(PlayerData.metCharmSlug), value);
    }

    public bool salubraNotch1
    {
        get => orig.GetBool(nameof(PlayerData.salubraNotch1));
        set => orig.SetBool(nameof(PlayerData.salubraNotch1), value);
    }

    public bool salubraNotch2
    {
        get => orig.GetBool(nameof(PlayerData.salubraNotch2));
        set => orig.SetBool(nameof(PlayerData.salubraNotch2), value);
    }

    public bool salubraNotch3
    {
        get => orig.GetBool(nameof(PlayerData.salubraNotch3));
        set => orig.SetBool(nameof(PlayerData.salubraNotch3), value);
    }

    public bool salubraNotch4
    {
        get => orig.GetBool(nameof(PlayerData.salubraNotch4));
        set => orig.SetBool(nameof(PlayerData.salubraNotch4), value);
    }

    public bool salubraBlessing
    {
        get => orig.GetBool(nameof(PlayerData.salubraBlessing));
        set => orig.SetBool(nameof(PlayerData.salubraBlessing), value);
    }

    public bool salubraConvoCombo
    {
        get => orig.GetBool(nameof(PlayerData.salubraConvoCombo));
        set => orig.SetBool(nameof(PlayerData.salubraConvoCombo), value);
    }

    public bool salubraConvoOvercharm
    {
        get => orig.GetBool(nameof(PlayerData.salubraConvoOvercharm));
        set => orig.SetBool(nameof(PlayerData.salubraConvoOvercharm), value);
    }

    public bool salubraConvoTruth
    {
        get => orig.GetBool(nameof(PlayerData.salubraConvoTruth));
        set => orig.SetBool(nameof(PlayerData.salubraConvoTruth), value);
    }

    public bool cultistTransformed
    {
        get => orig.GetBool(nameof(PlayerData.cultistTransformed));
        set => orig.SetBool(nameof(PlayerData.cultistTransformed), value);
    }

    public bool metNailsmith
    {
        get => orig.GetBool(nameof(PlayerData.metNailsmith));
        set => orig.SetBool(nameof(PlayerData.metNailsmith), value);
    }

    public int nailSmithUpgrades
    {
        get => orig.GetInt(nameof(PlayerData.nailSmithUpgrades));
        set => orig.SetInt(nameof(PlayerData.nailSmithUpgrades), value);
    }

    public bool honedNail
    {
        get => orig.GetBool(nameof(PlayerData.honedNail));
        set => orig.SetBool(nameof(PlayerData.honedNail), value);
    }

    public bool nailsmithCliff
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithCliff));
        set => orig.SetBool(nameof(PlayerData.nailsmithCliff), value);
    }

    public bool nailsmithKilled
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithKilled));
        set => orig.SetBool(nameof(PlayerData.nailsmithKilled), value);
    }

    public bool nailsmithSpared
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithSpared));
        set => orig.SetBool(nameof(PlayerData.nailsmithSpared), value);
    }

    public bool nailsmithKillSpeech
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithKillSpeech));
        set => orig.SetBool(nameof(PlayerData.nailsmithKillSpeech), value);
    }

    public bool nailsmithSheo
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithSheo));
        set => orig.SetBool(nameof(PlayerData.nailsmithSheo), value);
    }

    public bool nailsmithConvoArt
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithConvoArt));
        set => orig.SetBool(nameof(PlayerData.nailsmithConvoArt), value);
    }

    public bool metNailmasterMato
    {
        get => orig.GetBool(nameof(PlayerData.metNailmasterMato));
        set => orig.SetBool(nameof(PlayerData.metNailmasterMato), value);
    }

    public bool metNailmasterSheo
    {
        get => orig.GetBool(nameof(PlayerData.metNailmasterSheo));
        set => orig.SetBool(nameof(PlayerData.metNailmasterSheo), value);
    }

    public bool metNailmasterOro
    {
        get => orig.GetBool(nameof(PlayerData.metNailmasterOro));
        set => orig.SetBool(nameof(PlayerData.metNailmasterOro), value);
    }

    public bool matoConvoSheo
    {
        get => orig.GetBool(nameof(PlayerData.matoConvoSheo));
        set => orig.SetBool(nameof(PlayerData.matoConvoSheo), value);
    }

    public bool matoConvoOro
    {
        get => orig.GetBool(nameof(PlayerData.matoConvoOro));
        set => orig.SetBool(nameof(PlayerData.matoConvoOro), value);
    }

    public bool matoConvoSly
    {
        get => orig.GetBool(nameof(PlayerData.matoConvoSly));
        set => orig.SetBool(nameof(PlayerData.matoConvoSly), value);
    }

    public bool sheoConvoMato
    {
        get => orig.GetBool(nameof(PlayerData.sheoConvoMato));
        set => orig.SetBool(nameof(PlayerData.sheoConvoMato), value);
    }

    public bool sheoConvoOro
    {
        get => orig.GetBool(nameof(PlayerData.sheoConvoOro));
        set => orig.SetBool(nameof(PlayerData.sheoConvoOro), value);
    }

    public bool sheoConvoSly
    {
        get => orig.GetBool(nameof(PlayerData.sheoConvoSly));
        set => orig.SetBool(nameof(PlayerData.sheoConvoSly), value);
    }

    public bool sheoConvoNailsmith
    {
        get => orig.GetBool(nameof(PlayerData.sheoConvoNailsmith));
        set => orig.SetBool(nameof(PlayerData.sheoConvoNailsmith), value);
    }

    public bool oroConvoSheo
    {
        get => orig.GetBool(nameof(PlayerData.oroConvoSheo));
        set => orig.SetBool(nameof(PlayerData.oroConvoSheo), value);
    }

    public bool oroConvoMato
    {
        get => orig.GetBool(nameof(PlayerData.oroConvoMato));
        set => orig.SetBool(nameof(PlayerData.oroConvoMato), value);
    }

    public bool oroConvoSly
    {
        get => orig.GetBool(nameof(PlayerData.oroConvoSly));
        set => orig.SetBool(nameof(PlayerData.oroConvoSly), value);
    }

    public bool hunterRoared
    {
        get => orig.GetBool(nameof(PlayerData.hunterRoared));
        set => orig.SetBool(nameof(PlayerData.hunterRoared), value);
    }

    public bool metHunter
    {
        get => orig.GetBool(nameof(PlayerData.metHunter));
        set => orig.SetBool(nameof(PlayerData.metHunter), value);
    }

    public bool hunterRewardOffered
    {
        get => orig.GetBool(nameof(PlayerData.hunterRewardOffered));
        set => orig.SetBool(nameof(PlayerData.hunterRewardOffered), value);
    }

    public bool huntersMarkOffered
    {
        get => orig.GetBool(nameof(PlayerData.huntersMarkOffered));
        set => orig.SetBool(nameof(PlayerData.huntersMarkOffered), value);
    }

    public bool hasHuntersMark
    {
        get => orig.GetBool(nameof(PlayerData.hasHuntersMark));
        set => orig.SetBool(nameof(PlayerData.hasHuntersMark), value);
    }

    public bool metLegEater
    {
        get => orig.GetBool(nameof(PlayerData.metLegEater));
        set => orig.SetBool(nameof(PlayerData.metLegEater), value);
    }

    public bool paidLegEater
    {
        get => orig.GetBool(nameof(PlayerData.paidLegEater));
        set => orig.SetBool(nameof(PlayerData.paidLegEater), value);
    }

    public bool refusedLegEater
    {
        get => orig.GetBool(nameof(PlayerData.refusedLegEater));
        set => orig.SetBool(nameof(PlayerData.refusedLegEater), value);
    }

    public bool legEaterConvo1
    {
        get => orig.GetBool(nameof(PlayerData.legEaterConvo1));
        set => orig.SetBool(nameof(PlayerData.legEaterConvo1), value);
    }

    public bool legEaterConvo2
    {
        get => orig.GetBool(nameof(PlayerData.legEaterConvo2));
        set => orig.SetBool(nameof(PlayerData.legEaterConvo2), value);
    }

    public bool legEaterConvo3
    {
        get => orig.GetBool(nameof(PlayerData.legEaterConvo3));
        set => orig.SetBool(nameof(PlayerData.legEaterConvo3), value);
    }

    public bool legEaterBrokenConvo
    {
        get => orig.GetBool(nameof(PlayerData.legEaterBrokenConvo));
        set => orig.SetBool(nameof(PlayerData.legEaterBrokenConvo), value);
    }

    public bool legEaterDungConvo
    {
        get => orig.GetBool(nameof(PlayerData.legEaterDungConvo));
        set => orig.SetBool(nameof(PlayerData.legEaterDungConvo), value);
    }

    public bool legEaterInfectedCrossroadConvo
    {
        get => orig.GetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo));
        set => orig.SetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo), value);
    }

    public bool legEaterBoughtConvo
    {
        get => orig.GetBool(nameof(PlayerData.legEaterBoughtConvo));
        set => orig.SetBool(nameof(PlayerData.legEaterBoughtConvo), value);
    }

    public bool legEaterGoldConvo
    {
        get => orig.GetBool(nameof(PlayerData.legEaterGoldConvo));
        set => orig.SetBool(nameof(PlayerData.legEaterGoldConvo), value);
    }

    public bool legEaterLeft
    {
        get => orig.GetBool(nameof(PlayerData.legEaterLeft));
        set => orig.SetBool(nameof(PlayerData.legEaterLeft), value);
    }

    public bool tukMet
    {
        get => orig.GetBool(nameof(PlayerData.tukMet));
        set => orig.SetBool(nameof(PlayerData.tukMet), value);
    }

    public int tukEggPrice
    {
        get => orig.GetInt(nameof(PlayerData.tukEggPrice));
        set => orig.SetInt(nameof(PlayerData.tukEggPrice), value);
    }

    public bool tukDungEgg
    {
        get => orig.GetBool(nameof(PlayerData.tukDungEgg));
        set => orig.SetBool(nameof(PlayerData.tukDungEgg), value);
    }

    public bool metEmilitia
    {
        get => orig.GetBool(nameof(PlayerData.metEmilitia));
        set => orig.SetBool(nameof(PlayerData.metEmilitia), value);
    }

    public bool emilitiaKingsBrandConvo
    {
        get => orig.GetBool(nameof(PlayerData.emilitiaKingsBrandConvo));
        set => orig.SetBool(nameof(PlayerData.emilitiaKingsBrandConvo), value);
    }

    public bool metCloth
    {
        get => orig.GetBool(nameof(PlayerData.metCloth));
        set => orig.SetBool(nameof(PlayerData.metCloth), value);
    }

    public bool clothEnteredTramRoom
    {
        get => orig.GetBool(nameof(PlayerData.clothEnteredTramRoom));
        set => orig.SetBool(nameof(PlayerData.clothEnteredTramRoom), value);
    }

    public bool savedCloth
    {
        get => orig.GetBool(nameof(PlayerData.savedCloth));
        set => orig.SetBool(nameof(PlayerData.savedCloth), value);
    }

    public bool clothEncounteredQueensGarden
    {
        get => orig.GetBool(nameof(PlayerData.clothEncounteredQueensGarden));
        set => orig.SetBool(nameof(PlayerData.clothEncounteredQueensGarden), value);
    }

    public bool clothKilled
    {
        get => orig.GetBool(nameof(PlayerData.clothKilled));
        set => orig.SetBool(nameof(PlayerData.clothKilled), value);
    }

    public bool clothInTown
    {
        get => orig.GetBool(nameof(PlayerData.clothInTown));
        set => orig.SetBool(nameof(PlayerData.clothInTown), value);
    }

    public bool clothLeftTown
    {
        get => orig.GetBool(nameof(PlayerData.clothLeftTown));
        set => orig.SetBool(nameof(PlayerData.clothLeftTown), value);
    }

    public bool clothGhostSpoken
    {
        get => orig.GetBool(nameof(PlayerData.clothGhostSpoken));
        set => orig.SetBool(nameof(PlayerData.clothGhostSpoken), value);
    }

    public bool bigCatHitTail
    {
        get => orig.GetBool(nameof(PlayerData.bigCatHitTail));
        set => orig.SetBool(nameof(PlayerData.bigCatHitTail), value);
    }

    public bool bigCatHitTailConvo
    {
        get => orig.GetBool(nameof(PlayerData.bigCatHitTailConvo));
        set => orig.SetBool(nameof(PlayerData.bigCatHitTailConvo), value);
    }

    public bool bigCatMeet
    {
        get => orig.GetBool(nameof(PlayerData.bigCatMeet));
        set => orig.SetBool(nameof(PlayerData.bigCatMeet), value);
    }

    public bool bigCatTalk1
    {
        get => orig.GetBool(nameof(PlayerData.bigCatTalk1));
        set => orig.SetBool(nameof(PlayerData.bigCatTalk1), value);
    }

    public bool bigCatTalk2
    {
        get => orig.GetBool(nameof(PlayerData.bigCatTalk2));
        set => orig.SetBool(nameof(PlayerData.bigCatTalk2), value);
    }

    public bool bigCatTalk3
    {
        get => orig.GetBool(nameof(PlayerData.bigCatTalk3));
        set => orig.SetBool(nameof(PlayerData.bigCatTalk3), value);
    }

    public bool bigCatKingsBrandConvo
    {
        get => orig.GetBool(nameof(PlayerData.bigCatKingsBrandConvo));
        set => orig.SetBool(nameof(PlayerData.bigCatKingsBrandConvo), value);
    }

    public bool bigCatShadeConvo
    {
        get => orig.GetBool(nameof(PlayerData.bigCatShadeConvo));
        set => orig.SetBool(nameof(PlayerData.bigCatShadeConvo), value);
    }

    public bool tisoEncounteredTown
    {
        get => orig.GetBool(nameof(PlayerData.tisoEncounteredTown));
        set => orig.SetBool(nameof(PlayerData.tisoEncounteredTown), value);
    }

    public bool tisoEncounteredBench
    {
        get => orig.GetBool(nameof(PlayerData.tisoEncounteredBench));
        set => orig.SetBool(nameof(PlayerData.tisoEncounteredBench), value);
    }

    public bool tisoEncounteredLake
    {
        get => orig.GetBool(nameof(PlayerData.tisoEncounteredLake));
        set => orig.SetBool(nameof(PlayerData.tisoEncounteredLake), value);
    }

    public bool tisoEncounteredColosseum
    {
        get => orig.GetBool(nameof(PlayerData.tisoEncounteredColosseum));
        set => orig.SetBool(nameof(PlayerData.tisoEncounteredColosseum), value);
    }

    public bool tisoDead
    {
        get => orig.GetBool(nameof(PlayerData.tisoDead));
        set => orig.SetBool(nameof(PlayerData.tisoDead), value);
    }

    public bool tisoShieldConvo
    {
        get => orig.GetBool(nameof(PlayerData.tisoShieldConvo));
        set => orig.SetBool(nameof(PlayerData.tisoShieldConvo), value);
    }

    public int mossCultist
    {
        get => orig.GetInt(nameof(PlayerData.mossCultist));
        set => orig.SetInt(nameof(PlayerData.mossCultist), value);
    }

    public bool maskmakerMet
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerMet));
        set => orig.SetBool(nameof(PlayerData.maskmakerMet), value);
    }

    public bool maskmakerConvo1
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerConvo1));
        set => orig.SetBool(nameof(PlayerData.maskmakerConvo1), value);
    }

    public bool maskmakerConvo2
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerConvo2));
        set => orig.SetBool(nameof(PlayerData.maskmakerConvo2), value);
    }

    public bool maskmakerUnmasked1
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerUnmasked1));
        set => orig.SetBool(nameof(PlayerData.maskmakerUnmasked1), value);
    }

    public bool maskmakerUnmasked2
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerUnmasked2));
        set => orig.SetBool(nameof(PlayerData.maskmakerUnmasked2), value);
    }

    public bool maskmakerShadowDash
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerShadowDash));
        set => orig.SetBool(nameof(PlayerData.maskmakerShadowDash), value);
    }

    public bool maskmakerKingsBrand
    {
        get => orig.GetBool(nameof(PlayerData.maskmakerKingsBrand));
        set => orig.SetBool(nameof(PlayerData.maskmakerKingsBrand), value);
    }

    public bool dungDefenderConvo1
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderConvo1));
        set => orig.SetBool(nameof(PlayerData.dungDefenderConvo1), value);
    }

    public bool dungDefenderConvo2
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderConvo2));
        set => orig.SetBool(nameof(PlayerData.dungDefenderConvo2), value);
    }

    public bool dungDefenderConvo3
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderConvo3));
        set => orig.SetBool(nameof(PlayerData.dungDefenderConvo3), value);
    }

    public bool dungDefenderCharmConvo
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderCharmConvo));
        set => orig.SetBool(nameof(PlayerData.dungDefenderCharmConvo), value);
    }

    public bool dungDefenderIsmaConvo
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderIsmaConvo));
        set => orig.SetBool(nameof(PlayerData.dungDefenderIsmaConvo), value);
    }

    public bool dungDefenderAwoken
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderAwoken));
        set => orig.SetBool(nameof(PlayerData.dungDefenderAwoken), value);
    }

    public bool dungDefenderLeft
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderLeft));
        set => orig.SetBool(nameof(PlayerData.dungDefenderLeft), value);
    }

    public bool dungDefenderAwakeConvo
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderAwakeConvo));
        set => orig.SetBool(nameof(PlayerData.dungDefenderAwakeConvo), value);
    }

    public bool midwifeMet
    {
        get => orig.GetBool(nameof(PlayerData.midwifeMet));
        set => orig.SetBool(nameof(PlayerData.midwifeMet), value);
    }

    public bool midwifeConvo1
    {
        get => orig.GetBool(nameof(PlayerData.midwifeConvo1));
        set => orig.SetBool(nameof(PlayerData.midwifeConvo1), value);
    }

    public bool midwifeConvo2
    {
        get => orig.GetBool(nameof(PlayerData.midwifeConvo2));
        set => orig.SetBool(nameof(PlayerData.midwifeConvo2), value);
    }

    public bool metQueen
    {
        get => orig.GetBool(nameof(PlayerData.metQueen));
        set => orig.SetBool(nameof(PlayerData.metQueen), value);
    }

    public bool queenTalk1
    {
        get => orig.GetBool(nameof(PlayerData.queenTalk1));
        set => orig.SetBool(nameof(PlayerData.queenTalk1), value);
    }

    public bool queenTalk2
    {
        get => orig.GetBool(nameof(PlayerData.queenTalk2));
        set => orig.SetBool(nameof(PlayerData.queenTalk2), value);
    }

    public bool queenDung1
    {
        get => orig.GetBool(nameof(PlayerData.queenDung1));
        set => orig.SetBool(nameof(PlayerData.queenDung1), value);
    }

    public bool queenDung2
    {
        get => orig.GetBool(nameof(PlayerData.queenDung2));
        set => orig.SetBool(nameof(PlayerData.queenDung2), value);
    }

    public bool queenHornet
    {
        get => orig.GetBool(nameof(PlayerData.queenHornet));
        set => orig.SetBool(nameof(PlayerData.queenHornet), value);
    }

    public bool queenTalkExtra
    {
        get => orig.GetBool(nameof(PlayerData.queenTalkExtra));
        set => orig.SetBool(nameof(PlayerData.queenTalkExtra), value);
    }

    public bool gotQueenFragment
    {
        get => orig.GetBool(nameof(PlayerData.gotQueenFragment));
        set => orig.SetBool(nameof(PlayerData.gotQueenFragment), value);
    }

    public bool queenConvo_grimm1
    {
        get => orig.GetBool(nameof(PlayerData.queenConvo_grimm1));
        set => orig.SetBool(nameof(PlayerData.queenConvo_grimm1), value);
    }

    public bool queenConvo_grimm2
    {
        get => orig.GetBool(nameof(PlayerData.queenConvo_grimm2));
        set => orig.SetBool(nameof(PlayerData.queenConvo_grimm2), value);
    }

    public bool gotKingFragment
    {
        get => orig.GetBool(nameof(PlayerData.gotKingFragment));
        set => orig.SetBool(nameof(PlayerData.gotKingFragment), value);
    }

    public bool metXun
    {
        get => orig.GetBool(nameof(PlayerData.metXun));
        set => orig.SetBool(nameof(PlayerData.metXun), value);
    }

    public bool xunFailedConvo1
    {
        get => orig.GetBool(nameof(PlayerData.xunFailedConvo1));
        set => orig.SetBool(nameof(PlayerData.xunFailedConvo1), value);
    }

    public bool xunFailedConvo2
    {
        get => orig.GetBool(nameof(PlayerData.xunFailedConvo2));
        set => orig.SetBool(nameof(PlayerData.xunFailedConvo2), value);
    }

    public bool xunFlowerBroken
    {
        get => orig.GetBool(nameof(PlayerData.xunFlowerBroken));
        set => orig.SetBool(nameof(PlayerData.xunFlowerBroken), value);
    }

    public int xunFlowerBrokeTimes
    {
        get => orig.GetInt(nameof(PlayerData.xunFlowerBrokeTimes));
        set => orig.SetInt(nameof(PlayerData.xunFlowerBrokeTimes), value);
    }

    public bool xunFlowerGiven
    {
        get => orig.GetBool(nameof(PlayerData.xunFlowerGiven));
        set => orig.SetBool(nameof(PlayerData.xunFlowerGiven), value);
    }

    public bool xunRewardGiven
    {
        get => orig.GetBool(nameof(PlayerData.xunRewardGiven));
        set => orig.SetBool(nameof(PlayerData.xunRewardGiven), value);
    }

    public int menderState
    {
        get => orig.GetInt(nameof(PlayerData.menderState));
        set => orig.SetInt(nameof(PlayerData.menderState), value);
    }

    public bool menderSignBroken
    {
        get => orig.GetBool(nameof(PlayerData.menderSignBroken));
        set => orig.SetBool(nameof(PlayerData.menderSignBroken), value);
    }

    public bool allBelieverTabletsDestroyed
    {
        get => orig.GetBool(nameof(PlayerData.allBelieverTabletsDestroyed));
        set => orig.SetBool(nameof(PlayerData.allBelieverTabletsDestroyed), value);
    }

    public int mrMushroomState
    {
        get => orig.GetInt(nameof(PlayerData.mrMushroomState));
        set => orig.SetInt(nameof(PlayerData.mrMushroomState), value);
    }

    public bool openedMapperShop
    {
        get => orig.GetBool(nameof(PlayerData.openedMapperShop));
        set => orig.SetBool(nameof(PlayerData.openedMapperShop), value);
    }

    public bool openedSlyShop
    {
        get => orig.GetBool(nameof(PlayerData.openedSlyShop));
        set => orig.SetBool(nameof(PlayerData.openedSlyShop), value);
    }

    public bool metStag
    {
        get => orig.GetBool(nameof(PlayerData.metStag));
        set => orig.SetBool(nameof(PlayerData.metStag), value);
    }

    public bool travelling
    {
        get => orig.GetBool(nameof(PlayerData.travelling));
        set => orig.SetBool(nameof(PlayerData.travelling), value);
    }

    public int stagPosition
    {
        get => orig.GetInt(nameof(PlayerData.stagPosition));
        set => orig.SetInt(nameof(PlayerData.stagPosition), value);
    }

    public int stationsOpened
    {
        get => orig.GetInt(nameof(PlayerData.stationsOpened));
        set => orig.SetInt(nameof(PlayerData.stationsOpened), value);
    }

    public bool stagConvoTram
    {
        get => orig.GetBool(nameof(PlayerData.stagConvoTram));
        set => orig.SetBool(nameof(PlayerData.stagConvoTram), value);
    }

    public bool stagConvoTiso
    {
        get => orig.GetBool(nameof(PlayerData.stagConvoTiso));
        set => orig.SetBool(nameof(PlayerData.stagConvoTiso), value);
    }

    public bool stagRemember1
    {
        get => orig.GetBool(nameof(PlayerData.stagRemember1));
        set => orig.SetBool(nameof(PlayerData.stagRemember1), value);
    }

    public bool stagRemember2
    {
        get => orig.GetBool(nameof(PlayerData.stagRemember2));
        set => orig.SetBool(nameof(PlayerData.stagRemember2), value);
    }

    public bool stagRemember3
    {
        get => orig.GetBool(nameof(PlayerData.stagRemember3));
        set => orig.SetBool(nameof(PlayerData.stagRemember3), value);
    }

    public bool stagEggInspected
    {
        get => orig.GetBool(nameof(PlayerData.stagEggInspected));
        set => orig.SetBool(nameof(PlayerData.stagEggInspected), value);
    }

    public bool stagHopeConvo
    {
        get => orig.GetBool(nameof(PlayerData.stagHopeConvo));
        set => orig.SetBool(nameof(PlayerData.stagHopeConvo), value);
    }

    public string nextScene
    {
        get => orig.GetString(nameof(PlayerData.nextScene));
        set => orig.SetString(nameof(PlayerData.nextScene), value);
    }

    public bool littleFoolMet
    {
        get => orig.GetBool(nameof(PlayerData.littleFoolMet));
        set => orig.SetBool(nameof(PlayerData.littleFoolMet), value);
    }

    public bool ranAway
    {
        get => orig.GetBool(nameof(PlayerData.ranAway));
        set => orig.SetBool(nameof(PlayerData.ranAway), value);
    }

    public bool seenColosseumTitle
    {
        get => orig.GetBool(nameof(PlayerData.seenColosseumTitle));
        set => orig.SetBool(nameof(PlayerData.seenColosseumTitle), value);
    }

    public bool colosseumBronzeOpened
    {
        get => orig.GetBool(nameof(PlayerData.colosseumBronzeOpened));
        set => orig.SetBool(nameof(PlayerData.colosseumBronzeOpened), value);
    }

    public bool colosseumBronzeCompleted
    {
        get => orig.GetBool(nameof(PlayerData.colosseumBronzeCompleted));
        set => orig.SetBool(nameof(PlayerData.colosseumBronzeCompleted), value);
    }

    public bool colosseumSilverOpened
    {
        get => orig.GetBool(nameof(PlayerData.colosseumSilverOpened));
        set => orig.SetBool(nameof(PlayerData.colosseumSilverOpened), value);
    }

    public bool colosseumSilverCompleted
    {
        get => orig.GetBool(nameof(PlayerData.colosseumSilverCompleted));
        set => orig.SetBool(nameof(PlayerData.colosseumSilverCompleted), value);
    }

    public bool colosseumGoldOpened
    {
        get => orig.GetBool(nameof(PlayerData.colosseumGoldOpened));
        set => orig.SetBool(nameof(PlayerData.colosseumGoldOpened), value);
    }

    public bool colosseumGoldCompleted
    {
        get => orig.GetBool(nameof(PlayerData.colosseumGoldCompleted));
        set => orig.SetBool(nameof(PlayerData.colosseumGoldCompleted), value);
    }

    public bool openedTown
    {
        get => orig.GetBool(nameof(PlayerData.openedTown));
        set => orig.SetBool(nameof(PlayerData.openedTown), value);
    }

    public bool openedTownBuilding
    {
        get => orig.GetBool(nameof(PlayerData.openedTownBuilding));
        set => orig.SetBool(nameof(PlayerData.openedTownBuilding), value);
    }

    public bool openedCrossroads
    {
        get => orig.GetBool(nameof(PlayerData.openedCrossroads));
        set => orig.SetBool(nameof(PlayerData.openedCrossroads), value);
    }

    public bool openedGreenpath
    {
        get => orig.GetBool(nameof(PlayerData.openedGreenpath));
        set => orig.SetBool(nameof(PlayerData.openedGreenpath), value);
    }

    public bool openedRuins1
    {
        get => orig.GetBool(nameof(PlayerData.openedRuins1));
        set => orig.SetBool(nameof(PlayerData.openedRuins1), value);
    }

    public bool openedRuins2
    {
        get => orig.GetBool(nameof(PlayerData.openedRuins2));
        set => orig.SetBool(nameof(PlayerData.openedRuins2), value);
    }

    public bool openedFungalWastes
    {
        get => orig.GetBool(nameof(PlayerData.openedFungalWastes));
        set => orig.SetBool(nameof(PlayerData.openedFungalWastes), value);
    }

    public bool openedRoyalGardens
    {
        get => orig.GetBool(nameof(PlayerData.openedRoyalGardens));
        set => orig.SetBool(nameof(PlayerData.openedRoyalGardens), value);
    }

    public bool openedRestingGrounds
    {
        get => orig.GetBool(nameof(PlayerData.openedRestingGrounds));
        set => orig.SetBool(nameof(PlayerData.openedRestingGrounds), value);
    }

    public bool openedDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.openedDeepnest));
        set => orig.SetBool(nameof(PlayerData.openedDeepnest), value);
    }

    public bool openedStagNest
    {
        get => orig.GetBool(nameof(PlayerData.openedStagNest));
        set => orig.SetBool(nameof(PlayerData.openedStagNest), value);
    }

    public bool openedHiddenStation
    {
        get => orig.GetBool(nameof(PlayerData.openedHiddenStation));
        set => orig.SetBool(nameof(PlayerData.openedHiddenStation), value);
    }

    public string dreamReturnScene
    {
        get => orig.GetString(nameof(PlayerData.dreamReturnScene));
        set => orig.SetString(nameof(PlayerData.dreamReturnScene), value);
    }

    public int charmSlots
    {
        get => orig.GetInt(nameof(PlayerData.charmSlots));
        set => orig.SetInt(nameof(PlayerData.charmSlots), value);
    }

    public int charmSlotsFilled
    {
        get => orig.GetInt(nameof(PlayerData.charmSlotsFilled));
        set => orig.SetInt(nameof(PlayerData.charmSlotsFilled), value);
    }

    public bool hasCharm
    {
        get => orig.GetBool(nameof(PlayerData.hasCharm));
        set => orig.SetBool(nameof(PlayerData.hasCharm), value);
    }

    public List<int> equippedCharms
    {
        get => orig.GetVariable<List<int>>(nameof(PlayerData.equippedCharms));
        set => orig.SetVariable(nameof(PlayerData.equippedCharms), value);
    }

    public bool charmBenchMsg
    {
        get => orig.GetBool(nameof(PlayerData.charmBenchMsg));
        set => orig.SetBool(nameof(PlayerData.charmBenchMsg), value);
    }

    public int charmsOwned
    {
        get => orig.GetInt(nameof(PlayerData.charmsOwned));
        set => orig.SetInt(nameof(PlayerData.charmsOwned), value);
    }

    public bool canOvercharm
    {
        get => orig.GetBool(nameof(PlayerData.canOvercharm));
        set => orig.SetBool(nameof(PlayerData.canOvercharm), value);
    }

    public bool overcharmed
    {
        get => orig.GetBool(nameof(PlayerData.overcharmed));
        set => orig.SetBool(nameof(PlayerData.overcharmed), value);
    }

    public bool gotCharm_1
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_1));
        set => orig.SetBool(nameof(PlayerData.gotCharm_1), value);
    }

    public bool equippedCharm_1
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_1));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_1), value);
    }

    public int charmCost_1
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_1));
        set => orig.SetInt(nameof(PlayerData.charmCost_1), value);
    }

    public bool newCharm_1
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_1));
        set => orig.SetBool(nameof(PlayerData.newCharm_1), value);
    }

    public bool gotCharm_2
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_2));
        set => orig.SetBool(nameof(PlayerData.gotCharm_2), value);
    }

    public bool equippedCharm_2
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_2));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_2), value);
    }

    public int charmCost_2
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_2));
        set => orig.SetInt(nameof(PlayerData.charmCost_2), value);
    }

    public bool newCharm_2
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_2));
        set => orig.SetBool(nameof(PlayerData.newCharm_2), value);
    }

    public bool gotCharm_3
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_3));
        set => orig.SetBool(nameof(PlayerData.gotCharm_3), value);
    }

    public bool equippedCharm_3
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_3));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_3), value);
    }

    public int charmCost_3
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_3));
        set => orig.SetInt(nameof(PlayerData.charmCost_3), value);
    }

    public bool newCharm_3
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_3));
        set => orig.SetBool(nameof(PlayerData.newCharm_3), value);
    }

    public bool gotCharm_4
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_4));
        set => orig.SetBool(nameof(PlayerData.gotCharm_4), value);
    }

    public bool equippedCharm_4
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_4));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_4), value);
    }

    public int charmCost_4
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_4));
        set => orig.SetInt(nameof(PlayerData.charmCost_4), value);
    }

    public bool newCharm_4
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_4));
        set => orig.SetBool(nameof(PlayerData.newCharm_4), value);
    }

    public bool gotCharm_5
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_5));
        set => orig.SetBool(nameof(PlayerData.gotCharm_5), value);
    }

    public bool equippedCharm_5
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_5));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_5), value);
    }

    public int charmCost_5
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_5));
        set => orig.SetInt(nameof(PlayerData.charmCost_5), value);
    }

    public bool newCharm_5
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_5));
        set => orig.SetBool(nameof(PlayerData.newCharm_5), value);
    }

    public bool gotCharm_6
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_6));
        set => orig.SetBool(nameof(PlayerData.gotCharm_6), value);
    }

    public bool equippedCharm_6
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_6));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_6), value);
    }

    public int charmCost_6
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_6));
        set => orig.SetInt(nameof(PlayerData.charmCost_6), value);
    }

    public bool newCharm_6
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_6));
        set => orig.SetBool(nameof(PlayerData.newCharm_6), value);
    }

    public bool gotCharm_7
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_7));
        set => orig.SetBool(nameof(PlayerData.gotCharm_7), value);
    }

    public bool equippedCharm_7
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_7));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_7), value);
    }

    public int charmCost_7
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_7));
        set => orig.SetInt(nameof(PlayerData.charmCost_7), value);
    }

    public bool newCharm_7
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_7));
        set => orig.SetBool(nameof(PlayerData.newCharm_7), value);
    }

    public bool gotCharm_8
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_8));
        set => orig.SetBool(nameof(PlayerData.gotCharm_8), value);
    }

    public bool equippedCharm_8
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_8));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_8), value);
    }

    public int charmCost_8
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_8));
        set => orig.SetInt(nameof(PlayerData.charmCost_8), value);
    }

    public bool newCharm_8
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_8));
        set => orig.SetBool(nameof(PlayerData.newCharm_8), value);
    }

    public bool gotCharm_9
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_9));
        set => orig.SetBool(nameof(PlayerData.gotCharm_9), value);
    }

    public bool equippedCharm_9
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_9));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_9), value);
    }

    public int charmCost_9
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_9));
        set => orig.SetInt(nameof(PlayerData.charmCost_9), value);
    }

    public bool newCharm_9
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_9));
        set => orig.SetBool(nameof(PlayerData.newCharm_9), value);
    }

    public bool gotCharm_10
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_10));
        set => orig.SetBool(nameof(PlayerData.gotCharm_10), value);
    }

    public bool equippedCharm_10
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_10));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_10), value);
    }

    public int charmCost_10
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_10));
        set => orig.SetInt(nameof(PlayerData.charmCost_10), value);
    }

    public bool newCharm_10
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_10));
        set => orig.SetBool(nameof(PlayerData.newCharm_10), value);
    }

    public bool gotCharm_11
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_11));
        set => orig.SetBool(nameof(PlayerData.gotCharm_11), value);
    }

    public bool equippedCharm_11
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_11));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_11), value);
    }

    public int charmCost_11
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_11));
        set => orig.SetInt(nameof(PlayerData.charmCost_11), value);
    }

    public bool newCharm_11
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_11));
        set => orig.SetBool(nameof(PlayerData.newCharm_11), value);
    }

    public bool gotCharm_12
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_12));
        set => orig.SetBool(nameof(PlayerData.gotCharm_12), value);
    }

    public bool equippedCharm_12
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_12));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_12), value);
    }

    public int charmCost_12
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_12));
        set => orig.SetInt(nameof(PlayerData.charmCost_12), value);
    }

    public bool newCharm_12
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_12));
        set => orig.SetBool(nameof(PlayerData.newCharm_12), value);
    }

    public bool gotCharm_13
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_13));
        set => orig.SetBool(nameof(PlayerData.gotCharm_13), value);
    }

    public bool equippedCharm_13
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_13));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_13), value);
    }

    public int charmCost_13
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_13));
        set => orig.SetInt(nameof(PlayerData.charmCost_13), value);
    }

    public bool newCharm_13
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_13));
        set => orig.SetBool(nameof(PlayerData.newCharm_13), value);
    }

    public bool gotCharm_14
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_14));
        set => orig.SetBool(nameof(PlayerData.gotCharm_14), value);
    }

    public bool equippedCharm_14
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_14));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_14), value);
    }

    public int charmCost_14
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_14));
        set => orig.SetInt(nameof(PlayerData.charmCost_14), value);
    }

    public bool newCharm_14
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_14));
        set => orig.SetBool(nameof(PlayerData.newCharm_14), value);
    }

    public bool gotCharm_15
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_15));
        set => orig.SetBool(nameof(PlayerData.gotCharm_15), value);
    }

    public bool equippedCharm_15
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_15));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_15), value);
    }

    public int charmCost_15
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_15));
        set => orig.SetInt(nameof(PlayerData.charmCost_15), value);
    }

    public bool newCharm_15
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_15));
        set => orig.SetBool(nameof(PlayerData.newCharm_15), value);
    }

    public bool gotCharm_16
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_16));
        set => orig.SetBool(nameof(PlayerData.gotCharm_16), value);
    }

    public bool equippedCharm_16
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_16));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_16), value);
    }

    public int charmCost_16
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_16));
        set => orig.SetInt(nameof(PlayerData.charmCost_16), value);
    }

    public bool newCharm_16
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_16));
        set => orig.SetBool(nameof(PlayerData.newCharm_16), value);
    }

    public bool gotCharm_17
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_17));
        set => orig.SetBool(nameof(PlayerData.gotCharm_17), value);
    }

    public bool equippedCharm_17
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_17));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_17), value);
    }

    public int charmCost_17
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_17));
        set => orig.SetInt(nameof(PlayerData.charmCost_17), value);
    }

    public bool newCharm_17
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_17));
        set => orig.SetBool(nameof(PlayerData.newCharm_17), value);
    }

    public bool gotCharm_18
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_18));
        set => orig.SetBool(nameof(PlayerData.gotCharm_18), value);
    }

    public bool equippedCharm_18
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_18));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_18), value);
    }

    public int charmCost_18
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_18));
        set => orig.SetInt(nameof(PlayerData.charmCost_18), value);
    }

    public bool newCharm_18
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_18));
        set => orig.SetBool(nameof(PlayerData.newCharm_18), value);
    }

    public bool gotCharm_19
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_19));
        set => orig.SetBool(nameof(PlayerData.gotCharm_19), value);
    }

    public bool equippedCharm_19
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_19));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_19), value);
    }

    public int charmCost_19
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_19));
        set => orig.SetInt(nameof(PlayerData.charmCost_19), value);
    }

    public bool newCharm_19
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_19));
        set => orig.SetBool(nameof(PlayerData.newCharm_19), value);
    }

    public bool gotCharm_20
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_20));
        set => orig.SetBool(nameof(PlayerData.gotCharm_20), value);
    }

    public bool equippedCharm_20
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_20));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_20), value);
    }

    public int charmCost_20
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_20));
        set => orig.SetInt(nameof(PlayerData.charmCost_20), value);
    }

    public bool newCharm_20
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_20));
        set => orig.SetBool(nameof(PlayerData.newCharm_20), value);
    }

    public bool gotCharm_21
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_21));
        set => orig.SetBool(nameof(PlayerData.gotCharm_21), value);
    }

    public bool equippedCharm_21
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_21));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_21), value);
    }

    public int charmCost_21
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_21));
        set => orig.SetInt(nameof(PlayerData.charmCost_21), value);
    }

    public bool newCharm_21
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_21));
        set => orig.SetBool(nameof(PlayerData.newCharm_21), value);
    }

    public bool gotCharm_22
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_22));
        set => orig.SetBool(nameof(PlayerData.gotCharm_22), value);
    }

    public bool equippedCharm_22
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_22));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_22), value);
    }

    public int charmCost_22
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_22));
        set => orig.SetInt(nameof(PlayerData.charmCost_22), value);
    }

    public bool newCharm_22
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_22));
        set => orig.SetBool(nameof(PlayerData.newCharm_22), value);
    }

    public bool gotCharm_23
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_23));
        set => orig.SetBool(nameof(PlayerData.gotCharm_23), value);
    }

    public bool equippedCharm_23
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_23));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_23), value);
    }

    public bool brokenCharm_23
    {
        get => orig.GetBool(nameof(PlayerData.brokenCharm_23));
        set => orig.SetBool(nameof(PlayerData.brokenCharm_23), value);
    }

    public int charmCost_23
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_23));
        set => orig.SetInt(nameof(PlayerData.charmCost_23), value);
    }

    public bool newCharm_23
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_23));
        set => orig.SetBool(nameof(PlayerData.newCharm_23), value);
    }

    public bool gotCharm_24
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_24));
        set => orig.SetBool(nameof(PlayerData.gotCharm_24), value);
    }

    public bool equippedCharm_24
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_24));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_24), value);
    }

    public bool brokenCharm_24
    {
        get => orig.GetBool(nameof(PlayerData.brokenCharm_24));
        set => orig.SetBool(nameof(PlayerData.brokenCharm_24), value);
    }

    public int charmCost_24
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_24));
        set => orig.SetInt(nameof(PlayerData.charmCost_24), value);
    }

    public bool newCharm_24
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_24));
        set => orig.SetBool(nameof(PlayerData.newCharm_24), value);
    }

    public bool gotCharm_25
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_25));
        set => orig.SetBool(nameof(PlayerData.gotCharm_25), value);
    }

    public bool equippedCharm_25
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_25));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_25), value);
    }

    public bool brokenCharm_25
    {
        get => orig.GetBool(nameof(PlayerData.brokenCharm_25));
        set => orig.SetBool(nameof(PlayerData.brokenCharm_25), value);
    }

    public int charmCost_25
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_25));
        set => orig.SetInt(nameof(PlayerData.charmCost_25), value);
    }

    public bool newCharm_25
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_25));
        set => orig.SetBool(nameof(PlayerData.newCharm_25), value);
    }

    public bool gotCharm_26
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_26));
        set => orig.SetBool(nameof(PlayerData.gotCharm_26), value);
    }

    public bool equippedCharm_26
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_26));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_26), value);
    }

    public int charmCost_26
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_26));
        set => orig.SetInt(nameof(PlayerData.charmCost_26), value);
    }

    public bool newCharm_26
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_26));
        set => orig.SetBool(nameof(PlayerData.newCharm_26), value);
    }

    public bool gotCharm_27
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_27));
        set => orig.SetBool(nameof(PlayerData.gotCharm_27), value);
    }

    public bool equippedCharm_27
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_27));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_27), value);
    }

    public int charmCost_27
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_27));
        set => orig.SetInt(nameof(PlayerData.charmCost_27), value);
    }

    public bool newCharm_27
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_27));
        set => orig.SetBool(nameof(PlayerData.newCharm_27), value);
    }

    public bool gotCharm_28
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_28));
        set => orig.SetBool(nameof(PlayerData.gotCharm_28), value);
    }

    public bool equippedCharm_28
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_28));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_28), value);
    }

    public int charmCost_28
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_28));
        set => orig.SetInt(nameof(PlayerData.charmCost_28), value);
    }

    public bool newCharm_28
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_28));
        set => orig.SetBool(nameof(PlayerData.newCharm_28), value);
    }

    public bool gotCharm_29
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_29));
        set => orig.SetBool(nameof(PlayerData.gotCharm_29), value);
    }

    public bool equippedCharm_29
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_29));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_29), value);
    }

    public int charmCost_29
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_29));
        set => orig.SetInt(nameof(PlayerData.charmCost_29), value);
    }

    public bool newCharm_29
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_29));
        set => orig.SetBool(nameof(PlayerData.newCharm_29), value);
    }

    public bool gotCharm_30
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_30));
        set => orig.SetBool(nameof(PlayerData.gotCharm_30), value);
    }

    public bool equippedCharm_30
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_30));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_30), value);
    }

    public int charmCost_30
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_30));
        set => orig.SetInt(nameof(PlayerData.charmCost_30), value);
    }

    public bool newCharm_30
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_30));
        set => orig.SetBool(nameof(PlayerData.newCharm_30), value);
    }

    public bool gotCharm_31
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_31));
        set => orig.SetBool(nameof(PlayerData.gotCharm_31), value);
    }

    public bool equippedCharm_31
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_31));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_31), value);
    }

    public int charmCost_31
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_31));
        set => orig.SetInt(nameof(PlayerData.charmCost_31), value);
    }

    public bool newCharm_31
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_31));
        set => orig.SetBool(nameof(PlayerData.newCharm_31), value);
    }

    public bool gotCharm_32
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_32));
        set => orig.SetBool(nameof(PlayerData.gotCharm_32), value);
    }

    public bool equippedCharm_32
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_32));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_32), value);
    }

    public int charmCost_32
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_32));
        set => orig.SetInt(nameof(PlayerData.charmCost_32), value);
    }

    public bool newCharm_32
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_32));
        set => orig.SetBool(nameof(PlayerData.newCharm_32), value);
    }

    public bool gotCharm_33
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_33));
        set => orig.SetBool(nameof(PlayerData.gotCharm_33), value);
    }

    public bool equippedCharm_33
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_33));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_33), value);
    }

    public int charmCost_33
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_33));
        set => orig.SetInt(nameof(PlayerData.charmCost_33), value);
    }

    public bool newCharm_33
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_33));
        set => orig.SetBool(nameof(PlayerData.newCharm_33), value);
    }

    public bool gotCharm_34
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_34));
        set => orig.SetBool(nameof(PlayerData.gotCharm_34), value);
    }

    public bool equippedCharm_34
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_34));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_34), value);
    }

    public int charmCost_34
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_34));
        set => orig.SetInt(nameof(PlayerData.charmCost_34), value);
    }

    public bool newCharm_34
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_34));
        set => orig.SetBool(nameof(PlayerData.newCharm_34), value);
    }

    public bool gotCharm_35
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_35));
        set => orig.SetBool(nameof(PlayerData.gotCharm_35), value);
    }

    public bool equippedCharm_35
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_35));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_35), value);
    }

    public int charmCost_35
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_35));
        set => orig.SetInt(nameof(PlayerData.charmCost_35), value);
    }

    public bool newCharm_35
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_35));
        set => orig.SetBool(nameof(PlayerData.newCharm_35), value);
    }

    public bool gotCharm_36
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_36));
        set => orig.SetBool(nameof(PlayerData.gotCharm_36), value);
    }

    public bool equippedCharm_36
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_36));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_36), value);
    }

    public int charmCost_36
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_36));
        set => orig.SetInt(nameof(PlayerData.charmCost_36), value);
    }

    public bool newCharm_36
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_36));
        set => orig.SetBool(nameof(PlayerData.newCharm_36), value);
    }

    public bool gotCharm_37
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_37));
        set => orig.SetBool(nameof(PlayerData.gotCharm_37), value);
    }

    public bool equippedCharm_37
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_37));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_37), value);
    }

    public int charmCost_37
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_37));
        set => orig.SetInt(nameof(PlayerData.charmCost_37), value);
    }

    public bool newCharm_37
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_37));
        set => orig.SetBool(nameof(PlayerData.newCharm_37), value);
    }

    public bool gotCharm_38
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_38));
        set => orig.SetBool(nameof(PlayerData.gotCharm_38), value);
    }

    public bool equippedCharm_38
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_38));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_38), value);
    }

    public int charmCost_38
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_38));
        set => orig.SetInt(nameof(PlayerData.charmCost_38), value);
    }

    public bool newCharm_38
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_38));
        set => orig.SetBool(nameof(PlayerData.newCharm_38), value);
    }

    public bool gotCharm_39
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_39));
        set => orig.SetBool(nameof(PlayerData.gotCharm_39), value);
    }

    public bool equippedCharm_39
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_39));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_39), value);
    }

    public int charmCost_39
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_39));
        set => orig.SetInt(nameof(PlayerData.charmCost_39), value);
    }

    public bool newCharm_39
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_39));
        set => orig.SetBool(nameof(PlayerData.newCharm_39), value);
    }

    public bool gotCharm_40
    {
        get => orig.GetBool(nameof(PlayerData.gotCharm_40));
        set => orig.SetBool(nameof(PlayerData.gotCharm_40), value);
    }

    public bool equippedCharm_40
    {
        get => orig.GetBool(nameof(PlayerData.equippedCharm_40));
        set => orig.SetBool(nameof(PlayerData.equippedCharm_40), value);
    }

    public int charmCost_40
    {
        get => orig.GetInt(nameof(PlayerData.charmCost_40));
        set => orig.SetInt(nameof(PlayerData.charmCost_40), value);
    }

    public bool newCharm_40
    {
        get => orig.GetBool(nameof(PlayerData.newCharm_40));
        set => orig.SetBool(nameof(PlayerData.newCharm_40), value);
    }

    public bool fragileHealth_unbreakable
    {
        get => orig.GetBool(nameof(PlayerData.fragileHealth_unbreakable));
        set => orig.SetBool(nameof(PlayerData.fragileHealth_unbreakable), value);
    }

    public bool fragileGreed_unbreakable
    {
        get => orig.GetBool(nameof(PlayerData.fragileGreed_unbreakable));
        set => orig.SetBool(nameof(PlayerData.fragileGreed_unbreakable), value);
    }

    public bool fragileStrength_unbreakable
    {
        get => orig.GetBool(nameof(PlayerData.fragileStrength_unbreakable));
        set => orig.SetBool(nameof(PlayerData.fragileStrength_unbreakable), value);
    }

    public int royalCharmState
    {
        get => orig.GetInt(nameof(PlayerData.royalCharmState));
        set => orig.SetInt(nameof(PlayerData.royalCharmState), value);
    }

    public bool hasJournal
    {
        get => orig.GetBool(nameof(PlayerData.hasJournal));
        set => orig.SetBool(nameof(PlayerData.hasJournal), value);
    }

    public int lastJournalItem
    {
        get => orig.GetInt(nameof(PlayerData.lastJournalItem));
        set => orig.SetInt(nameof(PlayerData.lastJournalItem), value);
    }

    public bool killedDummy
    {
        get => orig.GetBool(nameof(PlayerData.killedDummy));
        set => orig.SetBool(nameof(PlayerData.killedDummy), value);
    }

    public int killsDummy
    {
        get => orig.GetInt(nameof(PlayerData.killsDummy));
        set => orig.SetInt(nameof(PlayerData.killsDummy), value);
    }

    public bool newDataDummy
    {
        get => orig.GetBool(nameof(PlayerData.newDataDummy));
        set => orig.SetBool(nameof(PlayerData.newDataDummy), value);
    }

    public bool seenJournalMsg
    {
        get => orig.GetBool(nameof(PlayerData.seenJournalMsg));
        set => orig.SetBool(nameof(PlayerData.seenJournalMsg), value);
    }

    public bool seenHunterMsg
    {
        get => orig.GetBool(nameof(PlayerData.seenHunterMsg));
        set => orig.SetBool(nameof(PlayerData.seenHunterMsg), value);
    }

    public bool fillJournal
    {
        get => orig.GetBool(nameof(PlayerData.fillJournal));
        set => orig.SetBool(nameof(PlayerData.fillJournal), value);
    }

    public int journalEntriesCompleted
    {
        get => orig.GetInt(nameof(PlayerData.journalEntriesCompleted));
        set => orig.SetInt(nameof(PlayerData.journalEntriesCompleted), value);
    }

    public int journalNotesCompleted
    {
        get => orig.GetInt(nameof(PlayerData.journalNotesCompleted));
        set => orig.SetInt(nameof(PlayerData.journalNotesCompleted), value);
    }

    public int journalEntriesTotal
    {
        get => orig.GetInt(nameof(PlayerData.journalEntriesTotal));
        set => orig.SetInt(nameof(PlayerData.journalEntriesTotal), value);
    }

    public bool killedCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedCrawler));
        set => orig.SetBool(nameof(PlayerData.killedCrawler), value);
    }

    public int killsCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsCrawler));
        set => orig.SetInt(nameof(PlayerData.killsCrawler), value);
    }

    public bool newDataCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataCrawler), value);
    }

    public bool killedBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.killedBuzzer));
        set => orig.SetBool(nameof(PlayerData.killedBuzzer), value);
    }

    public int killsBuzzer
    {
        get => orig.GetInt(nameof(PlayerData.killsBuzzer));
        set => orig.SetInt(nameof(PlayerData.killsBuzzer), value);
    }

    public bool newDataBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.newDataBuzzer));
        set => orig.SetBool(nameof(PlayerData.newDataBuzzer), value);
    }

    public bool killedBouncer
    {
        get => orig.GetBool(nameof(PlayerData.killedBouncer));
        set => orig.SetBool(nameof(PlayerData.killedBouncer), value);
    }

    public int killsBouncer
    {
        get => orig.GetInt(nameof(PlayerData.killsBouncer));
        set => orig.SetInt(nameof(PlayerData.killsBouncer), value);
    }

    public bool newDataBouncer
    {
        get => orig.GetBool(nameof(PlayerData.newDataBouncer));
        set => orig.SetBool(nameof(PlayerData.newDataBouncer), value);
    }

    public bool killedClimber
    {
        get => orig.GetBool(nameof(PlayerData.killedClimber));
        set => orig.SetBool(nameof(PlayerData.killedClimber), value);
    }

    public int killsClimber
    {
        get => orig.GetInt(nameof(PlayerData.killsClimber));
        set => orig.SetInt(nameof(PlayerData.killsClimber), value);
    }

    public bool newDataClimber
    {
        get => orig.GetBool(nameof(PlayerData.newDataClimber));
        set => orig.SetBool(nameof(PlayerData.newDataClimber), value);
    }

    public bool killedHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedHopper));
        set => orig.SetBool(nameof(PlayerData.killedHopper), value);
    }

    public int killsHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsHopper));
        set => orig.SetInt(nameof(PlayerData.killsHopper), value);
    }

    public bool newDataHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataHopper));
        set => orig.SetBool(nameof(PlayerData.newDataHopper), value);
    }

    public bool killedWorm
    {
        get => orig.GetBool(nameof(PlayerData.killedWorm));
        set => orig.SetBool(nameof(PlayerData.killedWorm), value);
    }

    public int killsWorm
    {
        get => orig.GetInt(nameof(PlayerData.killsWorm));
        set => orig.SetInt(nameof(PlayerData.killsWorm), value);
    }

    public bool newDataWorm
    {
        get => orig.GetBool(nameof(PlayerData.newDataWorm));
        set => orig.SetBool(nameof(PlayerData.newDataWorm), value);
    }

    public bool killedSpitter
    {
        get => orig.GetBool(nameof(PlayerData.killedSpitter));
        set => orig.SetBool(nameof(PlayerData.killedSpitter), value);
    }

    public int killsSpitter
    {
        get => orig.GetInt(nameof(PlayerData.killsSpitter));
        set => orig.SetInt(nameof(PlayerData.killsSpitter), value);
    }

    public bool newDataSpitter
    {
        get => orig.GetBool(nameof(PlayerData.newDataSpitter));
        set => orig.SetBool(nameof(PlayerData.newDataSpitter), value);
    }

    public bool killedHatcher
    {
        get => orig.GetBool(nameof(PlayerData.killedHatcher));
        set => orig.SetBool(nameof(PlayerData.killedHatcher), value);
    }

    public int killsHatcher
    {
        get => orig.GetInt(nameof(PlayerData.killsHatcher));
        set => orig.SetInt(nameof(PlayerData.killsHatcher), value);
    }

    public bool newDataHatcher
    {
        get => orig.GetBool(nameof(PlayerData.newDataHatcher));
        set => orig.SetBool(nameof(PlayerData.newDataHatcher), value);
    }

    public bool killedHatchling
    {
        get => orig.GetBool(nameof(PlayerData.killedHatchling));
        set => orig.SetBool(nameof(PlayerData.killedHatchling), value);
    }

    public int killsHatchling
    {
        get => orig.GetInt(nameof(PlayerData.killsHatchling));
        set => orig.SetInt(nameof(PlayerData.killsHatchling), value);
    }

    public bool newDataHatchling
    {
        get => orig.GetBool(nameof(PlayerData.newDataHatchling));
        set => orig.SetBool(nameof(PlayerData.newDataHatchling), value);
    }

    public bool killedZombieRunner
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieRunner));
        set => orig.SetBool(nameof(PlayerData.killedZombieRunner), value);
    }

    public int killsZombieRunner
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieRunner));
        set => orig.SetInt(nameof(PlayerData.killsZombieRunner), value);
    }

    public bool newDataZombieRunner
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieRunner));
        set => orig.SetBool(nameof(PlayerData.newDataZombieRunner), value);
    }

    public bool killedZombieHornhead
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieHornhead));
        set => orig.SetBool(nameof(PlayerData.killedZombieHornhead), value);
    }

    public int killsZombieHornhead
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieHornhead));
        set => orig.SetInt(nameof(PlayerData.killsZombieHornhead), value);
    }

    public bool newDataZombieHornhead
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieHornhead));
        set => orig.SetBool(nameof(PlayerData.newDataZombieHornhead), value);
    }

    public bool killedZombieLeaper
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieLeaper));
        set => orig.SetBool(nameof(PlayerData.killedZombieLeaper), value);
    }

    public int killsZombieLeaper
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieLeaper));
        set => orig.SetInt(nameof(PlayerData.killsZombieLeaper), value);
    }

    public bool newDataZombieLeaper
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieLeaper));
        set => orig.SetBool(nameof(PlayerData.newDataZombieLeaper), value);
    }

    public bool killedZombieBarger
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieBarger));
        set => orig.SetBool(nameof(PlayerData.killedZombieBarger), value);
    }

    public int killsZombieBarger
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieBarger));
        set => orig.SetInt(nameof(PlayerData.killsZombieBarger), value);
    }

    public bool newDataZombieBarger
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieBarger));
        set => orig.SetBool(nameof(PlayerData.newDataZombieBarger), value);
    }

    public bool killedZombieShield
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieShield));
        set => orig.SetBool(nameof(PlayerData.killedZombieShield), value);
    }

    public int killsZombieShield
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieShield));
        set => orig.SetInt(nameof(PlayerData.killsZombieShield), value);
    }

    public bool newDataZombieShield
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieShield));
        set => orig.SetBool(nameof(PlayerData.newDataZombieShield), value);
    }

    public bool killedZombieGuard
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieGuard));
        set => orig.SetBool(nameof(PlayerData.killedZombieGuard), value);
    }

    public int killsZombieGuard
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieGuard));
        set => orig.SetInt(nameof(PlayerData.killsZombieGuard), value);
    }

    public bool newDataZombieGuard
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieGuard));
        set => orig.SetBool(nameof(PlayerData.newDataZombieGuard), value);
    }

    public bool killedBigBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.killedBigBuzzer));
        set => orig.SetBool(nameof(PlayerData.killedBigBuzzer), value);
    }

    public int killsBigBuzzer
    {
        get => orig.GetInt(nameof(PlayerData.killsBigBuzzer));
        set => orig.SetInt(nameof(PlayerData.killsBigBuzzer), value);
    }

    public bool newDataBigBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.newDataBigBuzzer));
        set => orig.SetBool(nameof(PlayerData.newDataBigBuzzer), value);
    }

    public bool killedBigFly
    {
        get => orig.GetBool(nameof(PlayerData.killedBigFly));
        set => orig.SetBool(nameof(PlayerData.killedBigFly), value);
    }

    public int killsBigFly
    {
        get => orig.GetInt(nameof(PlayerData.killsBigFly));
        set => orig.SetInt(nameof(PlayerData.killsBigFly), value);
    }

    public bool newDataBigFly
    {
        get => orig.GetBool(nameof(PlayerData.newDataBigFly));
        set => orig.SetBool(nameof(PlayerData.newDataBigFly), value);
    }

    public bool killedMawlek
    {
        get => orig.GetBool(nameof(PlayerData.killedMawlek));
        set => orig.SetBool(nameof(PlayerData.killedMawlek), value);
    }

    public int killsMawlek
    {
        get => orig.GetInt(nameof(PlayerData.killsMawlek));
        set => orig.SetInt(nameof(PlayerData.killsMawlek), value);
    }

    public bool newDataMawlek
    {
        get => orig.GetBool(nameof(PlayerData.newDataMawlek));
        set => orig.SetBool(nameof(PlayerData.newDataMawlek), value);
    }

    public bool killedFalseKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedFalseKnight));
        set => orig.SetBool(nameof(PlayerData.killedFalseKnight), value);
    }

    public int killsFalseKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsFalseKnight));
        set => orig.SetInt(nameof(PlayerData.killsFalseKnight), value);
    }

    public bool newDataFalseKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataFalseKnight));
        set => orig.SetBool(nameof(PlayerData.newDataFalseKnight), value);
    }

    public bool killedRoller
    {
        get => orig.GetBool(nameof(PlayerData.killedRoller));
        set => orig.SetBool(nameof(PlayerData.killedRoller), value);
    }

    public int killsRoller
    {
        get => orig.GetInt(nameof(PlayerData.killsRoller));
        set => orig.SetInt(nameof(PlayerData.killsRoller), value);
    }

    public bool newDataRoller
    {
        get => orig.GetBool(nameof(PlayerData.newDataRoller));
        set => orig.SetBool(nameof(PlayerData.newDataRoller), value);
    }

    public bool killedBlocker
    {
        get => orig.GetBool(nameof(PlayerData.killedBlocker));
        set => orig.SetBool(nameof(PlayerData.killedBlocker), value);
    }

    public int killsBlocker
    {
        get => orig.GetInt(nameof(PlayerData.killsBlocker));
        set => orig.SetInt(nameof(PlayerData.killsBlocker), value);
    }

    public bool newDataBlocker
    {
        get => orig.GetBool(nameof(PlayerData.newDataBlocker));
        set => orig.SetBool(nameof(PlayerData.newDataBlocker), value);
    }

    public bool killedPrayerSlug
    {
        get => orig.GetBool(nameof(PlayerData.killedPrayerSlug));
        set => orig.SetBool(nameof(PlayerData.killedPrayerSlug), value);
    }

    public int killsPrayerSlug
    {
        get => orig.GetInt(nameof(PlayerData.killsPrayerSlug));
        set => orig.SetInt(nameof(PlayerData.killsPrayerSlug), value);
    }

    public bool newDataPrayerSlug
    {
        get => orig.GetBool(nameof(PlayerData.newDataPrayerSlug));
        set => orig.SetBool(nameof(PlayerData.newDataPrayerSlug), value);
    }

    public bool killedMenderBug
    {
        get => orig.GetBool(nameof(PlayerData.killedMenderBug));
        set => orig.SetBool(nameof(PlayerData.killedMenderBug), value);
    }

    public int killsMenderBug
    {
        get => orig.GetInt(nameof(PlayerData.killsMenderBug));
        set => orig.SetInt(nameof(PlayerData.killsMenderBug), value);
    }

    public bool newDataMenderBug
    {
        get => orig.GetBool(nameof(PlayerData.newDataMenderBug));
        set => orig.SetBool(nameof(PlayerData.newDataMenderBug), value);
    }

    public bool killedMossmanRunner
    {
        get => orig.GetBool(nameof(PlayerData.killedMossmanRunner));
        set => orig.SetBool(nameof(PlayerData.killedMossmanRunner), value);
    }

    public int killsMossmanRunner
    {
        get => orig.GetInt(nameof(PlayerData.killsMossmanRunner));
        set => orig.SetInt(nameof(PlayerData.killsMossmanRunner), value);
    }

    public bool newDataMossmanRunner
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossmanRunner));
        set => orig.SetBool(nameof(PlayerData.newDataMossmanRunner), value);
    }

    public bool killedMossmanShaker
    {
        get => orig.GetBool(nameof(PlayerData.killedMossmanShaker));
        set => orig.SetBool(nameof(PlayerData.killedMossmanShaker), value);
    }

    public int killsMossmanShaker
    {
        get => orig.GetInt(nameof(PlayerData.killsMossmanShaker));
        set => orig.SetInt(nameof(PlayerData.killsMossmanShaker), value);
    }

    public bool newDataMossmanShaker
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossmanShaker));
        set => orig.SetBool(nameof(PlayerData.newDataMossmanShaker), value);
    }

    public bool killedMosquito
    {
        get => orig.GetBool(nameof(PlayerData.killedMosquito));
        set => orig.SetBool(nameof(PlayerData.killedMosquito), value);
    }

    public int killsMosquito
    {
        get => orig.GetInt(nameof(PlayerData.killsMosquito));
        set => orig.SetInt(nameof(PlayerData.killsMosquito), value);
    }

    public bool newDataMosquito
    {
        get => orig.GetBool(nameof(PlayerData.newDataMosquito));
        set => orig.SetBool(nameof(PlayerData.newDataMosquito), value);
    }

    public bool killedBlobFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedBlobFlyer));
        set => orig.SetBool(nameof(PlayerData.killedBlobFlyer), value);
    }

    public int killsBlobFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsBlobFlyer));
        set => orig.SetInt(nameof(PlayerData.killsBlobFlyer), value);
    }

    public bool newDataBlobFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataBlobFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataBlobFlyer), value);
    }

    public bool killedFungifiedZombie
    {
        get => orig.GetBool(nameof(PlayerData.killedFungifiedZombie));
        set => orig.SetBool(nameof(PlayerData.killedFungifiedZombie), value);
    }

    public int killsFungifiedZombie
    {
        get => orig.GetInt(nameof(PlayerData.killsFungifiedZombie));
        set => orig.SetInt(nameof(PlayerData.killsFungifiedZombie), value);
    }

    public bool newDataFungifiedZombie
    {
        get => orig.GetBool(nameof(PlayerData.newDataFungifiedZombie));
        set => orig.SetBool(nameof(PlayerData.newDataFungifiedZombie), value);
    }

    public bool killedPlantShooter
    {
        get => orig.GetBool(nameof(PlayerData.killedPlantShooter));
        set => orig.SetBool(nameof(PlayerData.killedPlantShooter), value);
    }

    public int killsPlantShooter
    {
        get => orig.GetInt(nameof(PlayerData.killsPlantShooter));
        set => orig.SetInt(nameof(PlayerData.killsPlantShooter), value);
    }

    public bool newDataPlantShooter
    {
        get => orig.GetBool(nameof(PlayerData.newDataPlantShooter));
        set => orig.SetBool(nameof(PlayerData.newDataPlantShooter), value);
    }

    public bool killedMossCharger
    {
        get => orig.GetBool(nameof(PlayerData.killedMossCharger));
        set => orig.SetBool(nameof(PlayerData.killedMossCharger), value);
    }

    public int killsMossCharger
    {
        get => orig.GetInt(nameof(PlayerData.killsMossCharger));
        set => orig.SetInt(nameof(PlayerData.killsMossCharger), value);
    }

    public bool newDataMossCharger
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossCharger));
        set => orig.SetBool(nameof(PlayerData.newDataMossCharger), value);
    }

    public bool killedMegaMossCharger
    {
        get => orig.GetBool(nameof(PlayerData.killedMegaMossCharger));
        set => orig.SetBool(nameof(PlayerData.killedMegaMossCharger), value);
    }

    public int killsMegaMossCharger
    {
        get => orig.GetInt(nameof(PlayerData.killsMegaMossCharger));
        set => orig.SetInt(nameof(PlayerData.killsMegaMossCharger), value);
    }

    public bool newDataMegaMossCharger
    {
        get => orig.GetBool(nameof(PlayerData.newDataMegaMossCharger));
        set => orig.SetBool(nameof(PlayerData.newDataMegaMossCharger), value);
    }

    public bool killedSnapperTrap
    {
        get => orig.GetBool(nameof(PlayerData.killedSnapperTrap));
        set => orig.SetBool(nameof(PlayerData.killedSnapperTrap), value);
    }

    public int killsSnapperTrap
    {
        get => orig.GetInt(nameof(PlayerData.killsSnapperTrap));
        set => orig.SetInt(nameof(PlayerData.killsSnapperTrap), value);
    }

    public bool newDataSnapperTrap
    {
        get => orig.GetBool(nameof(PlayerData.newDataSnapperTrap));
        set => orig.SetBool(nameof(PlayerData.newDataSnapperTrap), value);
    }

    public bool killedMossKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedMossKnight));
        set => orig.SetBool(nameof(PlayerData.killedMossKnight), value);
    }

    public int killsMossKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsMossKnight));
        set => orig.SetInt(nameof(PlayerData.killsMossKnight), value);
    }

    public bool newDataMossKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossKnight));
        set => orig.SetBool(nameof(PlayerData.newDataMossKnight), value);
    }

    public bool killedGrassHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedGrassHopper));
        set => orig.SetBool(nameof(PlayerData.killedGrassHopper), value);
    }

    public int killsGrassHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsGrassHopper));
        set => orig.SetInt(nameof(PlayerData.killsGrassHopper), value);
    }

    public bool newDataGrassHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataGrassHopper));
        set => orig.SetBool(nameof(PlayerData.newDataGrassHopper), value);
    }

    public bool killedAcidFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedAcidFlyer));
        set => orig.SetBool(nameof(PlayerData.killedAcidFlyer), value);
    }

    public int killsAcidFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsAcidFlyer));
        set => orig.SetInt(nameof(PlayerData.killsAcidFlyer), value);
    }

    public bool newDataAcidFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataAcidFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataAcidFlyer), value);
    }

    public bool killedAcidWalker
    {
        get => orig.GetBool(nameof(PlayerData.killedAcidWalker));
        set => orig.SetBool(nameof(PlayerData.killedAcidWalker), value);
    }

    public int killsAcidWalker
    {
        get => orig.GetInt(nameof(PlayerData.killsAcidWalker));
        set => orig.SetInt(nameof(PlayerData.killsAcidWalker), value);
    }

    public bool newDataAcidWalker
    {
        get => orig.GetBool(nameof(PlayerData.newDataAcidWalker));
        set => orig.SetBool(nameof(PlayerData.newDataAcidWalker), value);
    }

    public bool killedMossFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedMossFlyer));
        set => orig.SetBool(nameof(PlayerData.killedMossFlyer), value);
    }

    public int killsMossFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsMossFlyer));
        set => orig.SetInt(nameof(PlayerData.killsMossFlyer), value);
    }

    public bool newDataMossFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataMossFlyer), value);
    }

    public bool killedMossKnightFat
    {
        get => orig.GetBool(nameof(PlayerData.killedMossKnightFat));
        set => orig.SetBool(nameof(PlayerData.killedMossKnightFat), value);
    }

    public int killsMossKnightFat
    {
        get => orig.GetInt(nameof(PlayerData.killsMossKnightFat));
        set => orig.SetInt(nameof(PlayerData.killsMossKnightFat), value);
    }

    public bool newDataMossKnightFat
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossKnightFat));
        set => orig.SetBool(nameof(PlayerData.newDataMossKnightFat), value);
    }

    public bool killedMossWalker
    {
        get => orig.GetBool(nameof(PlayerData.killedMossWalker));
        set => orig.SetBool(nameof(PlayerData.killedMossWalker), value);
    }

    public int killsMossWalker
    {
        get => orig.GetInt(nameof(PlayerData.killsMossWalker));
        set => orig.SetInt(nameof(PlayerData.killsMossWalker), value);
    }

    public bool newDataMossWalker
    {
        get => orig.GetBool(nameof(PlayerData.newDataMossWalker));
        set => orig.SetBool(nameof(PlayerData.newDataMossWalker), value);
    }

    public bool killedInfectedKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedInfectedKnight));
        set => orig.SetBool(nameof(PlayerData.killedInfectedKnight), value);
    }

    public int killsInfectedKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsInfectedKnight));
        set => orig.SetInt(nameof(PlayerData.killsInfectedKnight), value);
    }

    public bool newDataInfectedKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataInfectedKnight));
        set => orig.SetBool(nameof(PlayerData.newDataInfectedKnight), value);
    }

    public bool killedLazyFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedLazyFlyer));
        set => orig.SetBool(nameof(PlayerData.killedLazyFlyer), value);
    }

    public int killsLazyFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsLazyFlyer));
        set => orig.SetInt(nameof(PlayerData.killsLazyFlyer), value);
    }

    public bool newDataLazyFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataLazyFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataLazyFlyer), value);
    }

    public bool killedZapBug
    {
        get => orig.GetBool(nameof(PlayerData.killedZapBug));
        set => orig.SetBool(nameof(PlayerData.killedZapBug), value);
    }

    public int killsZapBug
    {
        get => orig.GetInt(nameof(PlayerData.killsZapBug));
        set => orig.SetInt(nameof(PlayerData.killsZapBug), value);
    }

    public bool newDataZapBug
    {
        get => orig.GetBool(nameof(PlayerData.newDataZapBug));
        set => orig.SetBool(nameof(PlayerData.newDataZapBug), value);
    }

    public bool killedJellyfish
    {
        get => orig.GetBool(nameof(PlayerData.killedJellyfish));
        set => orig.SetBool(nameof(PlayerData.killedJellyfish), value);
    }

    public int killsJellyfish
    {
        get => orig.GetInt(nameof(PlayerData.killsJellyfish));
        set => orig.SetInt(nameof(PlayerData.killsJellyfish), value);
    }

    public bool newDataJellyfish
    {
        get => orig.GetBool(nameof(PlayerData.newDataJellyfish));
        set => orig.SetBool(nameof(PlayerData.newDataJellyfish), value);
    }

    public bool killedJellyCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedJellyCrawler));
        set => orig.SetBool(nameof(PlayerData.killedJellyCrawler), value);
    }

    public int killsJellyCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsJellyCrawler));
        set => orig.SetInt(nameof(PlayerData.killsJellyCrawler), value);
    }

    public bool newDataJellyCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataJellyCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataJellyCrawler), value);
    }

    public bool killedMegaJellyfish
    {
        get => orig.GetBool(nameof(PlayerData.killedMegaJellyfish));
        set => orig.SetBool(nameof(PlayerData.killedMegaJellyfish), value);
    }

    public int killsMegaJellyfish
    {
        get => orig.GetInt(nameof(PlayerData.killsMegaJellyfish));
        set => orig.SetInt(nameof(PlayerData.killsMegaJellyfish), value);
    }

    public bool newDataMegaJellyfish
    {
        get => orig.GetBool(nameof(PlayerData.newDataMegaJellyfish));
        set => orig.SetBool(nameof(PlayerData.newDataMegaJellyfish), value);
    }

    public bool killedFungoonBaby
    {
        get => orig.GetBool(nameof(PlayerData.killedFungoonBaby));
        set => orig.SetBool(nameof(PlayerData.killedFungoonBaby), value);
    }

    public int killsFungoonBaby
    {
        get => orig.GetInt(nameof(PlayerData.killsFungoonBaby));
        set => orig.SetInt(nameof(PlayerData.killsFungoonBaby), value);
    }

    public bool newDataFungoonBaby
    {
        get => orig.GetBool(nameof(PlayerData.newDataFungoonBaby));
        set => orig.SetBool(nameof(PlayerData.newDataFungoonBaby), value);
    }

    public bool killedMushroomTurret
    {
        get => orig.GetBool(nameof(PlayerData.killedMushroomTurret));
        set => orig.SetBool(nameof(PlayerData.killedMushroomTurret), value);
    }

    public int killsMushroomTurret
    {
        get => orig.GetInt(nameof(PlayerData.killsMushroomTurret));
        set => orig.SetInt(nameof(PlayerData.killsMushroomTurret), value);
    }

    public bool newDataMushroomTurret
    {
        get => orig.GetBool(nameof(PlayerData.newDataMushroomTurret));
        set => orig.SetBool(nameof(PlayerData.newDataMushroomTurret), value);
    }

    public bool killedMantis
    {
        get => orig.GetBool(nameof(PlayerData.killedMantis));
        set => orig.SetBool(nameof(PlayerData.killedMantis), value);
    }

    public int killsMantis
    {
        get => orig.GetInt(nameof(PlayerData.killsMantis));
        set => orig.SetInt(nameof(PlayerData.killsMantis), value);
    }

    public bool newDataMantis
    {
        get => orig.GetBool(nameof(PlayerData.newDataMantis));
        set => orig.SetBool(nameof(PlayerData.newDataMantis), value);
    }

    public bool killedMushroomRoller
    {
        get => orig.GetBool(nameof(PlayerData.killedMushroomRoller));
        set => orig.SetBool(nameof(PlayerData.killedMushroomRoller), value);
    }

    public int killsMushroomRoller
    {
        get => orig.GetInt(nameof(PlayerData.killsMushroomRoller));
        set => orig.SetInt(nameof(PlayerData.killsMushroomRoller), value);
    }

    public bool newDataMushroomRoller
    {
        get => orig.GetBool(nameof(PlayerData.newDataMushroomRoller));
        set => orig.SetBool(nameof(PlayerData.newDataMushroomRoller), value);
    }

    public bool killedMushroomBrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedMushroomBrawler));
        set => orig.SetBool(nameof(PlayerData.killedMushroomBrawler), value);
    }

    public int killsMushroomBrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsMushroomBrawler));
        set => orig.SetInt(nameof(PlayerData.killsMushroomBrawler), value);
    }

    public bool newDataMushroomBrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataMushroomBrawler));
        set => orig.SetBool(nameof(PlayerData.newDataMushroomBrawler), value);
    }

    public bool killedMushroomBaby
    {
        get => orig.GetBool(nameof(PlayerData.killedMushroomBaby));
        set => orig.SetBool(nameof(PlayerData.killedMushroomBaby), value);
    }

    public int killsMushroomBaby
    {
        get => orig.GetInt(nameof(PlayerData.killsMushroomBaby));
        set => orig.SetInt(nameof(PlayerData.killsMushroomBaby), value);
    }

    public bool newDataMushroomBaby
    {
        get => orig.GetBool(nameof(PlayerData.newDataMushroomBaby));
        set => orig.SetBool(nameof(PlayerData.newDataMushroomBaby), value);
    }

    public bool killedMantisFlyerChild
    {
        get => orig.GetBool(nameof(PlayerData.killedMantisFlyerChild));
        set => orig.SetBool(nameof(PlayerData.killedMantisFlyerChild), value);
    }

    public int killsMantisFlyerChild
    {
        get => orig.GetInt(nameof(PlayerData.killsMantisFlyerChild));
        set => orig.SetInt(nameof(PlayerData.killsMantisFlyerChild), value);
    }

    public bool newDataMantisFlyerChild
    {
        get => orig.GetBool(nameof(PlayerData.newDataMantisFlyerChild));
        set => orig.SetBool(nameof(PlayerData.newDataMantisFlyerChild), value);
    }

    public bool killedFungusFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedFungusFlyer));
        set => orig.SetBool(nameof(PlayerData.killedFungusFlyer), value);
    }

    public int killsFungusFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsFungusFlyer));
        set => orig.SetInt(nameof(PlayerData.killsFungusFlyer), value);
    }

    public bool newDataFungusFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataFungusFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataFungusFlyer), value);
    }

    public bool killedFungCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedFungCrawler));
        set => orig.SetBool(nameof(PlayerData.killedFungCrawler), value);
    }

    public int killsFungCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsFungCrawler));
        set => orig.SetInt(nameof(PlayerData.killsFungCrawler), value);
    }

    public bool newDataFungCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataFungCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataFungCrawler), value);
    }

    public bool killedMantisLord
    {
        get => orig.GetBool(nameof(PlayerData.killedMantisLord));
        set => orig.SetBool(nameof(PlayerData.killedMantisLord), value);
    }

    public int killsMantisLord
    {
        get => orig.GetInt(nameof(PlayerData.killsMantisLord));
        set => orig.SetInt(nameof(PlayerData.killsMantisLord), value);
    }

    public bool newDataMantisLord
    {
        get => orig.GetBool(nameof(PlayerData.newDataMantisLord));
        set => orig.SetBool(nameof(PlayerData.newDataMantisLord), value);
    }

    public bool killedBlackKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedBlackKnight));
        set => orig.SetBool(nameof(PlayerData.killedBlackKnight), value);
    }

    public int killsBlackKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsBlackKnight));
        set => orig.SetInt(nameof(PlayerData.killsBlackKnight), value);
    }

    public bool newDataBlackKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataBlackKnight));
        set => orig.SetBool(nameof(PlayerData.newDataBlackKnight), value);
    }

    public bool killedElectricMage
    {
        get => orig.GetBool(nameof(PlayerData.killedElectricMage));
        set => orig.SetBool(nameof(PlayerData.killedElectricMage), value);
    }

    public int killsElectricMage
    {
        get => orig.GetInt(nameof(PlayerData.killsElectricMage));
        set => orig.SetInt(nameof(PlayerData.killsElectricMage), value);
    }

    public bool newDataElectricMage
    {
        get => orig.GetBool(nameof(PlayerData.newDataElectricMage));
        set => orig.SetBool(nameof(PlayerData.newDataElectricMage), value);
    }

    public bool killedMage
    {
        get => orig.GetBool(nameof(PlayerData.killedMage));
        set => orig.SetBool(nameof(PlayerData.killedMage), value);
    }

    public int killsMage
    {
        get => orig.GetInt(nameof(PlayerData.killsMage));
        set => orig.SetInt(nameof(PlayerData.killsMage), value);
    }

    public bool newDataMage
    {
        get => orig.GetBool(nameof(PlayerData.newDataMage));
        set => orig.SetBool(nameof(PlayerData.newDataMage), value);
    }

    public bool killedMageKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedMageKnight));
        set => orig.SetBool(nameof(PlayerData.killedMageKnight), value);
    }

    public int killsMageKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsMageKnight));
        set => orig.SetInt(nameof(PlayerData.killsMageKnight), value);
    }

    public bool newDataMageKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataMageKnight));
        set => orig.SetBool(nameof(PlayerData.newDataMageKnight), value);
    }

    public bool killedRoyalDandy
    {
        get => orig.GetBool(nameof(PlayerData.killedRoyalDandy));
        set => orig.SetBool(nameof(PlayerData.killedRoyalDandy), value);
    }

    public int killsRoyalDandy
    {
        get => orig.GetInt(nameof(PlayerData.killsRoyalDandy));
        set => orig.SetInt(nameof(PlayerData.killsRoyalDandy), value);
    }

    public bool newDataRoyalDandy
    {
        get => orig.GetBool(nameof(PlayerData.newDataRoyalDandy));
        set => orig.SetBool(nameof(PlayerData.newDataRoyalDandy), value);
    }

    public bool killedRoyalCoward
    {
        get => orig.GetBool(nameof(PlayerData.killedRoyalCoward));
        set => orig.SetBool(nameof(PlayerData.killedRoyalCoward), value);
    }

    public int killsRoyalCoward
    {
        get => orig.GetInt(nameof(PlayerData.killsRoyalCoward));
        set => orig.SetInt(nameof(PlayerData.killsRoyalCoward), value);
    }

    public bool newDataRoyalCoward
    {
        get => orig.GetBool(nameof(PlayerData.newDataRoyalCoward));
        set => orig.SetBool(nameof(PlayerData.newDataRoyalCoward), value);
    }

    public bool killedRoyalPlumper
    {
        get => orig.GetBool(nameof(PlayerData.killedRoyalPlumper));
        set => orig.SetBool(nameof(PlayerData.killedRoyalPlumper), value);
    }

    public int killsRoyalPlumper
    {
        get => orig.GetInt(nameof(PlayerData.killsRoyalPlumper));
        set => orig.SetInt(nameof(PlayerData.killsRoyalPlumper), value);
    }

    public bool newDataRoyalPlumper
    {
        get => orig.GetBool(nameof(PlayerData.newDataRoyalPlumper));
        set => orig.SetBool(nameof(PlayerData.newDataRoyalPlumper), value);
    }

    public bool killedFlyingSentrySword
    {
        get => orig.GetBool(nameof(PlayerData.killedFlyingSentrySword));
        set => orig.SetBool(nameof(PlayerData.killedFlyingSentrySword), value);
    }

    public int killsFlyingSentrySword
    {
        get => orig.GetInt(nameof(PlayerData.killsFlyingSentrySword));
        set => orig.SetInt(nameof(PlayerData.killsFlyingSentrySword), value);
    }

    public bool newDataFlyingSentrySword
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlyingSentrySword));
        set => orig.SetBool(nameof(PlayerData.newDataFlyingSentrySword), value);
    }

    public bool killedFlyingSentryJavelin
    {
        get => orig.GetBool(nameof(PlayerData.killedFlyingSentryJavelin));
        set => orig.SetBool(nameof(PlayerData.killedFlyingSentryJavelin), value);
    }

    public int killsFlyingSentryJavelin
    {
        get => orig.GetInt(nameof(PlayerData.killsFlyingSentryJavelin));
        set => orig.SetInt(nameof(PlayerData.killsFlyingSentryJavelin), value);
    }

    public bool newDataFlyingSentryJavelin
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlyingSentryJavelin));
        set => orig.SetBool(nameof(PlayerData.newDataFlyingSentryJavelin), value);
    }

    public bool killedSentry
    {
        get => orig.GetBool(nameof(PlayerData.killedSentry));
        set => orig.SetBool(nameof(PlayerData.killedSentry), value);
    }

    public int killsSentry
    {
        get => orig.GetInt(nameof(PlayerData.killsSentry));
        set => orig.SetInt(nameof(PlayerData.killsSentry), value);
    }

    public bool newDataSentry
    {
        get => orig.GetBool(nameof(PlayerData.newDataSentry));
        set => orig.SetBool(nameof(PlayerData.newDataSentry), value);
    }

    public bool killedSentryFat
    {
        get => orig.GetBool(nameof(PlayerData.killedSentryFat));
        set => orig.SetBool(nameof(PlayerData.killedSentryFat), value);
    }

    public int killsSentryFat
    {
        get => orig.GetInt(nameof(PlayerData.killsSentryFat));
        set => orig.SetInt(nameof(PlayerData.killsSentryFat), value);
    }

    public bool newDataSentryFat
    {
        get => orig.GetBool(nameof(PlayerData.newDataSentryFat));
        set => orig.SetBool(nameof(PlayerData.newDataSentryFat), value);
    }

    public bool killedMageBlob
    {
        get => orig.GetBool(nameof(PlayerData.killedMageBlob));
        set => orig.SetBool(nameof(PlayerData.killedMageBlob), value);
    }

    public int killsMageBlob
    {
        get => orig.GetInt(nameof(PlayerData.killsMageBlob));
        set => orig.SetInt(nameof(PlayerData.killsMageBlob), value);
    }

    public bool newDataMageBlob
    {
        get => orig.GetBool(nameof(PlayerData.newDataMageBlob));
        set => orig.SetBool(nameof(PlayerData.newDataMageBlob), value);
    }

    public bool killedGreatShieldZombie
    {
        get => orig.GetBool(nameof(PlayerData.killedGreatShieldZombie));
        set => orig.SetBool(nameof(PlayerData.killedGreatShieldZombie), value);
    }

    public int killsGreatShieldZombie
    {
        get => orig.GetInt(nameof(PlayerData.killsGreatShieldZombie));
        set => orig.SetInt(nameof(PlayerData.killsGreatShieldZombie), value);
    }

    public bool newDataGreatShieldZombie
    {
        get => orig.GetBool(nameof(PlayerData.newDataGreatShieldZombie));
        set => orig.SetBool(nameof(PlayerData.newDataGreatShieldZombie), value);
    }

    public bool killedJarCollector
    {
        get => orig.GetBool(nameof(PlayerData.killedJarCollector));
        set => orig.SetBool(nameof(PlayerData.killedJarCollector), value);
    }

    public int killsJarCollector
    {
        get => orig.GetInt(nameof(PlayerData.killsJarCollector));
        set => orig.SetInt(nameof(PlayerData.killsJarCollector), value);
    }

    public bool newDataJarCollector
    {
        get => orig.GetBool(nameof(PlayerData.newDataJarCollector));
        set => orig.SetBool(nameof(PlayerData.newDataJarCollector), value);
    }

    public bool killedMageBalloon
    {
        get => orig.GetBool(nameof(PlayerData.killedMageBalloon));
        set => orig.SetBool(nameof(PlayerData.killedMageBalloon), value);
    }

    public int killsMageBalloon
    {
        get => orig.GetInt(nameof(PlayerData.killsMageBalloon));
        set => orig.SetInt(nameof(PlayerData.killsMageBalloon), value);
    }

    public bool newDataMageBalloon
    {
        get => orig.GetBool(nameof(PlayerData.newDataMageBalloon));
        set => orig.SetBool(nameof(PlayerData.newDataMageBalloon), value);
    }

    public bool killedMageLord
    {
        get => orig.GetBool(nameof(PlayerData.killedMageLord));
        set => orig.SetBool(nameof(PlayerData.killedMageLord), value);
    }

    public int killsMageLord
    {
        get => orig.GetInt(nameof(PlayerData.killsMageLord));
        set => orig.SetInt(nameof(PlayerData.killsMageLord), value);
    }

    public bool newDataMageLord
    {
        get => orig.GetBool(nameof(PlayerData.newDataMageLord));
        set => orig.SetBool(nameof(PlayerData.newDataMageLord), value);
    }

    public bool killedGorgeousHusk
    {
        get => orig.GetBool(nameof(PlayerData.killedGorgeousHusk));
        set => orig.SetBool(nameof(PlayerData.killedGorgeousHusk), value);
    }

    public int killsGorgeousHusk
    {
        get => orig.GetInt(nameof(PlayerData.killsGorgeousHusk));
        set => orig.SetInt(nameof(PlayerData.killsGorgeousHusk), value);
    }

    public bool newDataGorgeousHusk
    {
        get => orig.GetBool(nameof(PlayerData.newDataGorgeousHusk));
        set => orig.SetBool(nameof(PlayerData.newDataGorgeousHusk), value);
    }

    public bool killedFlipHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedFlipHopper));
        set => orig.SetBool(nameof(PlayerData.killedFlipHopper), value);
    }

    public int killsFlipHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsFlipHopper));
        set => orig.SetInt(nameof(PlayerData.killsFlipHopper), value);
    }

    public bool newDataFlipHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlipHopper));
        set => orig.SetBool(nameof(PlayerData.newDataFlipHopper), value);
    }

    public bool killedFlukeman
    {
        get => orig.GetBool(nameof(PlayerData.killedFlukeman));
        set => orig.SetBool(nameof(PlayerData.killedFlukeman), value);
    }

    public int killsFlukeman
    {
        get => orig.GetInt(nameof(PlayerData.killsFlukeman));
        set => orig.SetInt(nameof(PlayerData.killsFlukeman), value);
    }

    public bool newDataFlukeman
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlukeman));
        set => orig.SetBool(nameof(PlayerData.newDataFlukeman), value);
    }

    public bool killedInflater
    {
        get => orig.GetBool(nameof(PlayerData.killedInflater));
        set => orig.SetBool(nameof(PlayerData.killedInflater), value);
    }

    public int killsInflater
    {
        get => orig.GetInt(nameof(PlayerData.killsInflater));
        set => orig.SetInt(nameof(PlayerData.killsInflater), value);
    }

    public bool newDataInflater
    {
        get => orig.GetBool(nameof(PlayerData.newDataInflater));
        set => orig.SetBool(nameof(PlayerData.newDataInflater), value);
    }

    public bool killedFlukefly
    {
        get => orig.GetBool(nameof(PlayerData.killedFlukefly));
        set => orig.SetBool(nameof(PlayerData.killedFlukefly), value);
    }

    public int killsFlukefly
    {
        get => orig.GetInt(nameof(PlayerData.killsFlukefly));
        set => orig.SetInt(nameof(PlayerData.killsFlukefly), value);
    }

    public bool newDataFlukefly
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlukefly));
        set => orig.SetBool(nameof(PlayerData.newDataFlukefly), value);
    }

    public bool killedFlukeMother
    {
        get => orig.GetBool(nameof(PlayerData.killedFlukeMother));
        set => orig.SetBool(nameof(PlayerData.killedFlukeMother), value);
    }

    public int killsFlukeMother
    {
        get => orig.GetInt(nameof(PlayerData.killsFlukeMother));
        set => orig.SetInt(nameof(PlayerData.killsFlukeMother), value);
    }

    public bool newDataFlukeMother
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlukeMother));
        set => orig.SetBool(nameof(PlayerData.newDataFlukeMother), value);
    }

    public bool killedDungDefender
    {
        get => orig.GetBool(nameof(PlayerData.killedDungDefender));
        set => orig.SetBool(nameof(PlayerData.killedDungDefender), value);
    }

    public int killsDungDefender
    {
        get => orig.GetInt(nameof(PlayerData.killsDungDefender));
        set => orig.SetInt(nameof(PlayerData.killsDungDefender), value);
    }

    public bool newDataDungDefender
    {
        get => orig.GetBool(nameof(PlayerData.newDataDungDefender));
        set => orig.SetBool(nameof(PlayerData.newDataDungDefender), value);
    }

    public bool killedCrystalCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedCrystalCrawler));
        set => orig.SetBool(nameof(PlayerData.killedCrystalCrawler), value);
    }

    public int killsCrystalCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsCrystalCrawler));
        set => orig.SetInt(nameof(PlayerData.killsCrystalCrawler), value);
    }

    public bool newDataCrystalCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataCrystalCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataCrystalCrawler), value);
    }

    public bool killedCrystalFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedCrystalFlyer));
        set => orig.SetBool(nameof(PlayerData.killedCrystalFlyer), value);
    }

    public int killsCrystalFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsCrystalFlyer));
        set => orig.SetInt(nameof(PlayerData.killsCrystalFlyer), value);
    }

    public bool newDataCrystalFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataCrystalFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataCrystalFlyer), value);
    }

    public bool killedLaserBug
    {
        get => orig.GetBool(nameof(PlayerData.killedLaserBug));
        set => orig.SetBool(nameof(PlayerData.killedLaserBug), value);
    }

    public int killsLaserBug
    {
        get => orig.GetInt(nameof(PlayerData.killsLaserBug));
        set => orig.SetInt(nameof(PlayerData.killsLaserBug), value);
    }

    public bool newDataLaserBug
    {
        get => orig.GetBool(nameof(PlayerData.newDataLaserBug));
        set => orig.SetBool(nameof(PlayerData.newDataLaserBug), value);
    }

    public bool killedBeamMiner
    {
        get => orig.GetBool(nameof(PlayerData.killedBeamMiner));
        set => orig.SetBool(nameof(PlayerData.killedBeamMiner), value);
    }

    public int killsBeamMiner
    {
        get => orig.GetInt(nameof(PlayerData.killsBeamMiner));
        set => orig.SetInt(nameof(PlayerData.killsBeamMiner), value);
    }

    public bool newDataBeamMiner
    {
        get => orig.GetBool(nameof(PlayerData.newDataBeamMiner));
        set => orig.SetBool(nameof(PlayerData.newDataBeamMiner), value);
    }

    public bool killedZombieMiner
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieMiner));
        set => orig.SetBool(nameof(PlayerData.killedZombieMiner), value);
    }

    public int killsZombieMiner
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieMiner));
        set => orig.SetInt(nameof(PlayerData.killsZombieMiner), value);
    }

    public bool newDataZombieMiner
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieMiner));
        set => orig.SetBool(nameof(PlayerData.newDataZombieMiner), value);
    }

    public bool killedMegaBeamMiner
    {
        get => orig.GetBool(nameof(PlayerData.killedMegaBeamMiner));
        set => orig.SetBool(nameof(PlayerData.killedMegaBeamMiner), value);
    }

    public int killsMegaBeamMiner
    {
        get => orig.GetInt(nameof(PlayerData.killsMegaBeamMiner));
        set => orig.SetInt(nameof(PlayerData.killsMegaBeamMiner), value);
    }

    public bool newDataMegaBeamMiner
    {
        get => orig.GetBool(nameof(PlayerData.newDataMegaBeamMiner));
        set => orig.SetBool(nameof(PlayerData.newDataMegaBeamMiner), value);
    }

    public bool killedMinesCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedMinesCrawler));
        set => orig.SetBool(nameof(PlayerData.killedMinesCrawler), value);
    }

    public int killsMinesCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsMinesCrawler));
        set => orig.SetInt(nameof(PlayerData.killsMinesCrawler), value);
    }

    public bool newDataMinesCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataMinesCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataMinesCrawler), value);
    }

    public bool killedAngryBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.killedAngryBuzzer));
        set => orig.SetBool(nameof(PlayerData.killedAngryBuzzer), value);
    }

    public int killsAngryBuzzer
    {
        get => orig.GetInt(nameof(PlayerData.killsAngryBuzzer));
        set => orig.SetInt(nameof(PlayerData.killsAngryBuzzer), value);
    }

    public bool newDataAngryBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.newDataAngryBuzzer));
        set => orig.SetBool(nameof(PlayerData.newDataAngryBuzzer), value);
    }

    public bool killedBurstingBouncer
    {
        get => orig.GetBool(nameof(PlayerData.killedBurstingBouncer));
        set => orig.SetBool(nameof(PlayerData.killedBurstingBouncer), value);
    }

    public int killsBurstingBouncer
    {
        get => orig.GetInt(nameof(PlayerData.killsBurstingBouncer));
        set => orig.SetInt(nameof(PlayerData.killsBurstingBouncer), value);
    }

    public bool newDataBurstingBouncer
    {
        get => orig.GetBool(nameof(PlayerData.newDataBurstingBouncer));
        set => orig.SetBool(nameof(PlayerData.newDataBurstingBouncer), value);
    }

    public bool killedBurstingZombie
    {
        get => orig.GetBool(nameof(PlayerData.killedBurstingZombie));
        set => orig.SetBool(nameof(PlayerData.killedBurstingZombie), value);
    }

    public int killsBurstingZombie
    {
        get => orig.GetInt(nameof(PlayerData.killsBurstingZombie));
        set => orig.SetInt(nameof(PlayerData.killsBurstingZombie), value);
    }

    public bool newDataBurstingZombie
    {
        get => orig.GetBool(nameof(PlayerData.newDataBurstingZombie));
        set => orig.SetBool(nameof(PlayerData.newDataBurstingZombie), value);
    }

    public bool killedSpittingZombie
    {
        get => orig.GetBool(nameof(PlayerData.killedSpittingZombie));
        set => orig.SetBool(nameof(PlayerData.killedSpittingZombie), value);
    }

    public int killsSpittingZombie
    {
        get => orig.GetInt(nameof(PlayerData.killsSpittingZombie));
        set => orig.SetInt(nameof(PlayerData.killsSpittingZombie), value);
    }

    public bool newDataSpittingZombie
    {
        get => orig.GetBool(nameof(PlayerData.newDataSpittingZombie));
        set => orig.SetBool(nameof(PlayerData.newDataSpittingZombie), value);
    }

    public bool killedBabyCentipede
    {
        get => orig.GetBool(nameof(PlayerData.killedBabyCentipede));
        set => orig.SetBool(nameof(PlayerData.killedBabyCentipede), value);
    }

    public int killsBabyCentipede
    {
        get => orig.GetInt(nameof(PlayerData.killsBabyCentipede));
        set => orig.SetInt(nameof(PlayerData.killsBabyCentipede), value);
    }

    public bool newDataBabyCentipede
    {
        get => orig.GetBool(nameof(PlayerData.newDataBabyCentipede));
        set => orig.SetBool(nameof(PlayerData.newDataBabyCentipede), value);
    }

    public bool killedBigCentipede
    {
        get => orig.GetBool(nameof(PlayerData.killedBigCentipede));
        set => orig.SetBool(nameof(PlayerData.killedBigCentipede), value);
    }

    public int killsBigCentipede
    {
        get => orig.GetInt(nameof(PlayerData.killsBigCentipede));
        set => orig.SetInt(nameof(PlayerData.killsBigCentipede), value);
    }

    public bool newDataBigCentipede
    {
        get => orig.GetBool(nameof(PlayerData.newDataBigCentipede));
        set => orig.SetBool(nameof(PlayerData.newDataBigCentipede), value);
    }

    public bool killedCentipedeHatcher
    {
        get => orig.GetBool(nameof(PlayerData.killedCentipedeHatcher));
        set => orig.SetBool(nameof(PlayerData.killedCentipedeHatcher), value);
    }

    public int killsCentipedeHatcher
    {
        get => orig.GetInt(nameof(PlayerData.killsCentipedeHatcher));
        set => orig.SetInt(nameof(PlayerData.killsCentipedeHatcher), value);
    }

    public bool newDataCentipedeHatcher
    {
        get => orig.GetBool(nameof(PlayerData.newDataCentipedeHatcher));
        set => orig.SetBool(nameof(PlayerData.newDataCentipedeHatcher), value);
    }

    public bool killedLesserMawlek
    {
        get => orig.GetBool(nameof(PlayerData.killedLesserMawlek));
        set => orig.SetBool(nameof(PlayerData.killedLesserMawlek), value);
    }

    public int killsLesserMawlek
    {
        get => orig.GetInt(nameof(PlayerData.killsLesserMawlek));
        set => orig.SetInt(nameof(PlayerData.killsLesserMawlek), value);
    }

    public bool newDataLesserMawlek
    {
        get => orig.GetBool(nameof(PlayerData.newDataLesserMawlek));
        set => orig.SetBool(nameof(PlayerData.newDataLesserMawlek), value);
    }

    public bool killedSlashSpider
    {
        get => orig.GetBool(nameof(PlayerData.killedSlashSpider));
        set => orig.SetBool(nameof(PlayerData.killedSlashSpider), value);
    }

    public int killsSlashSpider
    {
        get => orig.GetInt(nameof(PlayerData.killsSlashSpider));
        set => orig.SetInt(nameof(PlayerData.killsSlashSpider), value);
    }

    public bool newDataSlashSpider
    {
        get => orig.GetBool(nameof(PlayerData.newDataSlashSpider));
        set => orig.SetBool(nameof(PlayerData.newDataSlashSpider), value);
    }

    public bool killedSpiderCorpse
    {
        get => orig.GetBool(nameof(PlayerData.killedSpiderCorpse));
        set => orig.SetBool(nameof(PlayerData.killedSpiderCorpse), value);
    }

    public int killsSpiderCorpse
    {
        get => orig.GetInt(nameof(PlayerData.killsSpiderCorpse));
        set => orig.SetInt(nameof(PlayerData.killsSpiderCorpse), value);
    }

    public bool newDataSpiderCorpse
    {
        get => orig.GetBool(nameof(PlayerData.newDataSpiderCorpse));
        set => orig.SetBool(nameof(PlayerData.newDataSpiderCorpse), value);
    }

    public bool killedShootSpider
    {
        get => orig.GetBool(nameof(PlayerData.killedShootSpider));
        set => orig.SetBool(nameof(PlayerData.killedShootSpider), value);
    }

    public int killsShootSpider
    {
        get => orig.GetInt(nameof(PlayerData.killsShootSpider));
        set => orig.SetInt(nameof(PlayerData.killsShootSpider), value);
    }

    public bool newDataShootSpider
    {
        get => orig.GetBool(nameof(PlayerData.newDataShootSpider));
        set => orig.SetBool(nameof(PlayerData.newDataShootSpider), value);
    }

    public bool killedMiniSpider
    {
        get => orig.GetBool(nameof(PlayerData.killedMiniSpider));
        set => orig.SetBool(nameof(PlayerData.killedMiniSpider), value);
    }

    public int killsMiniSpider
    {
        get => orig.GetInt(nameof(PlayerData.killsMiniSpider));
        set => orig.SetInt(nameof(PlayerData.killsMiniSpider), value);
    }

    public bool newDataMiniSpider
    {
        get => orig.GetBool(nameof(PlayerData.newDataMiniSpider));
        set => orig.SetBool(nameof(PlayerData.newDataMiniSpider), value);
    }

    public bool killedSpiderFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedSpiderFlyer));
        set => orig.SetBool(nameof(PlayerData.killedSpiderFlyer), value);
    }

    public int killsSpiderFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsSpiderFlyer));
        set => orig.SetInt(nameof(PlayerData.killsSpiderFlyer), value);
    }

    public bool newDataSpiderFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataSpiderFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataSpiderFlyer), value);
    }

    public bool killedMimicSpider
    {
        get => orig.GetBool(nameof(PlayerData.killedMimicSpider));
        set => orig.SetBool(nameof(PlayerData.killedMimicSpider), value);
    }

    public int killsMimicSpider
    {
        get => orig.GetInt(nameof(PlayerData.killsMimicSpider));
        set => orig.SetInt(nameof(PlayerData.killsMimicSpider), value);
    }

    public bool newDataMimicSpider
    {
        get => orig.GetBool(nameof(PlayerData.newDataMimicSpider));
        set => orig.SetBool(nameof(PlayerData.newDataMimicSpider), value);
    }

    public bool killedBeeHatchling
    {
        get => orig.GetBool(nameof(PlayerData.killedBeeHatchling));
        set => orig.SetBool(nameof(PlayerData.killedBeeHatchling), value);
    }

    public int killsBeeHatchling
    {
        get => orig.GetInt(nameof(PlayerData.killsBeeHatchling));
        set => orig.SetInt(nameof(PlayerData.killsBeeHatchling), value);
    }

    public bool newDataBeeHatchling
    {
        get => orig.GetBool(nameof(PlayerData.newDataBeeHatchling));
        set => orig.SetBool(nameof(PlayerData.newDataBeeHatchling), value);
    }

    public bool killedBeeStinger
    {
        get => orig.GetBool(nameof(PlayerData.killedBeeStinger));
        set => orig.SetBool(nameof(PlayerData.killedBeeStinger), value);
    }

    public int killsBeeStinger
    {
        get => orig.GetInt(nameof(PlayerData.killsBeeStinger));
        set => orig.SetInt(nameof(PlayerData.killsBeeStinger), value);
    }

    public bool newDataBeeStinger
    {
        get => orig.GetBool(nameof(PlayerData.newDataBeeStinger));
        set => orig.SetBool(nameof(PlayerData.newDataBeeStinger), value);
    }

    public bool killedBigBee
    {
        get => orig.GetBool(nameof(PlayerData.killedBigBee));
        set => orig.SetBool(nameof(PlayerData.killedBigBee), value);
    }

    public int killsBigBee
    {
        get => orig.GetInt(nameof(PlayerData.killsBigBee));
        set => orig.SetInt(nameof(PlayerData.killsBigBee), value);
    }

    public bool newDataBigBee
    {
        get => orig.GetBool(nameof(PlayerData.newDataBigBee));
        set => orig.SetBool(nameof(PlayerData.newDataBigBee), value);
    }

    public bool killedHiveKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedHiveKnight));
        set => orig.SetBool(nameof(PlayerData.killedHiveKnight), value);
    }

    public int killsHiveKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsHiveKnight));
        set => orig.SetInt(nameof(PlayerData.killsHiveKnight), value);
    }

    public bool newDataHiveKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataHiveKnight));
        set => orig.SetBool(nameof(PlayerData.newDataHiveKnight), value);
    }

    public bool killedBlowFly
    {
        get => orig.GetBool(nameof(PlayerData.killedBlowFly));
        set => orig.SetBool(nameof(PlayerData.killedBlowFly), value);
    }

    public int killsBlowFly
    {
        get => orig.GetInt(nameof(PlayerData.killsBlowFly));
        set => orig.SetInt(nameof(PlayerData.killsBlowFly), value);
    }

    public bool newDataBlowFly
    {
        get => orig.GetBool(nameof(PlayerData.newDataBlowFly));
        set => orig.SetBool(nameof(PlayerData.newDataBlowFly), value);
    }

    public bool killedCeilingDropper
    {
        get => orig.GetBool(nameof(PlayerData.killedCeilingDropper));
        set => orig.SetBool(nameof(PlayerData.killedCeilingDropper), value);
    }

    public int killsCeilingDropper
    {
        get => orig.GetInt(nameof(PlayerData.killsCeilingDropper));
        set => orig.SetInt(nameof(PlayerData.killsCeilingDropper), value);
    }

    public bool newDataCeilingDropper
    {
        get => orig.GetBool(nameof(PlayerData.newDataCeilingDropper));
        set => orig.SetBool(nameof(PlayerData.newDataCeilingDropper), value);
    }

    public bool killedGiantHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedGiantHopper));
        set => orig.SetBool(nameof(PlayerData.killedGiantHopper), value);
    }

    public int killsGiantHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsGiantHopper));
        set => orig.SetInt(nameof(PlayerData.killsGiantHopper), value);
    }

    public bool newDataGiantHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataGiantHopper));
        set => orig.SetBool(nameof(PlayerData.newDataGiantHopper), value);
    }

    public bool killedGrubMimic
    {
        get => orig.GetBool(nameof(PlayerData.killedGrubMimic));
        set => orig.SetBool(nameof(PlayerData.killedGrubMimic), value);
    }

    public int killsGrubMimic
    {
        get => orig.GetInt(nameof(PlayerData.killsGrubMimic));
        set => orig.SetInt(nameof(PlayerData.killsGrubMimic), value);
    }

    public bool newDataGrubMimic
    {
        get => orig.GetBool(nameof(PlayerData.newDataGrubMimic));
        set => orig.SetBool(nameof(PlayerData.newDataGrubMimic), value);
    }

    public bool killedMawlekTurret
    {
        get => orig.GetBool(nameof(PlayerData.killedMawlekTurret));
        set => orig.SetBool(nameof(PlayerData.killedMawlekTurret), value);
    }

    public int killsMawlekTurret
    {
        get => orig.GetInt(nameof(PlayerData.killsMawlekTurret));
        set => orig.SetInt(nameof(PlayerData.killsMawlekTurret), value);
    }

    public bool newDataMawlekTurret
    {
        get => orig.GetBool(nameof(PlayerData.newDataMawlekTurret));
        set => orig.SetBool(nameof(PlayerData.newDataMawlekTurret), value);
    }

    public bool killedOrangeScuttler
    {
        get => orig.GetBool(nameof(PlayerData.killedOrangeScuttler));
        set => orig.SetBool(nameof(PlayerData.killedOrangeScuttler), value);
    }

    public int killsOrangeScuttler
    {
        get => orig.GetInt(nameof(PlayerData.killsOrangeScuttler));
        set => orig.SetInt(nameof(PlayerData.killsOrangeScuttler), value);
    }

    public bool newDataOrangeScuttler
    {
        get => orig.GetBool(nameof(PlayerData.newDataOrangeScuttler));
        set => orig.SetBool(nameof(PlayerData.newDataOrangeScuttler), value);
    }

    public bool killedHealthScuttler
    {
        get => orig.GetBool(nameof(PlayerData.killedHealthScuttler));
        set => orig.SetBool(nameof(PlayerData.killedHealthScuttler), value);
    }

    public int killsHealthScuttler
    {
        get => orig.GetInt(nameof(PlayerData.killsHealthScuttler));
        set => orig.SetInt(nameof(PlayerData.killsHealthScuttler), value);
    }

    public bool newDataHealthScuttler
    {
        get => orig.GetBool(nameof(PlayerData.newDataHealthScuttler));
        set => orig.SetBool(nameof(PlayerData.newDataHealthScuttler), value);
    }

    public bool killedPigeon
    {
        get => orig.GetBool(nameof(PlayerData.killedPigeon));
        set => orig.SetBool(nameof(PlayerData.killedPigeon), value);
    }

    public int killsPigeon
    {
        get => orig.GetInt(nameof(PlayerData.killsPigeon));
        set => orig.SetInt(nameof(PlayerData.killsPigeon), value);
    }

    public bool newDataPigeon
    {
        get => orig.GetBool(nameof(PlayerData.newDataPigeon));
        set => orig.SetBool(nameof(PlayerData.newDataPigeon), value);
    }

    public bool killedZombieHive
    {
        get => orig.GetBool(nameof(PlayerData.killedZombieHive));
        set => orig.SetBool(nameof(PlayerData.killedZombieHive), value);
    }

    public int killsZombieHive
    {
        get => orig.GetInt(nameof(PlayerData.killsZombieHive));
        set => orig.SetInt(nameof(PlayerData.killsZombieHive), value);
    }

    public bool newDataZombieHive
    {
        get => orig.GetBool(nameof(PlayerData.newDataZombieHive));
        set => orig.SetBool(nameof(PlayerData.newDataZombieHive), value);
    }

    public bool killedDreamGuard
    {
        get => orig.GetBool(nameof(PlayerData.killedDreamGuard));
        set => orig.SetBool(nameof(PlayerData.killedDreamGuard), value);
    }

    public int killsDreamGuard
    {
        get => orig.GetInt(nameof(PlayerData.killsDreamGuard));
        set => orig.SetInt(nameof(PlayerData.killsDreamGuard), value);
    }

    public bool newDataDreamGuard
    {
        get => orig.GetBool(nameof(PlayerData.newDataDreamGuard));
        set => orig.SetBool(nameof(PlayerData.newDataDreamGuard), value);
    }

    public bool killedHornet
    {
        get => orig.GetBool(nameof(PlayerData.killedHornet));
        set => orig.SetBool(nameof(PlayerData.killedHornet), value);
    }

    public int killsHornet
    {
        get => orig.GetInt(nameof(PlayerData.killsHornet));
        set => orig.SetInt(nameof(PlayerData.killsHornet), value);
    }

    public bool newDataHornet
    {
        get => orig.GetBool(nameof(PlayerData.newDataHornet));
        set => orig.SetBool(nameof(PlayerData.newDataHornet), value);
    }

    public bool killedAbyssCrawler
    {
        get => orig.GetBool(nameof(PlayerData.killedAbyssCrawler));
        set => orig.SetBool(nameof(PlayerData.killedAbyssCrawler), value);
    }

    public int killsAbyssCrawler
    {
        get => orig.GetInt(nameof(PlayerData.killsAbyssCrawler));
        set => orig.SetInt(nameof(PlayerData.killsAbyssCrawler), value);
    }

    public bool newDataAbyssCrawler
    {
        get => orig.GetBool(nameof(PlayerData.newDataAbyssCrawler));
        set => orig.SetBool(nameof(PlayerData.newDataAbyssCrawler), value);
    }

    public bool killedSuperSpitter
    {
        get => orig.GetBool(nameof(PlayerData.killedSuperSpitter));
        set => orig.SetBool(nameof(PlayerData.killedSuperSpitter), value);
    }

    public int killsSuperSpitter
    {
        get => orig.GetInt(nameof(PlayerData.killsSuperSpitter));
        set => orig.SetInt(nameof(PlayerData.killsSuperSpitter), value);
    }

    public bool newDataSuperSpitter
    {
        get => orig.GetBool(nameof(PlayerData.newDataSuperSpitter));
        set => orig.SetBool(nameof(PlayerData.newDataSuperSpitter), value);
    }

    public bool killedSibling
    {
        get => orig.GetBool(nameof(PlayerData.killedSibling));
        set => orig.SetBool(nameof(PlayerData.killedSibling), value);
    }

    public int killsSibling
    {
        get => orig.GetInt(nameof(PlayerData.killsSibling));
        set => orig.SetInt(nameof(PlayerData.killsSibling), value);
    }

    public bool newDataSibling
    {
        get => orig.GetBool(nameof(PlayerData.newDataSibling));
        set => orig.SetBool(nameof(PlayerData.newDataSibling), value);
    }

    public bool killedPalaceFly
    {
        get => orig.GetBool(nameof(PlayerData.killedPalaceFly));
        set => orig.SetBool(nameof(PlayerData.killedPalaceFly), value);
    }

    public int killsPalaceFly
    {
        get => orig.GetInt(nameof(PlayerData.killsPalaceFly));
        set => orig.SetInt(nameof(PlayerData.killsPalaceFly), value);
    }

    public bool newDataPalaceFly
    {
        get => orig.GetBool(nameof(PlayerData.newDataPalaceFly));
        set => orig.SetBool(nameof(PlayerData.newDataPalaceFly), value);
    }

    public bool killedEggSac
    {
        get => orig.GetBool(nameof(PlayerData.killedEggSac));
        set => orig.SetBool(nameof(PlayerData.killedEggSac), value);
    }

    public int killsEggSac
    {
        get => orig.GetInt(nameof(PlayerData.killsEggSac));
        set => orig.SetInt(nameof(PlayerData.killsEggSac), value);
    }

    public bool newDataEggSac
    {
        get => orig.GetBool(nameof(PlayerData.newDataEggSac));
        set => orig.SetBool(nameof(PlayerData.newDataEggSac), value);
    }

    public bool killedMummy
    {
        get => orig.GetBool(nameof(PlayerData.killedMummy));
        set => orig.SetBool(nameof(PlayerData.killedMummy), value);
    }

    public int killsMummy
    {
        get => orig.GetInt(nameof(PlayerData.killsMummy));
        set => orig.SetInt(nameof(PlayerData.killsMummy), value);
    }

    public bool newDataMummy
    {
        get => orig.GetBool(nameof(PlayerData.newDataMummy));
        set => orig.SetBool(nameof(PlayerData.newDataMummy), value);
    }

    public bool killedOrangeBalloon
    {
        get => orig.GetBool(nameof(PlayerData.killedOrangeBalloon));
        set => orig.SetBool(nameof(PlayerData.killedOrangeBalloon), value);
    }

    public int killsOrangeBalloon
    {
        get => orig.GetInt(nameof(PlayerData.killsOrangeBalloon));
        set => orig.SetInt(nameof(PlayerData.killsOrangeBalloon), value);
    }

    public bool newDataOrangeBalloon
    {
        get => orig.GetBool(nameof(PlayerData.newDataOrangeBalloon));
        set => orig.SetBool(nameof(PlayerData.newDataOrangeBalloon), value);
    }

    public bool killedAbyssTendril
    {
        get => orig.GetBool(nameof(PlayerData.killedAbyssTendril));
        set => orig.SetBool(nameof(PlayerData.killedAbyssTendril), value);
    }

    public int killsAbyssTendril
    {
        get => orig.GetInt(nameof(PlayerData.killsAbyssTendril));
        set => orig.SetInt(nameof(PlayerData.killsAbyssTendril), value);
    }

    public bool newDataAbyssTendril
    {
        get => orig.GetBool(nameof(PlayerData.newDataAbyssTendril));
        set => orig.SetBool(nameof(PlayerData.newDataAbyssTendril), value);
    }

    public bool killedHeavyMantis
    {
        get => orig.GetBool(nameof(PlayerData.killedHeavyMantis));
        set => orig.SetBool(nameof(PlayerData.killedHeavyMantis), value);
    }

    public int killsHeavyMantis
    {
        get => orig.GetInt(nameof(PlayerData.killsHeavyMantis));
        set => orig.SetInt(nameof(PlayerData.killsHeavyMantis), value);
    }

    public bool newDataHeavyMantis
    {
        get => orig.GetBool(nameof(PlayerData.newDataHeavyMantis));
        set => orig.SetBool(nameof(PlayerData.newDataHeavyMantis), value);
    }

    public bool killedTraitorLord
    {
        get => orig.GetBool(nameof(PlayerData.killedTraitorLord));
        set => orig.SetBool(nameof(PlayerData.killedTraitorLord), value);
    }

    public int killsTraitorLord
    {
        get => orig.GetInt(nameof(PlayerData.killsTraitorLord));
        set => orig.SetInt(nameof(PlayerData.killsTraitorLord), value);
    }

    public bool newDataTraitorLord
    {
        get => orig.GetBool(nameof(PlayerData.newDataTraitorLord));
        set => orig.SetBool(nameof(PlayerData.newDataTraitorLord), value);
    }

    public bool killedMantisHeavyFlyer
    {
        get => orig.GetBool(nameof(PlayerData.killedMantisHeavyFlyer));
        set => orig.SetBool(nameof(PlayerData.killedMantisHeavyFlyer), value);
    }

    public int killsMantisHeavyFlyer
    {
        get => orig.GetInt(nameof(PlayerData.killsMantisHeavyFlyer));
        set => orig.SetInt(nameof(PlayerData.killsMantisHeavyFlyer), value);
    }

    public bool newDataMantisHeavyFlyer
    {
        get => orig.GetBool(nameof(PlayerData.newDataMantisHeavyFlyer));
        set => orig.SetBool(nameof(PlayerData.newDataMantisHeavyFlyer), value);
    }

    public bool killedGardenZombie
    {
        get => orig.GetBool(nameof(PlayerData.killedGardenZombie));
        set => orig.SetBool(nameof(PlayerData.killedGardenZombie), value);
    }

    public int killsGardenZombie
    {
        get => orig.GetInt(nameof(PlayerData.killsGardenZombie));
        set => orig.SetInt(nameof(PlayerData.killsGardenZombie), value);
    }

    public bool newDataGardenZombie
    {
        get => orig.GetBool(nameof(PlayerData.newDataGardenZombie));
        set => orig.SetBool(nameof(PlayerData.newDataGardenZombie), value);
    }

    public bool killedRoyalGuard
    {
        get => orig.GetBool(nameof(PlayerData.killedRoyalGuard));
        set => orig.SetBool(nameof(PlayerData.killedRoyalGuard), value);
    }

    public int killsRoyalGuard
    {
        get => orig.GetInt(nameof(PlayerData.killsRoyalGuard));
        set => orig.SetInt(nameof(PlayerData.killsRoyalGuard), value);
    }

    public bool newDataRoyalGuard
    {
        get => orig.GetBool(nameof(PlayerData.newDataRoyalGuard));
        set => orig.SetBool(nameof(PlayerData.newDataRoyalGuard), value);
    }

    public bool killedWhiteRoyal
    {
        get => orig.GetBool(nameof(PlayerData.killedWhiteRoyal));
        set => orig.SetBool(nameof(PlayerData.killedWhiteRoyal), value);
    }

    public int killsWhiteRoyal
    {
        get => orig.GetInt(nameof(PlayerData.killsWhiteRoyal));
        set => orig.SetInt(nameof(PlayerData.killsWhiteRoyal), value);
    }

    public bool newDataWhiteRoyal
    {
        get => orig.GetBool(nameof(PlayerData.newDataWhiteRoyal));
        set => orig.SetBool(nameof(PlayerData.newDataWhiteRoyal), value);
    }

    public bool openedPalaceGrounds
    {
        get => orig.GetBool(nameof(PlayerData.openedPalaceGrounds));
        set => orig.SetBool(nameof(PlayerData.openedPalaceGrounds), value);
    }

    public bool killedOblobble
    {
        get => orig.GetBool(nameof(PlayerData.killedOblobble));
        set => orig.SetBool(nameof(PlayerData.killedOblobble), value);
    }

    public int killsOblobble
    {
        get => orig.GetInt(nameof(PlayerData.killsOblobble));
        set => orig.SetInt(nameof(PlayerData.killsOblobble), value);
    }

    public bool newDataOblobble
    {
        get => orig.GetBool(nameof(PlayerData.newDataOblobble));
        set => orig.SetBool(nameof(PlayerData.newDataOblobble), value);
    }

    public bool killedZote
    {
        get => orig.GetBool(nameof(PlayerData.killedZote));
        set => orig.SetBool(nameof(PlayerData.killedZote), value);
    }

    public int killsZote
    {
        get => orig.GetInt(nameof(PlayerData.killsZote));
        set => orig.SetInt(nameof(PlayerData.killsZote), value);
    }

    public bool newDataZote
    {
        get => orig.GetBool(nameof(PlayerData.newDataZote));
        set => orig.SetBool(nameof(PlayerData.newDataZote), value);
    }

    public bool killedBlobble
    {
        get => orig.GetBool(nameof(PlayerData.killedBlobble));
        set => orig.SetBool(nameof(PlayerData.killedBlobble), value);
    }

    public int killsBlobble
    {
        get => orig.GetInt(nameof(PlayerData.killsBlobble));
        set => orig.SetInt(nameof(PlayerData.killsBlobble), value);
    }

    public bool newDataBlobble
    {
        get => orig.GetBool(nameof(PlayerData.newDataBlobble));
        set => orig.SetBool(nameof(PlayerData.newDataBlobble), value);
    }

    public bool killedColMosquito
    {
        get => orig.GetBool(nameof(PlayerData.killedColMosquito));
        set => orig.SetBool(nameof(PlayerData.killedColMosquito), value);
    }

    public int killsColMosquito
    {
        get => orig.GetInt(nameof(PlayerData.killsColMosquito));
        set => orig.SetInt(nameof(PlayerData.killsColMosquito), value);
    }

    public bool newDataColMosquito
    {
        get => orig.GetBool(nameof(PlayerData.newDataColMosquito));
        set => orig.SetBool(nameof(PlayerData.newDataColMosquito), value);
    }

    public bool killedColRoller
    {
        get => orig.GetBool(nameof(PlayerData.killedColRoller));
        set => orig.SetBool(nameof(PlayerData.killedColRoller), value);
    }

    public int killsColRoller
    {
        get => orig.GetInt(nameof(PlayerData.killsColRoller));
        set => orig.SetInt(nameof(PlayerData.killsColRoller), value);
    }

    public bool newDataColRoller
    {
        get => orig.GetBool(nameof(PlayerData.newDataColRoller));
        set => orig.SetBool(nameof(PlayerData.newDataColRoller), value);
    }

    public bool killedColFlyingSentry
    {
        get => orig.GetBool(nameof(PlayerData.killedColFlyingSentry));
        set => orig.SetBool(nameof(PlayerData.killedColFlyingSentry), value);
    }

    public int killsColFlyingSentry
    {
        get => orig.GetInt(nameof(PlayerData.killsColFlyingSentry));
        set => orig.SetInt(nameof(PlayerData.killsColFlyingSentry), value);
    }

    public bool newDataColFlyingSentry
    {
        get => orig.GetBool(nameof(PlayerData.newDataColFlyingSentry));
        set => orig.SetBool(nameof(PlayerData.newDataColFlyingSentry), value);
    }

    public bool killedColMiner
    {
        get => orig.GetBool(nameof(PlayerData.killedColMiner));
        set => orig.SetBool(nameof(PlayerData.killedColMiner), value);
    }

    public int killsColMiner
    {
        get => orig.GetInt(nameof(PlayerData.killsColMiner));
        set => orig.SetInt(nameof(PlayerData.killsColMiner), value);
    }

    public bool newDataColMiner
    {
        get => orig.GetBool(nameof(PlayerData.newDataColMiner));
        set => orig.SetBool(nameof(PlayerData.newDataColMiner), value);
    }

    public bool killedColShield
    {
        get => orig.GetBool(nameof(PlayerData.killedColShield));
        set => orig.SetBool(nameof(PlayerData.killedColShield), value);
    }

    public int killsColShield
    {
        get => orig.GetInt(nameof(PlayerData.killsColShield));
        set => orig.SetInt(nameof(PlayerData.killsColShield), value);
    }

    public bool newDataColShield
    {
        get => orig.GetBool(nameof(PlayerData.newDataColShield));
        set => orig.SetBool(nameof(PlayerData.newDataColShield), value);
    }

    public bool killedColWorm
    {
        get => orig.GetBool(nameof(PlayerData.killedColWorm));
        set => orig.SetBool(nameof(PlayerData.killedColWorm), value);
    }

    public int killsColWorm
    {
        get => orig.GetInt(nameof(PlayerData.killsColWorm));
        set => orig.SetInt(nameof(PlayerData.killsColWorm), value);
    }

    public bool newDataColWorm
    {
        get => orig.GetBool(nameof(PlayerData.newDataColWorm));
        set => orig.SetBool(nameof(PlayerData.newDataColWorm), value);
    }

    public bool killedColHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedColHopper));
        set => orig.SetBool(nameof(PlayerData.killedColHopper), value);
    }

    public int killsColHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsColHopper));
        set => orig.SetInt(nameof(PlayerData.killsColHopper), value);
    }

    public bool newDataColHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataColHopper));
        set => orig.SetBool(nameof(PlayerData.newDataColHopper), value);
    }

    public bool killedLobsterLancer
    {
        get => orig.GetBool(nameof(PlayerData.killedLobsterLancer));
        set => orig.SetBool(nameof(PlayerData.killedLobsterLancer), value);
    }

    public int killsLobsterLancer
    {
        get => orig.GetInt(nameof(PlayerData.killsLobsterLancer));
        set => orig.SetInt(nameof(PlayerData.killsLobsterLancer), value);
    }

    public bool newDataLobsterLancer
    {
        get => orig.GetBool(nameof(PlayerData.newDataLobsterLancer));
        set => orig.SetBool(nameof(PlayerData.newDataLobsterLancer), value);
    }

    public bool killedGhostAladar
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostAladar));
        set => orig.SetBool(nameof(PlayerData.killedGhostAladar), value);
    }

    public int killsGhostAladar
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostAladar));
        set => orig.SetInt(nameof(PlayerData.killsGhostAladar), value);
    }

    public bool newDataGhostAladar
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostAladar));
        set => orig.SetBool(nameof(PlayerData.newDataGhostAladar), value);
    }

    public bool killedGhostXero
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostXero));
        set => orig.SetBool(nameof(PlayerData.killedGhostXero), value);
    }

    public int killsGhostXero
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostXero));
        set => orig.SetInt(nameof(PlayerData.killsGhostXero), value);
    }

    public bool newDataGhostXero
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostXero));
        set => orig.SetBool(nameof(PlayerData.newDataGhostXero), value);
    }

    public bool killedGhostHu
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostHu));
        set => orig.SetBool(nameof(PlayerData.killedGhostHu), value);
    }

    public int killsGhostHu
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostHu));
        set => orig.SetInt(nameof(PlayerData.killsGhostHu), value);
    }

    public bool newDataGhostHu
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostHu));
        set => orig.SetBool(nameof(PlayerData.newDataGhostHu), value);
    }

    public bool killedGhostMarmu
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostMarmu));
        set => orig.SetBool(nameof(PlayerData.killedGhostMarmu), value);
    }

    public int killsGhostMarmu
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostMarmu));
        set => orig.SetInt(nameof(PlayerData.killsGhostMarmu), value);
    }

    public bool newDataGhostMarmu
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostMarmu));
        set => orig.SetBool(nameof(PlayerData.newDataGhostMarmu), value);
    }

    public bool killedGhostNoEyes
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostNoEyes));
        set => orig.SetBool(nameof(PlayerData.killedGhostNoEyes), value);
    }

    public int killsGhostNoEyes
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostNoEyes));
        set => orig.SetInt(nameof(PlayerData.killsGhostNoEyes), value);
    }

    public bool newDataGhostNoEyes
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostNoEyes));
        set => orig.SetBool(nameof(PlayerData.newDataGhostNoEyes), value);
    }

    public bool killedGhostMarkoth
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostMarkoth));
        set => orig.SetBool(nameof(PlayerData.killedGhostMarkoth), value);
    }

    public int killsGhostMarkoth
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostMarkoth));
        set => orig.SetInt(nameof(PlayerData.killsGhostMarkoth), value);
    }

    public bool newDataGhostMarkoth
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostMarkoth));
        set => orig.SetBool(nameof(PlayerData.newDataGhostMarkoth), value);
    }

    public bool killedGhostGalien
    {
        get => orig.GetBool(nameof(PlayerData.killedGhostGalien));
        set => orig.SetBool(nameof(PlayerData.killedGhostGalien), value);
    }

    public int killsGhostGalien
    {
        get => orig.GetInt(nameof(PlayerData.killsGhostGalien));
        set => orig.SetInt(nameof(PlayerData.killsGhostGalien), value);
    }

    public bool newDataGhostGalien
    {
        get => orig.GetBool(nameof(PlayerData.newDataGhostGalien));
        set => orig.SetBool(nameof(PlayerData.newDataGhostGalien), value);
    }

    public bool killedWhiteDefender
    {
        get => orig.GetBool(nameof(PlayerData.killedWhiteDefender));
        set => orig.SetBool(nameof(PlayerData.killedWhiteDefender), value);
    }

    public int killsWhiteDefender
    {
        get => orig.GetInt(nameof(PlayerData.killsWhiteDefender));
        set => orig.SetInt(nameof(PlayerData.killsWhiteDefender), value);
    }

    public bool newDataWhiteDefender
    {
        get => orig.GetBool(nameof(PlayerData.newDataWhiteDefender));
        set => orig.SetBool(nameof(PlayerData.newDataWhiteDefender), value);
    }

    public bool killedGreyPrince
    {
        get => orig.GetBool(nameof(PlayerData.killedGreyPrince));
        set => orig.SetBool(nameof(PlayerData.killedGreyPrince), value);
    }

    public int killsGreyPrince
    {
        get => orig.GetInt(nameof(PlayerData.killsGreyPrince));
        set => orig.SetInt(nameof(PlayerData.killsGreyPrince), value);
    }

    public bool newDataGreyPrince
    {
        get => orig.GetBool(nameof(PlayerData.newDataGreyPrince));
        set => orig.SetBool(nameof(PlayerData.newDataGreyPrince), value);
    }

    public bool killedZotelingBalloon
    {
        get => orig.GetBool(nameof(PlayerData.killedZotelingBalloon));
        set => orig.SetBool(nameof(PlayerData.killedZotelingBalloon), value);
    }

    public int killsZotelingBalloon
    {
        get => orig.GetInt(nameof(PlayerData.killsZotelingBalloon));
        set => orig.SetInt(nameof(PlayerData.killsZotelingBalloon), value);
    }

    public bool newDataZotelingBalloon
    {
        get => orig.GetBool(nameof(PlayerData.newDataZotelingBalloon));
        set => orig.SetBool(nameof(PlayerData.newDataZotelingBalloon), value);
    }

    public bool killedZotelingHopper
    {
        get => orig.GetBool(nameof(PlayerData.killedZotelingHopper));
        set => orig.SetBool(nameof(PlayerData.killedZotelingHopper), value);
    }

    public int killsZotelingHopper
    {
        get => orig.GetInt(nameof(PlayerData.killsZotelingHopper));
        set => orig.SetInt(nameof(PlayerData.killsZotelingHopper), value);
    }

    public bool newDataZotelingHopper
    {
        get => orig.GetBool(nameof(PlayerData.newDataZotelingHopper));
        set => orig.SetBool(nameof(PlayerData.newDataZotelingHopper), value);
    }

    public bool killedZotelingBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.killedZotelingBuzzer));
        set => orig.SetBool(nameof(PlayerData.killedZotelingBuzzer), value);
    }

    public int killsZotelingBuzzer
    {
        get => orig.GetInt(nameof(PlayerData.killsZotelingBuzzer));
        set => orig.SetInt(nameof(PlayerData.killsZotelingBuzzer), value);
    }

    public bool newDataZotelingBuzzer
    {
        get => orig.GetBool(nameof(PlayerData.newDataZotelingBuzzer));
        set => orig.SetBool(nameof(PlayerData.newDataZotelingBuzzer), value);
    }

    public bool killedHollowKnight
    {
        get => orig.GetBool(nameof(PlayerData.killedHollowKnight));
        set => orig.SetBool(nameof(PlayerData.killedHollowKnight), value);
    }

    public int killsHollowKnight
    {
        get => orig.GetInt(nameof(PlayerData.killsHollowKnight));
        set => orig.SetInt(nameof(PlayerData.killsHollowKnight), value);
    }

    public bool newDataHollowKnight
    {
        get => orig.GetBool(nameof(PlayerData.newDataHollowKnight));
        set => orig.SetBool(nameof(PlayerData.newDataHollowKnight), value);
    }

    public bool killedFinalBoss
    {
        get => orig.GetBool(nameof(PlayerData.killedFinalBoss));
        set => orig.SetBool(nameof(PlayerData.killedFinalBoss), value);
    }

    public int killsFinalBoss
    {
        get => orig.GetInt(nameof(PlayerData.killsFinalBoss));
        set => orig.SetInt(nameof(PlayerData.killsFinalBoss), value);
    }

    public bool newDataFinalBoss
    {
        get => orig.GetBool(nameof(PlayerData.newDataFinalBoss));
        set => orig.SetBool(nameof(PlayerData.newDataFinalBoss), value);
    }

    public bool killedHunterMark
    {
        get => orig.GetBool(nameof(PlayerData.killedHunterMark));
        set => orig.SetBool(nameof(PlayerData.killedHunterMark), value);
    }

    public int killsHunterMark
    {
        get => orig.GetInt(nameof(PlayerData.killsHunterMark));
        set => orig.SetInt(nameof(PlayerData.killsHunterMark), value);
    }

    public bool newDataHunterMark
    {
        get => orig.GetBool(nameof(PlayerData.newDataHunterMark));
        set => orig.SetBool(nameof(PlayerData.newDataHunterMark), value);
    }

    public bool killedFlameBearerSmall
    {
        get => orig.GetBool(nameof(PlayerData.killedFlameBearerSmall));
        set => orig.SetBool(nameof(PlayerData.killedFlameBearerSmall), value);
    }

    public int killsFlameBearerSmall
    {
        get => orig.GetInt(nameof(PlayerData.killsFlameBearerSmall));
        set => orig.SetInt(nameof(PlayerData.killsFlameBearerSmall), value);
    }

    public bool newDataFlameBearerSmall
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlameBearerSmall));
        set => orig.SetBool(nameof(PlayerData.newDataFlameBearerSmall), value);
    }

    public bool killedFlameBearerMed
    {
        get => orig.GetBool(nameof(PlayerData.killedFlameBearerMed));
        set => orig.SetBool(nameof(PlayerData.killedFlameBearerMed), value);
    }

    public int killsFlameBearerMed
    {
        get => orig.GetInt(nameof(PlayerData.killsFlameBearerMed));
        set => orig.SetInt(nameof(PlayerData.killsFlameBearerMed), value);
    }

    public bool newDataFlameBearerMed
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlameBearerMed));
        set => orig.SetBool(nameof(PlayerData.newDataFlameBearerMed), value);
    }

    public bool killedFlameBearerLarge
    {
        get => orig.GetBool(nameof(PlayerData.killedFlameBearerLarge));
        set => orig.SetBool(nameof(PlayerData.killedFlameBearerLarge), value);
    }

    public int killsFlameBearerLarge
    {
        get => orig.GetInt(nameof(PlayerData.killsFlameBearerLarge));
        set => orig.SetInt(nameof(PlayerData.killsFlameBearerLarge), value);
    }

    public bool newDataFlameBearerLarge
    {
        get => orig.GetBool(nameof(PlayerData.newDataFlameBearerLarge));
        set => orig.SetBool(nameof(PlayerData.newDataFlameBearerLarge), value);
    }

    public bool killedGrimm
    {
        get => orig.GetBool(nameof(PlayerData.killedGrimm));
        set => orig.SetBool(nameof(PlayerData.killedGrimm), value);
    }

    public int killsGrimm
    {
        get => orig.GetInt(nameof(PlayerData.killsGrimm));
        set => orig.SetInt(nameof(PlayerData.killsGrimm), value);
    }

    public bool newDataGrimm
    {
        get => orig.GetBool(nameof(PlayerData.newDataGrimm));
        set => orig.SetBool(nameof(PlayerData.newDataGrimm), value);
    }

    public bool killedNightmareGrimm
    {
        get => orig.GetBool(nameof(PlayerData.killedNightmareGrimm));
        set => orig.SetBool(nameof(PlayerData.killedNightmareGrimm), value);
    }

    public int killsNightmareGrimm
    {
        get => orig.GetInt(nameof(PlayerData.killsNightmareGrimm));
        set => orig.SetInt(nameof(PlayerData.killsNightmareGrimm), value);
    }

    public bool newDataNightmareGrimm
    {
        get => orig.GetBool(nameof(PlayerData.newDataNightmareGrimm));
        set => orig.SetBool(nameof(PlayerData.newDataNightmareGrimm), value);
    }

    public bool killedBindingSeal
    {
        get => orig.GetBool(nameof(PlayerData.killedBindingSeal));
        set => orig.SetBool(nameof(PlayerData.killedBindingSeal), value);
    }

    public int killsBindingSeal
    {
        get => orig.GetInt(nameof(PlayerData.killsBindingSeal));
        set => orig.SetInt(nameof(PlayerData.killsBindingSeal), value);
    }

    public bool newDataBindingSeal
    {
        get => orig.GetBool(nameof(PlayerData.newDataBindingSeal));
        set => orig.SetBool(nameof(PlayerData.newDataBindingSeal), value);
    }

    public bool killedFatFluke
    {
        get => orig.GetBool(nameof(PlayerData.killedFatFluke));
        set => orig.SetBool(nameof(PlayerData.killedFatFluke), value);
    }

    public int killsFatFluke
    {
        get => orig.GetInt(nameof(PlayerData.killsFatFluke));
        set => orig.SetInt(nameof(PlayerData.killsFatFluke), value);
    }

    public bool newDataFatFluke
    {
        get => orig.GetBool(nameof(PlayerData.newDataFatFluke));
        set => orig.SetBool(nameof(PlayerData.newDataFatFluke), value);
    }

    public bool killedPaleLurker
    {
        get => orig.GetBool(nameof(PlayerData.killedPaleLurker));
        set => orig.SetBool(nameof(PlayerData.killedPaleLurker), value);
    }

    public int killsPaleLurker
    {
        get => orig.GetInt(nameof(PlayerData.killsPaleLurker));
        set => orig.SetInt(nameof(PlayerData.killsPaleLurker), value);
    }

    public bool newDataPaleLurker
    {
        get => orig.GetBool(nameof(PlayerData.newDataPaleLurker));
        set => orig.SetBool(nameof(PlayerData.newDataPaleLurker), value);
    }

    public bool killedNailBros
    {
        get => orig.GetBool(nameof(PlayerData.killedNailBros));
        set => orig.SetBool(nameof(PlayerData.killedNailBros), value);
    }

    public int killsNailBros
    {
        get => orig.GetInt(nameof(PlayerData.killsNailBros));
        set => orig.SetInt(nameof(PlayerData.killsNailBros), value);
    }

    public bool newDataNailBros
    {
        get => orig.GetBool(nameof(PlayerData.newDataNailBros));
        set => orig.SetBool(nameof(PlayerData.newDataNailBros), value);
    }

    public bool killedPaintmaster
    {
        get => orig.GetBool(nameof(PlayerData.killedPaintmaster));
        set => orig.SetBool(nameof(PlayerData.killedPaintmaster), value);
    }

    public int killsPaintmaster
    {
        get => orig.GetInt(nameof(PlayerData.killsPaintmaster));
        set => orig.SetInt(nameof(PlayerData.killsPaintmaster), value);
    }

    public bool newDataPaintmaster
    {
        get => orig.GetBool(nameof(PlayerData.newDataPaintmaster));
        set => orig.SetBool(nameof(PlayerData.newDataPaintmaster), value);
    }

    public bool killedNailsage
    {
        get => orig.GetBool(nameof(PlayerData.killedNailsage));
        set => orig.SetBool(nameof(PlayerData.killedNailsage), value);
    }

    public int killsNailsage
    {
        get => orig.GetInt(nameof(PlayerData.killsNailsage));
        set => orig.SetInt(nameof(PlayerData.killsNailsage), value);
    }

    public bool newDataNailsage
    {
        get => orig.GetBool(nameof(PlayerData.newDataNailsage));
        set => orig.SetBool(nameof(PlayerData.newDataNailsage), value);
    }

    public bool killedHollowKnightPrime
    {
        get => orig.GetBool(nameof(PlayerData.killedHollowKnightPrime));
        set => orig.SetBool(nameof(PlayerData.killedHollowKnightPrime), value);
    }

    public int killsHollowKnightPrime
    {
        get => orig.GetInt(nameof(PlayerData.killsHollowKnightPrime));
        set => orig.SetInt(nameof(PlayerData.killsHollowKnightPrime), value);
    }

    public bool newDataHollowKnightPrime
    {
        get => orig.GetBool(nameof(PlayerData.newDataHollowKnightPrime));
        set => orig.SetBool(nameof(PlayerData.newDataHollowKnightPrime), value);
    }

    public bool killedGodseekerMask
    {
        get => orig.GetBool(nameof(PlayerData.killedGodseekerMask));
        set => orig.SetBool(nameof(PlayerData.killedGodseekerMask), value);
    }

    public int killsGodseekerMask
    {
        get => orig.GetInt(nameof(PlayerData.killsGodseekerMask));
        set => orig.SetInt(nameof(PlayerData.killsGodseekerMask), value);
    }

    public bool newDataGodseekerMask
    {
        get => orig.GetBool(nameof(PlayerData.newDataGodseekerMask));
        set => orig.SetBool(nameof(PlayerData.newDataGodseekerMask), value);
    }

    public bool killedVoidIdol_1
    {
        get => orig.GetBool(nameof(PlayerData.killedVoidIdol_1));
        set => orig.SetBool(nameof(PlayerData.killedVoidIdol_1), value);
    }

    public int killsVoidIdol_1
    {
        get => orig.GetInt(nameof(PlayerData.killsVoidIdol_1));
        set => orig.SetInt(nameof(PlayerData.killsVoidIdol_1), value);
    }

    public bool newDataVoidIdol_1
    {
        get => orig.GetBool(nameof(PlayerData.newDataVoidIdol_1));
        set => orig.SetBool(nameof(PlayerData.newDataVoidIdol_1), value);
    }

    public bool killedVoidIdol_2
    {
        get => orig.GetBool(nameof(PlayerData.killedVoidIdol_2));
        set => orig.SetBool(nameof(PlayerData.killedVoidIdol_2), value);
    }

    public int killsVoidIdol_2
    {
        get => orig.GetInt(nameof(PlayerData.killsVoidIdol_2));
        set => orig.SetInt(nameof(PlayerData.killsVoidIdol_2), value);
    }

    public bool newDataVoidIdol_2
    {
        get => orig.GetBool(nameof(PlayerData.newDataVoidIdol_2));
        set => orig.SetBool(nameof(PlayerData.newDataVoidIdol_2), value);
    }

    public bool killedVoidIdol_3
    {
        get => orig.GetBool(nameof(PlayerData.killedVoidIdol_3));
        set => orig.SetBool(nameof(PlayerData.killedVoidIdol_3), value);
    }

    public int killsVoidIdol_3
    {
        get => orig.GetInt(nameof(PlayerData.killsVoidIdol_3));
        set => orig.SetInt(nameof(PlayerData.killsVoidIdol_3), value);
    }

    public bool newDataVoidIdol_3
    {
        get => orig.GetBool(nameof(PlayerData.newDataVoidIdol_3));
        set => orig.SetBool(nameof(PlayerData.newDataVoidIdol_3), value);
    }

    public int grubsCollected
    {
        get => orig.GetInt(nameof(PlayerData.grubsCollected));
        set => orig.SetInt(nameof(PlayerData.grubsCollected), value);
    }

    public int grubRewards
    {
        get => orig.GetInt(nameof(PlayerData.grubRewards));
        set => orig.SetInt(nameof(PlayerData.grubRewards), value);
    }

    public bool finalGrubRewardCollected
    {
        get => orig.GetBool(nameof(PlayerData.finalGrubRewardCollected));
        set => orig.SetBool(nameof(PlayerData.finalGrubRewardCollected), value);
    }

    public bool fatGrubKing
    {
        get => orig.GetBool(nameof(PlayerData.fatGrubKing));
        set => orig.SetBool(nameof(PlayerData.fatGrubKing), value);
    }

    public bool falseKnightDefeated
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightDefeated));
        set => orig.SetBool(nameof(PlayerData.falseKnightDefeated), value);
    }

    public bool falseKnightDreamDefeated
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightDreamDefeated));
        set => orig.SetBool(nameof(PlayerData.falseKnightDreamDefeated), value);
    }

    public bool falseKnightOrbsCollected
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightOrbsCollected));
        set => orig.SetBool(nameof(PlayerData.falseKnightOrbsCollected), value);
    }

    public bool mawlekDefeated
    {
        get => orig.GetBool(nameof(PlayerData.mawlekDefeated));
        set => orig.SetBool(nameof(PlayerData.mawlekDefeated), value);
    }

    public bool giantBuzzerDefeated
    {
        get => orig.GetBool(nameof(PlayerData.giantBuzzerDefeated));
        set => orig.SetBool(nameof(PlayerData.giantBuzzerDefeated), value);
    }

    public bool giantFlyDefeated
    {
        get => orig.GetBool(nameof(PlayerData.giantFlyDefeated));
        set => orig.SetBool(nameof(PlayerData.giantFlyDefeated), value);
    }

    public bool blocker1Defeated
    {
        get => orig.GetBool(nameof(PlayerData.blocker1Defeated));
        set => orig.SetBool(nameof(PlayerData.blocker1Defeated), value);
    }

    public bool blocker2Defeated
    {
        get => orig.GetBool(nameof(PlayerData.blocker2Defeated));
        set => orig.SetBool(nameof(PlayerData.blocker2Defeated), value);
    }

    public bool hornet1Defeated
    {
        get => orig.GetBool(nameof(PlayerData.hornet1Defeated));
        set => orig.SetBool(nameof(PlayerData.hornet1Defeated), value);
    }

    public bool collectorDefeated
    {
        get => orig.GetBool(nameof(PlayerData.collectorDefeated));
        set => orig.SetBool(nameof(PlayerData.collectorDefeated), value);
    }

    public bool hornetOutskirtsDefeated
    {
        get => orig.GetBool(nameof(PlayerData.hornetOutskirtsDefeated));
        set => orig.SetBool(nameof(PlayerData.hornetOutskirtsDefeated), value);
    }

    public bool mageLordDreamDefeated
    {
        get => orig.GetBool(nameof(PlayerData.mageLordDreamDefeated));
        set => orig.SetBool(nameof(PlayerData.mageLordDreamDefeated), value);
    }

    public bool mageLordOrbsCollected
    {
        get => orig.GetBool(nameof(PlayerData.mageLordOrbsCollected));
        set => orig.SetBool(nameof(PlayerData.mageLordOrbsCollected), value);
    }

    public bool infectedKnightDreamDefeated
    {
        get => orig.GetBool(nameof(PlayerData.infectedKnightDreamDefeated));
        set => orig.SetBool(nameof(PlayerData.infectedKnightDreamDefeated), value);
    }

    public bool infectedKnightOrbsCollected
    {
        get => orig.GetBool(nameof(PlayerData.infectedKnightOrbsCollected));
        set => orig.SetBool(nameof(PlayerData.infectedKnightOrbsCollected), value);
    }

    public bool whiteDefenderDefeated
    {
        get => orig.GetBool(nameof(PlayerData.whiteDefenderDefeated));
        set => orig.SetBool(nameof(PlayerData.whiteDefenderDefeated), value);
    }

    public bool whiteDefenderOrbsCollected
    {
        get => orig.GetBool(nameof(PlayerData.whiteDefenderOrbsCollected));
        set => orig.SetBool(nameof(PlayerData.whiteDefenderOrbsCollected), value);
    }

    public int whiteDefenderDefeats
    {
        get => orig.GetInt(nameof(PlayerData.whiteDefenderDefeats));
        set => orig.SetInt(nameof(PlayerData.whiteDefenderDefeats), value);
    }

    public int greyPrinceDefeats
    {
        get => orig.GetInt(nameof(PlayerData.greyPrinceDefeats));
        set => orig.SetInt(nameof(PlayerData.greyPrinceDefeats), value);
    }

    public bool greyPrinceDefeated
    {
        get => orig.GetBool(nameof(PlayerData.greyPrinceDefeated));
        set => orig.SetBool(nameof(PlayerData.greyPrinceDefeated), value);
    }

    public bool greyPrinceOrbsCollected
    {
        get => orig.GetBool(nameof(PlayerData.greyPrinceOrbsCollected));
        set => orig.SetBool(nameof(PlayerData.greyPrinceOrbsCollected), value);
    }

    public int aladarSlugDefeated
    {
        get => orig.GetInt(nameof(PlayerData.aladarSlugDefeated));
        set => orig.SetInt(nameof(PlayerData.aladarSlugDefeated), value);
    }

    public int xeroDefeated
    {
        get => orig.GetInt(nameof(PlayerData.xeroDefeated));
        set => orig.SetInt(nameof(PlayerData.xeroDefeated), value);
    }

    public int elderHuDefeated
    {
        get => orig.GetInt(nameof(PlayerData.elderHuDefeated));
        set => orig.SetInt(nameof(PlayerData.elderHuDefeated), value);
    }

    public int mumCaterpillarDefeated
    {
        get => orig.GetInt(nameof(PlayerData.mumCaterpillarDefeated));
        set => orig.SetInt(nameof(PlayerData.mumCaterpillarDefeated), value);
    }

    public int noEyesDefeated
    {
        get => orig.GetInt(nameof(PlayerData.noEyesDefeated));
        set => orig.SetInt(nameof(PlayerData.noEyesDefeated), value);
    }

    public int markothDefeated
    {
        get => orig.GetInt(nameof(PlayerData.markothDefeated));
        set => orig.SetInt(nameof(PlayerData.markothDefeated), value);
    }

    public int galienDefeated
    {
        get => orig.GetInt(nameof(PlayerData.galienDefeated));
        set => orig.SetInt(nameof(PlayerData.galienDefeated), value);
    }

    public bool XERO_encountered
    {
        get => orig.GetBool(nameof(PlayerData.XERO_encountered));
        set => orig.SetBool(nameof(PlayerData.XERO_encountered), value);
    }

    public bool ALADAR_encountered
    {
        get => orig.GetBool(nameof(PlayerData.ALADAR_encountered));
        set => orig.SetBool(nameof(PlayerData.ALADAR_encountered), value);
    }

    public bool HU_encountered
    {
        get => orig.GetBool(nameof(PlayerData.HU_encountered));
        set => orig.SetBool(nameof(PlayerData.HU_encountered), value);
    }

    public bool MUMCAT_encountered
    {
        get => orig.GetBool(nameof(PlayerData.MUMCAT_encountered));
        set => orig.SetBool(nameof(PlayerData.MUMCAT_encountered), value);
    }

    public bool NOEYES_encountered
    {
        get => orig.GetBool(nameof(PlayerData.NOEYES_encountered));
        set => orig.SetBool(nameof(PlayerData.NOEYES_encountered), value);
    }

    public bool MARKOTH_encountered
    {
        get => orig.GetBool(nameof(PlayerData.MARKOTH_encountered));
        set => orig.SetBool(nameof(PlayerData.MARKOTH_encountered), value);
    }

    public bool GALIEN_encountered
    {
        get => orig.GetBool(nameof(PlayerData.GALIEN_encountered));
        set => orig.SetBool(nameof(PlayerData.GALIEN_encountered), value);
    }

    public bool xeroPinned
    {
        get => orig.GetBool(nameof(PlayerData.xeroPinned));
        set => orig.SetBool(nameof(PlayerData.xeroPinned), value);
    }

    public bool aladarPinned
    {
        get => orig.GetBool(nameof(PlayerData.aladarPinned));
        set => orig.SetBool(nameof(PlayerData.aladarPinned), value);
    }

    public bool huPinned
    {
        get => orig.GetBool(nameof(PlayerData.huPinned));
        set => orig.SetBool(nameof(PlayerData.huPinned), value);
    }

    public bool mumCaterpillarPinned
    {
        get => orig.GetBool(nameof(PlayerData.mumCaterpillarPinned));
        set => orig.SetBool(nameof(PlayerData.mumCaterpillarPinned), value);
    }

    public bool noEyesPinned
    {
        get => orig.GetBool(nameof(PlayerData.noEyesPinned));
        set => orig.SetBool(nameof(PlayerData.noEyesPinned), value);
    }

    public bool markothPinned
    {
        get => orig.GetBool(nameof(PlayerData.markothPinned));
        set => orig.SetBool(nameof(PlayerData.markothPinned), value);
    }

    public bool galienPinned
    {
        get => orig.GetBool(nameof(PlayerData.galienPinned));
        set => orig.SetBool(nameof(PlayerData.galienPinned), value);
    }

    public int currentInvPane
    {
        get => orig.GetInt(nameof(PlayerData.currentInvPane));
        set => orig.SetInt(nameof(PlayerData.currentInvPane), value);
    }

    public bool showGeoUI
    {
        get => orig.GetBool(nameof(PlayerData.showGeoUI));
        set => orig.SetBool(nameof(PlayerData.showGeoUI), value);
    }

    public bool showHealthUI
    {
        get => orig.GetBool(nameof(PlayerData.showHealthUI));
        set => orig.SetBool(nameof(PlayerData.showHealthUI), value);
    }

    public bool promptFocus
    {
        get => orig.GetBool(nameof(PlayerData.promptFocus));
        set => orig.SetBool(nameof(PlayerData.promptFocus), value);
    }

    public bool seenFocusTablet
    {
        get => orig.GetBool(nameof(PlayerData.seenFocusTablet));
        set => orig.SetBool(nameof(PlayerData.seenFocusTablet), value);
    }

    public bool seenDreamNailPrompt
    {
        get => orig.GetBool(nameof(PlayerData.seenDreamNailPrompt));
        set => orig.SetBool(nameof(PlayerData.seenDreamNailPrompt), value);
    }

    public bool isFirstGame
    {
        get => orig.GetBool(nameof(PlayerData.isFirstGame));
        set => orig.SetBool(nameof(PlayerData.isFirstGame), value);
    }

    public bool enteredTutorialFirstTime
    {
        get => orig.GetBool(nameof(PlayerData.enteredTutorialFirstTime));
        set => orig.SetBool(nameof(PlayerData.enteredTutorialFirstTime), value);
    }

    public bool isInvincible
    {
        get => orig.GetBool(nameof(PlayerData.isInvincible));
        set => orig.SetBool(nameof(PlayerData.isInvincible), value);
    }

    public bool infiniteAirJump
    {
        get => orig.GetBool(nameof(PlayerData.infiniteAirJump));
        set => orig.SetBool(nameof(PlayerData.infiniteAirJump), value);
    }

    public bool invinciTest
    {
        get => orig.GetBool(nameof(PlayerData.invinciTest));
        set => orig.SetBool(nameof(PlayerData.invinciTest), value);
    }

    public int currentArea
    {
        get => orig.GetInt(nameof(PlayerData.currentArea));
        set => orig.SetInt(nameof(PlayerData.currentArea), value);
    }

    public bool visitedDirtmouth
    {
        get => orig.GetBool(nameof(PlayerData.visitedDirtmouth));
        set => orig.SetBool(nameof(PlayerData.visitedDirtmouth), value);
    }

    public bool visitedCrossroads
    {
        get => orig.GetBool(nameof(PlayerData.visitedCrossroads));
        set => orig.SetBool(nameof(PlayerData.visitedCrossroads), value);
    }

    public bool visitedGreenpath
    {
        get => orig.GetBool(nameof(PlayerData.visitedGreenpath));
        set => orig.SetBool(nameof(PlayerData.visitedGreenpath), value);
    }

    public bool visitedFungus
    {
        get => orig.GetBool(nameof(PlayerData.visitedFungus));
        set => orig.SetBool(nameof(PlayerData.visitedFungus), value);
    }

    public bool visitedHive
    {
        get => orig.GetBool(nameof(PlayerData.visitedHive));
        set => orig.SetBool(nameof(PlayerData.visitedHive), value);
    }

    public bool visitedCrossroadsInfected
    {
        get => orig.GetBool(nameof(PlayerData.visitedCrossroadsInfected));
        set => orig.SetBool(nameof(PlayerData.visitedCrossroadsInfected), value);
    }

    public bool visitedRuins
    {
        get => orig.GetBool(nameof(PlayerData.visitedRuins));
        set => orig.SetBool(nameof(PlayerData.visitedRuins), value);
    }

    public bool visitedMines
    {
        get => orig.GetBool(nameof(PlayerData.visitedMines));
        set => orig.SetBool(nameof(PlayerData.visitedMines), value);
    }

    public bool visitedRoyalGardens
    {
        get => orig.GetBool(nameof(PlayerData.visitedRoyalGardens));
        set => orig.SetBool(nameof(PlayerData.visitedRoyalGardens), value);
    }

    public bool visitedFogCanyon
    {
        get => orig.GetBool(nameof(PlayerData.visitedFogCanyon));
        set => orig.SetBool(nameof(PlayerData.visitedFogCanyon), value);
    }

    public bool visitedDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.visitedDeepnest));
        set => orig.SetBool(nameof(PlayerData.visitedDeepnest), value);
    }

    public bool visitedRestingGrounds
    {
        get => orig.GetBool(nameof(PlayerData.visitedRestingGrounds));
        set => orig.SetBool(nameof(PlayerData.visitedRestingGrounds), value);
    }

    public bool visitedWaterways
    {
        get => orig.GetBool(nameof(PlayerData.visitedWaterways));
        set => orig.SetBool(nameof(PlayerData.visitedWaterways), value);
    }

    public bool visitedAbyss
    {
        get => orig.GetBool(nameof(PlayerData.visitedAbyss));
        set => orig.SetBool(nameof(PlayerData.visitedAbyss), value);
    }

    public bool visitedOutskirts
    {
        get => orig.GetBool(nameof(PlayerData.visitedOutskirts));
        set => orig.SetBool(nameof(PlayerData.visitedOutskirts), value);
    }

    public bool visitedWhitePalace
    {
        get => orig.GetBool(nameof(PlayerData.visitedWhitePalace));
        set => orig.SetBool(nameof(PlayerData.visitedWhitePalace), value);
    }

    public bool visitedCliffs
    {
        get => orig.GetBool(nameof(PlayerData.visitedCliffs));
        set => orig.SetBool(nameof(PlayerData.visitedCliffs), value);
    }

    public bool visitedAbyssLower
    {
        get => orig.GetBool(nameof(PlayerData.visitedAbyssLower));
        set => orig.SetBool(nameof(PlayerData.visitedAbyssLower), value);
    }

    public bool visitedGodhome
    {
        get => orig.GetBool(nameof(PlayerData.visitedGodhome));
        set => orig.SetBool(nameof(PlayerData.visitedGodhome), value);
    }

    public bool visitedMines10
    {
        get => orig.GetBool(nameof(PlayerData.visitedMines10));
        set => orig.SetBool(nameof(PlayerData.visitedMines10), value);
    }

    public List<string> scenesVisited
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesVisited));
        set => orig.SetVariable(nameof(PlayerData.scenesVisited), value);
    }

    public List<string> scenesMapped
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesMapped));
        set => orig.SetVariable(nameof(PlayerData.scenesMapped), value);
    }

    public List<string> scenesEncounteredBench
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesEncounteredBench));
        set => orig.SetVariable(nameof(PlayerData.scenesEncounteredBench),
            value);
    }

    public List<string> scenesGrubRescued
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesGrubRescued));
        set => orig.SetVariable(nameof(PlayerData.scenesGrubRescued), value);
    }

    public List<string> scenesFlameCollected
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesFlameCollected));
        set => orig.SetVariable(nameof(PlayerData.scenesFlameCollected), value);
    }

    public List<string> scenesEncounteredCocoon
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesEncounteredCocoon));
        set => orig.SetVariable(nameof(PlayerData.scenesEncounteredCocoon),
            value);
    }

    public List<string> scenesEncounteredDreamPlant
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.scenesEncounteredDreamPlant));
        set => orig.SetVariable(nameof(PlayerData.scenesEncounteredDreamPlant),
            value);
    }

    public List<string> scenesEncounteredDreamPlantC
    {
        get =>
            orig.GetVariable<List<string>>(nameof(PlayerData.scenesEncounteredDreamPlantC));
        set => orig.SetVariable(nameof(PlayerData.scenesEncounteredDreamPlantC),
            value);
    }

    public bool hasMap
    {
        get => orig.GetBool(nameof(PlayerData.hasMap));
        set => orig.SetBool(nameof(PlayerData.hasMap), value);
    }

    public bool mapAllRooms
    {
        get => orig.GetBool(nameof(PlayerData.mapAllRooms));
        set => orig.SetBool(nameof(PlayerData.mapAllRooms), value);
    }

    public bool atMapPrompt
    {
        get => orig.GetBool(nameof(PlayerData.atMapPrompt));
        set => orig.SetBool(nameof(PlayerData.atMapPrompt), value);
    }

    public bool mapDirtmouth
    {
        get => orig.GetBool(nameof(PlayerData.mapDirtmouth));
        set => orig.SetBool(nameof(PlayerData.mapDirtmouth), value);
    }

    public bool mapCrossroads
    {
        get => orig.GetBool(nameof(PlayerData.mapCrossroads));
        set => orig.SetBool(nameof(PlayerData.mapCrossroads), value);
    }

    public bool mapGreenpath
    {
        get => orig.GetBool(nameof(PlayerData.mapGreenpath));
        set => orig.SetBool(nameof(PlayerData.mapGreenpath), value);
    }

    public bool mapFogCanyon
    {
        get => orig.GetBool(nameof(PlayerData.mapFogCanyon));
        set => orig.SetBool(nameof(PlayerData.mapFogCanyon), value);
    }

    public bool mapRoyalGardens
    {
        get => orig.GetBool(nameof(PlayerData.mapRoyalGardens));
        set => orig.SetBool(nameof(PlayerData.mapRoyalGardens), value);
    }

    public bool mapFungalWastes
    {
        get => orig.GetBool(nameof(PlayerData.mapFungalWastes));
        set => orig.SetBool(nameof(PlayerData.mapFungalWastes), value);
    }

    public bool mapCity
    {
        get => orig.GetBool(nameof(PlayerData.mapCity));
        set => orig.SetBool(nameof(PlayerData.mapCity), value);
    }

    public bool mapWaterways
    {
        get => orig.GetBool(nameof(PlayerData.mapWaterways));
        set => orig.SetBool(nameof(PlayerData.mapWaterways), value);
    }

    public bool mapMines
    {
        get => orig.GetBool(nameof(PlayerData.mapMines));
        set => orig.SetBool(nameof(PlayerData.mapMines), value);
    }

    public bool mapDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.mapDeepnest));
        set => orig.SetBool(nameof(PlayerData.mapDeepnest), value);
    }

    public bool mapCliffs
    {
        get => orig.GetBool(nameof(PlayerData.mapCliffs));
        set => orig.SetBool(nameof(PlayerData.mapCliffs), value);
    }

    public bool mapOutskirts
    {
        get => orig.GetBool(nameof(PlayerData.mapOutskirts));
        set => orig.SetBool(nameof(PlayerData.mapOutskirts), value);
    }

    public bool mapRestingGrounds
    {
        get => orig.GetBool(nameof(PlayerData.mapRestingGrounds));
        set => orig.SetBool(nameof(PlayerData.mapRestingGrounds), value);
    }

    public bool mapAbyss
    {
        get => orig.GetBool(nameof(PlayerData.mapAbyss));
        set => orig.SetBool(nameof(PlayerData.mapAbyss), value);
    }

    public bool hasPin
    {
        get => orig.GetBool(nameof(PlayerData.hasPin));
        set => orig.SetBool(nameof(PlayerData.hasPin), value);
    }

    public bool hasPinBench
    {
        get => orig.GetBool(nameof(PlayerData.hasPinBench));
        set => orig.SetBool(nameof(PlayerData.hasPinBench), value);
    }

    public bool hasPinCocoon
    {
        get => orig.GetBool(nameof(PlayerData.hasPinCocoon));
        set => orig.SetBool(nameof(PlayerData.hasPinCocoon), value);
    }

    public bool hasPinDreamPlant
    {
        get => orig.GetBool(nameof(PlayerData.hasPinDreamPlant));
        set => orig.SetBool(nameof(PlayerData.hasPinDreamPlant), value);
    }

    public bool hasPinGuardian
    {
        get => orig.GetBool(nameof(PlayerData.hasPinGuardian));
        set => orig.SetBool(nameof(PlayerData.hasPinGuardian), value);
    }

    public bool hasPinBlackEgg
    {
        get => orig.GetBool(nameof(PlayerData.hasPinBlackEgg));
        set => orig.SetBool(nameof(PlayerData.hasPinBlackEgg), value);
    }

    public bool hasPinShop
    {
        get => orig.GetBool(nameof(PlayerData.hasPinShop));
        set => orig.SetBool(nameof(PlayerData.hasPinShop), value);
    }

    public bool hasPinSpa
    {
        get => orig.GetBool(nameof(PlayerData.hasPinSpa));
        set => orig.SetBool(nameof(PlayerData.hasPinSpa), value);
    }

    public bool hasPinStag
    {
        get => orig.GetBool(nameof(PlayerData.hasPinStag));
        set => orig.SetBool(nameof(PlayerData.hasPinStag), value);
    }

    public bool hasPinTram
    {
        get => orig.GetBool(nameof(PlayerData.hasPinTram));
        set => orig.SetBool(nameof(PlayerData.hasPinTram), value);
    }

    public bool hasPinGhost
    {
        get => orig.GetBool(nameof(PlayerData.hasPinGhost));
        set => orig.SetBool(nameof(PlayerData.hasPinGhost), value);
    }

    public bool hasPinGrub
    {
        get => orig.GetBool(nameof(PlayerData.hasPinGrub));
        set => orig.SetBool(nameof(PlayerData.hasPinGrub), value);
    }

    public bool hasMarker
    {
        get => orig.GetBool(nameof(PlayerData.hasMarker));
        set => orig.SetBool(nameof(PlayerData.hasMarker), value);
    }

    public bool hasMarker_r
    {
        get => orig.GetBool(nameof(PlayerData.hasMarker_r));
        set => orig.SetBool(nameof(PlayerData.hasMarker_r), value);
    }

    public bool hasMarker_b
    {
        get => orig.GetBool(nameof(PlayerData.hasMarker_b));
        set => orig.SetBool(nameof(PlayerData.hasMarker_b), value);
    }

    public bool hasMarker_y
    {
        get => orig.GetBool(nameof(PlayerData.hasMarker_y));
        set => orig.SetBool(nameof(PlayerData.hasMarker_y), value);
    }

    public bool hasMarker_w
    {
        get => orig.GetBool(nameof(PlayerData.hasMarker_w));
        set => orig.SetBool(nameof(PlayerData.hasMarker_w), value);
    }

    public int spareMarkers_r
    {
        get => orig.GetInt(nameof(PlayerData.spareMarkers_r));
        set => orig.SetInt(nameof(PlayerData.spareMarkers_r), value);
    }

    public int spareMarkers_b
    {
        get => orig.GetInt(nameof(PlayerData.spareMarkers_b));
        set => orig.SetInt(nameof(PlayerData.spareMarkers_b), value);
    }

    public int spareMarkers_y
    {
        get => orig.GetInt(nameof(PlayerData.spareMarkers_y));
        set => orig.SetInt(nameof(PlayerData.spareMarkers_y), value);
    }

    public int spareMarkers_w
    {
        get => orig.GetInt(nameof(PlayerData.spareMarkers_w));
        set => orig.SetInt(nameof(PlayerData.spareMarkers_w), value);
    }

    public List<Vector3> placedMarkers_r
    {
        get => orig.GetVariable<List<Vector3>>(nameof(PlayerData.placedMarkers_r));
        set =>
            orig.SetVariable(nameof(PlayerData.placedMarkers_r), value);
    }

    public List<Vector3> placedMarkers_b
    {
        get => orig.GetVariable<List<Vector3>>(nameof(PlayerData.placedMarkers_b));
        set =>
            orig.SetVariable(nameof(PlayerData.placedMarkers_b), value);
    }

    public List<Vector3> placedMarkers_y
    {
        get => orig.GetVariable<List<Vector3>>(nameof(PlayerData.placedMarkers_y));
        set =>
            orig.SetVariable(nameof(PlayerData.placedMarkers_y), value);
    }

    public List<Vector3> placedMarkers_w
    {
        get => orig.GetVariable<List<Vector3>>(nameof(PlayerData.placedMarkers_w));
        set =>
            orig.SetVariable(nameof(PlayerData.placedMarkers_w), value);
    }

    public int environmentType
    {
        get => orig.GetInt(nameof(PlayerData.environmentType));
        set => orig.SetInt(nameof(PlayerData.environmentType), value);
    }

    public int environmentTypeDefault
    {
        get => orig.GetInt(nameof(PlayerData.environmentTypeDefault));
        set => orig.SetInt(nameof(PlayerData.environmentTypeDefault), value);
    }

    public int previousDarkness
    {
        get => orig.GetInt(nameof(PlayerData.previousDarkness));
        set => orig.SetInt(nameof(PlayerData.previousDarkness), value);
    }

    public bool openedTramLower
    {
        get => orig.GetBool(nameof(PlayerData.openedTramLower));
        set => orig.SetBool(nameof(PlayerData.openedTramLower), value);
    }

    public bool openedTramRestingGrounds
    {
        get => orig.GetBool(nameof(PlayerData.openedTramRestingGrounds));
        set => orig.SetBool(nameof(PlayerData.openedTramRestingGrounds), value);
    }

    public int tramLowerPosition
    {
        get => orig.GetInt(nameof(PlayerData.tramLowerPosition));
        set => orig.SetInt(nameof(PlayerData.tramLowerPosition), value);
    }

    public int tramRestingGroundsPosition
    {
        get => orig.GetInt(nameof(PlayerData.tramRestingGroundsPosition));
        set => orig.SetInt(nameof(PlayerData.tramRestingGroundsPosition), value);
    }

    public bool mineLiftOpened
    {
        get => orig.GetBool(nameof(PlayerData.mineLiftOpened));
        set => orig.SetBool(nameof(PlayerData.mineLiftOpened), value);
    }

    public bool menderDoorOpened
    {
        get => orig.GetBool(nameof(PlayerData.menderDoorOpened));
        set => orig.SetBool(nameof(PlayerData.menderDoorOpened), value);
    }

    public bool vesselFragStagNest
    {
        get => orig.GetBool(nameof(PlayerData.vesselFragStagNest));
        set => orig.SetBool(nameof(PlayerData.vesselFragStagNest), value);
    }

    public bool shamanPillar
    {
        get => orig.GetBool(nameof(PlayerData.shamanPillar));
        set => orig.SetBool(nameof(PlayerData.shamanPillar), value);
    }

    public bool crossroadsMawlekWall
    {
        get => orig.GetBool(nameof(PlayerData.crossroadsMawlekWall));
        set => orig.SetBool(nameof(PlayerData.crossroadsMawlekWall), value);
    }

    public bool eggTempleVisited
    {
        get => orig.GetBool(nameof(PlayerData.eggTempleVisited));
        set => orig.SetBool(nameof(PlayerData.eggTempleVisited), value);
    }

    public bool crossroadsInfected
    {
        get => orig.GetBool(nameof(PlayerData.crossroadsInfected));
        set => orig.SetBool(nameof(PlayerData.crossroadsInfected), value);
    }

    public bool falseKnightFirstPlop
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightFirstPlop));
        set => orig.SetBool(nameof(PlayerData.falseKnightFirstPlop), value);
    }

    public bool falseKnightWallRepaired
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightWallRepaired));
        set => orig.SetBool(nameof(PlayerData.falseKnightWallRepaired), value);
    }

    public bool falseKnightWallBroken
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightWallBroken));
        set => orig.SetBool(nameof(PlayerData.falseKnightWallBroken), value);
    }

    public bool falseKnightGhostDeparted
    {
        get => orig.GetBool(nameof(PlayerData.falseKnightGhostDeparted));
        set => orig.SetBool(nameof(PlayerData.falseKnightGhostDeparted), value);
    }

    public bool spaBugsEncountered
    {
        get => orig.GetBool(nameof(PlayerData.spaBugsEncountered));
        set => orig.SetBool(nameof(PlayerData.spaBugsEncountered), value);
    }

    public bool hornheadVinePlat
    {
        get => orig.GetBool(nameof(PlayerData.hornheadVinePlat));
        set => orig.SetBool(nameof(PlayerData.hornheadVinePlat), value);
    }

    public bool infectedKnightEncountered
    {
        get => orig.GetBool(nameof(PlayerData.infectedKnightEncountered));
        set => orig.SetBool(nameof(PlayerData.infectedKnightEncountered), value);
    }

    public bool megaMossChargerEncountered
    {
        get => orig.GetBool(nameof(PlayerData.megaMossChargerEncountered));
        set => orig.SetBool(nameof(PlayerData.megaMossChargerEncountered), value);
    }

    public bool megaMossChargerDefeated
    {
        get => orig.GetBool(nameof(PlayerData.megaMossChargerDefeated));
        set => orig.SetBool(nameof(PlayerData.megaMossChargerDefeated), value);
    }

    public bool dreamerScene1
    {
        get => orig.GetBool(nameof(PlayerData.dreamerScene1));
        set => orig.SetBool(nameof(PlayerData.dreamerScene1), value);
    }

    public bool slugEncounterComplete
    {
        get => orig.GetBool(nameof(PlayerData.slugEncounterComplete));
        set => orig.SetBool(nameof(PlayerData.slugEncounterComplete), value);
    }

    public bool defeatedDoubleBlockers
    {
        get => orig.GetBool(nameof(PlayerData.defeatedDoubleBlockers));
        set => orig.SetBool(nameof(PlayerData.defeatedDoubleBlockers), value);
    }

    public bool oneWayArchive
    {
        get => orig.GetBool(nameof(PlayerData.oneWayArchive));
        set => orig.SetBool(nameof(PlayerData.oneWayArchive), value);
    }

    public bool defeatedMegaJelly
    {
        get => orig.GetBool(nameof(PlayerData.defeatedMegaJelly));
        set => orig.SetBool(nameof(PlayerData.defeatedMegaJelly), value);
    }

    public bool summonedMonomon
    {
        get => orig.GetBool(nameof(PlayerData.summonedMonomon));
        set => orig.SetBool(nameof(PlayerData.summonedMonomon), value);
    }

    public bool sawWoundedQuirrel
    {
        get => orig.GetBool(nameof(PlayerData.sawWoundedQuirrel));
        set => orig.SetBool(nameof(PlayerData.sawWoundedQuirrel), value);
    }

    public bool encounteredMegaJelly
    {
        get => orig.GetBool(nameof(PlayerData.encounteredMegaJelly));
        set => orig.SetBool(nameof(PlayerData.encounteredMegaJelly), value);
    }

    public bool defeatedMantisLords
    {
        get => orig.GetBool(nameof(PlayerData.defeatedMantisLords));
        set => orig.SetBool(nameof(PlayerData.defeatedMantisLords), value);
    }

    public bool encounteredGatekeeper
    {
        get => orig.GetBool(nameof(PlayerData.encounteredGatekeeper));
        set => orig.SetBool(nameof(PlayerData.encounteredGatekeeper), value);
    }

    public bool deepnestWall
    {
        get => orig.GetBool(nameof(PlayerData.deepnestWall));
        set => orig.SetBool(nameof(PlayerData.deepnestWall), value);
    }

    public bool queensStationNonDisplay
    {
        get => orig.GetBool(nameof(PlayerData.queensStationNonDisplay));
        set => orig.SetBool(nameof(PlayerData.queensStationNonDisplay), value);
    }

    public bool cityBridge1
    {
        get => orig.GetBool(nameof(PlayerData.cityBridge1));
        set => orig.SetBool(nameof(PlayerData.cityBridge1), value);
    }

    public bool cityBridge2
    {
        get => orig.GetBool(nameof(PlayerData.cityBridge2));
        set => orig.SetBool(nameof(PlayerData.cityBridge2), value);
    }

    public bool cityLift1
    {
        get => orig.GetBool(nameof(PlayerData.cityLift1));
        set => orig.SetBool(nameof(PlayerData.cityLift1), value);
    }

    public bool cityLift1_isUp
    {
        get => orig.GetBool(nameof(PlayerData.cityLift1_isUp));
        set => orig.SetBool(nameof(PlayerData.cityLift1_isUp), value);
    }

    public bool liftArrival
    {
        get => orig.GetBool(nameof(PlayerData.liftArrival));
        set => orig.SetBool(nameof(PlayerData.liftArrival), value);
    }

    public bool openedMageDoor
    {
        get => orig.GetBool(nameof(PlayerData.openedMageDoor));
        set => orig.SetBool(nameof(PlayerData.openedMageDoor), value);
    }

    public bool openedMageDoor_v2
    {
        get => orig.GetBool(nameof(PlayerData.openedMageDoor_v2));
        set => orig.SetBool(nameof(PlayerData.openedMageDoor_v2), value);
    }

    public bool brokenMageWindow
    {
        get => orig.GetBool(nameof(PlayerData.brokenMageWindow));
        set => orig.SetBool(nameof(PlayerData.brokenMageWindow), value);
    }

    public bool brokenMageWindowGlass
    {
        get => orig.GetBool(nameof(PlayerData.brokenMageWindowGlass));
        set => orig.SetBool(nameof(PlayerData.brokenMageWindowGlass), value);
    }

    public bool mageLordEncountered
    {
        get => orig.GetBool(nameof(PlayerData.mageLordEncountered));
        set => orig.SetBool(nameof(PlayerData.mageLordEncountered), value);
    }

    public bool mageLordEncountered_2
    {
        get => orig.GetBool(nameof(PlayerData.mageLordEncountered_2));
        set => orig.SetBool(nameof(PlayerData.mageLordEncountered_2), value);
    }

    public bool mageLordDefeated
    {
        get => orig.GetBool(nameof(PlayerData.mageLordDefeated));
        set => orig.SetBool(nameof(PlayerData.mageLordDefeated), value);
    }

    public bool ruins1_5_tripleDoor
    {
        get => orig.GetBool(nameof(PlayerData.ruins1_5_tripleDoor));
        set => orig.SetBool(nameof(PlayerData.ruins1_5_tripleDoor), value);
    }

    public bool openedCityGate
    {
        get => orig.GetBool(nameof(PlayerData.openedCityGate));
        set => orig.SetBool(nameof(PlayerData.openedCityGate), value);
    }

    public bool cityGateClosed
    {
        get => orig.GetBool(nameof(PlayerData.cityGateClosed));
        set => orig.SetBool(nameof(PlayerData.cityGateClosed), value);
    }

    public bool bathHouseOpened
    {
        get => orig.GetBool(nameof(PlayerData.bathHouseOpened));
        set => orig.SetBool(nameof(PlayerData.bathHouseOpened), value);
    }

    public bool bathHouseWall
    {
        get => orig.GetBool(nameof(PlayerData.bathHouseWall));
        set => orig.SetBool(nameof(PlayerData.bathHouseWall), value);
    }

    public bool cityLift2
    {
        get => orig.GetBool(nameof(PlayerData.cityLift2));
        set => orig.SetBool(nameof(PlayerData.cityLift2), value);
    }

    public bool cityLift2_isUp
    {
        get => orig.GetBool(nameof(PlayerData.cityLift2_isUp));
        set => orig.SetBool(nameof(PlayerData.cityLift2_isUp), value);
    }

    public bool city2_sewerDoor
    {
        get => orig.GetBool(nameof(PlayerData.city2_sewerDoor));
        set => orig.SetBool(nameof(PlayerData.city2_sewerDoor), value);
    }

    public bool openedLoveDoor
    {
        get => orig.GetBool(nameof(PlayerData.openedLoveDoor));
        set => orig.SetBool(nameof(PlayerData.openedLoveDoor), value);
    }

    public bool watcherChandelier
    {
        get => orig.GetBool(nameof(PlayerData.watcherChandelier));
        set => orig.SetBool(nameof(PlayerData.watcherChandelier), value);
    }

    public bool completedQuakeArea
    {
        get => orig.GetBool(nameof(PlayerData.completedQuakeArea));
        set => orig.SetBool(nameof(PlayerData.completedQuakeArea), value);
    }

    public bool kingsStationNonDisplay
    {
        get => orig.GetBool(nameof(PlayerData.kingsStationNonDisplay));
        set => orig.SetBool(nameof(PlayerData.kingsStationNonDisplay), value);
    }

    public bool tollBenchCity
    {
        get => orig.GetBool(nameof(PlayerData.tollBenchCity));
        set => orig.SetBool(nameof(PlayerData.tollBenchCity), value);
    }

    public bool waterwaysGate
    {
        get => orig.GetBool(nameof(PlayerData.waterwaysGate));
        set => orig.SetBool(nameof(PlayerData.waterwaysGate), value);
    }

    public bool defeatedDungDefender
    {
        get => orig.GetBool(nameof(PlayerData.defeatedDungDefender));
        set => orig.SetBool(nameof(PlayerData.defeatedDungDefender), value);
    }

    public bool dungDefenderEncounterReady
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderEncounterReady));
        set => orig.SetBool(nameof(PlayerData.dungDefenderEncounterReady), value);
    }

    public bool flukeMotherEncountered
    {
        get => orig.GetBool(nameof(PlayerData.flukeMotherEncountered));
        set => orig.SetBool(nameof(PlayerData.flukeMotherEncountered), value);
    }

    public bool flukeMotherDefeated
    {
        get => orig.GetBool(nameof(PlayerData.flukeMotherDefeated));
        set => orig.SetBool(nameof(PlayerData.flukeMotherDefeated), value);
    }

    public bool openedWaterwaysManhole
    {
        get => orig.GetBool(nameof(PlayerData.openedWaterwaysManhole));
        set => orig.SetBool(nameof(PlayerData.openedWaterwaysManhole), value);
    }

    public bool waterwaysAcidDrained
    {
        get => orig.GetBool(nameof(PlayerData.waterwaysAcidDrained));
        set => orig.SetBool(nameof(PlayerData.waterwaysAcidDrained), value);
    }

    public bool dungDefenderWallBroken
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderWallBroken));
        set => orig.SetBool(nameof(PlayerData.dungDefenderWallBroken), value);
    }

    public bool dungDefenderSleeping
    {
        get => orig.GetBool(nameof(PlayerData.dungDefenderSleeping));
        set => orig.SetBool(nameof(PlayerData.dungDefenderSleeping), value);
    }

    public bool defeatedMegaBeamMiner
    {
        get => orig.GetBool(nameof(PlayerData.defeatedMegaBeamMiner));
        set => orig.SetBool(nameof(PlayerData.defeatedMegaBeamMiner), value);
    }

    public bool defeatedMegaBeamMiner2
    {
        get => orig.GetBool(nameof(PlayerData.defeatedMegaBeamMiner2));
        set => orig.SetBool(nameof(PlayerData.defeatedMegaBeamMiner2), value);
    }

    public bool brokeMinersWall
    {
        get => orig.GetBool(nameof(PlayerData.brokeMinersWall));
        set => orig.SetBool(nameof(PlayerData.brokeMinersWall), value);
    }

    public bool encounteredMimicSpider
    {
        get => orig.GetBool(nameof(PlayerData.encounteredMimicSpider));
        set => orig.SetBool(nameof(PlayerData.encounteredMimicSpider), value);
    }

    public bool steppedBeyondBridge
    {
        get => orig.GetBool(nameof(PlayerData.steppedBeyondBridge));
        set => orig.SetBool(nameof(PlayerData.steppedBeyondBridge), value);
    }

    public bool deepnestBridgeCollapsed
    {
        get => orig.GetBool(nameof(PlayerData.deepnestBridgeCollapsed));
        set => orig.SetBool(nameof(PlayerData.deepnestBridgeCollapsed), value);
    }

    public bool spiderCapture
    {
        get => orig.GetBool(nameof(PlayerData.spiderCapture));
        set => orig.SetBool(nameof(PlayerData.spiderCapture), value);
    }

    public bool deepnest26b_switch
    {
        get => orig.GetBool(nameof(PlayerData.deepnest26b_switch));
        set => orig.SetBool(nameof(PlayerData.deepnest26b_switch), value);
    }

    public bool openedRestingGrounds02
    {
        get => orig.GetBool(nameof(PlayerData.openedRestingGrounds02));
        set => orig.SetBool(nameof(PlayerData.openedRestingGrounds02), value);
    }

    public bool restingGroundsCryptWall
    {
        get => orig.GetBool(nameof(PlayerData.restingGroundsCryptWall));
        set => orig.SetBool(nameof(PlayerData.restingGroundsCryptWall), value);
    }

    public bool dreamNailConvo
    {
        get => orig.GetBool(nameof(PlayerData.dreamNailConvo));
        set => orig.SetBool(nameof(PlayerData.dreamNailConvo), value);
    }

    public int gladeGhostsKilled
    {
        get => orig.GetInt(nameof(PlayerData.gladeGhostsKilled));
        set => orig.SetInt(nameof(PlayerData.gladeGhostsKilled), value);
    }

    public bool openedGardensStagStation
    {
        get => orig.GetBool(nameof(PlayerData.openedGardensStagStation));
        set => orig.SetBool(nameof(PlayerData.openedGardensStagStation), value);
    }

    public bool extendedGramophone
    {
        get => orig.GetBool(nameof(PlayerData.extendedGramophone));
        set => orig.SetBool(nameof(PlayerData.extendedGramophone), value);
    }

    public bool tollBenchQueensGardens
    {
        get => orig.GetBool(nameof(PlayerData.tollBenchQueensGardens));
        set => orig.SetBool(nameof(PlayerData.tollBenchQueensGardens), value);
    }

    public bool blizzardEnded
    {
        get => orig.GetBool(nameof(PlayerData.blizzardEnded));
        set => orig.SetBool(nameof(PlayerData.blizzardEnded), value);
    }

    public bool encounteredHornet
    {
        get => orig.GetBool(nameof(PlayerData.encounteredHornet));
        set => orig.SetBool(nameof(PlayerData.encounteredHornet), value);
    }

    public bool savedByHornet
    {
        get => orig.GetBool(nameof(PlayerData.savedByHornet));
        set => orig.SetBool(nameof(PlayerData.savedByHornet), value);
    }

    public bool outskirtsWall
    {
        get => orig.GetBool(nameof(PlayerData.outskirtsWall));
        set => orig.SetBool(nameof(PlayerData.outskirtsWall), value);
    }

    public bool abyssGateOpened
    {
        get => orig.GetBool(nameof(PlayerData.abyssGateOpened));
        set => orig.SetBool(nameof(PlayerData.abyssGateOpened), value);
    }

    public bool abyssLighthouse
    {
        get => orig.GetBool(nameof(PlayerData.abyssLighthouse));
        set => orig.SetBool(nameof(PlayerData.abyssLighthouse), value);
    }

    public bool blueVineDoor
    {
        get => orig.GetBool(nameof(PlayerData.blueVineDoor));
        set => orig.SetBool(nameof(PlayerData.blueVineDoor), value);
    }

    public bool gotShadeCharm
    {
        get => orig.GetBool(nameof(PlayerData.gotShadeCharm));
        set => orig.SetBool(nameof(PlayerData.gotShadeCharm), value);
    }

    public bool tollBenchAbyss
    {
        get => orig.GetBool(nameof(PlayerData.tollBenchAbyss));
        set => orig.SetBool(nameof(PlayerData.tollBenchAbyss), value);
    }

    public int fountainGeo
    {
        get => orig.GetInt(nameof(PlayerData.fountainGeo));
        set => orig.SetInt(nameof(PlayerData.fountainGeo), value);
    }

    public bool fountainVesselSummoned
    {
        get => orig.GetBool(nameof(PlayerData.fountainVesselSummoned));
        set => orig.SetBool(nameof(PlayerData.fountainVesselSummoned), value);
    }

    public bool openedBlackEggPath
    {
        get => orig.GetBool(nameof(PlayerData.openedBlackEggPath));
        set => orig.SetBool(nameof(PlayerData.openedBlackEggPath), value);
    }

    public bool enteredDreamWorld
    {
        get => orig.GetBool(nameof(PlayerData.enteredDreamWorld));
        set => orig.SetBool(nameof(PlayerData.enteredDreamWorld), value);
    }

    public bool duskKnightDefeated
    {
        get => orig.GetBool(nameof(PlayerData.duskKnightDefeated));
        set => orig.SetBool(nameof(PlayerData.duskKnightDefeated), value);
    }

    public bool whitePalaceOrb_1
    {
        get => orig.GetBool(nameof(PlayerData.whitePalaceOrb_1));
        set => orig.SetBool(nameof(PlayerData.whitePalaceOrb_1), value);
    }

    public bool whitePalaceOrb_2
    {
        get => orig.GetBool(nameof(PlayerData.whitePalaceOrb_2));
        set => orig.SetBool(nameof(PlayerData.whitePalaceOrb_2), value);
    }

    public bool whitePalaceOrb_3
    {
        get => orig.GetBool(nameof(PlayerData.whitePalaceOrb_3));
        set => orig.SetBool(nameof(PlayerData.whitePalaceOrb_3), value);
    }

    public bool whitePalace05_lever
    {
        get => orig.GetBool(nameof(PlayerData.whitePalace05_lever));
        set => orig.SetBool(nameof(PlayerData.whitePalace05_lever), value);
    }

    public bool whitePalaceMidWarp
    {
        get => orig.GetBool(nameof(PlayerData.whitePalaceMidWarp));
        set => orig.SetBool(nameof(PlayerData.whitePalaceMidWarp), value);
    }

    public bool whitePalaceSecretRoomVisited
    {
        get => orig.GetBool(nameof(PlayerData.whitePalaceSecretRoomVisited));
        set => orig.SetBool(nameof(PlayerData.whitePalaceSecretRoomVisited), value);
    }

    public bool tramOpenedDeepnest
    {
        get => orig.GetBool(nameof(PlayerData.tramOpenedDeepnest));
        set => orig.SetBool(nameof(PlayerData.tramOpenedDeepnest), value);
    }

    public bool tramOpenedCrossroads
    {
        get => orig.GetBool(nameof(PlayerData.tramOpenedCrossroads));
        set => orig.SetBool(nameof(PlayerData.tramOpenedCrossroads), value);
    }

    public bool openedBlackEggDoor
    {
        get => orig.GetBool(nameof(PlayerData.openedBlackEggDoor));
        set => orig.SetBool(nameof(PlayerData.openedBlackEggDoor), value);
    }

    public bool unchainedHollowKnight
    {
        get => orig.GetBool(nameof(PlayerData.unchainedHollowKnight));
        set => orig.SetBool(nameof(PlayerData.unchainedHollowKnight), value);
    }

    public int flamesCollected
    {
        get => orig.GetInt(nameof(PlayerData.flamesCollected));
        set => orig.SetInt(nameof(PlayerData.flamesCollected), value);
    }

    public int flamesRequired
    {
        get => orig.GetInt(nameof(PlayerData.flamesRequired));
        set => orig.SetInt(nameof(PlayerData.flamesRequired), value);
    }

    public bool nightmareLanternAppeared
    {
        get => orig.GetBool(nameof(PlayerData.nightmareLanternAppeared));
        set => orig.SetBool(nameof(PlayerData.nightmareLanternAppeared), value);
    }

    public bool nightmareLanternLit
    {
        get => orig.GetBool(nameof(PlayerData.nightmareLanternLit));
        set => orig.SetBool(nameof(PlayerData.nightmareLanternLit), value);
    }

    public bool troupeInTown
    {
        get => orig.GetBool(nameof(PlayerData.troupeInTown));
        set => orig.SetBool(nameof(PlayerData.troupeInTown), value);
    }

    public bool divineInTown
    {
        get => orig.GetBool(nameof(PlayerData.divineInTown));
        set => orig.SetBool(nameof(PlayerData.divineInTown), value);
    }

    public int grimmChildLevel
    {
        get => orig.GetInt(nameof(PlayerData.grimmChildLevel));
        set => orig.SetInt(nameof(PlayerData.grimmChildLevel), value);
    }

    public bool elderbugConvoGrimm
    {
        get => orig.GetBool(nameof(PlayerData.elderbugConvoGrimm));
        set => orig.SetBool(nameof(PlayerData.elderbugConvoGrimm), value);
    }

    public bool slyConvoGrimm
    {
        get => orig.GetBool(nameof(PlayerData.slyConvoGrimm));
        set => orig.SetBool(nameof(PlayerData.slyConvoGrimm), value);
    }

    public bool iseldaConvoGrimm
    {
        get => orig.GetBool(nameof(PlayerData.iseldaConvoGrimm));
        set => orig.SetBool(nameof(PlayerData.iseldaConvoGrimm), value);
    }

    public bool midwifeWeaverlingConvo
    {
        get => orig.GetBool(nameof(PlayerData.midwifeWeaverlingConvo));
        set => orig.SetBool(nameof(PlayerData.midwifeWeaverlingConvo), value);
    }

    public bool metGrimm
    {
        get => orig.GetBool(nameof(PlayerData.metGrimm));
        set => orig.SetBool(nameof(PlayerData.metGrimm), value);
    }

    public bool foughtGrimm
    {
        get => orig.GetBool(nameof(PlayerData.foughtGrimm));
        set => orig.SetBool(nameof(PlayerData.foughtGrimm), value);
    }

    public bool metBrum
    {
        get => orig.GetBool(nameof(PlayerData.metBrum));
        set => orig.SetBool(nameof(PlayerData.metBrum), value);
    }

    public bool defeatedNightmareGrimm
    {
        get => orig.GetBool(nameof(PlayerData.defeatedNightmareGrimm));
        set => orig.SetBool(nameof(PlayerData.defeatedNightmareGrimm), value);
    }

    public bool grimmchildAwoken
    {
        get => orig.GetBool(nameof(PlayerData.grimmchildAwoken));
        set => orig.SetBool(nameof(PlayerData.grimmchildAwoken), value);
    }

    public bool gotBrummsFlame
    {
        get => orig.GetBool(nameof(PlayerData.gotBrummsFlame));
        set => orig.SetBool(nameof(PlayerData.gotBrummsFlame), value);
    }

    public bool brummBrokeBrazier
    {
        get => orig.GetBool(nameof(PlayerData.brummBrokeBrazier));
        set => orig.SetBool(nameof(PlayerData.brummBrokeBrazier), value);
    }

    public bool destroyedNightmareLantern
    {
        get => orig.GetBool(nameof(PlayerData.destroyedNightmareLantern));
        set => orig.SetBool(nameof(PlayerData.destroyedNightmareLantern), value);
    }

    public bool gotGrimmNotch
    {
        get => orig.GetBool(nameof(PlayerData.gotGrimmNotch));
        set => orig.SetBool(nameof(PlayerData.gotGrimmNotch), value);
    }

    public bool nymmInTown
    {
        get => orig.GetBool(nameof(PlayerData.nymmInTown));
        set => orig.SetBool(nameof(PlayerData.nymmInTown), value);
    }

    public bool nymmSpoken
    {
        get => orig.GetBool(nameof(PlayerData.nymmSpoken));
        set => orig.SetBool(nameof(PlayerData.nymmSpoken), value);
    }

    public bool nymmCharmConvo
    {
        get => orig.GetBool(nameof(PlayerData.nymmCharmConvo));
        set => orig.SetBool(nameof(PlayerData.nymmCharmConvo), value);
    }

    public bool nymmFinalConvo
    {
        get => orig.GetBool(nameof(PlayerData.nymmFinalConvo));
        set => orig.SetBool(nameof(PlayerData.nymmFinalConvo), value);
    }

    public bool elderbugNymmConvo
    {
        get => orig.GetBool(nameof(PlayerData.elderbugNymmConvo));
        set => orig.SetBool(nameof(PlayerData.elderbugNymmConvo), value);
    }

    public bool slyNymmConvo
    {
        get => orig.GetBool(nameof(PlayerData.slyNymmConvo));
        set => orig.SetBool(nameof(PlayerData.slyNymmConvo), value);
    }

    public bool iseldaNymmConvo
    {
        get => orig.GetBool(nameof(PlayerData.iseldaNymmConvo));
        set => orig.SetBool(nameof(PlayerData.iseldaNymmConvo), value);
    }

    public bool nymmMissedEggOpen
    {
        get => orig.GetBool(nameof(PlayerData.nymmMissedEggOpen));
        set => orig.SetBool(nameof(PlayerData.nymmMissedEggOpen), value);
    }

    public bool elderbugTroupeLeftConvo
    {
        get => orig.GetBool(nameof(PlayerData.elderbugTroupeLeftConvo));
        set => orig.SetBool(nameof(PlayerData.elderbugTroupeLeftConvo), value);
    }

    public bool elderbugBrettaLeft
    {
        get => orig.GetBool(nameof(PlayerData.elderbugBrettaLeft));
        set => orig.SetBool(nameof(PlayerData.elderbugBrettaLeft), value);
    }

    public bool jijiGrimmConvo
    {
        get => orig.GetBool(nameof(PlayerData.jijiGrimmConvo));
        set => orig.SetBool(nameof(PlayerData.jijiGrimmConvo), value);
    }

    public bool metDivine
    {
        get => orig.GetBool(nameof(PlayerData.metDivine));
        set => orig.SetBool(nameof(PlayerData.metDivine), value);
    }

    public bool divineFinalConvo
    {
        get => orig.GetBool(nameof(PlayerData.divineFinalConvo));
        set => orig.SetBool(nameof(PlayerData.divineFinalConvo), value);
    }

    public bool gaveFragileHeart
    {
        get => orig.GetBool(nameof(PlayerData.gaveFragileHeart));
        set => orig.SetBool(nameof(PlayerData.gaveFragileHeart), value);
    }

    public bool gaveFragileGreed
    {
        get => orig.GetBool(nameof(PlayerData.gaveFragileGreed));
        set => orig.SetBool(nameof(PlayerData.gaveFragileGreed), value);
    }

    public bool gaveFragileStrength
    {
        get => orig.GetBool(nameof(PlayerData.gaveFragileStrength));
        set => orig.SetBool(nameof(PlayerData.gaveFragileStrength), value);
    }

    public int divineEatenConvos
    {
        get => orig.GetInt(nameof(PlayerData.divineEatenConvos));
        set => orig.SetInt(nameof(PlayerData.divineEatenConvos), value);
    }

    public bool pooedFragileHeart
    {
        get => orig.GetBool(nameof(PlayerData.pooedFragileHeart));
        set => orig.SetBool(nameof(PlayerData.pooedFragileHeart), value);
    }

    public bool pooedFragileGreed
    {
        get => orig.GetBool(nameof(PlayerData.pooedFragileGreed));
        set => orig.SetBool(nameof(PlayerData.pooedFragileGreed), value);
    }

    public bool pooedFragileStrength
    {
        get => orig.GetBool(nameof(PlayerData.pooedFragileStrength));
        set => orig.SetBool(nameof(PlayerData.pooedFragileStrength), value);
    }

    public float completionPercentage
    {
        get => orig.GetFloat(nameof(PlayerData.completionPercentage));
        set => orig.SetFloat(nameof(PlayerData.completionPercentage), value);
    }

    public bool disablePause
    {
        get => orig.GetBool(nameof(PlayerData.disablePause));
        set => orig.SetBool(nameof(PlayerData.disablePause), value);
    }

    public bool backerCredits
    {
        get => orig.GetBool(nameof(PlayerData.backerCredits));
        set => orig.SetBool(nameof(PlayerData.backerCredits), value);
    }

    public bool unlockedCompletionRate
    {
        get => orig.GetBool(nameof(PlayerData.unlockedCompletionRate));
        set => orig.SetBool(nameof(PlayerData.unlockedCompletionRate), value);
    }

    public int mapKeyPref
    {
        get => orig.GetInt(nameof(PlayerData.mapKeyPref));
        set => orig.SetInt(nameof(PlayerData.mapKeyPref), value);
    }

    public List<string> playerStory
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.playerStory));
        set => orig.SetVariable(nameof(PlayerData.playerStory), value);
    }

    public string playerStoryOutput
    {
        get => orig.GetString(nameof(PlayerData.playerStoryOutput));
        set => orig.SetString(nameof(PlayerData.playerStoryOutput), value);
    }

    public bool betaEnd
    {
        get => orig.GetBool(nameof(PlayerData.betaEnd));
        set => orig.SetBool(nameof(PlayerData.betaEnd), value);
    }

    public bool newDatTraitorLord
    {
        get => orig.GetBool(nameof(PlayerData.newDatTraitorLord));
        set => orig.SetBool(nameof(PlayerData.newDatTraitorLord), value);
    }

    public string bossReturnEntryGate
    {
        get => orig.GetString(nameof(PlayerData.bossReturnEntryGate));
        set => orig.SetString(nameof(PlayerData.bossReturnEntryGate), value);
    }

    public BossSequenceDoor.Completion bossDoorStateTier1
    {
        get => orig.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier1));
        set => orig.SetVariable(nameof(PlayerData.bossDoorStateTier1),
            value);
    }

    public BossSequenceDoor.Completion bossDoorStateTier2
    {
        get => orig.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier2));
        set => orig.SetVariable(nameof(PlayerData.bossDoorStateTier2),
            value);
    }

    public BossSequenceDoor.Completion bossDoorStateTier3
    {
        get => orig.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier3));
        set => orig.SetVariable(nameof(PlayerData.bossDoorStateTier3),
            value);
    }

    public BossSequenceDoor.Completion bossDoorStateTier4
    {
        get => orig.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier4));
        set => orig.SetVariable(nameof(PlayerData.bossDoorStateTier4),
            value);
    }

    public BossSequenceDoor.Completion bossDoorStateTier5
    {
        get => orig.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier5));
        set => orig.SetVariable(nameof(PlayerData.bossDoorStateTier5),
            value);
    }

    public int bossStatueTargetLevel
    {
        get => orig.GetInt(nameof(PlayerData.bossStatueTargetLevel));
        set => orig.SetInt(nameof(PlayerData.bossStatueTargetLevel), value);
    }

    public string currentBossStatueCompletionKey
    {
        get => orig.GetString(nameof(PlayerData.currentBossStatueCompletionKey));
        set => orig.SetString(nameof(PlayerData.currentBossStatueCompletionKey), value);
    }

    public BossStatue.Completion statueStateGruzMother
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGruzMother));
        set => orig.SetVariable(nameof(PlayerData.statueStateGruzMother),
            value);
    }

    public BossStatue.Completion statueStateVengefly
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateVengefly));
        set =>
            orig.SetVariable(nameof(PlayerData.statueStateVengefly), value);
    }

    public BossStatue.Completion statueStateBroodingMawlek
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBroodingMawlek));
        set => orig.SetVariable(nameof(PlayerData.statueStateBroodingMawlek),
            value);
    }

    public BossStatue.Completion statueStateFalseKnight
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFalseKnight));
        set => orig.SetVariable(nameof(PlayerData.statueStateFalseKnight),
            value);
    }

    public BossStatue.Completion statueStateFailedChampion
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFailedChampion));
        set => orig.SetVariable(nameof(PlayerData.statueStateFailedChampion),
            value);
    }

    public BossStatue.Completion statueStateHornet1
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet1));
        set => orig.SetVariable(nameof(PlayerData.statueStateHornet1), value);
    }

    public BossStatue.Completion statueStateHornet2
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet2));
        set => orig.SetVariable(nameof(PlayerData.statueStateHornet2), value);
    }

    public BossStatue.Completion statueStateMegaMossCharger
    {
        get =>
            orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMegaMossCharger));
        set => orig.SetVariable(nameof(PlayerData.statueStateMegaMossCharger),
            value);
    }

    public BossStatue.Completion statueStateMantisLords
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMantisLords));
        set => orig.SetVariable(nameof(PlayerData.statueStateMantisLords),
            value);
    }

    public BossStatue.Completion statueStateOblobbles
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateOblobbles));
        set => orig.SetVariable(nameof(PlayerData.statueStateOblobbles),
            value);
    }

    public BossStatue.Completion statueStateGreyPrince
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGreyPrince));
        set => orig.SetVariable(nameof(PlayerData.statueStateGreyPrince),
            value);
    }

    public BossStatue.Completion statueStateBrokenVessel
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBrokenVessel));
        set => orig.SetVariable(nameof(PlayerData.statueStateBrokenVessel),
            value);
    }

    public BossStatue.Completion statueStateLostKin
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateLostKin));
        set => orig.SetVariable(nameof(PlayerData.statueStateLostKin), value);
    }

    public BossStatue.Completion statueStateNosk
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNosk));
        set => orig.SetVariable(nameof(PlayerData.statueStateNosk), value);
    }

    public BossStatue.Completion statueStateFlukemarm
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFlukemarm));
        set => orig.SetVariable(nameof(PlayerData.statueStateFlukemarm),
            value);
    }

    public BossStatue.Completion statueStateCollector
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCollector));
        set => orig.SetVariable(nameof(PlayerData.statueStateCollector),
            value);
    }

    public BossStatue.Completion statueStateWatcherKnights
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWatcherKnights));
        set => orig.SetVariable(nameof(PlayerData.statueStateWatcherKnights),
            value);
    }

    public BossStatue.Completion statueStateSoulMaster
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulMaster));
        set => orig.SetVariable(nameof(PlayerData.statueStateSoulMaster),
            value);
    }

    public BossStatue.Completion statueStateSoulTyrant
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulTyrant));
        set => orig.SetVariable(nameof(PlayerData.statueStateSoulTyrant),
            value);
    }

    public BossStatue.Completion statueStateGodTamer
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGodTamer));
        set =>
            orig.SetVariable(nameof(PlayerData.statueStateGodTamer), value);
    }

    public BossStatue.Completion statueStateCrystalGuardian1
    {
        get => orig.GetVariable<BossStatue.Completion>(
            nameof(PlayerData.statueStateCrystalGuardian1));
        set => orig.SetVariable(
            nameof(PlayerData.statueStateCrystalGuardian1), value);
    }

    public BossStatue.Completion statueStateCrystalGuardian2
    {
        get => orig.GetVariable<BossStatue.Completion>(
            nameof(PlayerData.statueStateCrystalGuardian2));
        set => orig.SetVariable(
            nameof(PlayerData.statueStateCrystalGuardian2), value);
    }

    public BossStatue.Completion statueStateUumuu
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateUumuu));
        set => orig.SetVariable(nameof(PlayerData.statueStateUumuu), value);
    }

    public BossStatue.Completion statueStateDungDefender
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateDungDefender));
        set => orig.SetVariable(nameof(PlayerData.statueStateDungDefender),
            value);
    }

    public BossStatue.Completion statueStateWhiteDefender
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWhiteDefender));
        set => orig.SetVariable(nameof(PlayerData.statueStateWhiteDefender),
            value);
    }

    public BossStatue.Completion statueStateHiveKnight
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHiveKnight));
        set => orig.SetVariable(nameof(PlayerData.statueStateHiveKnight),
            value);
    }

    public BossStatue.Completion statueStateTraitorLord
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateTraitorLord));
        set => orig.SetVariable(nameof(PlayerData.statueStateTraitorLord),
            value);
    }

    public BossStatue.Completion statueStateGrimm
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGrimm));
        set => orig.SetVariable(nameof(PlayerData.statueStateGrimm), value);
    }

    public BossStatue.Completion statueStateNightmareGrimm
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNightmareGrimm));
        set => orig.SetVariable(nameof(PlayerData.statueStateNightmareGrimm),
            value);
    }

    public BossStatue.Completion statueStateHollowKnight
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHollowKnight));
        set => orig.SetVariable(nameof(PlayerData.statueStateHollowKnight),
            value);
    }

    public BossStatue.Completion statueStateElderHu
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateElderHu));
        set => orig.SetVariable(nameof(PlayerData.statueStateElderHu), value);
    }

    public BossStatue.Completion statueStateGalien
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGalien));
        set => orig.SetVariable(nameof(PlayerData.statueStateGalien), value);
    }

    public BossStatue.Completion statueStateMarkoth
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarkoth));
        set => orig.SetVariable(nameof(PlayerData.statueStateMarkoth), value);
    }

    public BossStatue.Completion statueStateMarmu
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarmu));
        set => orig.SetVariable(nameof(PlayerData.statueStateMarmu), value);
    }

    public BossStatue.Completion statueStateNoEyes
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoEyes));
        set => orig.SetVariable(nameof(PlayerData.statueStateNoEyes), value);
    }

    public BossStatue.Completion statueStateXero
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateXero));
        set => orig.SetVariable(nameof(PlayerData.statueStateXero), value);
    }

    public BossStatue.Completion statueStateGorb
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGorb));
        set => orig.SetVariable(nameof(PlayerData.statueStateGorb), value);
    }

    public BossStatue.Completion statueStateRadiance
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateRadiance));
        set =>
            orig.SetVariable(nameof(PlayerData.statueStateRadiance), value);
    }

    public BossStatue.Completion statueStateSly
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSly));
        set => orig.SetVariable(nameof(PlayerData.statueStateSly), value);
    }

    public BossStatue.Completion statueStateNailmasters
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNailmasters));
        set => orig.SetVariable(nameof(PlayerData.statueStateNailmasters),
            value);
    }

    public BossStatue.Completion statueStateMageKnight
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMageKnight));
        set => orig.SetVariable(nameof(PlayerData.statueStateMageKnight),
            value);
    }

    public BossStatue.Completion statueStatePaintmaster
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStatePaintmaster));
        set => orig.SetVariable(nameof(PlayerData.statueStatePaintmaster),
            value);
    }

    public BossStatue.Completion statueStateZote
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateZote));
        set => orig.SetVariable(nameof(PlayerData.statueStateZote), value);
    }

    public BossStatue.Completion statueStateNoskHornet
    {
        get => orig.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoskHornet));
        set => orig.SetVariable(nameof(PlayerData.statueStateNoskHornet),
            value);
    }

    public BossStatue.Completion statueStateMantisLordsExtra
    {
        get => orig.GetVariable<BossStatue.Completion>(
            nameof(PlayerData.statueStateMantisLordsExtra));
        set => orig.SetVariable(
            nameof(PlayerData.statueStateMantisLordsExtra), value);
    }

    public bool godseekerUnlocked
    {
        get => orig.GetBool(nameof(PlayerData.godseekerUnlocked));
        set => orig.SetBool(nameof(PlayerData.godseekerUnlocked), value);
    }

    public BossSequenceController.BossSequenceData currentBossSequence
    {
        get => orig.GetVariable<BossSequenceController.BossSequenceData>(
            nameof(PlayerData.currentBossSequence));
        set => orig.SetVariable(
            nameof(PlayerData.currentBossSequence), value);
    }

    public bool bossRushMode
    {
        get => orig.GetBool(nameof(PlayerData.bossRushMode));
        set => orig.SetBool(nameof(PlayerData.bossRushMode), value);
    }

    public bool bossDoorCageUnlocked
    {
        get => orig.GetBool(nameof(PlayerData.bossDoorCageUnlocked));
        set => orig.SetBool(nameof(PlayerData.bossDoorCageUnlocked), value);
    }

    public bool blueRoomDoorUnlocked
    {
        get => orig.GetBool(nameof(PlayerData.blueRoomDoorUnlocked));
        set => orig.SetBool(nameof(PlayerData.blueRoomDoorUnlocked), value);
    }

    public bool blueRoomActivated
    {
        get => orig.GetBool(nameof(PlayerData.blueRoomActivated));
        set => orig.SetBool(nameof(PlayerData.blueRoomActivated), value);
    }

    public bool finalBossDoorUnlocked
    {
        get => orig.GetBool(nameof(PlayerData.finalBossDoorUnlocked));
        set => orig.SetBool(nameof(PlayerData.finalBossDoorUnlocked), value);
    }

    public bool hasGodfinder
    {
        get => orig.GetBool(nameof(PlayerData.hasGodfinder));
        set => orig.SetBool(nameof(PlayerData.hasGodfinder), value);
    }

    public bool unlockedNewBossStatue
    {
        get => orig.GetBool(nameof(PlayerData.unlockedNewBossStatue));
        set => orig.SetBool(nameof(PlayerData.unlockedNewBossStatue), value);
    }

    public bool scaredFlukeHermitEncountered
    {
        get => orig.GetBool(nameof(PlayerData.scaredFlukeHermitEncountered));
        set => orig.SetBool(nameof(PlayerData.scaredFlukeHermitEncountered), value);
    }

    public bool scaredFlukeHermitReturned
    {
        get => orig.GetBool(nameof(PlayerData.scaredFlukeHermitReturned));
        set => orig.SetBool(nameof(PlayerData.scaredFlukeHermitReturned), value);
    }

    public bool enteredGGAtrium
    {
        get => orig.GetBool(nameof(PlayerData.enteredGGAtrium));
        set => orig.SetBool(nameof(PlayerData.enteredGGAtrium), value);
    }

    public bool extraFlowerAppear
    {
        get => orig.GetBool(nameof(PlayerData.extraFlowerAppear));
        set => orig.SetBool(nameof(PlayerData.extraFlowerAppear), value);
    }

    public bool givenGodseekerFlower
    {
        get => orig.GetBool(nameof(PlayerData.givenGodseekerFlower));
        set => orig.SetBool(nameof(PlayerData.givenGodseekerFlower), value);
    }

    public bool givenOroFlower
    {
        get => orig.GetBool(nameof(PlayerData.givenOroFlower));
        set => orig.SetBool(nameof(PlayerData.givenOroFlower), value);
    }

    public bool givenWhiteLadyFlower
    {
        get => orig.GetBool(nameof(PlayerData.givenWhiteLadyFlower));
        set => orig.SetBool(nameof(PlayerData.givenWhiteLadyFlower), value);
    }

    public bool givenEmilitiaFlower
    {
        get => orig.GetBool(nameof(PlayerData.givenEmilitiaFlower));
        set => orig.SetBool(nameof(PlayerData.givenEmilitiaFlower), value);
    }

    public List<string> unlockedBossScenes
    {
        get => orig.GetVariable<List<string>>(nameof(PlayerData.unlockedBossScenes));
        set => orig.SetVariable(nameof(PlayerData.unlockedBossScenes), value);
    }

    public bool queuedGodfinderIcon
    {
        get => orig.GetBool(nameof(PlayerData.queuedGodfinderIcon));
        set => orig.SetBool(nameof(PlayerData.queuedGodfinderIcon), value);
    }

    public bool godseekerSpokenAwake
    {
        get => orig.GetBool(nameof(PlayerData.godseekerSpokenAwake));
        set => orig.SetBool(nameof(PlayerData.godseekerSpokenAwake), value);
    }

    public bool nailsmithCorpseAppeared
    {
        get => orig.GetBool(nameof(PlayerData.nailsmithCorpseAppeared));
        set => orig.SetBool(nameof(PlayerData.nailsmithCorpseAppeared), value);
    }

    public int godseekerWaterwaysSeenState
    {
        get => orig.GetInt(nameof(PlayerData.godseekerWaterwaysSeenState));
        set => orig.SetInt(nameof(PlayerData.godseekerWaterwaysSeenState), value);
    }

    public bool godseekerWaterwaysSpoken1
    {
        get => orig.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken1));
        set => orig.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken1), value);
    }

    public bool godseekerWaterwaysSpoken2
    {
        get => orig.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken2));
        set => orig.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken2), value);
    }

    public bool godseekerWaterwaysSpoken3
    {
        get => orig.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken3));
        set => orig.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken3), value);
    }

    public int bossDoorEntranceTextSeen
    {
        get => orig.GetInt(nameof(PlayerData.bossDoorEntranceTextSeen));
        set => orig.SetInt(nameof(PlayerData.bossDoorEntranceTextSeen), value);
    }

    public bool seenDoor4Finale
    {
        get => orig.GetBool(nameof(PlayerData.seenDoor4Finale));
        set => orig.SetBool(nameof(PlayerData.seenDoor4Finale), value);
    }

    public bool zoteStatueWallBroken
    {
        get => orig.GetBool(nameof(PlayerData.zoteStatueWallBroken));
        set => orig.SetBool(nameof(PlayerData.zoteStatueWallBroken), value);
    }

    public bool seenGGWastes
    {
        get => orig.GetBool(nameof(PlayerData.seenGGWastes));
        set => orig.SetBool(nameof(PlayerData.seenGGWastes), value);
    }

    public bool ordealAchieved
    {
        get => orig.GetBool(nameof(PlayerData.ordealAchieved));
        set => orig.SetBool(nameof(PlayerData.ordealAchieved), value);
    }

    public void SetupNewPlayerData()
    {
        CallMethod();
    }

    public void HasMapForScene(string sceneName)
    {
        CallMethod(new object[] {sceneName});
    }

    public void PrintStory()
    {
        orig.PrintStory();
    }

    public void Reset()
    {
        orig.Reset();
    }

    public bool UpdateGameMap()
    {
        return orig.UpdateGameMap();
    }

    public void CheckAllMaps()
    {
        orig.CheckAllMaps();
    }

    public void SetBool(string boolName, bool value)
    {
        orig.SetBool(boolName, value);
    }

    public void SetInt(string intName, int value)
    {
        orig.SetInt(intName, value);
    }

    public void IncrementInt(string intName)
    {
        orig.IncrementInt(intName);
    }

    public void IntAdd(string intName, int amount)
    {
        orig.IntAdd(intName, amount);
    }

    public void SetFloat(string floatName, float value)
    {
        orig.SetFloat(floatName, value);
    }

    public void DecrementInt(string intName)
    {
        orig.DecrementInt(intName);
    }

    public bool GetBool(string boolName)
    {
        return orig.GetBool(boolName);
    }

    public int GetInt(string intName)
    {
        return orig.GetInt(intName);
    }

    public float GetFloat(string floatName)
    {
        return orig.GetFloat(floatName);
    }

    public string GetString(string stringName)
    {
        return orig.GetString(stringName);
    }

    public void SetString(string stringName, string value)
    {
        orig.SetString(stringName, value);
    }

    public void SetVector3(string vectorName, Vector3 value)
    {
        orig.SetVector3(vectorName, value);
    }

    public Vector3 GetVector3(string vectorName)
    {
        return orig.GetVector3(vectorName);
    }

    public void SetVariable<T>(string fieldName, T value)
    {
        orig.SetVariable(fieldName, value);
    }

    public T GetVariable<T>(string fieldName)
    {
        return orig.GetVariable<T>(fieldName);
    }

    public void AddHealth(int amount)
    {
        orig.AddHealth(amount);
    }

    public void TakeHealth(int amount)
    {
        orig.TakeHealth(amount);
    }

    public void MaxHealth()
    {
        orig.MaxHealth();
    }

    public void ActivateTestingCheats()
    {
        orig.ActivateTestingCheats();
    }

    public void GetAllPowerups()
    {
        orig.GetAllPowerups();
    }

    public void AddToMaxHealth(int amount)
    {
        orig.AddToMaxHealth(amount);
    }

    public void UpdateBlueHealth()
    {
        orig.UpdateBlueHealth();
    }

    public void AddGeo(int amount)
    {
        orig.AddGeo(amount);
    }

    public void TakeGeo(int amount)
    {
        orig.TakeGeo(amount);
    }

    public bool WouldDie(int damage)
    {
        return orig.WouldDie(damage);
    }

    public bool AddMPCharge(int amount)
    {
        return orig.AddMPCharge(amount);
    }

    public void TakeMP(int amount)
    {
        orig.TakeMP(amount);
    }

    public void TakeReserveMP(int amount)
    {
        orig.TakeReserveMP(amount);
    }

    public void ClearMP()
    {
        orig.ClearMP();
    }

    public void AddToMaxMPReserve(int amount)
    {
        orig.AddToMaxMPReserve(amount);
    }

    public void StartSoulLimiter()
    {
        orig.StartSoulLimiter();
    }

    public void EndSoulLimiter()
    {
        orig.EndSoulLimiter();
    }

    public void EquipCharm(int charmNum)
    {
        orig.EquipCharm(charmNum);
    }

    public void UnequipCharm(int charmNum)
    {
        orig.UnequipCharm(charmNum);
    }

    public void CalculateNotchesUsed()
    {
        orig.CalculateNotchesUsed();
    }

    public void SetBenchRespawn(RespawnMarker spawnMarker, string sceneName, int spawnType)
    {
        orig.SetBenchRespawn(spawnMarker, sceneName, spawnType);
    }

    public void SetBenchRespawn(string spawnMarker, string sceneName, bool facingRight)
    {
        orig.SetBenchRespawn(spawnMarker, sceneName, facingRight);
    }

    public void SetBenchRespawn(string spawnMarker, string sceneName, int spawnType, bool facingRight)
    {
        orig.SetBenchRespawn(spawnMarker, sceneName, spawnType, facingRight);
    }

    public void SetHazardRespawn(HazardRespawnMarker location)
    {
        orig.SetHazardRespawn(location);
    }

    public void SetHazardRespawn(Vector3 position, bool facingRight)
    {
        orig.SetHazardRespawn(position, facingRight);
    }

    public void CountGameCompletion()
    {
        orig.CountGameCompletion();
    }

    public void CountCharms()
    {
        orig.CountCharms();
    }

    public void CountJournalEntries()
    {
        orig.CountJournalEntries();
    }

    public void AddGGPlayerDataOverrides()
    {
        orig.AddGGPlayerDataOverrides();
    }

    public void SetBoolSwappedArgs(bool value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetFloatSwappedArgs(float value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetIntSwappedArgs(int value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetStringSwappedArgs(string value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetVector3SwappedArgs(Vector3 value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetVariableSwappedArgs<T>(T value, string name)
    {
        CallMethod(new object[] {value, name});
    }

    public void SetBoolInternal(string boolName, bool value)
    {
        orig.SetBoolInternal(boolName, value);
    }

    public bool GetBoolInternal(string boolName)
    {
        return orig.GetBoolInternal(boolName);
    }

    public void SetIntInternal(string intName, int value)
    {
        orig.SetIntInternal(intName, value);
    }

    public int GetIntInternal(string intName)
    {
        return orig.GetIntInternal(intName);
    }

    public void SetFloatInternal(string floatName, float value)
    {
        orig.SetFloatInternal(floatName, value);
    }

    public float GetFloatInternal(string floatName)
    {
        return orig.GetFloatInternal(floatName);
    }

    public void SetStringInternal(string stringName, string value)
    {
        orig.SetStringInternal(stringName, value);
    }

    public string GetStringInternal(string stringName)
    {
        return orig.GetStringInternal(stringName);
    }

    public void SetVector3Internal(string vector3Name, Vector3 value)
    {
        orig.SetVector3Internal(vector3Name, value);
    }

    public Vector3 GetVector3Internal(string vector3Name)
    {
        return orig.GetVector3Internal(vector3Name);
    }

    public void SetVariableInternal<T>(string variableName, T value)
    {
        orig.SetVariableInternal(variableName, value);
    }

    public T GetVariableInternal<T>(string variableName)
    {
        return orig.GetVariableInternal<T>(variableName);
    }

    public void TakeHealthInternal(int amount)
    {
        CallMethod(new object[] {amount});
    }

    public void orig_UpdateBlueHealth()
    {
        orig.orig_UpdateBlueHealth();
    }

    public void orig_AddHealth(int amount)
    {
        orig.orig_AddHealth(amount);
    }
}