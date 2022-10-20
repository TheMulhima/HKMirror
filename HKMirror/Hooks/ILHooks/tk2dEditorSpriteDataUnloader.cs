namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dEditorSpriteDataUnloader.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dEditorSpriteDataUnloader
{
    public static event ILContext.Manipulator Register
    {
        add => IL.tk2dEditorSpriteDataUnloader.Register += value;
        remove => IL.tk2dEditorSpriteDataUnloader.Register -= value;
    }

    public static event ILContext.Manipulator Unregister
    {
        add => IL.tk2dEditorSpriteDataUnloader.Unregister += value;
        remove => IL.tk2dEditorSpriteDataUnloader.Unregister -= value;
    }
}