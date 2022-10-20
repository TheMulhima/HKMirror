namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteColliderIsland.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteColliderIsland
{
    public static event ILContext.Manipulator IsValid
    {
        add => IL.tk2dSpriteColliderIsland.IsValid += value;
        remove => IL.tk2dSpriteColliderIsland.IsValid -= value;
    }

    public static event ILContext.Manipulator CopyFrom
    {
        add => IL.tk2dSpriteColliderIsland.CopyFrom += value;
        remove => IL.tk2dSpriteColliderIsland.CopyFrom -= value;
    }

    public static event ILContext.Manipulator CompareTo
    {
        add => IL.tk2dSpriteColliderIsland.CompareTo += value;
        remove => IL.tk2dSpriteColliderIsland.CompareTo -= value;
    }
}