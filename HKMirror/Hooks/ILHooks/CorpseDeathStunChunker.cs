using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseDeathStunChunker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseDeathStunChunker
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CorpseDeathStunChunker.Start += value;
        remove => IL.CorpseDeathStunChunker.Start -= value;
    }

    public static event ILContext.Manipulator DeathStun
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStunChunker), "DeathStun").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStunChunker), "DeathStun").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStunChunker), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseDeathStunChunker), "Jitter").GetStateMachineTarget(), value);
    }
}