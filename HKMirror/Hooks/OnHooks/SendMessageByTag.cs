using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SendMessageByTag class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSendMessageByTag
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<SendMessageByTag> orig, SendMessageByTag self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<SendMessageByTag> orig, SendMessageByTag self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                    try
                    {
                        _afterOnExit.Invoke(@params);
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
        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SendMessageByTag> orig, SendMessageByTag self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<SendMessageByTag> orig, SendMessageByTag self);

        public sealed class Params_OnEnter
        {
            public SendMessageByTag self;
        }

        public sealed class Params_OnExit
        {
            public SendMessageByTag self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnEnter"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SendMessageByTag), "OnExit"), value);
        }
    }
}