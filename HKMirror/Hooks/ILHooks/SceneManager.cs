using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneManager
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SceneManager.Start += value;
        remove => IL.SceneManager.Start -= value;
    }

    public static event ILContext.Manipulator SetLighting
    {
        add => IL.SceneManager.SetLighting += value;
        remove => IL.SceneManager.SetLighting -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SceneManager.Update += value;
        remove => IL.SceneManager.Update -= value;
    }

    public static event ILContext.Manipulator GetDarknessLevel
    {
        add => IL.SceneManager.GetDarknessLevel += value;
        remove => IL.SceneManager.GetDarknessLevel -= value;
    }

    public static event ILContext.Manipulator SetWindy
    {
        add => IL.SceneManager.SetWindy += value;
        remove => IL.SceneManager.SetWindy -= value;
    }

    public static event ILContext.Manipulator AdjustSaturation
    {
        add => IL.SceneManager.AdjustSaturation += value;
        remove => IL.SceneManager.AdjustSaturation -= value;
    }

    public static event ILContext.Manipulator AdjustSaturationForPlatform
    {
        add => IL.SceneManager.AdjustSaturationForPlatform += value;
        remove => IL.SceneManager.AdjustSaturationForPlatform -= value;
    }

    public static event ILContext.Manipulator PrintDebugInfo
    {
        add => IL.SceneManager.PrintDebugInfo += value;
        remove => IL.SceneManager.PrintDebugInfo -= value;
    }

    public static event ILContext.Manipulator DrawBlackBorders
    {
        add => IL.SceneManager.DrawBlackBorders += value;
        remove => IL.SceneManager.DrawBlackBorders -= value;
    }

    public static event ILContext.Manipulator AddSceneMapped
    {
        add => IL.SceneManager.AddSceneMapped += value;
        remove => IL.SceneManager.AddSceneMapped -= value;
    }

    public static event ILContext.Manipulator UpdateSceneSettings
    {
        add => IL.SceneManager.UpdateSceneSettings += value;
        remove => IL.SceneManager.UpdateSceneSettings -= value;
    }

    public static event ILContext.Manipulator orig_Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneManager), "orig_Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneManager), "orig_Update"),
            value);
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneManager), "orig_Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneManager), "orig_Start"),
            value);
    }
}