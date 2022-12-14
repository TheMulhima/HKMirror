using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUIMultiStateToggleButton class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUIMultiStateToggleButton
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Index()
        {
            if (!HookedList.Contains("get_Index"))
            {
                HookedList.Add("get_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "get_Index"), get_Index);
            }
        }

        internal static event Delegates.get_Index_BeforeArgs _beforeget_Index;
        internal static event Delegates.get_Index_AfterArgs _afterget_Index;

        private static int get_Index(Func<tk2dUIMultiStateToggleButton, int> orig, tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_get_Index @params = new()
            {
                self = self
            };
            if (_beforeget_Index != null)
                foreach (Delegates.get_Index_BeforeArgs toInvoke in _beforeget_Index.GetInvocationList())
                    try
                    {
                        _beforeget_Index?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Index != null)
                foreach (Delegates.get_Index_AfterArgs toInvoke in _afterget_Index.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Index.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_Index()
        {
            if (!HookedList.Contains("set_Index"))
            {
                HookedList.Add("set_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "set_Index"), set_Index);
            }
        }

        internal static event Delegates.set_Index_BeforeArgs _beforeset_Index;
        internal static event Delegates.set_Index_AfterArgs _afterset_Index;

        private static void set_Index(Action<tk2dUIMultiStateToggleButton, int> orig, tk2dUIMultiStateToggleButton self,
            int value)
        {
            Delegates.Params_set_Index @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Index != null)
                foreach (Delegates.set_Index_BeforeArgs toInvoke in _beforeset_Index.GetInvocationList())
                    try
                    {
                        _beforeset_Index?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Index != null)
                foreach (Delegates.set_Index_AfterArgs toInvoke in _afterset_Index.GetInvocationList())
                    try
                    {
                        _afterset_Index.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.tk2dUIMultiStateToggleButton.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.tk2dUIMultiStateToggleButton.orig_Start orig, tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.tk2dUIMultiStateToggleButton.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUIMultiStateToggleButton.orig_OnEnable orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.tk2dUIMultiStateToggleButton.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUIMultiStateToggleButton.orig_OnDisable orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookButtonClick()
        {
            if (!HookedList.Contains("ButtonClick"))
            {
                HookedList.Add("ButtonClick");
                On.tk2dUIMultiStateToggleButton.ButtonClick += ButtonClick;
            }
        }

        internal static event Delegates.ButtonClick_BeforeArgs _beforeButtonClick;
        internal static event Delegates.ButtonClick_AfterArgs _afterButtonClick;

        private static void ButtonClick(On.tk2dUIMultiStateToggleButton.orig_ButtonClick orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_ButtonClick @params = new()
            {
                self = self
            };
            if (_beforeButtonClick != null)
                foreach (Delegates.ButtonClick_BeforeArgs toInvoke in _beforeButtonClick.GetInvocationList())
                    try
                    {
                        _beforeButtonClick?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterButtonClick != null)
                foreach (Delegates.ButtonClick_AfterArgs toInvoke in _afterButtonClick.GetInvocationList())
                    try
                    {
                        _afterButtonClick.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookButtonDown()
        {
            if (!HookedList.Contains("ButtonDown"))
            {
                HookedList.Add("ButtonDown");
                On.tk2dUIMultiStateToggleButton.ButtonDown += ButtonDown;
            }
        }

        internal static event Delegates.ButtonDown_BeforeArgs _beforeButtonDown;
        internal static event Delegates.ButtonDown_AfterArgs _afterButtonDown;

        private static void ButtonDown(On.tk2dUIMultiStateToggleButton.orig_ButtonDown orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_ButtonDown @params = new()
            {
                self = self
            };
            if (_beforeButtonDown != null)
                foreach (Delegates.ButtonDown_BeforeArgs toInvoke in _beforeButtonDown.GetInvocationList())
                    try
                    {
                        _beforeButtonDown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterButtonDown != null)
                foreach (Delegates.ButtonDown_AfterArgs toInvoke in _afterButtonDown.GetInvocationList())
                    try
                    {
                        _afterButtonDown.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookButtonToggle()
        {
            if (!HookedList.Contains("ButtonToggle"))
            {
                HookedList.Add("ButtonToggle");
                On.tk2dUIMultiStateToggleButton.ButtonToggle += ButtonToggle;
            }
        }

        internal static event Delegates.ButtonToggle_BeforeArgs _beforeButtonToggle;
        internal static event Delegates.ButtonToggle_AfterArgs _afterButtonToggle;

        private static void ButtonToggle(On.tk2dUIMultiStateToggleButton.orig_ButtonToggle orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_ButtonToggle @params = new()
            {
                self = self
            };
            if (_beforeButtonToggle != null)
                foreach (Delegates.ButtonToggle_BeforeArgs toInvoke in _beforeButtonToggle.GetInvocationList())
                    try
                    {
                        _beforeButtonToggle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterButtonToggle != null)
                foreach (Delegates.ButtonToggle_AfterArgs toInvoke in _afterButtonToggle.GetInvocationList())
                    try
                    {
                        _afterButtonToggle.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetState()
        {
            if (!HookedList.Contains("SetState"))
            {
                HookedList.Add("SetState");
                On.tk2dUIMultiStateToggleButton.SetState += SetState;
            }
        }

        internal static event Delegates.SetState_BeforeArgs _beforeSetState;
        internal static event Delegates.SetState_AfterArgs _afterSetState;

        private static void SetState(On.tk2dUIMultiStateToggleButton.orig_SetState orig,
            tk2dUIMultiStateToggleButton self)
        {
            Delegates.Params_SetState @params = new()
            {
                self = self
            };
            if (_beforeSetState != null)
                foreach (Delegates.SetState_BeforeArgs toInvoke in _beforeSetState.GetInvocationList())
                    try
                    {
                        _beforeSetState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetState != null)
                foreach (Delegates.SetState_AfterArgs toInvoke in _afterSetState.GetInvocationList())
                    try
                    {
                        _afterSetState.Invoke(@params);
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
        public delegate void ButtonClick_AfterArgs(Params_ButtonClick args);

        public delegate void ButtonClick_BeforeArgs(Params_ButtonClick args);

        public delegate void ButtonClick_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void ButtonDown_AfterArgs(Params_ButtonDown args);

        public delegate void ButtonDown_BeforeArgs(Params_ButtonDown args);

        public delegate void ButtonDown_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void ButtonToggle_AfterArgs(Params_ButtonToggle args);

        public delegate void ButtonToggle_BeforeArgs(Params_ButtonToggle args);

        public delegate void ButtonToggle_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate int get_Index_AfterArgs(Params_get_Index args, int ret);

        public delegate void get_Index_BeforeArgs(Params_get_Index args);

        public delegate int get_Index_WithArgs(Func<tk2dUIMultiStateToggleButton, int> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void set_Index_AfterArgs(Params_set_Index args);

        public delegate void set_Index_BeforeArgs(Params_set_Index args);

        public delegate void set_Index_WithArgs(Action<tk2dUIMultiStateToggleButton, int> orig,
            tk2dUIMultiStateToggleButton self, int value);

        public delegate void SetState_AfterArgs(Params_SetState args);

        public delegate void SetState_BeforeArgs(Params_SetState args);

        public delegate void SetState_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<tk2dUIMultiStateToggleButton> orig,
            tk2dUIMultiStateToggleButton self);

        public sealed class Params_get_Index
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_set_Index
        {
            public tk2dUIMultiStateToggleButton self;
            public int value;
        }

        public sealed class Params_Start
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_OnEnable
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_OnDisable
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_ButtonClick
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_ButtonDown
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_ButtonToggle
        {
            public tk2dUIMultiStateToggleButton self;
        }

        public sealed class Params_SetState
        {
            public tk2dUIMultiStateToggleButton self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Index_BeforeArgs get_Index
        {
            add
            {
                HookHandler._beforeget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._beforeget_Index -= value;
        }

        public static event Delegates.set_Index_BeforeArgs set_Index
        {
            add
            {
                HookHandler._beforeset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._beforeset_Index -= value;
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

        public static event Delegates.ButtonClick_BeforeArgs ButtonClick
        {
            add
            {
                HookHandler._beforeButtonClick += value;
                HookHandler.HookButtonClick();
            }
            remove => HookHandler._beforeButtonClick -= value;
        }

        public static event Delegates.ButtonDown_BeforeArgs ButtonDown
        {
            add
            {
                HookHandler._beforeButtonDown += value;
                HookHandler.HookButtonDown();
            }
            remove => HookHandler._beforeButtonDown -= value;
        }

        public static event Delegates.ButtonToggle_BeforeArgs ButtonToggle
        {
            add
            {
                HookHandler._beforeButtonToggle += value;
                HookHandler.HookButtonToggle();
            }
            remove => HookHandler._beforeButtonToggle -= value;
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
        public static event Delegates.get_Index_AfterArgs get_Index
        {
            add
            {
                HookHandler._afterget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._afterget_Index -= value;
        }

        public static event Delegates.set_Index_AfterArgs set_Index
        {
            add
            {
                HookHandler._afterset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._afterset_Index -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.ButtonClick_AfterArgs ButtonClick
        {
            add
            {
                HookHandler._afterButtonClick += value;
                HookHandler.HookButtonClick();
            }
            remove => HookHandler._afterButtonClick -= value;
        }

        public static event Delegates.ButtonDown_AfterArgs ButtonDown
        {
            add
            {
                HookHandler._afterButtonDown += value;
                HookHandler.HookButtonDown();
            }
            remove => HookHandler._afterButtonDown -= value;
        }

        public static event Delegates.ButtonToggle_AfterArgs ButtonToggle
        {
            add
            {
                HookHandler._afterButtonToggle += value;
                HookHandler.HookButtonToggle();
            }
            remove => HookHandler._afterButtonToggle -= value;
        }

        public static event Delegates.SetState_AfterArgs SetState
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
        public static event Delegates.get_Index_WithArgs get_Index
        {
            add => HookEndpointManager.Add<Delegates.get_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "get_Index"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "get_Index"), value);
        }

        public static event Delegates.set_Index_WithArgs set_Index
        {
            add => HookEndpointManager.Add<Delegates.set_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "set_Index"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "set_Index"), value);
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_Start Start
        {
            add => On.tk2dUIMultiStateToggleButton.Start += value;
            remove => On.tk2dUIMultiStateToggleButton.Start -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_OnEnable OnEnable
        {
            add => On.tk2dUIMultiStateToggleButton.OnEnable += value;
            remove => On.tk2dUIMultiStateToggleButton.OnEnable -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_OnDisable OnDisable
        {
            add => On.tk2dUIMultiStateToggleButton.OnDisable += value;
            remove => On.tk2dUIMultiStateToggleButton.OnDisable -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_ButtonClick ButtonClick
        {
            add => On.tk2dUIMultiStateToggleButton.ButtonClick += value;
            remove => On.tk2dUIMultiStateToggleButton.ButtonClick -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_ButtonDown ButtonDown
        {
            add => On.tk2dUIMultiStateToggleButton.ButtonDown += value;
            remove => On.tk2dUIMultiStateToggleButton.ButtonDown -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_ButtonToggle ButtonToggle
        {
            add => On.tk2dUIMultiStateToggleButton.ButtonToggle += value;
            remove => On.tk2dUIMultiStateToggleButton.ButtonToggle -= value;
        }

        public static event On.tk2dUIMultiStateToggleButton.hook_SetState SetState
        {
            add => On.tk2dUIMultiStateToggleButton.SetState += value;
            remove => On.tk2dUIMultiStateToggleButton.SetState -= value;
        }
    }
}