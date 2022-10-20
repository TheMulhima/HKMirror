using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUtils.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUtils
{
    public static event ILContext.Manipulator SendEventToGameObject_PlayMakerFSM_GameObject_string_bool
    {
        add => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_bool += value;
        remove => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator SendEventToGameObject_PlayMakerFSM_GameObject_string
    {
        add => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string += value;
        remove => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string -= value;
    }

    public static event ILContext.Manipulator SendEventToGameObject_PlayMakerFSM_GameObject_string_FsmEventData
    {
        add => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_FsmEventData += value;
        remove => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_FsmEventData -= value;
    }

    public static event ILContext.Manipulator SendEventToGameObject_PlayMakerFSM_GameObject_string_bool_FsmEventData
    {
        add => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_bool_FsmEventData += value;
        remove => IL.PlayMakerUtils.SendEventToGameObject_PlayMakerFSM_GameObject_string_bool_FsmEventData -= value;
    }

    public static event ILContext.Manipulator DoesTargetImplementsEvent
    {
        add => IL.PlayMakerUtils.DoesTargetImplementsEvent += value;
        remove => IL.PlayMakerUtils.DoesTargetImplementsEvent -= value;
    }

    public static event ILContext.Manipulator DoesGameObjectImplementsEvent_GameObject_string
    {
        add => IL.PlayMakerUtils.DoesGameObjectImplementsEvent_GameObject_string += value;
        remove => IL.PlayMakerUtils.DoesGameObjectImplementsEvent_GameObject_string -= value;
    }

    public static event ILContext.Manipulator DoesGameObjectImplementsEvent_GameObject_string_string
    {
        add => IL.PlayMakerUtils.DoesGameObjectImplementsEvent_GameObject_string_string += value;
        remove => IL.PlayMakerUtils.DoesGameObjectImplementsEvent_GameObject_string_string -= value;
    }

    public static event ILContext.Manipulator DoesFsmImplementsEvent
    {
        add => IL.PlayMakerUtils.DoesFsmImplementsEvent += value;
        remove => IL.PlayMakerUtils.DoesFsmImplementsEvent -= value;
    }

    public static event ILContext.Manipulator FindFsmOnGameObject
    {
        add => IL.PlayMakerUtils.FindFsmOnGameObject += value;
        remove => IL.PlayMakerUtils.FindFsmOnGameObject -= value;
    }

    public static event ILContext.Manipulator RefreshValueFromFsmVar
    {
        add => IL.PlayMakerUtils.RefreshValueFromFsmVar += value;
        remove => IL.PlayMakerUtils.RefreshValueFromFsmVar -= value;
    }

    public static event ILContext.Manipulator GetValueFromFsmVar
    {
        add => IL.PlayMakerUtils.GetValueFromFsmVar += value;
        remove => IL.PlayMakerUtils.GetValueFromFsmVar -= value;
    }

    public static event ILContext.Manipulator ApplyValueToFsmVar
    {
        add => IL.PlayMakerUtils.ApplyValueToFsmVar += value;
        remove => IL.PlayMakerUtils.ApplyValueToFsmVar -= value;
    }

    public static event ILContext.Manipulator GetFloatFromObject
    {
        add => IL.PlayMakerUtils.GetFloatFromObject += value;
        remove => IL.PlayMakerUtils.GetFloatFromObject -= value;
    }

    public static event ILContext.Manipulator ParseFsmVarToString
    {
        add => IL.PlayMakerUtils.ParseFsmVarToString += value;
        remove => IL.PlayMakerUtils.ParseFsmVarToString -= value;
    }

    public static event ILContext.Manipulator ParseValueToString_Object_bool
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils), "ParseValueToString", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils), "ParseValueToString", false), value);
    }

    public static event ILContext.Manipulator ParseValueToString_Object
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils), "ParseValueToString", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils), "ParseValueToString", false), value);
    }

    public static event ILContext.Manipulator ParseValueFromString_string_bool
    {
        add => IL.PlayMakerUtils.ParseValueFromString_string_bool += value;
        remove => IL.PlayMakerUtils.ParseValueFromString_string_bool -= value;
    }

    public static event ILContext.Manipulator ParseValueFromString_string_VariableType
    {
        add => IL.PlayMakerUtils.ParseValueFromString_string_VariableType += value;
        remove => IL.PlayMakerUtils.ParseValueFromString_string_VariableType -= value;
    }

    public static event ILContext.Manipulator ParseValueFromString_string_Type
    {
        add => IL.PlayMakerUtils.ParseValueFromString_string_Type += value;
        remove => IL.PlayMakerUtils.ParseValueFromString_string_Type -= value;
    }

    public static event ILContext.Manipulator ParseValueFromString_string
    {
        add => IL.PlayMakerUtils.ParseValueFromString_string += value;
        remove => IL.PlayMakerUtils.ParseValueFromString_string -= value;
    }
}