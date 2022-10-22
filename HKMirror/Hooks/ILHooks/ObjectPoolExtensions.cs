using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ObjectPoolExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILObjectPoolExtensions
{
    public static event ILContext.Manipulator CreatePool_GameObject
    {
        add => IL.ObjectPoolExtensions.CreatePool_GameObject += value;
        remove => IL.ObjectPoolExtensions.CreatePool_GameObject -= value;
    }

    public static event ILContext.Manipulator CreatePool_GameObject_int
    {
        add => IL.ObjectPoolExtensions.CreatePool_GameObject_int += value;
        remove => IL.ObjectPoolExtensions.CreatePool_GameObject_int -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform_Vector3_Quaternion
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject_Transform_Vector3_Quaternion += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject_Transform_Vector3_Quaternion -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Vector3_Quaternion
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject_Vector3_Quaternion += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject_Vector3_Quaternion -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform_Vector3
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject_Transform_Vector3 += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject_Transform_Vector3 -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Vector3
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject_Vector3 += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject_Vector3 -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject_Transform
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject_Transform += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject_Transform -= value;
    }

    public static event ILContext.Manipulator Spawn_GameObject
    {
        add => IL.ObjectPoolExtensions.Spawn_GameObject += value;
        remove => IL.ObjectPoolExtensions.Spawn_GameObject -= value;
    }

    public static event ILContext.Manipulator Recycle
    {
        add => IL.ObjectPoolExtensions.Recycle += value;
        remove => IL.ObjectPoolExtensions.Recycle -= value;
    }

    public static event ILContext.Manipulator RecycleAll
    {
        add => IL.ObjectPoolExtensions.RecycleAll += value;
        remove => IL.ObjectPoolExtensions.RecycleAll -= value;
    }

    public static event ILContext.Manipulator CountPooled
    {
        add => IL.ObjectPoolExtensions.CountPooled += value;
        remove => IL.ObjectPoolExtensions.CountPooled -= value;
    }

    public static event ILContext.Manipulator CountSpawned
    {
        add => IL.ObjectPoolExtensions.CountSpawned += value;
        remove => IL.ObjectPoolExtensions.CountSpawned -= value;
    }

    public static event ILContext.Manipulator GetSpawned_GameObject_GameObject_bool
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetSpawned", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetSpawned", false), value);
    }

    public static event ILContext.Manipulator GetSpawned_GameObject_GameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetSpawned", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetSpawned", false), value);
    }

    public static event ILContext.Manipulator GetSpawned_GameObject
    {
        add => IL.ObjectPoolExtensions.GetSpawned_GameObject += value;
        remove => IL.ObjectPoolExtensions.GetSpawned_GameObject -= value;
    }

    public static event ILContext.Manipulator GetPooled_GameObject_GameObject_bool
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetPooled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetPooled", false), value);
    }

    public static event ILContext.Manipulator GetPooled_GameObject_GameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetPooled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectPoolExtensions), "GetPooled", false), value);
    }

    public static event ILContext.Manipulator GetPooled_GameObject
    {
        add => IL.ObjectPoolExtensions.GetPooled_GameObject += value;
        remove => IL.ObjectPoolExtensions.GetPooled_GameObject -= value;
    }

    public static event ILContext.Manipulator DestroyPooled
    {
        add => IL.ObjectPoolExtensions.DestroyPooled += value;
        remove => IL.ObjectPoolExtensions.DestroyPooled -= value;
    }

    public static event ILContext.Manipulator DestroyAll
    {
        add => IL.ObjectPoolExtensions.DestroyAll += value;
        remove => IL.ObjectPoolExtensions.DestroyAll -= value;
    }
}