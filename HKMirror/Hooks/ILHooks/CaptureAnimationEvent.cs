namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CaptureAnimationEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCaptureAnimationEvent
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CaptureAnimationEvent.Start += value;
        remove => IL.CaptureAnimationEvent.Start -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataBoolTrue
    {
        add => IL.CaptureAnimationEvent.SetPlayerDataBoolTrue += value;
        remove => IL.CaptureAnimationEvent.SetPlayerDataBoolTrue -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataBoolFalse
    {
        add => IL.CaptureAnimationEvent.SetPlayerDataBoolFalse += value;
        remove => IL.CaptureAnimationEvent.SetPlayerDataBoolFalse -= value;
    }

    public static event ILContext.Manipulator IncrementPlayerDataInt
    {
        add => IL.CaptureAnimationEvent.IncrementPlayerDataInt += value;
        remove => IL.CaptureAnimationEvent.IncrementPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator DecrementPlayerDataInt
    {
        add => IL.CaptureAnimationEvent.DecrementPlayerDataInt += value;
        remove => IL.CaptureAnimationEvent.DecrementPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBool
    {
        add => IL.CaptureAnimationEvent.GetPlayerDataBool += value;
        remove => IL.CaptureAnimationEvent.GetPlayerDataBool -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataInt
    {
        add => IL.CaptureAnimationEvent.GetPlayerDataInt += value;
        remove => IL.CaptureAnimationEvent.GetPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataFloat
    {
        add => IL.CaptureAnimationEvent.GetPlayerDataFloat += value;
        remove => IL.CaptureAnimationEvent.GetPlayerDataFloat -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataString
    {
        add => IL.CaptureAnimationEvent.GetPlayerDataString += value;
        remove => IL.CaptureAnimationEvent.GetPlayerDataString -= value;
    }

    public static event ILContext.Manipulator EquipCharm
    {
        add => IL.CaptureAnimationEvent.EquipCharm += value;
        remove => IL.CaptureAnimationEvent.EquipCharm -= value;
    }

    public static event ILContext.Manipulator UnequipCharm
    {
        add => IL.CaptureAnimationEvent.UnequipCharm += value;
        remove => IL.CaptureAnimationEvent.UnequipCharm -= value;
    }

    public static event ILContext.Manipulator UpdateBlueHealth
    {
        add => IL.CaptureAnimationEvent.UpdateBlueHealth += value;
        remove => IL.CaptureAnimationEvent.UpdateBlueHealth -= value;
    }
}