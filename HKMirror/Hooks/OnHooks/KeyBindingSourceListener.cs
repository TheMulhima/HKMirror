using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for KeyBindingSourceListener class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnKeyBindingSourceListener
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<KeyBindingSourceListener> orig, KeyBindingSourceListener self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookListen()
        {
            if (!HookedList.Contains("Listen"))
            {
                HookedList.Add("Listen");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Listen"), Listen);
            }
        }

        internal static event Delegates.Listen_BeforeArgs _beforeListen;
        internal static event Delegates.Listen_NormalArgs _afterListen;

        private static BindingSource Listen(
            Func<KeyBindingSourceListener, BindingListenOptions, InputDevice, BindingSource> orig,
            KeyBindingSourceListener self, BindingListenOptions listenOptions, InputDevice device)
        {
            Delegates.Params_Listen @params = new()
            {
                self = self, listenOptions = listenOptions, device = device
            };
            _beforeListen?.Invoke(@params);
            self = @params.self;
            listenOptions = @params.listenOptions;
            device = @params.device;
            var retVal = orig(self, listenOptions, device);
            if (_afterListen != null) retVal = _afterListen.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Listen_BeforeArgs(Params_Listen args);

        public delegate BindingSource Listen_NormalArgs(Params_Listen args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public KeyBindingSourceListener self;
        }

        public sealed class Params_Listen
        {
            public InputDevice device;
            public BindingListenOptions listenOptions;
            public KeyBindingSourceListener self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.Listen_BeforeArgs Listen
        {
            add
            {
                HookHandler._beforeListen += value;
                HookHandler.HookListen();
            }
            remove => HookHandler._beforeListen -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.Listen_NormalArgs Listen
        {
            add
            {
                HookHandler._afterListen += value;
                HookHandler.HookListen();
            }
            remove => HookHandler._afterListen -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Reset"), value);
        }

        public static event Delegates.Listen_NormalArgs Listen
        {
            add => HookEndpointManager.Add<Delegates.Listen_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Listen"), value);
            remove => HookEndpointManager.Remove<Delegates.Listen_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Listen"), value);
        }
    }
}