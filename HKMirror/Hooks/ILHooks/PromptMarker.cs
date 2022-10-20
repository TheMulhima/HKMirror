using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PromptMarker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPromptMarker
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PromptMarker.Awake += value;
        remove => IL.PromptMarker.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.PromptMarker.Start += value;
        remove => IL.PromptMarker.Start -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.PromptMarker.OnDestroy += value;
        remove => IL.PromptMarker.OnDestroy -= value;
    }

    public static event ILContext.Manipulator RecycleOnLevelLoad
    {
        add => IL.PromptMarker.RecycleOnLevelLoad += value;
        remove => IL.PromptMarker.RecycleOnLevelLoad -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PromptMarker.OnEnable += value;
        remove => IL.PromptMarker.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PromptMarker.Update += value;
        remove => IL.PromptMarker.Update -= value;
    }

    public static event ILContext.Manipulator SetLabel
    {
        add => IL.PromptMarker.SetLabel += value;
        remove => IL.PromptMarker.SetLabel -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.PromptMarker.Show += value;
        remove => IL.PromptMarker.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.PromptMarker.Hide += value;
        remove => IL.PromptMarker.Hide -= value;
    }

    public static event ILContext.Manipulator RecycleDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PromptMarker), "RecycleDelayed").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PromptMarker), "RecycleDelayed").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetOwner
    {
        add => IL.PromptMarker.SetOwner += value;
        remove => IL.PromptMarker.SetOwner -= value;
    }
}