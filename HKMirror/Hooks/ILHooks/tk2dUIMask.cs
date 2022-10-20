using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIMask.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIMask
{
    public static event ILContext.Manipulator get_ThisMeshFilter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIMask), "get_ThisMeshFilter"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIMask), "get_ThisMeshFilter"),
            value);
    }

    public static event ILContext.Manipulator get_ThisBoxCollider
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIMask), "get_ThisBoxCollider"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIMask), "get_ThisBoxCollider"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIMask.Awake += value;
        remove => IL.tk2dUIMask.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dUIMask.OnDestroy += value;
        remove => IL.tk2dUIMask.OnDestroy -= value;
    }

    public static event ILContext.Manipulator FillMesh
    {
        add => IL.tk2dUIMask.FillMesh += value;
        remove => IL.tk2dUIMask.FillMesh -= value;
    }

    public static event ILContext.Manipulator OnDrawGizmosSelected
    {
        add => IL.tk2dUIMask.OnDrawGizmosSelected += value;
        remove => IL.tk2dUIMask.OnDrawGizmosSelected -= value;
    }

    public static event ILContext.Manipulator Build
    {
        add => IL.tk2dUIMask.Build += value;
        remove => IL.tk2dUIMask.Build -= value;
    }

    public static event ILContext.Manipulator ReshapeBounds
    {
        add => IL.tk2dUIMask.ReshapeBounds += value;
        remove => IL.tk2dUIMask.ReshapeBounds -= value;
    }
}