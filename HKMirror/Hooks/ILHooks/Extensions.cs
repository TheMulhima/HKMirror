using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Extensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILExtensions
{
    public static event ILContext.Manipulator GetFirstInteractable
    {
        add => IL.Extensions.GetFirstInteractable += value;
        remove => IL.Extensions.GetFirstInteractable -= value;
    }

    public static event ILContext.Manipulator PlayOnSource
    {
        add => IL.Extensions.PlayOnSource += value;
        remove => IL.Extensions.PlayOnSource -= value;
    }

    public static event ILContext.Manipulator SetActiveChildren
    {
        add => IL.Extensions.SetActiveChildren += value;
        remove => IL.Extensions.SetActiveChildren -= value;
    }

    public static event ILContext.Manipulator SetActiveWithChildren
    {
        add => IL.Extensions.SetActiveWithChildren += value;
        remove => IL.Extensions.SetActiveWithChildren -= value;
    }

    public static event ILContext.Manipulator HasParameter
    {
        add => IL.Extensions.HasParameter += value;
        remove => IL.Extensions.HasParameter -= value;
    }

    public static event ILContext.Manipulator PlayAnimWait
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Extensions), "PlayAnimWait", false).GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Extensions), "PlayAnimWait", false).GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlayAnimGetTime
    {
        add => IL.Extensions.PlayAnimGetTime += value;
        remove => IL.Extensions.PlayAnimGetTime -= value;
    }

    public static event ILContext.Manipulator MultiplyElements_Vector3_Vector3
    {
        add => IL.Extensions.MultiplyElements_Vector3_Vector3 += value;
        remove => IL.Extensions.MultiplyElements_Vector3_Vector3 -= value;
    }

    public static event ILContext.Manipulator MultiplyElements_Vector2_Vector2
    {
        add => IL.Extensions.MultiplyElements_Vector2_Vector2 += value;
        remove => IL.Extensions.MultiplyElements_Vector2_Vector2 -= value;
    }

    public static event ILContext.Manipulator SetPositionX
    {
        add => IL.Extensions.SetPositionX += value;
        remove => IL.Extensions.SetPositionX -= value;
    }

    public static event ILContext.Manipulator SetPositionY
    {
        add => IL.Extensions.SetPositionY += value;
        remove => IL.Extensions.SetPositionY -= value;
    }

    public static event ILContext.Manipulator SetPositionZ
    {
        add => IL.Extensions.SetPositionZ += value;
        remove => IL.Extensions.SetPositionZ -= value;
    }

    public static event ILContext.Manipulator SetPosition2D_Transform_float_float
    {
        add => IL.Extensions.SetPosition2D_Transform_float_float += value;
        remove => IL.Extensions.SetPosition2D_Transform_float_float -= value;
    }

    public static event ILContext.Manipulator SetPosition2D_Transform_Vector2
    {
        add => IL.Extensions.SetPosition2D_Transform_Vector2 += value;
        remove => IL.Extensions.SetPosition2D_Transform_Vector2 -= value;
    }

    public static event ILContext.Manipulator SetPosition3D
    {
        add => IL.Extensions.SetPosition3D += value;
        remove => IL.Extensions.SetPosition3D -= value;
    }

    public static event ILContext.Manipulator SetScaleX
    {
        add => IL.Extensions.SetScaleX += value;
        remove => IL.Extensions.SetScaleX -= value;
    }

    public static event ILContext.Manipulator SetScaleY
    {
        add => IL.Extensions.SetScaleY += value;
        remove => IL.Extensions.SetScaleY -= value;
    }

    public static event ILContext.Manipulator SetScaleZ
    {
        add => IL.Extensions.SetScaleZ += value;
        remove => IL.Extensions.SetScaleZ -= value;
    }

    public static event ILContext.Manipulator SetRotationZ
    {
        add => IL.Extensions.SetRotationZ += value;
        remove => IL.Extensions.SetRotationZ -= value;
    }

    public static event ILContext.Manipulator SetScaleMatching
    {
        add => IL.Extensions.SetScaleMatching += value;
        remove => IL.Extensions.SetScaleMatching -= value;
    }

    public static event ILContext.Manipulator GetPositionX
    {
        add => IL.Extensions.GetPositionX += value;
        remove => IL.Extensions.GetPositionX -= value;
    }

    public static event ILContext.Manipulator GetPositionY
    {
        add => IL.Extensions.GetPositionY += value;
        remove => IL.Extensions.GetPositionY -= value;
    }

    public static event ILContext.Manipulator GetPositionZ
    {
        add => IL.Extensions.GetPositionZ += value;
        remove => IL.Extensions.GetPositionZ -= value;
    }

    public static event ILContext.Manipulator GetScaleX
    {
        add => IL.Extensions.GetScaleX += value;
        remove => IL.Extensions.GetScaleX -= value;
    }

    public static event ILContext.Manipulator GetScaleY
    {
        add => IL.Extensions.GetScaleY += value;
        remove => IL.Extensions.GetScaleY -= value;
    }

    public static event ILContext.Manipulator GetScaleZ
    {
        add => IL.Extensions.GetScaleZ += value;
        remove => IL.Extensions.GetScaleZ -= value;
    }

    public static event ILContext.Manipulator GetRotation2D
    {
        add => IL.Extensions.GetRotation2D += value;
        remove => IL.Extensions.GetRotation2D -= value;
    }

    public static event ILContext.Manipulator SetRotation2D
    {
        add => IL.Extensions.SetRotation2D += value;
        remove => IL.Extensions.SetRotation2D -= value;
    }

    public static event ILContext.Manipulator IsAny
    {
        add => IL.Extensions.IsAny += value;
        remove => IL.Extensions.IsAny -= value;
    }
}