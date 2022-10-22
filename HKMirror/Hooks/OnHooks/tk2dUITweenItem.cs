using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUITweenItem class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUITweenItem
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_UseOnReleaseInsteadOfOnUp()
        {
            if (!HookedList.Contains("get_UseOnReleaseInsteadOfOnUp"))
            {
                HookedList.Add("get_UseOnReleaseInsteadOfOnUp");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "get_UseOnReleaseInsteadOfOnUp"),
                    get_UseOnReleaseInsteadOfOnUp);
            }
        }

        internal static event Delegates.get_UseOnReleaseInsteadOfOnUp_BeforeArgs _beforeget_UseOnReleaseInsteadOfOnUp;
        internal static event Delegates.get_UseOnReleaseInsteadOfOnUp_AfterArgs _afterget_UseOnReleaseInsteadOfOnUp;

        private static bool get_UseOnReleaseInsteadOfOnUp(Func<tk2dUITweenItem, bool> orig, tk2dUITweenItem self)
        {
            Delegates.Params_get_UseOnReleaseInsteadOfOnUp @params = new()
            {
                self = self
            };
            if (_beforeget_UseOnReleaseInsteadOfOnUp != null)
                foreach (Delegates.get_UseOnReleaseInsteadOfOnUp_BeforeArgs toInvoke in
                         _beforeget_UseOnReleaseInsteadOfOnUp.GetInvocationList())
                    try
                    {
                        _beforeget_UseOnReleaseInsteadOfOnUp?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_UseOnReleaseInsteadOfOnUp != null)
                foreach (Delegates.get_UseOnReleaseInsteadOfOnUp_AfterArgs toInvoke in
                         _afterget_UseOnReleaseInsteadOfOnUp.GetInvocationList())
                    try
                    {
                        retVal = _afterget_UseOnReleaseInsteadOfOnUp.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.tk2dUITweenItem.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.tk2dUITweenItem.orig_Awake orig, tk2dUITweenItem self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
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
                On.tk2dUITweenItem.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUITweenItem.orig_OnEnable orig, tk2dUITweenItem self)
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
                On.tk2dUITweenItem.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUITweenItem.orig_OnDisable orig, tk2dUITweenItem self)
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

        internal static void HookButtonDown()
        {
            if (!HookedList.Contains("ButtonDown"))
            {
                HookedList.Add("ButtonDown");
                On.tk2dUITweenItem.ButtonDown += ButtonDown;
            }
        }

        internal static event Delegates.ButtonDown_BeforeArgs _beforeButtonDown;
        internal static event Delegates.ButtonDown_AfterArgs _afterButtonDown;

        private static void ButtonDown(On.tk2dUITweenItem.orig_ButtonDown orig, tk2dUITweenItem self)
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

        internal static void HookButtonUp()
        {
            if (!HookedList.Contains("ButtonUp"))
            {
                HookedList.Add("ButtonUp");
                On.tk2dUITweenItem.ButtonUp += ButtonUp;
            }
        }

        internal static event Delegates.ButtonUp_BeforeArgs _beforeButtonUp;
        internal static event Delegates.ButtonUp_AfterArgs _afterButtonUp;

        private static void ButtonUp(On.tk2dUITweenItem.orig_ButtonUp orig, tk2dUITweenItem self)
        {
            Delegates.Params_ButtonUp @params = new()
            {
                self = self
            };
            if (_beforeButtonUp != null)
                foreach (Delegates.ButtonUp_BeforeArgs toInvoke in _beforeButtonUp.GetInvocationList())
                    try
                    {
                        _beforeButtonUp?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterButtonUp != null)
                foreach (Delegates.ButtonUp_AfterArgs toInvoke in _afterButtonUp.GetInvocationList())
                    try
                    {
                        _afterButtonUp.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookScaleTween()
        {
            if (!HookedList.Contains("ScaleTween"))
            {
                HookedList.Add("ScaleTween");
                On.tk2dUITweenItem.ScaleTween += ScaleTween;
            }
        }

        internal static event Delegates.ScaleTween_BeforeArgs _beforeScaleTween;

        private static IEnumerator ScaleTween(On.tk2dUITweenItem.orig_ScaleTween orig, tk2dUITweenItem self)
        {
            Delegates.Params_ScaleTween @params = new()
            {
                self = self
            };
            if (_beforeScaleTween != null)
                foreach (Delegates.ScaleTween_BeforeArgs toInvoke in _beforeScaleTween.GetInvocationList())
                    try
                    {
                        _beforeScaleTween?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookInternalSetUseOnReleaseInsteadOfOnUp()
        {
            if (!HookedList.Contains("InternalSetUseOnReleaseInsteadOfOnUp"))
            {
                HookedList.Add("InternalSetUseOnReleaseInsteadOfOnUp");
                On.tk2dUITweenItem.InternalSetUseOnReleaseInsteadOfOnUp += InternalSetUseOnReleaseInsteadOfOnUp;
            }
        }

        internal static event Delegates.InternalSetUseOnReleaseInsteadOfOnUp_BeforeArgs
            _beforeInternalSetUseOnReleaseInsteadOfOnUp;

        internal static event Delegates.InternalSetUseOnReleaseInsteadOfOnUp_AfterArgs
            _afterInternalSetUseOnReleaseInsteadOfOnUp;

        private static void InternalSetUseOnReleaseInsteadOfOnUp(
            On.tk2dUITweenItem.orig_InternalSetUseOnReleaseInsteadOfOnUp orig, tk2dUITweenItem self, bool state)
        {
            Delegates.Params_InternalSetUseOnReleaseInsteadOfOnUp @params = new()
            {
                self = self, state = state
            };
            if (_beforeInternalSetUseOnReleaseInsteadOfOnUp != null)
                foreach (Delegates.InternalSetUseOnReleaseInsteadOfOnUp_BeforeArgs toInvoke in
                         _beforeInternalSetUseOnReleaseInsteadOfOnUp.GetInvocationList())
                    try
                    {
                        _beforeInternalSetUseOnReleaseInsteadOfOnUp?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            state = @params.state;
            orig(self, state);
            if (_afterInternalSetUseOnReleaseInsteadOfOnUp != null)
                foreach (Delegates.InternalSetUseOnReleaseInsteadOfOnUp_AfterArgs toInvoke in
                         _afterInternalSetUseOnReleaseInsteadOfOnUp.GetInvocationList())
                    try
                    {
                        _afterInternalSetUseOnReleaseInsteadOfOnUp.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<tk2dUITweenItem> orig, tk2dUITweenItem self);

        public delegate void ButtonDown_AfterArgs(Params_ButtonDown args);

        public delegate void ButtonDown_BeforeArgs(Params_ButtonDown args);

        public delegate void ButtonDown_WithArgs(Action<tk2dUITweenItem> orig, tk2dUITweenItem self);

        public delegate void ButtonUp_AfterArgs(Params_ButtonUp args);

        public delegate void ButtonUp_BeforeArgs(Params_ButtonUp args);

        public delegate void ButtonUp_WithArgs(Action<tk2dUITweenItem> orig, tk2dUITweenItem self);

        public delegate bool get_UseOnReleaseInsteadOfOnUp_AfterArgs(Params_get_UseOnReleaseInsteadOfOnUp args,
            bool ret);

        public delegate void get_UseOnReleaseInsteadOfOnUp_BeforeArgs(Params_get_UseOnReleaseInsteadOfOnUp args);

        public delegate bool get_UseOnReleaseInsteadOfOnUp_WithArgs(Func<tk2dUITweenItem, bool> orig,
            tk2dUITweenItem self);

        public delegate void InternalSetUseOnReleaseInsteadOfOnUp_AfterArgs(
            Params_InternalSetUseOnReleaseInsteadOfOnUp args);

        public delegate void InternalSetUseOnReleaseInsteadOfOnUp_BeforeArgs(
            Params_InternalSetUseOnReleaseInsteadOfOnUp args);

        public delegate void InternalSetUseOnReleaseInsteadOfOnUp_WithArgs(Action<tk2dUITweenItem, bool> orig,
            tk2dUITweenItem self, bool state);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<tk2dUITweenItem> orig, tk2dUITweenItem self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<tk2dUITweenItem> orig, tk2dUITweenItem self);

        public delegate IEnumerator ScaleTween_AfterArgs(Params_ScaleTween args, IEnumerator ret);

        public delegate void ScaleTween_BeforeArgs(Params_ScaleTween args);

        public delegate IEnumerator ScaleTween_WithArgs(Func<tk2dUITweenItem, IEnumerator> orig, tk2dUITweenItem self);

        public sealed class Params_get_UseOnReleaseInsteadOfOnUp
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_Awake
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_OnEnable
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_OnDisable
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_ButtonDown
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_ButtonUp
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_ScaleTween
        {
            public tk2dUITweenItem self;
        }

        public sealed class Params_InternalSetUseOnReleaseInsteadOfOnUp
        {
            public tk2dUITweenItem self;
            public bool state;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_UseOnReleaseInsteadOfOnUp_BeforeArgs get_UseOnReleaseInsteadOfOnUp
        {
            add
            {
                HookHandler._beforeget_UseOnReleaseInsteadOfOnUp += value;
                HookHandler.Hookget_UseOnReleaseInsteadOfOnUp();
            }
            remove => HookHandler._beforeget_UseOnReleaseInsteadOfOnUp -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
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

        public static event Delegates.ButtonDown_BeforeArgs ButtonDown
        {
            add
            {
                HookHandler._beforeButtonDown += value;
                HookHandler.HookButtonDown();
            }
            remove => HookHandler._beforeButtonDown -= value;
        }

        public static event Delegates.ButtonUp_BeforeArgs ButtonUp
        {
            add
            {
                HookHandler._beforeButtonUp += value;
                HookHandler.HookButtonUp();
            }
            remove => HookHandler._beforeButtonUp -= value;
        }

        public static event Delegates.ScaleTween_BeforeArgs ScaleTween
        {
            add
            {
                HookHandler._beforeScaleTween += value;
                HookHandler.HookScaleTween();
            }
            remove => HookHandler._beforeScaleTween -= value;
        }

        public static event Delegates.InternalSetUseOnReleaseInsteadOfOnUp_BeforeArgs
            InternalSetUseOnReleaseInsteadOfOnUp
            {
                add
                {
                    HookHandler._beforeInternalSetUseOnReleaseInsteadOfOnUp += value;
                    HookHandler.HookInternalSetUseOnReleaseInsteadOfOnUp();
                }
                remove => HookHandler._beforeInternalSetUseOnReleaseInsteadOfOnUp -= value;
            }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_UseOnReleaseInsteadOfOnUp_AfterArgs get_UseOnReleaseInsteadOfOnUp
        {
            add
            {
                HookHandler._afterget_UseOnReleaseInsteadOfOnUp += value;
                HookHandler.Hookget_UseOnReleaseInsteadOfOnUp();
            }
            remove => HookHandler._afterget_UseOnReleaseInsteadOfOnUp -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
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

        public static event Delegates.ButtonDown_AfterArgs ButtonDown
        {
            add
            {
                HookHandler._afterButtonDown += value;
                HookHandler.HookButtonDown();
            }
            remove => HookHandler._afterButtonDown -= value;
        }

        public static event Delegates.ButtonUp_AfterArgs ButtonUp
        {
            add
            {
                HookHandler._afterButtonUp += value;
                HookHandler.HookButtonUp();
            }
            remove => HookHandler._afterButtonUp -= value;
        }

        public static event Delegates.InternalSetUseOnReleaseInsteadOfOnUp_AfterArgs
            InternalSetUseOnReleaseInsteadOfOnUp
            {
                add
                {
                    HookHandler._afterInternalSetUseOnReleaseInsteadOfOnUp += value;
                    HookHandler.HookInternalSetUseOnReleaseInsteadOfOnUp();
                }
                remove => HookHandler._afterInternalSetUseOnReleaseInsteadOfOnUp -= value;
            }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_UseOnReleaseInsteadOfOnUp_WithArgs get_UseOnReleaseInsteadOfOnUp
        {
            add => HookEndpointManager.Add<Delegates.get_UseOnReleaseInsteadOfOnUp_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "get_UseOnReleaseInsteadOfOnUp"), value);
            remove => HookEndpointManager.Remove<Delegates.get_UseOnReleaseInsteadOfOnUp_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "get_UseOnReleaseInsteadOfOnUp"), value);
        }

        public static event On.tk2dUITweenItem.hook_Awake Awake
        {
            add => On.tk2dUITweenItem.Awake += value;
            remove => On.tk2dUITweenItem.Awake -= value;
        }

        public static event On.tk2dUITweenItem.hook_OnEnable OnEnable
        {
            add => On.tk2dUITweenItem.OnEnable += value;
            remove => On.tk2dUITweenItem.OnEnable -= value;
        }

        public static event On.tk2dUITweenItem.hook_OnDisable OnDisable
        {
            add => On.tk2dUITweenItem.OnDisable += value;
            remove => On.tk2dUITweenItem.OnDisable -= value;
        }

        public static event On.tk2dUITweenItem.hook_ButtonDown ButtonDown
        {
            add => On.tk2dUITweenItem.ButtonDown += value;
            remove => On.tk2dUITweenItem.ButtonDown -= value;
        }

        public static event On.tk2dUITweenItem.hook_ButtonUp ButtonUp
        {
            add => On.tk2dUITweenItem.ButtonUp += value;
            remove => On.tk2dUITweenItem.ButtonUp -= value;
        }

        public static event On.tk2dUITweenItem.hook_ScaleTween ScaleTween
        {
            add => On.tk2dUITweenItem.ScaleTween += value;
            remove => On.tk2dUITweenItem.ScaleTween -= value;
        }

        public static event On.tk2dUITweenItem.hook_InternalSetUseOnReleaseInsteadOfOnUp
            InternalSetUseOnReleaseInsteadOfOnUp
            {
                add => On.tk2dUITweenItem.InternalSetUseOnReleaseInsteadOfOnUp += value;
                remove => On.tk2dUITweenItem.InternalSetUseOnReleaseInsteadOfOnUp -= value;
            }
    }
}