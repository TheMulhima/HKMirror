using Microsoft.Xbox;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameSaveLoadedArgs.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameSaveLoadedArgs
{
    public static event ILContext.Manipulator get_Data
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "get_Data"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "get_Data"),
            value);
    }

    public static event ILContext.Manipulator set_Data
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "set_Data"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "set_Data"),
            value);
    }
}