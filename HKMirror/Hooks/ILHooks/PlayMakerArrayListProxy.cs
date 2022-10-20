using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerArrayListProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerArrayListProxy
{
    public static event ILContext.Manipulator get_arrayList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerArrayListProxy), "get_arrayList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerArrayListProxy), "get_arrayList"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.PlayMakerArrayListProxy.Awake += value;
        remove => IL.PlayMakerArrayListProxy.Awake -= value;
    }

    public static event ILContext.Manipulator isCollectionDefined
    {
        add => IL.PlayMakerArrayListProxy.isCollectionDefined += value;
        remove => IL.PlayMakerArrayListProxy.isCollectionDefined -= value;
    }

    public static event ILContext.Manipulator TakeSnapShot
    {
        add => IL.PlayMakerArrayListProxy.TakeSnapShot += value;
        remove => IL.PlayMakerArrayListProxy.TakeSnapShot -= value;
    }

    public static event ILContext.Manipulator RevertToSnapShot
    {
        add => IL.PlayMakerArrayListProxy.RevertToSnapShot += value;
        remove => IL.PlayMakerArrayListProxy.RevertToSnapShot -= value;
    }

    public static event ILContext.Manipulator Add
    {
        add => IL.PlayMakerArrayListProxy.Add += value;
        remove => IL.PlayMakerArrayListProxy.Add -= value;
    }

    public static event ILContext.Manipulator AddRange
    {
        add => IL.PlayMakerArrayListProxy.AddRange += value;
        remove => IL.PlayMakerArrayListProxy.AddRange -= value;
    }

    public static event ILContext.Manipulator InspectorEdit
    {
        add => IL.PlayMakerArrayListProxy.InspectorEdit += value;
        remove => IL.PlayMakerArrayListProxy.InspectorEdit -= value;
    }

    public static event ILContext.Manipulator Set
    {
        add => IL.PlayMakerArrayListProxy.Set += value;
        remove => IL.PlayMakerArrayListProxy.Set -= value;
    }

    public static event ILContext.Manipulator Remove
    {
        add => IL.PlayMakerArrayListProxy.Remove += value;
        remove => IL.PlayMakerArrayListProxy.Remove -= value;
    }

    public static event ILContext.Manipulator PreFillArrayList
    {
        add => IL.PlayMakerArrayListProxy.PreFillArrayList += value;
        remove => IL.PlayMakerArrayListProxy.PreFillArrayList -= value;
    }
}