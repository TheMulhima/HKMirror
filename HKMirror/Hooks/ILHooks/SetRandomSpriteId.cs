using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetRandomSpriteId.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetRandomSpriteId
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SetRandomSpriteId.Awake += value;
        remove => IL.SetRandomSpriteId.Awake -= value;
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.SetRandomSpriteId.Init += value;
        remove => IL.SetRandomSpriteId.Init -= value;
    }

    public static event ILContext.Manipulator InitExternalDebris
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SetRandomSpriteId), "IExternalDebris.InitExternalDebris"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetRandomSpriteId), "IExternalDebris.InitExternalDebris"), value);
    }
}