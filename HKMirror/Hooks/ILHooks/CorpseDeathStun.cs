using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseDeathStun.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseDeathStun
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CorpseDeathStun.Start += value;
        remove => IL.CorpseDeathStun.Start -= value;
    }

    public static event ILContext.Manipulator DeathStun
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStun), "DeathStun").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStun), "DeathStun").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStun), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStun), "Jitter").GetStateMachineTarget(), value);
    }
}