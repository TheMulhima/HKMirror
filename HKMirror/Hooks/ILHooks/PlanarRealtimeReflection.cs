namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlanarRealtimeReflection.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlanarRealtimeReflection
{
    public static event ILContext.Manipulator OnWillRenderObject
    {
        add => IL.PlanarRealtimeReflection.OnWillRenderObject += value;
        remove => IL.PlanarRealtimeReflection.OnWillRenderObject -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.PlanarRealtimeReflection.OnDisable += value;
        remove => IL.PlanarRealtimeReflection.OnDisable -= value;
    }

    public static event ILContext.Manipulator UpdateCameraModes
    {
        add => IL.PlanarRealtimeReflection.UpdateCameraModes += value;
        remove => IL.PlanarRealtimeReflection.UpdateCameraModes -= value;
    }

    public static event ILContext.Manipulator CreateSurfaceObjects
    {
        add => IL.PlanarRealtimeReflection.CreateSurfaceObjects += value;
        remove => IL.PlanarRealtimeReflection.CreateSurfaceObjects -= value;
    }

    public static event ILContext.Manipulator sgn
    {
        add => IL.PlanarRealtimeReflection.sgn += value;
        remove => IL.PlanarRealtimeReflection.sgn -= value;
    }

    public static event ILContext.Manipulator CameraSpacePlane
    {
        add => IL.PlanarRealtimeReflection.CameraSpacePlane += value;
        remove => IL.PlanarRealtimeReflection.CameraSpacePlane -= value;
    }

    public static event ILContext.Manipulator CalculateObliqueMatrix
    {
        add => IL.PlanarRealtimeReflection.CalculateObliqueMatrix += value;
        remove => IL.PlanarRealtimeReflection.CalculateObliqueMatrix -= value;
    }

    public static event ILContext.Manipulator CalculateReflectionMatrix
    {
        add => IL.PlanarRealtimeReflection.CalculateReflectionMatrix += value;
        remove => IL.PlanarRealtimeReflection.CalculateReflectionMatrix -= value;
    }
}