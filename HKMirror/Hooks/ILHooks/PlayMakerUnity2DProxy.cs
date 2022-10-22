using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUnity2DProxy,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUnity2DProxy
{
    public static event ILContext.Manipulator AddOnCollisionEnter2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnCollisionEnter2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnCollisionEnter2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnCollisionEnter2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnCollisionEnter2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnCollisionEnter2dDelegate -= value;
    }

    public static event ILContext.Manipulator AddOnCollisionStay2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnCollisionStay2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnCollisionStay2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnCollisionStay2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnCollisionStay2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnCollisionStay2dDelegate -= value;
    }

    public static event ILContext.Manipulator AddOnCollisionExit2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnCollisionExit2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnCollisionExit2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnCollisionExit2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnCollisionExit2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnCollisionExit2dDelegate -= value;
    }

    public static event ILContext.Manipulator AddOnTriggerEnter2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnTriggerEnter2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnTriggerEnter2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnTriggerEnter2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnTriggerEnter2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnTriggerEnter2dDelegate -= value;
    }

    public static event ILContext.Manipulator AddOnTriggerStay2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnTriggerStay2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnTriggerStay2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnTriggerStay2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnTriggerStay2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnTriggerStay2dDelegate -= value;
    }

    public static event ILContext.Manipulator AddOnTriggerExit2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.AddOnTriggerExit2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.AddOnTriggerExit2dDelegate -= value;
    }

    public static event ILContext.Manipulator RemoveOnTriggerExit2dDelegate
    {
        add => IL.PlayMakerUnity2DProxy.RemoveOnTriggerExit2dDelegate += value;
        remove => IL.PlayMakerUnity2DProxy.RemoveOnTriggerExit2dDelegate -= value;
    }

    public static event ILContext.Manipulator help
    {
        add => IL.PlayMakerUnity2DProxy.help += value;
        remove => IL.PlayMakerUnity2DProxy.help -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.PlayMakerUnity2DProxy.Start += value;
        remove => IL.PlayMakerUnity2DProxy.Start -= value;
    }

    public static event ILContext.Manipulator RefreshImplementation
    {
        add => IL.PlayMakerUnity2DProxy.RefreshImplementation += value;
        remove => IL.PlayMakerUnity2DProxy.RefreshImplementation -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.PlayMakerUnity2DProxy.OnCollisionEnter2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionStay2D
    {
        add => IL.PlayMakerUnity2DProxy.OnCollisionStay2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnCollisionStay2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionExit2D
    {
        add => IL.PlayMakerUnity2DProxy.OnCollisionExit2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnCollisionExit2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.PlayMakerUnity2DProxy.OnTriggerEnter2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.PlayMakerUnity2DProxy.OnTriggerStay2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.PlayMakerUnity2DProxy.OnTriggerExit2D += value;
        remove => IL.PlayMakerUnity2DProxy.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator CheckGameObjectEventsImplementation
    {
        add => IL.PlayMakerUnity2DProxy.CheckGameObjectEventsImplementation += value;
        remove => IL.PlayMakerUnity2DProxy.CheckGameObjectEventsImplementation -= value;
    }

    public static event ILContext.Manipulator CheckFsmEventsImplementation
    {
        add => IL.PlayMakerUnity2DProxy.CheckFsmEventsImplementation += value;
        remove => IL.PlayMakerUnity2DProxy.CheckFsmEventsImplementation -= value;
    }

    public static event ILContext.Manipulator CheckTransition
    {
        add => IL.PlayMakerUnity2DProxy.CheckTransition += value;
        remove => IL.PlayMakerUnity2DProxy.CheckTransition -= value;
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayMakerUnity2DProxy), "orig_Start"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUnity2DProxy), "orig_Start"), value);
    }
}