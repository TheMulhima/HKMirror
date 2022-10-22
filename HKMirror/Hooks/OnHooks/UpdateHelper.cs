using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for UpdateHelper class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUpdateHelper
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSetDirty()
        {
            if (!HookedList.Contains("SetDirty"))
            {
                HookedList.Add("SetDirty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UpdateHelper), "SetDirty", false), SetDirty);
            }
        }

        internal static event Delegates.SetDirty_BeforeArgs _beforeSetDirty;
        internal static event Delegates.SetDirty_AfterArgs _afterSetDirty;

        private static void SetDirty(Action<Fsm> orig, Fsm fsm)
        {
            Delegates.Params_SetDirty @params = new()
            {
                fsm = fsm
            };
            if (_beforeSetDirty != null)
                foreach (Delegates.SetDirty_BeforeArgs toInvoke in _beforeSetDirty.GetInvocationList())
                    try
                    {
                        _beforeSetDirty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            fsm = @params.fsm;
            orig(fsm);
            if (_afterSetDirty != null)
                foreach (Delegates.SetDirty_AfterArgs toInvoke in _afterSetDirty.GetInvocationList())
                    try
                    {
                        _afterSetDirty.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void SetDirty_AfterArgs(Params_SetDirty args);

        public delegate void SetDirty_BeforeArgs(Params_SetDirty args);

        public delegate void SetDirty_WithArgs(Action<Fsm> orig, Fsm fsm);

        public sealed class Params_SetDirty
        {
            public Fsm fsm;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SetDirty_BeforeArgs SetDirty
        {
            add
            {
                HookHandler._beforeSetDirty += value;
                HookHandler.HookSetDirty();
            }
            remove => HookHandler._beforeSetDirty -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SetDirty_AfterArgs SetDirty
        {
            add
            {
                HookHandler._afterSetDirty += value;
                HookHandler.HookSetDirty();
            }
            remove => HookHandler._afterSetDirty -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.SetDirty_WithArgs SetDirty
        {
            add => HookEndpointManager.Add<Delegates.SetDirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UpdateHelper), "SetDirty", false), value);
            remove => HookEndpointManager.Remove<Delegates.SetDirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UpdateHelper), "SetDirty", false), value);
        }
    }
}