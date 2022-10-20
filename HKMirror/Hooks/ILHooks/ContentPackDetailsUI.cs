using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ContentPackDetailsUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILContentPackDetailsUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ContentPackDetailsUI.Awake += value;
        remove => IL.ContentPackDetailsUI.Awake -= value;
    }

    public static event ILContext.Manipulator ShowPackDetails
    {
        add => IL.ContentPackDetailsUI.ShowPackDetails += value;
        remove => IL.ContentPackDetailsUI.ShowPackDetails -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ContentPackDetailsUI.OnEnable += value;
        remove => IL.ContentPackDetailsUI.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.ContentPackDetailsUI.OnDisable += value;
        remove => IL.ContentPackDetailsUI.OnDisable -= value;
    }

    public static event ILContext.Manipulator UpdateDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ContentPackDetailsUI), "UpdateDelayed").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ContentPackDetailsUI), "UpdateDelayed").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator UndoMenuStyle
    {
        add => IL.ContentPackDetailsUI.UndoMenuStyle += value;
        remove => IL.ContentPackDetailsUI.UndoMenuStyle -= value;
    }
}