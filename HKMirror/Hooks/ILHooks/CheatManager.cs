using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheatManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheatManager
{
    public static event ILContext.Manipulator get_IsCheatsEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "get_IsCheatsEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "get_IsCheatsEnabled", false), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.CheatManager.Init += value;
        remove => IL.CheatManager.Init -= value;
    }

    public static event ILContext.Manipulator get_IsInstaKillEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "get_IsInstaKillEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "get_IsInstaKillEnabled", false), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CheatManager), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.CheatManager.OnDestroy += value;
        remove => IL.CheatManager.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CheatManager.Update += value;
        remove => IL.CheatManager.Update -= value;
    }

    public static event ILContext.Manipulator ToggleCheatMenu
    {
        add => IL.CheatManager.ToggleCheatMenu += value;
        remove => IL.CheatManager.ToggleCheatMenu -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.CheatManager.OnGUI += value;
        remove => IL.CheatManager.OnGUI -= value;
    }

    public static event ILContext.Manipulator OpenStagStations
    {
        add => IL.CheatManager.OpenStagStations += value;
        remove => IL.CheatManager.OpenStagStations -= value;
    }

    public static event ILContext.Manipulator CheatButton
    {
        add => IL.CheatManager.CheatButton += value;
        remove => IL.CheatManager.CheatButton -= value;
    }

    public static event ILContext.Manipulator SafetyCheatButton
    {
        add => IL.CheatManager.SafetyCheatButton += value;
        remove => IL.CheatManager.SafetyCheatButton -= value;
    }

    public static event ILContext.Manipulator Restore
    {
        add => IL.CheatManager.Restore += value;
        remove => IL.CheatManager.Restore -= value;
    }

    public static event ILContext.Manipulator Kill
    {
        add => IL.CheatManager.Kill += value;
        remove => IL.CheatManager.Kill -= value;
    }

    public static event ILContext.Manipulator GetGeo
    {
        add => IL.CheatManager.GetGeo += value;
        remove => IL.CheatManager.GetGeo -= value;
    }
}