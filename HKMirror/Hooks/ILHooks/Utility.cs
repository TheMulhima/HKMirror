using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Utility,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUtility
{
    public static event ILContext.Manipulator DrawCircleGizmo_Vector2_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawCircleGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawCircleGizmo", false), value);
    }

    public static event ILContext.Manipulator DrawCircleGizmo_Vector2_float_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawCircleGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawCircleGizmo", false), value);
    }

    public static event ILContext.Manipulator DrawOvalGizmo_Vector2_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawOvalGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawOvalGizmo", false),
            value);
    }

    public static event ILContext.Manipulator DrawOvalGizmo_Vector2_Vector2_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawOvalGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawOvalGizmo", false),
            value);
    }

    public static event ILContext.Manipulator DrawRectGizmo_Rect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
    }

    public static event ILContext.Manipulator DrawRectGizmo_Rect_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
    }

    public static event ILContext.Manipulator DrawRectGizmo_Vector2_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
    }

    public static event ILContext.Manipulator DrawRectGizmo_Vector2_Vector2_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "DrawRectGizmo", false),
            value);
    }

    public static event ILContext.Manipulator GameObjectIsCulledOnCurrentCamera
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GameObjectIsCulledOnCurrentCamera", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GameObjectIsCulledOnCurrentCamera", false), value);
    }

    public static event ILContext.Manipulator MoveColorTowards
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "MoveColorTowards", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "MoveColorTowards", false), value);
    }

    public static event ILContext.Manipulator ApplyDeadZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplyDeadZone", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplyDeadZone", false),
            value);
    }

    public static event ILContext.Manipulator ApplySmoothing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplySmoothing", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplySmoothing", false),
            value);
    }

    public static event ILContext.Manipulator ApplySnapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplySnapping", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ApplySnapping", false),
            value);
    }

    public static event ILContext.Manipulator TargetIsButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsButton", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsButton", false),
            value);
    }

    public static event ILContext.Manipulator TargetIsStandard
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsStandard", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsStandard", false), value);
    }

    public static event ILContext.Manipulator TargetIsAlias
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsAlias", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "TargetIsAlias", false),
            value);
    }

    public static event ILContext.Manipulator ReadFromFile
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ReadFromFile", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ReadFromFile", false),
            value);
    }

    public static event ILContext.Manipulator WriteToFile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "WriteToFile", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "WriteToFile", false),
            value);
    }

    public static event ILContext.Manipulator Abs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Abs", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Abs", false), value);
    }

    public static event ILContext.Manipulator Approximately_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Approximately", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Approximately", false),
            value);
    }

    public static event ILContext.Manipulator Approximately_Vector2_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Approximately", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Approximately", false),
            value);
    }

    public static event ILContext.Manipulator IsNotZero
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "IsNotZero", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "IsNotZero", false),
            value);
    }

    public static event ILContext.Manipulator IsZero
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "IsZero", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "IsZero", false), value);
    }

    public static event ILContext.Manipulator Sign
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Sign", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Sign", false), value);
    }

    public static event ILContext.Manipulator AbsoluteIsOverThreshold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "AbsoluteIsOverThreshold", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "AbsoluteIsOverThreshold", false), value);
    }

    public static event ILContext.Manipulator NormalizeAngle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "NormalizeAngle", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "NormalizeAngle", false),
            value);
    }

    public static event ILContext.Manipulator VectorToAngle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "VectorToAngle", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "VectorToAngle", false),
            value);
    }

    public static event ILContext.Manipulator Min_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Min", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Min", false), value);
    }

    public static event ILContext.Manipulator Max_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Max", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Max", false), value);
    }

    public static event ILContext.Manipulator Min_float_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Min", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Min", false), value);
    }

    public static event ILContext.Manipulator Max_float_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Max", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "Max", false), value);
    }

    public static event ILContext.Manipulator ValueFromSides_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ValueFromSides", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ValueFromSides", false),
            value);
    }

    public static event ILContext.Manipulator ValueFromSides_float_float_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ValueFromSides", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "ValueFromSides", false),
            value);
    }

    public static event ILContext.Manipulator NextPowerOfTwo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "NextPowerOfTwo", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "NextPowerOfTwo", false),
            value);
    }

    public static event ILContext.Manipulator get_Is32Bit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "get_Is32Bit", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "get_Is32Bit", false),
            value);
    }

    public static event ILContext.Manipulator get_Is64Bit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "get_Is64Bit", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "get_Is64Bit", false),
            value);
    }

    public static event ILContext.Manipulator GetPlatformName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "GetPlatformName", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetPlatformName", false), value);
    }

    public static event ILContext.Manipulator GetHumanUnderstandableWindowsVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetHumanUnderstandableWindowsVersion", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetHumanUnderstandableWindowsVersion", false), value);
    }

    public static event ILContext.Manipulator GetWindowsVersion
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "GetWindowsVersion", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetWindowsVersion", false), value);
    }

    public static event ILContext.Manipulator GetSystemBuildNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetSystemBuildNumber", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "GetSystemBuildNumber", false), value);
    }

    public static event ILContext.Manipulator LoadScene
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "LoadScene", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Utility), "LoadScene", false),
            value);
    }

    public static event ILContext.Manipulator PluginFileExtension
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Utility), "PluginFileExtension", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Utility), "PluginFileExtension", false), value);
    }
}