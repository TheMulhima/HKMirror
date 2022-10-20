namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpriteTweenColorNeutral.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpriteTweenColorNeutral
{
    public static event ILContext.Manipulator ColorReturnNeutral
    {
        add => IL.SpriteTweenColorNeutral.ColorReturnNeutral += value;
        remove => IL.SpriteTweenColorNeutral.ColorReturnNeutral -= value;
    }

    public static event ILContext.Manipulator updateSpriteColor
    {
        add => IL.SpriteTweenColorNeutral.updateSpriteColor += value;
        remove => IL.SpriteTweenColorNeutral.updateSpriteColor -= value;
    }

    public static event ILContext.Manipulator onEnable
    {
        add => IL.SpriteTweenColorNeutral.onEnable += value;
        remove => IL.SpriteTweenColorNeutral.onEnable -= value;
    }
}