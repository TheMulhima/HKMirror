using Modding.Delegates;

namespace HKMirror.InstanceClasses;

public static class InstanceClassWrapperCreator
{
    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HealthManagerR Reflect(HealthManager instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneR Reflect(BossScene instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceR Reflect(BossSequence instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneControllerR Reflect(BossSceneController instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmDisplayR Reflect(CharmDisplay instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmIconListR Reflect(CharmIconList instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmItemR Reflect(CharmItem instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmUpdateHandlerR Reflect(CharmUpdateHandler instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckGGBossLevelR Reflect(CheckGGBossLevel instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckInvincibilityR Reflect(CheckInvincibility instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageEnemiesR Reflect(DamageEnemies instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageHeroR Reflect(DamageHero instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DashEffectR Reflect(DashEffect instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyBulletR Reflect(EnemyBullet instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameMapR Reflect(GameMap instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroBoxR Reflect(HeroBox instance)
    {
        return new(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneManagerR Reflect(SceneManager instance)
    {
        return new(instance);
    }
}