using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteDefinition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteDefinition
{
    public static event ILContext.Manipulator get_Valid
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteDefinition), "get_Valid"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteDefinition), "get_Valid"), value);
    }

    public static event ILContext.Manipulator GetBounds
    {
        add => IL.tk2dSpriteDefinition.GetBounds += value;
        remove => IL.tk2dSpriteDefinition.GetBounds -= value;
    }

    public static event ILContext.Manipulator GetUntrimmedBounds
    {
        add => IL.tk2dSpriteDefinition.GetUntrimmedBounds += value;
        remove => IL.tk2dSpriteDefinition.GetUntrimmedBounds -= value;
    }
}