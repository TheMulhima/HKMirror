using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerHashTableProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerHashTableProxy
{
    public static event ILContext.Manipulator get_hashTable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerHashTableProxy), "get_hashTable"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerHashTableProxy), "get_hashTable"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.PlayMakerHashTableProxy.Awake += value;
        remove => IL.PlayMakerHashTableProxy.Awake -= value;
    }

    public static event ILContext.Manipulator isCollectionDefined
    {
        add => IL.PlayMakerHashTableProxy.isCollectionDefined += value;
        remove => IL.PlayMakerHashTableProxy.isCollectionDefined -= value;
    }

    public static event ILContext.Manipulator TakeSnapShot
    {
        add => IL.PlayMakerHashTableProxy.TakeSnapShot += value;
        remove => IL.PlayMakerHashTableProxy.TakeSnapShot -= value;
    }

    public static event ILContext.Manipulator RevertToSnapShot
    {
        add => IL.PlayMakerHashTableProxy.RevertToSnapShot += value;
        remove => IL.PlayMakerHashTableProxy.RevertToSnapShot -= value;
    }

    public static event ILContext.Manipulator InspectorEdit
    {
        add => IL.PlayMakerHashTableProxy.InspectorEdit += value;
        remove => IL.PlayMakerHashTableProxy.InspectorEdit -= value;
    }

    public static event ILContext.Manipulator PreFillHashTable
    {
        add => IL.PlayMakerHashTableProxy.PreFillHashTable += value;
        remove => IL.PlayMakerHashTableProxy.PreFillHashTable -= value;
    }
}