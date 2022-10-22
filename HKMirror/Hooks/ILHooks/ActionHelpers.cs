using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ActionHelpers,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILActionHelpers
{
    public static event ILContext.Manipulator get_WhiteTexture
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "get_WhiteTexture", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "get_WhiteTexture", false), value);
    }

    public static event ILContext.Manipulator BlendColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "BlendColor", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "BlendColor", false), value);
    }

    public static event ILContext.Manipulator IsVisible
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsVisible", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsVisible", false), value);
    }

    public static event ILContext.Manipulator GetOwnerDefault
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetOwnerDefault", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetOwnerDefault", false), value);
    }

    public static event ILContext.Manipulator GetGameObjectFsm
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetGameObjectFsm", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetGameObjectFsm", false), value);
    }

    public static event ILContext.Manipulator GetRandomWeightedIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetRandomWeightedIndex", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetRandomWeightedIndex", false), value);
    }

    public static event ILContext.Manipulator AddAnimationClip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AddAnimationClip", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AddAnimationClip", false), value);
    }

    public static event ILContext.Manipulator HasAnimationFinished
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "HasAnimationFinished", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "HasAnimationFinished", false), value);
    }

    public static event ILContext.Manipulator GetPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetPosition", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetPosition", false), value);
    }

    public static event ILContext.Manipulator GetTargetRotation_RotationOptions_Transform_Transform_Vector3
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetRotation", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetRotation", false), value);
    }

    public static event ILContext.Manipulator
        GetTargetRotation_RotationOptions_Transform_FsmVector3_FsmGameObject_Quaternion
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetRotation", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetRotation", false), value);
        }

    public static event ILContext.Manipulator CanEditTargetRotation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CanEditTargetRotation", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CanEditTargetRotation", false), value);
    }

    public static event ILContext.Manipulator GetTargetScale
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetScale", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetScale", false), value);
    }

    public static event ILContext.Manipulator
        GetTargetPosition_PositionOptions_Transform_FsmVector3_FsmGameObject_Vector3
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetPosition", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetPosition", false), value);
        }

    public static event ILContext.Manipulator IsValidTargetPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsValidTargetPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsValidTargetPosition", false), value);
    }

    public static event ILContext.Manipulator CanEditTargetPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CanEditTargetPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CanEditTargetPosition", false), value);
    }

    public static event ILContext.Manipulator GetTargetPosition_PositionOptions_Transform_Transform_Vector3
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetTargetPosition", false), value);
    }

    public static event ILContext.Manipulator IsMouseOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsMouseOver", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsMouseOver", false), value);
    }

    public static event ILContext.Manipulator MousePick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "MousePick", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "MousePick", false), value);
    }

    public static event ILContext.Manipulator MouseOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "MouseOver", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "MouseOver", false), value);
    }

    public static event ILContext.Manipulator DoMousePick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "DoMousePick", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "DoMousePick", false), value);
    }

    public static event ILContext.Manipulator LayerArrayToLayerMask
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LayerArrayToLayerMask", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LayerArrayToLayerMask", false), value);
    }

    public static event ILContext.Manipulator IsLoopingWrapMode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsLoopingWrapMode", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "IsLoopingWrapMode", false), value);
    }

    public static event ILContext.Manipulator CheckRayDistance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckRayDistance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckRayDistance", false), value);
    }

    public static event ILContext.Manipulator CheckForValidEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckForValidEvent", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckForValidEvent", false), value);
    }

    public static event ILContext.Manipulator CheckPhysicsSetup_FsmOwnerDefault
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysicsSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysicsSetup", false), value);
    }

    public static event ILContext.Manipulator CheckOwnerPhysicsSetup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckOwnerPhysicsSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckOwnerPhysicsSetup", false), value);
    }

    public static event ILContext.Manipulator CheckPhysicsSetup_GameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysicsSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysicsSetup", false), value);
    }

    public static event ILContext.Manipulator CheckPhysics2dSetup_FsmOwnerDefault
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysics2dSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysics2dSetup", false), value);
    }

    public static event ILContext.Manipulator CheckOwnerPhysics2dSetup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckOwnerPhysics2dSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckOwnerPhysics2dSetup", false), value);
    }

    public static event ILContext.Manipulator CheckPhysics2dSetup_GameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysics2dSetup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "CheckPhysics2dSetup", false), value);
    }

    public static event ILContext.Manipulator DebugLog
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "DebugLog", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "DebugLog", false),
            value);
    }

    public static event ILContext.Manipulator LogError
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LogError", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LogError", false),
            value);
    }

    public static event ILContext.Manipulator LogWarning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LogWarning", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "LogWarning", false), value);
    }

    public static event ILContext.Manipulator FormatUnityLogString
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "FormatUnityLogString", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "FormatUnityLogString", false), value);
    }

    public static event ILContext.Manipulator GetValueLabel_INamedVariable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetValueLabel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetValueLabel", false), value);
    }

    public static event ILContext.Manipulator GetValueLabel_Fsm_FsmOwnerDefault
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetValueLabel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "GetValueLabel", false), value);
    }

    public static event ILContext.Manipulator AutoName_FsmStateAction_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoName", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoName", false),
            value);
    }

    public static event ILContext.Manipulator AutoName_string_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoName", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoName", false),
            value);
    }

    public static event ILContext.Manipulator AutoNameRange_FsmStateAction_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameRange", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameRange", false), value);
    }

    public static event ILContext.Manipulator AutoNameRange_string_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameRange", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameRange", false), value);
    }

    public static event ILContext.Manipulator AutoNameSetVar_FsmStateAction_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameSetVar", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameSetVar", false), value);
    }

    public static event ILContext.Manipulator AutoNameSetVar_string_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameSetVar", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameSetVar", false), value);
    }

    public static event ILContext.Manipulator AutoNameConvert_FsmStateAction_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameConvert", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameConvert", false), value);
    }

    public static event ILContext.Manipulator AutoNameConvert_string_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameConvert", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameConvert", false), value);
    }

    public static event ILContext.Manipulator AutoNameGetProperty_FsmStateAction_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameGetProperty", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameGetProperty", false), value);
    }

    public static event ILContext.Manipulator AutoNameGetProperty_string_NamedVariable_NamedVariable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameGetProperty", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "AutoNameGetProperty", false), value);
    }

    public static event ILContext.Manipulator RuntimeError
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "RuntimeError", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ActionHelpers), "RuntimeError", false), value);
    }
}