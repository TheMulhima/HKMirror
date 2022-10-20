using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayerAction.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayerAction
{
    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Name"), value);
    }

    public static event ILContext.Manipulator set_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Name"), value);
    }

    public static event ILContext.Manipulator get_Owner
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Owner"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Owner"), value);
    }

    public static event ILContext.Manipulator set_Owner
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Owner"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Owner"), value);
    }

    public static event ILContext.Manipulator get_UserData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UserData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UserData"),
            value);
    }

    public static event ILContext.Manipulator set_UserData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_UserData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_UserData"),
            value);
    }

    public static event ILContext.Manipulator AddDefaultBinding_BindingSource
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"), value);
    }

    public static event ILContext.Manipulator AddDefaultBinding_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"), value);
    }

    public static event ILContext.Manipulator AddDefaultBinding_KeyCombo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"), value);
    }

    public static event ILContext.Manipulator AddDefaultBinding_Mouse
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"), value);
    }

    public static event ILContext.Manipulator AddDefaultBinding_InputControlType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddDefaultBinding"), value);
    }

    public static event ILContext.Manipulator AddBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "AddBinding"),
            value);
    }

    public static event ILContext.Manipulator InsertBindingAt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "InsertBindingAt"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "InsertBindingAt"),
            value);
    }

    public static event ILContext.Manipulator ReplaceBinding
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ReplaceBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ReplaceBinding"),
            value);
    }

    public static event ILContext.Manipulator HasBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "HasBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "HasBinding"),
            value);
    }

    public static event ILContext.Manipulator FindBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "FindBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "FindBinding"),
            value);
    }

    public static event ILContext.Manipulator HardRemoveBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "HardRemoveBinding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "HardRemoveBinding"), value);
    }

    public static event ILContext.Manipulator RemoveBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveBinding"),
            value);
    }

    public static event ILContext.Manipulator RemoveBindingAt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveBindingAt"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveBindingAt"),
            value);
    }

    public static event ILContext.Manipulator CountBindingsOfType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "CountBindingsOfType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "CountBindingsOfType"), value);
    }

    public static event ILContext.Manipulator RemoveFirstBindingOfType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveFirstBindingOfType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveFirstBindingOfType"), value);
    }

    public static event ILContext.Manipulator IndexOfFirstInvalidBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "IndexOfFirstInvalidBinding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "IndexOfFirstInvalidBinding"), value);
    }

    public static event ILContext.Manipulator ClearBindings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ClearBindings"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ClearBindings"),
            value);
    }

    public static event ILContext.Manipulator ResetBindings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ResetBindings"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ResetBindings"),
            value);
    }

    public static event ILContext.Manipulator ListenForBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ListenForBinding"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ListenForBinding"),
            value);
    }

    public static event ILContext.Manipulator ListenForBindingReplacing
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ListenForBindingReplacing"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "ListenForBindingReplacing"), value);
    }

    public static event ILContext.Manipulator StopListeningForBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "StopListeningForBinding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "StopListeningForBinding"), value);
    }

    public static event ILContext.Manipulator get_IsListeningForBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_IsListeningForBinding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_IsListeningForBinding"), value);
    }

    public static event ILContext.Manipulator get_Bindings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Bindings"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Bindings"),
            value);
    }

    public static event ILContext.Manipulator get_UnfilteredBindings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UnfilteredBindings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UnfilteredBindings"), value);
    }

    public static event ILContext.Manipulator RemoveOrphanedBindings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveOrphanedBindings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "RemoveOrphanedBindings"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Update"), value);
    }

    public static event ILContext.Manipulator UpdateBindings
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "UpdateBindings"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "UpdateBindings"),
            value);
    }

    public static event ILContext.Manipulator DetectBindings
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "DetectBindings"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "DetectBindings"),
            value);
    }

    public static event ILContext.Manipulator UpdateVisibleBindings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "UpdateVisibleBindings"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "UpdateVisibleBindings"), value);
    }

    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Device"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_Device"),
            value);
    }

    public static event ILContext.Manipulator set_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Device"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_Device"),
            value);
    }

    public static event ILContext.Manipulator get_ActiveDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_ActiveDevice"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_ActiveDevice"),
            value);
    }

    public static event ILContext.Manipulator get_LastInputTypeIsDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_LastInputTypeIsDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_LastInputTypeIsDevice"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_LowerDeadZone"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_LowerDeadZone"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UpperDeadZone"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_UpperDeadZone"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "set_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator Load
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Load"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Load"), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Save"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerAction), "Save"), value);
    }
}