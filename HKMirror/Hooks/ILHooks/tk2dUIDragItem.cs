namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIDragItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIDragItem
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIDragItem.OnEnable += value;
        remove => IL.tk2dUIDragItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIDragItem.OnDisable += value;
        remove => IL.tk2dUIDragItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator UpdateBtnPosition
    {
        add => IL.tk2dUIDragItem.UpdateBtnPosition += value;
        remove => IL.tk2dUIDragItem.UpdateBtnPosition -= value;
    }

    public static event ILContext.Manipulator CalculateNewPos
    {
        add => IL.tk2dUIDragItem.CalculateNewPos += value;
        remove => IL.tk2dUIDragItem.CalculateNewPos -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUIDragItem.ButtonDown += value;
        remove => IL.tk2dUIDragItem.ButtonDown -= value;
    }

    public static event ILContext.Manipulator ButtonRelease
    {
        add => IL.tk2dUIDragItem.ButtonRelease += value;
        remove => IL.tk2dUIDragItem.ButtonRelease -= value;
    }
}