using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuSetting
{
    public static event ILContext.Manipulator Start
    {
        add => IL.MenuSetting.Start += value;
        remove => IL.MenuSetting.Start -= value;
    }

    public static event ILContext.Manipulator RefreshValueFromGameSettings
    {
        add => IL.MenuSetting.RefreshValueFromGameSettings += value;
        remove => IL.MenuSetting.RefreshValueFromGameSettings -= value;
    }

    public static event ILContext.Manipulator UpdateSetting
    {
        add => IL.MenuSetting.UpdateSetting += value;
        remove => IL.MenuSetting.UpdateSetting -= value;
    }

    public static event ILContext.Manipulator orig_UpdateSetting
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSetting), "orig_UpdateSetting"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSetting), "orig_UpdateSetting"), value);
    }

    public static event ILContext.Manipulator orig_RefreshValueFromGameSettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSetting), "orig_RefreshValueFromGameSettings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSetting), "orig_RefreshValueFromGameSettings"), value);
    }
}