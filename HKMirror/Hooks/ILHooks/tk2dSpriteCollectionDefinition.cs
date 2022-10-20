namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteCollectionDefinition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollectionDefinition
{
    public static event ILContext.Manipulator CopyFrom
    {
        add => IL.tk2dSpriteCollectionDefinition.CopyFrom += value;
        remove => IL.tk2dSpriteCollectionDefinition.CopyFrom -= value;
    }

    public static event ILContext.Manipulator Clear
    {
        add => IL.tk2dSpriteCollectionDefinition.Clear += value;
        remove => IL.tk2dSpriteCollectionDefinition.Clear -= value;
    }

    public static event ILContext.Manipulator CompareTo
    {
        add => IL.tk2dSpriteCollectionDefinition.CompareTo += value;
        remove => IL.tk2dSpriteCollectionDefinition.CompareTo -= value;
    }
}