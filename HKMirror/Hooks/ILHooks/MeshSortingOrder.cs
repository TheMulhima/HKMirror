namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MeshSortingOrder.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMeshSortingOrder
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MeshSortingOrder.Awake += value;
        remove => IL.MeshSortingOrder.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.MeshSortingOrder.Update += value;
        remove => IL.MeshSortingOrder.Update -= value;
    }

    public static event ILContext.Manipulator OnValidate
    {
        add => IL.MeshSortingOrder.OnValidate += value;
        remove => IL.MeshSortingOrder.OnValidate -= value;
    }
}