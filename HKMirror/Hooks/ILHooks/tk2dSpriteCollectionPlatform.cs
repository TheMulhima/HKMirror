using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteCollectionPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollectionPlatform
{
    public static event ILContext.Manipulator get_Valid
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionPlatform), "get_Valid"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionPlatform), "get_Valid"), value);
    }

    public static event ILContext.Manipulator CopyFrom
    {
        add => IL.tk2dSpriteCollectionPlatform.CopyFrom += value;
        remove => IL.tk2dSpriteCollectionPlatform.CopyFrom -= value;
    }
}