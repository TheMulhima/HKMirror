namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CrystalPieceSize.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCrystalPieceSize
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.CrystalPieceSize.OnEnable += value;
        remove => IL.CrystalPieceSize.OnEnable -= value;
    }
}