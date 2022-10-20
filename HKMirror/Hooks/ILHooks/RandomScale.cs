using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomScale.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomScale
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RandomScale.Start += value;
        remove => IL.RandomScale.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.RandomScale.OnEnable += value;
        remove => IL.RandomScale.OnEnable -= value;
    }

    public static event ILContext.Manipulator ApplyScale
    {
        add => IL.RandomScale.ApplyScale += value;
        remove => IL.RandomScale.ApplyScale -= value;
    }

    public static event ILContext.Manipulator InitExternalDebris
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
    }
}