using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LightBlur.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLightBlur
{
    public static event ILContext.Manipulator get_PassGroupCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "get_PassGroupCount"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "get_PassGroupCount"),
            value);
    }

    public static event ILContext.Manipulator set_PassGroupCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "set_PassGroupCount"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "set_PassGroupCount"),
            value);
    }

    public static event ILContext.Manipulator get_BlurPassCount
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "get_BlurPassCount"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LightBlur), "get_BlurPassCount"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.LightBlur.Awake += value;
        remove => IL.LightBlur.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.LightBlur.OnDestroy += value;
        remove => IL.LightBlur.OnDestroy -= value;
    }

    public static event ILContext.Manipulator CheckResources
    {
        add => IL.LightBlur.CheckResources += value;
        remove => IL.LightBlur.CheckResources -= value;
    }

    public static event ILContext.Manipulator OnRenderImage
    {
        add => IL.LightBlur.OnRenderImage += value;
        remove => IL.LightBlur.OnRenderImage -= value;
    }
}