namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetPersistentBoolFromSaveData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetPersistentBoolFromSaveData
{
    public static event ILContext.Manipulator ShouldHideDirect
    {
        add => IL.GetPersistentBoolFromSaveData.ShouldHideDirect += value;
        remove => IL.GetPersistentBoolFromSaveData.ShouldHideDirect -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.GetPersistentBoolFromSaveData.Reset += value;
        remove => IL.GetPersistentBoolFromSaveData.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetPersistentBoolFromSaveData.OnEnter += value;
        remove => IL.GetPersistentBoolFromSaveData.OnEnter -= value;
    }
}