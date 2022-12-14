namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SaveProfileHealthBar class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSaveProfileHealthBar
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SaveProfileHealthBar.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.SaveProfileHealthBar.orig_Awake orig, SaveProfileHealthBar self)
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

        internal static void HookshowHealth()
        {
            if (!HookedList.Contains("showHealth"))
            {
                HookedList.Add("showHealth");
                On.SaveProfileHealthBar.showHealth += showHealth;
            }
        }

        internal static event Delegates.showHealth_BeforeArgs _beforeshowHealth;
        internal static event Delegates.showHealth_AfterArgs _aftershowHealth;

        private static void showHealth(On.SaveProfileHealthBar.orig_showHealth orig, SaveProfileHealthBar self,
            int numberToShow, bool steelsoulMode)
        {
            Delegates.Params_showHealth @params = new()
            {
                self = self, numberToShow = numberToShow, steelsoulMode = steelsoulMode
            };
            if (_beforeshowHealth != null)
                foreach (Delegates.showHealth_BeforeArgs toInvoke in _beforeshowHealth.GetInvocationList())
                    try
                    {
                        _beforeshowHealth?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            numberToShow = @params.numberToShow;
            steelsoulMode = @params.steelsoulMode;
            orig(self, numberToShow, steelsoulMode);
            if (_aftershowHealth != null)
                foreach (Delegates.showHealth_AfterArgs toInvoke in _aftershowHealth.GetInvocationList())
                    try
                    {
                        _aftershowHealth.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<SaveProfileHealthBar> orig, SaveProfileHealthBar self);

        public delegate void showHealth_AfterArgs(Params_showHealth args);

        public delegate void showHealth_BeforeArgs(Params_showHealth args);

        public delegate void showHealth_WithArgs(Action<SaveProfileHealthBar, int, bool> orig,
            SaveProfileHealthBar self, int numberToShow, bool steelsoulMode);

        public sealed class Params_Awake
        {
            public SaveProfileHealthBar self;
        }

        public sealed class Params_showHealth
        {
            public int numberToShow;
            public SaveProfileHealthBar self;
            public bool steelsoulMode;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.showHealth_BeforeArgs showHealth
        {
            add
            {
                HookHandler._beforeshowHealth += value;
                HookHandler.HookshowHealth();
            }
            remove => HookHandler._beforeshowHealth -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.showHealth_AfterArgs showHealth
        {
            add
            {
                HookHandler._aftershowHealth += value;
                HookHandler.HookshowHealth();
            }
            remove => HookHandler._aftershowHealth -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SaveProfileHealthBar.hook_Awake Awake
        {
            add => On.SaveProfileHealthBar.Awake += value;
            remove => On.SaveProfileHealthBar.Awake -= value;
        }

        public static event On.SaveProfileHealthBar.hook_showHealth showHealth
        {
            add => On.SaveProfileHealthBar.showHealth += value;
            remove => On.SaveProfileHealthBar.showHealth -= value;
        }
    }
}