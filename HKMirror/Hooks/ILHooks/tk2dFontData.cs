using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dFontData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dFontData
{
    public static event ILContext.Manipulator get_inst
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dFontData), "get_inst"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dFontData), "get_inst"), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.tk2dFontData.Init += value;
        remove => IL.tk2dFontData.Init -= value;
    }

    public static event ILContext.Manipulator ResetPlatformData
    {
        add => IL.tk2dFontData.ResetPlatformData += value;
        remove => IL.tk2dFontData.ResetPlatformData -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dFontData.OnDestroy += value;
        remove => IL.tk2dFontData.OnDestroy -= value;
    }

    public static event ILContext.Manipulator InitDictionary
    {
        add => IL.tk2dFontData.InitDictionary += value;
        remove => IL.tk2dFontData.InitDictionary -= value;
    }

    public static event ILContext.Manipulator SetDictionary
    {
        add => IL.tk2dFontData.SetDictionary += value;
        remove => IL.tk2dFontData.SetDictionary -= value;
    }
}