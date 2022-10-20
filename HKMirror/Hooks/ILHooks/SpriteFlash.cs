namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpriteFlash.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpriteFlash
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpriteFlash.Start += value;
        remove => IL.SpriteFlash.Start -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SpriteFlash.OnDisable += value;
        remove => IL.SpriteFlash.OnDisable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpriteFlash.Update += value;
        remove => IL.SpriteFlash.Update -= value;
    }

    public static event ILContext.Manipulator GeoFlash
    {
        add => IL.SpriteFlash.GeoFlash += value;
        remove => IL.SpriteFlash.GeoFlash -= value;
    }

    public static event ILContext.Manipulator flash
    {
        add => IL.SpriteFlash.flash += value;
        remove => IL.SpriteFlash.flash -= value;
    }

    public static event ILContext.Manipulator CancelFlash
    {
        add => IL.SpriteFlash.CancelFlash += value;
        remove => IL.SpriteFlash.CancelFlash -= value;
    }

    public static event ILContext.Manipulator FlashingSuperDash
    {
        add => IL.SpriteFlash.FlashingSuperDash += value;
        remove => IL.SpriteFlash.FlashingSuperDash -= value;
    }

    public static event ILContext.Manipulator FlashingGhostWounded
    {
        add => IL.SpriteFlash.FlashingGhostWounded += value;
        remove => IL.SpriteFlash.FlashingGhostWounded -= value;
    }

    public static event ILContext.Manipulator FlashingWhiteStay
    {
        add => IL.SpriteFlash.FlashingWhiteStay += value;
        remove => IL.SpriteFlash.FlashingWhiteStay -= value;
    }

    public static event ILContext.Manipulator FlashingWhiteStayMoth
    {
        add => IL.SpriteFlash.FlashingWhiteStayMoth += value;
        remove => IL.SpriteFlash.FlashingWhiteStayMoth -= value;
    }

    public static event ILContext.Manipulator FlashingFury
    {
        add => IL.SpriteFlash.FlashingFury += value;
        remove => IL.SpriteFlash.FlashingFury -= value;
    }

    public static event ILContext.Manipulator FlashingOrange
    {
        add => IL.SpriteFlash.FlashingOrange += value;
        remove => IL.SpriteFlash.FlashingOrange -= value;
    }

    public static event ILContext.Manipulator flashInfected
    {
        add => IL.SpriteFlash.flashInfected += value;
        remove => IL.SpriteFlash.flashInfected -= value;
    }

    public static event ILContext.Manipulator flashDung
    {
        add => IL.SpriteFlash.flashDung += value;
        remove => IL.SpriteFlash.flashDung -= value;
    }

    public static event ILContext.Manipulator flashDungQuick
    {
        add => IL.SpriteFlash.flashDungQuick += value;
        remove => IL.SpriteFlash.flashDungQuick -= value;
    }

    public static event ILContext.Manipulator flashSporeQuick
    {
        add => IL.SpriteFlash.flashSporeQuick += value;
        remove => IL.SpriteFlash.flashSporeQuick -= value;
    }

    public static event ILContext.Manipulator flashWhiteQuick
    {
        add => IL.SpriteFlash.flashWhiteQuick += value;
        remove => IL.SpriteFlash.flashWhiteQuick -= value;
    }

    public static event ILContext.Manipulator flashInfectedLong
    {
        add => IL.SpriteFlash.flashInfectedLong += value;
        remove => IL.SpriteFlash.flashInfectedLong -= value;
    }

    public static event ILContext.Manipulator flashArmoured
    {
        add => IL.SpriteFlash.flashArmoured += value;
        remove => IL.SpriteFlash.flashArmoured -= value;
    }

    public static event ILContext.Manipulator flashBenchRest
    {
        add => IL.SpriteFlash.flashBenchRest += value;
        remove => IL.SpriteFlash.flashBenchRest -= value;
    }

    public static event ILContext.Manipulator flashDreamImpact
    {
        add => IL.SpriteFlash.flashDreamImpact += value;
        remove => IL.SpriteFlash.flashDreamImpact -= value;
    }

    public static event ILContext.Manipulator flashMothDepart
    {
        add => IL.SpriteFlash.flashMothDepart += value;
        remove => IL.SpriteFlash.flashMothDepart -= value;
    }

    public static event ILContext.Manipulator flashSoulGet
    {
        add => IL.SpriteFlash.flashSoulGet += value;
        remove => IL.SpriteFlash.flashSoulGet -= value;
    }

    public static event ILContext.Manipulator flashShadeGet
    {
        add => IL.SpriteFlash.flashShadeGet += value;
        remove => IL.SpriteFlash.flashShadeGet -= value;
    }

    public static event ILContext.Manipulator flashWhiteLong
    {
        add => IL.SpriteFlash.flashWhiteLong += value;
        remove => IL.SpriteFlash.flashWhiteLong -= value;
    }

    public static event ILContext.Manipulator flashOvercharmed
    {
        add => IL.SpriteFlash.flashOvercharmed += value;
        remove => IL.SpriteFlash.flashOvercharmed -= value;
    }

    public static event ILContext.Manipulator flashFocusHeal
    {
        add => IL.SpriteFlash.flashFocusHeal += value;
        remove => IL.SpriteFlash.flashFocusHeal -= value;
    }

    public static event ILContext.Manipulator flashFocusGet
    {
        add => IL.SpriteFlash.flashFocusGet += value;
        remove => IL.SpriteFlash.flashFocusGet -= value;
    }

    public static event ILContext.Manipulator flashWhitePulse
    {
        add => IL.SpriteFlash.flashWhitePulse += value;
        remove => IL.SpriteFlash.flashWhitePulse -= value;
    }

    public static event ILContext.Manipulator flashHealBlue
    {
        add => IL.SpriteFlash.flashHealBlue += value;
        remove => IL.SpriteFlash.flashHealBlue -= value;
    }

    public static event ILContext.Manipulator FlashShadowRecharge
    {
        add => IL.SpriteFlash.FlashShadowRecharge += value;
        remove => IL.SpriteFlash.FlashShadowRecharge -= value;
    }

    public static event ILContext.Manipulator flashInfectedLoop
    {
        add => IL.SpriteFlash.flashInfectedLoop += value;
        remove => IL.SpriteFlash.flashInfectedLoop -= value;
    }

    public static event ILContext.Manipulator FlashGrimmflame
    {
        add => IL.SpriteFlash.FlashGrimmflame += value;
        remove => IL.SpriteFlash.FlashGrimmflame -= value;
    }

    public static event ILContext.Manipulator FlashGrimmHit
    {
        add => IL.SpriteFlash.FlashGrimmHit += value;
        remove => IL.SpriteFlash.FlashGrimmHit -= value;
    }

    public static event ILContext.Manipulator SendToChildren
    {
        add => IL.SpriteFlash.SendToChildren += value;
        remove => IL.SpriteFlash.SendToChildren -= value;
    }
}