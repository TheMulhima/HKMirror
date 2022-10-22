using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CanvasUtil,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCanvasUtil
{
    public static event ILContext.Manipulator get_TrajanBold
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "get_TrajanBold", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "get_TrajanBold", false), value);
    }

    public static event ILContext.Manipulator get_TrajanNormal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "get_TrajanNormal", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "get_TrajanNormal", false), value);
    }

    public static event ILContext.Manipulator CreateFonts
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateFonts", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateFonts", false),
            value);
    }

    public static event ILContext.Manipulator GetFont
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "GetFont", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "GetFont", false),
            value);
    }

    public static event ILContext.Manipulator NullSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "NullSprite", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "NullSprite", false),
            value);
    }

    public static event ILContext.Manipulator CreateSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateSprite", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateSprite", false), value);
    }

    public static event ILContext.Manipulator CreateCanvas_RenderMode_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false), value);
    }

    public static event ILContext.Manipulator CreateCanvas_RenderMode_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false), value);
    }

    public static event ILContext.Manipulator CreateCanvas_RenderMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateCanvas", false), value);
    }

    public static event ILContext.Manipulator CreateToggleGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateToggleGroup", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "CreateToggleGroup", false), value);
    }

    public static event ILContext.Manipulator FadeInCanvasGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "FadeInCanvasGroup", false).GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "FadeInCanvasGroup", false).GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator FadeOutCanvasGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "FadeOutCanvasGroup", false).GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CanvasUtil), "FadeOutCanvasGroup", false).GetStateMachineTarget(),
            value);
    }
}