namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneParticlesController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneParticlesController
{
    public static event ILContext.Manipulator SceneInit
    {
        add => IL.SceneParticlesController.SceneInit += value;
        remove => IL.SceneParticlesController.SceneInit -= value;
    }

    public static event ILContext.Manipulator EnableParticles
    {
        add => IL.SceneParticlesController.EnableParticles += value;
        remove => IL.SceneParticlesController.EnableParticles -= value;
    }

    public static event ILContext.Manipulator DisableParticles
    {
        add => IL.SceneParticlesController.DisableParticles += value;
        remove => IL.SceneParticlesController.DisableParticles -= value;
    }

    public static event ILContext.Manipulator BeginScene
    {
        add => IL.SceneParticlesController.BeginScene += value;
        remove => IL.SceneParticlesController.BeginScene -= value;
    }
}