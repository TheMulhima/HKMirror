using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUtil,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUtil
{
    public static event ILContext.Manipulator get_UndoEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUtil), "get_UndoEnabled", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUtil), "get_UndoEnabled", false), value);
    }

    public static event ILContext.Manipulator set_UndoEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUtil), "set_UndoEnabled", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUtil), "set_UndoEnabled", false), value);
    }

    public static event ILContext.Manipulator BeginGroup
    {
        add => IL.tk2dUtil.BeginGroup += value;
        remove => IL.tk2dUtil.BeginGroup -= value;
    }

    public static event ILContext.Manipulator EndGroup
    {
        add => IL.tk2dUtil.EndGroup += value;
        remove => IL.tk2dUtil.EndGroup -= value;
    }

    public static event ILContext.Manipulator DestroyImmediate
    {
        add => IL.tk2dUtil.DestroyImmediate += value;
        remove => IL.tk2dUtil.DestroyImmediate -= value;
    }

    public static event ILContext.Manipulator CreateGameObject
    {
        add => IL.tk2dUtil.CreateGameObject += value;
        remove => IL.tk2dUtil.CreateGameObject -= value;
    }

    public static event ILContext.Manipulator CreateMesh
    {
        add => IL.tk2dUtil.CreateMesh += value;
        remove => IL.tk2dUtil.CreateMesh -= value;
    }

    public static event ILContext.Manipulator SetActive
    {
        add => IL.tk2dUtil.SetActive += value;
        remove => IL.tk2dUtil.SetActive -= value;
    }

    public static event ILContext.Manipulator SetTransformParent
    {
        add => IL.tk2dUtil.SetTransformParent += value;
        remove => IL.tk2dUtil.SetTransformParent -= value;
    }

    public static event ILContext.Manipulator SetDirty
    {
        add => IL.tk2dUtil.SetDirty += value;
        remove => IL.tk2dUtil.SetDirty -= value;
    }
}