using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpawnJarControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpawnJarControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SpawnJarControl.Awake += value;
        remove => IL.SpawnJarControl.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpawnJarControl.OnEnable += value;
        remove => IL.SpawnJarControl.OnEnable -= value;
    }

    public static event ILContext.Manipulator Behaviour
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnJarControl), "Behaviour").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnJarControl), "Behaviour").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetEnemySpawn
    {
        add => IL.SpawnJarControl.SetEnemySpawn += value;
        remove => IL.SpawnJarControl.SetEnemySpawn -= value;
    }
}