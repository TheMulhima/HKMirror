using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Helper,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHelper
{
    public static event ILContext.Manipulator GetCollidingLayerMaskForLayer
    {
        add => IL.Helper.GetCollidingLayerMaskForLayer += value;
        remove => IL.Helper.GetCollidingLayerMaskForLayer -= value;
    }

    public static event ILContext.Manipulator GetReflectedAngle
    {
        add => IL.Helper.GetReflectedAngle += value;
        remove => IL.Helper.GetReflectedAngle -= value;
    }

    public static event ILContext.Manipulator GetRandomVector3InRange
    {
        add => IL.Helper.GetRandomVector3InRange += value;
        remove => IL.Helper.GetRandomVector3InRange -= value;
    }

    public static event ILContext.Manipulator GetRandomVector2InRange
    {
        add => IL.Helper.GetRandomVector2InRange += value;
        remove => IL.Helper.GetRandomVector2InRange -= value;
    }

    public static event ILContext.Manipulator IsRayHittingNoTriggers_Vector2_Vector2_float_int_RaycastHit2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Helper), "IsRayHittingNoTriggers", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Helper), "IsRayHittingNoTriggers", false), value);
    }

    public static event ILContext.Manipulator IsRayHittingNoTriggers_Vector2_Vector2_float_int
    {
        add => IL.Helper.IsRayHittingNoTriggers_Vector2_Vector2_float_int += value;
        remove => IL.Helper.IsRayHittingNoTriggers_Vector2_Vector2_float_int -= value;
    }

    public static event ILContext.Manipulator CombinePaths
    {
        add => IL.Helper.CombinePaths += value;
        remove => IL.Helper.CombinePaths -= value;
    }

    public static event ILContext.Manipulator FileOrFolderExists
    {
        add => IL.Helper.FileOrFolderExists += value;
        remove => IL.Helper.FileOrFolderExists -= value;
    }

    public static event ILContext.Manipulator DeleteFileOrFolder
    {
        add => IL.Helper.DeleteFileOrFolder += value;
        remove => IL.Helper.DeleteFileOrFolder -= value;
    }

    public static event ILContext.Manipulator CopyFileOrFolder
    {
        add => IL.Helper.CopyFileOrFolder += value;
        remove => IL.Helper.CopyFileOrFolder -= value;
    }

    public static event ILContext.Manipulator DeepCopy
    {
        add => IL.Helper.DeepCopy += value;
        remove => IL.Helper.DeepCopy -= value;
    }

    public static event ILContext.Manipulator MoveFileOrFolder
    {
        add => IL.Helper.MoveFileOrFolder += value;
        remove => IL.Helper.MoveFileOrFolder -= value;
    }

    public static event ILContext.Manipulator CheckMatchingSearchFilter
    {
        add => IL.Helper.CheckMatchingSearchFilter += value;
        remove => IL.Helper.CheckMatchingSearchFilter -= value;
    }

    public static event ILContext.Manipulator ParseSearchString
    {
        add => IL.Helper.ParseSearchString += value;
        remove => IL.Helper.ParseSearchString -= value;
    }
}