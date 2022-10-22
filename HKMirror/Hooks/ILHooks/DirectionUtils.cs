namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DirectionUtils,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDirectionUtils
{
    public static event ILContext.Manipulator GetCardinalDirection
    {
        add => IL.DirectionUtils.GetCardinalDirection += value;
        remove => IL.DirectionUtils.GetCardinalDirection -= value;
    }

    public static event ILContext.Manipulator NegSafeMod
    {
        add => IL.DirectionUtils.NegSafeMod += value;
        remove => IL.DirectionUtils.NegSafeMod -= value;
    }

    public static event ILContext.Manipulator GetX
    {
        add => IL.DirectionUtils.GetX += value;
        remove => IL.DirectionUtils.GetX -= value;
    }

    public static event ILContext.Manipulator GetY
    {
        add => IL.DirectionUtils.GetY += value;
        remove => IL.DirectionUtils.GetY -= value;
    }
}