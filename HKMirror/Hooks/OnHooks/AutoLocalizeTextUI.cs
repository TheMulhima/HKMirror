using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for AutoLocalizeTextUI class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAutoLocalizeTextUI
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.AutoLocalizeTextUI.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.AutoLocalizeTextUI.orig_Awake orig, AutoLocalizeTextUI self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.AutoLocalizeTextUI.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.AutoLocalizeTextUI.orig_OnEnable orig, AutoLocalizeTextUI self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
            {
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
            {
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.AutoLocalizeTextUI.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.AutoLocalizeTextUI.orig_OnDisable orig, AutoLocalizeTextUI self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
            {
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
            {
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                {
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookRefreshTextFromLocalization()
        {
            if (!HookedList.Contains("RefreshTextFromLocalization"))
            {
                HookedList.Add("RefreshTextFromLocalization");
                On.AutoLocalizeTextUI.RefreshTextFromLocalization += RefreshTextFromLocalization;
            }
        }

        internal static event Delegates.RefreshTextFromLocalization_BeforeArgs _beforeRefreshTextFromLocalization;
        internal static event Delegates.RefreshTextFromLocalization_AfterArgs _afterRefreshTextFromLocalization;

        private static void RefreshTextFromLocalization(On.AutoLocalizeTextUI.orig_RefreshTextFromLocalization orig,
            AutoLocalizeTextUI self)
        {
            Delegates.Params_RefreshTextFromLocalization @params = new()
            {
                self = self
            };
            if (_beforeRefreshTextFromLocalization != null)
            {
                foreach (Delegates.RefreshTextFromLocalization_BeforeArgs toInvoke in _beforeRefreshTextFromLocalization
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeRefreshTextFromLocalization?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterRefreshTextFromLocalization != null)
            {
                foreach (Delegates.RefreshTextFromLocalization_AfterArgs toInvoke in _afterRefreshTextFromLocalization
                             .GetInvocationList())
                {
                    try
                    {
                        _afterRefreshTextFromLocalization.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Awake
        {
            public AutoLocalizeTextUI self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<AutoLocalizeTextUI> orig, AutoLocalizeTextUI self);

        public sealed class Params_OnEnable
        {
            public AutoLocalizeTextUI self;
        }

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<AutoLocalizeTextUI> orig, AutoLocalizeTextUI self);

        public sealed class Params_OnDisable
        {
            public AutoLocalizeTextUI self;
        }

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<AutoLocalizeTextUI> orig, AutoLocalizeTextUI self);

        public sealed class Params_RefreshTextFromLocalization
        {
            public AutoLocalizeTextUI self;
        }

        public delegate void RefreshTextFromLocalization_BeforeArgs(Params_RefreshTextFromLocalization args);

        public delegate void RefreshTextFromLocalization_AfterArgs(Params_RefreshTextFromLocalization args);

        public delegate void RefreshTextFromLocalization_WithArgs(Action<AutoLocalizeTextUI> orig,
            AutoLocalizeTextUI self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.RefreshTextFromLocalization_BeforeArgs RefreshTextFromLocalization
        {
            add
            {
                HookHandler._beforeRefreshTextFromLocalization += value;
                HookHandler.HookRefreshTextFromLocalization();
            }
            remove => HookHandler._beforeRefreshTextFromLocalization -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.RefreshTextFromLocalization_AfterArgs RefreshTextFromLocalization
        {
            add
            {
                HookHandler._afterRefreshTextFromLocalization += value;
                HookHandler.HookRefreshTextFromLocalization();
            }
            remove => HookHandler._afterRefreshTextFromLocalization -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.AutoLocalizeTextUI.hook_Awake Awake
        {
            add => On.AutoLocalizeTextUI.Awake += value;
            remove => On.AutoLocalizeTextUI.Awake -= value;
        }

        public static event On.AutoLocalizeTextUI.hook_OnEnable OnEnable
        {
            add => On.AutoLocalizeTextUI.OnEnable += value;
            remove => On.AutoLocalizeTextUI.OnEnable -= value;
        }

        public static event On.AutoLocalizeTextUI.hook_OnDisable OnDisable
        {
            add => On.AutoLocalizeTextUI.OnDisable += value;
            remove => On.AutoLocalizeTextUI.OnDisable -= value;
        }

        public static event On.AutoLocalizeTextUI.hook_RefreshTextFromLocalization RefreshTextFromLocalization
        {
            add => On.AutoLocalizeTextUI.RefreshTextFromLocalization += value;
            remove => On.AutoLocalizeTextUI.RefreshTextFromLocalization -= value;
        }
    }
}