using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NextSceneOnInput.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNextSceneOnInput
{
    public static event ILContext.Manipulator get_AcceptingInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NextSceneOnInput), "get_AcceptingInput"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NextSceneOnInput), "get_AcceptingInput"), value);
    }

    public static event ILContext.Manipulator get_ButtonPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NextSceneOnInput), "get_ButtonPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NextSceneOnInput), "get_ButtonPressed"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.NextSceneOnInput.Start += value;
        remove => IL.NextSceneOnInput.Start -= value;
    }

    public static event ILContext.Manipulator UnlockSkip
    {
        add => IL.NextSceneOnInput.UnlockSkip += value;
        remove => IL.NextSceneOnInput.UnlockSkip -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.NextSceneOnInput.Update += value;
        remove => IL.NextSceneOnInput.Update -= value;
    }

    public static event ILContext.Manipulator Skip
    {
        add => IL.NextSceneOnInput.Skip += value;
        remove => IL.NextSceneOnInput.Skip -= value;
    }
}