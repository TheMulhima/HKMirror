using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUIHoverItem class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUIHoverItem
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsOver()
        {
            if (!HookedList.Contains("get_IsOver"))
            {
                HookedList.Add("get_IsOver");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "get_IsOver"), get_IsOver);
            }
        }

        internal static event Delegates.get_IsOver_BeforeArgs _beforeget_IsOver;
        internal static event Delegates.get_IsOver_NormalArgs _afterget_IsOver;

        private static bool get_IsOver(Func<tk2dUIHoverItem, bool> orig, tk2dUIHoverItem self)
        {
            Delegates.Params_get_IsOver @params = new()
            {
                self = self
            };
            _beforeget_IsOver?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsOver != null) retVal = _afterget_IsOver.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_IsOver()
        {
            if (!HookedList.Contains("set_IsOver"))
            {
                HookedList.Add("set_IsOver");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "set_IsOver"), set_IsOver);
            }
        }

        internal static event Delegates.set_IsOver_BeforeArgs _beforeset_IsOver;
        internal static event Delegates.set_IsOver_NormalArgs _afterset_IsOver;

        private static void set_IsOver(Action<tk2dUIHoverItem, bool> orig, tk2dUIHoverItem self, bool value)
        {
            Delegates.Params_set_IsOver @params = new()
            {
                self = self, value = value
            };
            _beforeset_IsOver?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_IsOver != null) _afterset_IsOver.Invoke(@params);
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.tk2dUIHoverItem.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.tk2dUIHoverItem.orig_Start orig, tk2dUIHoverItem self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.tk2dUIHoverItem.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUIHoverItem.orig_OnEnable orig, tk2dUIHoverItem self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.tk2dUIHoverItem.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUIHoverItem.orig_OnDisable orig, tk2dUIHoverItem self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }

        internal static void HookHoverOver()
        {
            if (!HookedList.Contains("HoverOver"))
            {
                HookedList.Add("HoverOver");
                On.tk2dUIHoverItem.HoverOver += HoverOver;
            }
        }

        internal static event Delegates.HoverOver_BeforeArgs _beforeHoverOver;
        internal static event Delegates.HoverOver_NormalArgs _afterHoverOver;

        private static void HoverOver(On.tk2dUIHoverItem.orig_HoverOver orig, tk2dUIHoverItem self)
        {
            Delegates.Params_HoverOver @params = new()
            {
                self = self
            };
            _beforeHoverOver?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterHoverOver != null) _afterHoverOver.Invoke(@params);
        }

        internal static void HookHoverOut()
        {
            if (!HookedList.Contains("HoverOut"))
            {
                HookedList.Add("HoverOut");
                On.tk2dUIHoverItem.HoverOut += HoverOut;
            }
        }

        internal static event Delegates.HoverOut_BeforeArgs _beforeHoverOut;
        internal static event Delegates.HoverOut_NormalArgs _afterHoverOut;

        private static void HoverOut(On.tk2dUIHoverItem.orig_HoverOut orig, tk2dUIHoverItem self)
        {
            Delegates.Params_HoverOut @params = new()
            {
                self = self
            };
            _beforeHoverOut?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterHoverOut != null) _afterHoverOut.Invoke(@params);
        }

        internal static void HookSetState()
        {
            if (!HookedList.Contains("SetState"))
            {
                HookedList.Add("SetState");
                On.tk2dUIHoverItem.SetState += SetState;
            }
        }

        internal static event Delegates.SetState_BeforeArgs _beforeSetState;
        internal static event Delegates.SetState_NormalArgs _afterSetState;

        private static void SetState(On.tk2dUIHoverItem.orig_SetState orig, tk2dUIHoverItem self)
        {
            Delegates.Params_SetState @params = new()
            {
                self = self
            };
            _beforeSetState?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSetState != null) _afterSetState.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_IsOver_BeforeArgs(Params_get_IsOver args);

        public delegate bool get_IsOver_NormalArgs(Params_get_IsOver args);

        public delegate void HoverOut_BeforeArgs(Params_HoverOut args);

        public delegate void HoverOut_NormalArgs(Params_HoverOut args);

        public delegate void HoverOver_BeforeArgs(Params_HoverOver args);

        public delegate void HoverOver_NormalArgs(Params_HoverOver args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void set_IsOver_BeforeArgs(Params_set_IsOver args);

        public delegate void set_IsOver_NormalArgs(Params_set_IsOver args);

        public delegate void SetState_BeforeArgs(Params_SetState args);

        public delegate void SetState_NormalArgs(Params_SetState args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_get_IsOver
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_set_IsOver
        {
            public tk2dUIHoverItem self;
            public bool value;
        }

        public sealed class Params_Start
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_OnEnable
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_OnDisable
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_HoverOver
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_HoverOut
        {
            public tk2dUIHoverItem self;
        }

        public sealed class Params_SetState
        {
            public tk2dUIHoverItem self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsOver_BeforeArgs get_IsOver
        {
            add
            {
                HookHandler._beforeget_IsOver += value;
                HookHandler.Hookget_IsOver();
            }
            remove => HookHandler._beforeget_IsOver -= value;
        }

        public static event Delegates.set_IsOver_BeforeArgs set_IsOver
        {
            add
            {
                HookHandler._beforeset_IsOver += value;
                HookHandler.Hookset_IsOver();
            }
            remove => HookHandler._beforeset_IsOver -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.HoverOver_BeforeArgs HoverOver
        {
            add
            {
                HookHandler._beforeHoverOver += value;
                HookHandler.HookHoverOver();
            }
            remove => HookHandler._beforeHoverOver -= value;
        }

        public static event Delegates.HoverOut_BeforeArgs HoverOut
        {
            add
            {
                HookHandler._beforeHoverOut += value;
                HookHandler.HookHoverOut();
            }
            remove => HookHandler._beforeHoverOut -= value;
        }

        public static event Delegates.SetState_BeforeArgs SetState
        {
            add
            {
                HookHandler._beforeSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._beforeSetState -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsOver_NormalArgs get_IsOver
        {
            add
            {
                HookHandler._afterget_IsOver += value;
                HookHandler.Hookget_IsOver();
            }
            remove => HookHandler._afterget_IsOver -= value;
        }

        public static event Delegates.set_IsOver_NormalArgs set_IsOver
        {
            add
            {
                HookHandler._afterset_IsOver += value;
                HookHandler.Hookset_IsOver();
            }
            remove => HookHandler._afterset_IsOver -= value;
        }

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.HoverOver_NormalArgs HoverOver
        {
            add
            {
                HookHandler._afterHoverOver += value;
                HookHandler.HookHoverOver();
            }
            remove => HookHandler._afterHoverOver -= value;
        }

        public static event Delegates.HoverOut_NormalArgs HoverOut
        {
            add
            {
                HookHandler._afterHoverOut += value;
                HookHandler.HookHoverOut();
            }
            remove => HookHandler._afterHoverOut -= value;
        }

        public static event Delegates.SetState_NormalArgs SetState
        {
            add
            {
                HookHandler._afterSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._afterSetState -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsOver_NormalArgs get_IsOver
        {
            add => HookEndpointManager.Add<Delegates.get_IsOver_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "get_IsOver"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsOver_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "get_IsOver"), value);
        }

        public static event Delegates.set_IsOver_NormalArgs set_IsOver
        {
            add => HookEndpointManager.Add<Delegates.set_IsOver_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "set_IsOver"), value);
            remove => HookEndpointManager.Remove<Delegates.set_IsOver_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "set_IsOver"), value);
        }

        public static event On.tk2dUIHoverItem.hook_Start Start
        {
            add => On.tk2dUIHoverItem.Start += value;
            remove => On.tk2dUIHoverItem.Start -= value;
        }

        public static event On.tk2dUIHoverItem.hook_OnEnable OnEnable
        {
            add => On.tk2dUIHoverItem.OnEnable += value;
            remove => On.tk2dUIHoverItem.OnEnable -= value;
        }

        public static event On.tk2dUIHoverItem.hook_OnDisable OnDisable
        {
            add => On.tk2dUIHoverItem.OnDisable += value;
            remove => On.tk2dUIHoverItem.OnDisable -= value;
        }

        public static event On.tk2dUIHoverItem.hook_HoverOver HoverOver
        {
            add => On.tk2dUIHoverItem.HoverOver += value;
            remove => On.tk2dUIHoverItem.HoverOver -= value;
        }

        public static event On.tk2dUIHoverItem.hook_HoverOut HoverOut
        {
            add => On.tk2dUIHoverItem.HoverOut += value;
            remove => On.tk2dUIHoverItem.HoverOut -= value;
        }

        public static event On.tk2dUIHoverItem.hook_SetState SetState
        {
            add => On.tk2dUIHoverItem.SetState += value;
            remove => On.tk2dUIHoverItem.SetState -= value;
        }
    }
}