using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ModalDialog.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILModalDialog
{
    public static event ILContext.Manipulator get_modalWindow
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModalDialog), "get_modalWindow"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModalDialog), "get_modalWindow"),
            value);
    }

    public static event ILContext.Manipulator HighlightDefault
    {
        add => IL.ModalDialog.HighlightDefault += value;
        remove => IL.ModalDialog.HighlightDefault -= value;
    }
}