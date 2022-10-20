using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GGCheckIfLastBossScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGGCheckIfLastBossScene
{
    public static event ILContext.Manipulator get_IsTrue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GGCheckIfLastBossScene), "get_IsTrue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GGCheckIfLastBossScene), "get_IsTrue"), value);
    }
}