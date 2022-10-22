namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for LogoLanguage class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLogoLanguage
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.LogoLanguage.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.LogoLanguage.orig_OnEnable orig, LogoLanguage self)
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

        internal static void HookSetSprite()
        {
            if (!HookedList.Contains("SetSprite"))
            {
                HookedList.Add("SetSprite");
                On.LogoLanguage.SetSprite += SetSprite;
            }
        }

        internal static event Delegates.SetSprite_BeforeArgs _beforeSetSprite;
        internal static event Delegates.SetSprite_AfterArgs _afterSetSprite;

        private static void SetSprite(On.LogoLanguage.orig_SetSprite orig, LogoLanguage self)
        {
            Delegates.Params_SetSprite @params = new()
            {
                self = self
            };
            if (_beforeSetSprite != null)
                foreach (Delegates.SetSprite_BeforeArgs toInvoke in _beforeSetSprite.GetInvocationList())
                    try
                    {
                        _beforeSetSprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetSprite != null)
                foreach (Delegates.SetSprite_AfterArgs toInvoke in _afterSetSprite.GetInvocationList())
                    try
                    {
                        _afterSetSprite.Invoke(@params);
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
        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<LogoLanguage> orig, LogoLanguage self);

        public delegate void SetSprite_AfterArgs(Params_SetSprite args);

        public delegate void SetSprite_BeforeArgs(Params_SetSprite args);

        public delegate void SetSprite_WithArgs(Action<LogoLanguage> orig, LogoLanguage self);

        public sealed class Params_OnEnable
        {
            public LogoLanguage self;
        }

        public sealed class Params_SetSprite
        {
            public LogoLanguage self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.SetSprite_BeforeArgs SetSprite
        {
            add
            {
                HookHandler._beforeSetSprite += value;
                HookHandler.HookSetSprite();
            }
            remove => HookHandler._beforeSetSprite -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.SetSprite_AfterArgs SetSprite
        {
            add
            {
                HookHandler._afterSetSprite += value;
                HookHandler.HookSetSprite();
            }
            remove => HookHandler._afterSetSprite -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.LogoLanguage.hook_OnEnable OnEnable
        {
            add => On.LogoLanguage.OnEnable += value;
            remove => On.LogoLanguage.OnEnable -= value;
        }

        public static event On.LogoLanguage.hook_SetSprite SetSprite
        {
            add => On.LogoLanguage.SetSprite += value;
            remove => On.LogoLanguage.SetSprite -= value;
        }
    }
}