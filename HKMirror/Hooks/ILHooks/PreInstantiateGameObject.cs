using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreInstantiateGameObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreInstantiateGameObject
{
    public static event ILContext.Manipulator get_InstantiatedGameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PreInstantiateGameObject), "get_InstantiatedGameObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PreInstantiateGameObject), "get_InstantiatedGameObject"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.PreInstantiateGameObject.Awake += value;
        remove => IL.PreInstantiateGameObject.Awake -= value;
    }
}