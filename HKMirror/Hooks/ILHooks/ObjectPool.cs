using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ObjectPool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILObjectPool
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "get_instance", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.ObjectPool.Awake += value;
        remove => IL.ObjectPool.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ObjectPool.Start += value;
        remove => IL.ObjectPool.Start -= value;
    }

    public static event ILContext.Manipulator CreateStartupPools
    {
        add => IL.ObjectPool.CreateStartupPools += value;
        remove => IL.ObjectPool.CreateStartupPools -= value;
    }

    public static event ILContext.Manipulator CreatePool
    {
        add => IL.ObjectPool.CreatePool += value;
        remove => IL.ObjectPool.CreatePool -= value;
    }

    public static event ILContext.Manipulator RevertToStartState
    {
        add => IL.ObjectPool.RevertToStartState += value;
        remove => IL.ObjectPool.RevertToStartState -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform_Vector3_Quaternion
    {
        add => IL.ObjectPool.Spawn_GameObject_Transform_Vector3_Quaternion += value;
        remove => IL.ObjectPool.Spawn_GameObject_Transform_Vector3_Quaternion -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform_Vector3
    {
        add => IL.ObjectPool.Spawn_GameObject_Transform_Vector3 += value;
        remove => IL.ObjectPool.Spawn_GameObject_Transform_Vector3 -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Vector3_Quaternion
    {
        add => IL.ObjectPool.Spawn_GameObject_Vector3_Quaternion += value;
        remove => IL.ObjectPool.Spawn_GameObject_Vector3_Quaternion -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform
    {
        add => IL.ObjectPool.Spawn_GameObject_Transform += value;
        remove => IL.ObjectPool.Spawn_GameObject_Transform -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Vector3
    {
        add => IL.ObjectPool.Spawn_GameObject_Vector3 += value;
        remove => IL.ObjectPool.Spawn_GameObject_Vector3 -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject
    {
        add => IL.ObjectPool.Spawn_GameObject += value;
        remove => IL.ObjectPool.Spawn_GameObject -= value;
    }

    public static event ILContext.Manipulator Recycle_GameObject
    {
        add => IL.ObjectPool.Recycle_GameObject += value;
        remove => IL.ObjectPool.Recycle_GameObject -= value;
    }

    public static event ILContext.Manipulator Recycle_GameObject_GameObject
    {
        add => IL.ObjectPool.Recycle_GameObject_GameObject += value;
        remove => IL.ObjectPool.Recycle_GameObject_GameObject -= value;
    }

    public static event ILContext.Manipulator RecycleAll_GameObject
    {
        add => IL.ObjectPool.RecycleAll_GameObject += value;
        remove => IL.ObjectPool.RecycleAll_GameObject -= value;
    }

    public static event ILContext.Manipulator RecycleAll
    {
        add => IL.ObjectPool.RecycleAll += value;
        remove => IL.ObjectPool.RecycleAll -= value;
    }

    public static event ILContext.Manipulator IsSpawned
    {
        add => IL.ObjectPool.IsSpawned += value;
        remove => IL.ObjectPool.IsSpawned -= value;
    }

    public static event ILContext.Manipulator CountPooled
    {
        add => IL.ObjectPool.CountPooled += value;
        remove => IL.ObjectPool.CountPooled -= value;
    }

    public static event ILContext.Manipulator CountSpawned
    {
        add => IL.ObjectPool.CountSpawned += value;
        remove => IL.ObjectPool.CountSpawned -= value;
    }

    public static event ILContext.Manipulator CountAllPooled
    {
        add => IL.ObjectPool.CountAllPooled += value;
        remove => IL.ObjectPool.CountAllPooled -= value;
    }

    public static event ILContext.Manipulator GetPooled
    {
        add => IL.ObjectPool.GetPooled += value;
        remove => IL.ObjectPool.GetPooled -= value;
    }

    public static event ILContext.Manipulator GetSpawned
    {
        add => IL.ObjectPool.GetSpawned += value;
        remove => IL.ObjectPool.GetSpawned -= value;
    }

    public static event ILContext.Manipulator DestroyPooled_GameObject
    {
        add => IL.ObjectPool.DestroyPooled_GameObject += value;
        remove => IL.ObjectPool.DestroyPooled_GameObject -= value;
    }

    public static event ILContext.Manipulator DestroyPooled_GameObject_int
    {
        add => IL.ObjectPool.DestroyPooled_GameObject_int += value;
        remove => IL.ObjectPool.DestroyPooled_GameObject_int -= value;
    }

    public static event ILContext.Manipulator DestroyAll
    {
        add => IL.ObjectPool.DestroyAll += value;
        remove => IL.ObjectPool.DestroyAll -= value;
    }

    public static event ILContext.Manipulator orig_Spawn
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "orig_Spawn", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "orig_Spawn", false),
            value);
    }

    public static event ILContext.Manipulator orig_CreatePool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "orig_CreatePool", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPool), "orig_CreatePool", false), value);
    }
}