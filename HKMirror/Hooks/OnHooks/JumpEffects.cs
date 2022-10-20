namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for JumpEffects class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnJumpEffects
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.JumpEffects.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.JumpEffects.orig_OnEnable orig, JumpEffects self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.JumpEffects.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.JumpEffects.orig_Update orig, JumpEffects self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookGetHero()
        {
            if (!HookedList.Contains("GetHero"))
            {
                HookedList.Add("GetHero");
                On.JumpEffects.GetHero += GetHero;
            }
        }

        internal static event Delegates.GetHero_BeforeArgs _beforeGetHero;
        internal static event Delegates.GetHero_NormalArgs _afterGetHero;

        private static void GetHero(On.JumpEffects.orig_GetHero orig, JumpEffects self)
        {
            Delegates.Params_GetHero @params = new()
            {
                self = self
            };
            _beforeGetHero?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterGetHero != null) _afterGetHero.Invoke(@params);
        }

        internal static void HookCheckForFall()
        {
            if (!HookedList.Contains("CheckForFall"))
            {
                HookedList.Add("CheckForFall");
                On.JumpEffects.CheckForFall += CheckForFall;
            }
        }

        internal static event Delegates.CheckForFall_BeforeArgs _beforeCheckForFall;
        internal static event Delegates.CheckForFall_NormalArgs _afterCheckForFall;

        private static void CheckForFall(On.JumpEffects.orig_CheckForFall orig, JumpEffects self)
        {
            Delegates.Params_CheckForFall @params = new()
            {
                self = self
            };
            _beforeCheckForFall?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterCheckForFall != null) _afterCheckForFall.Invoke(@params);
        }

        internal static void HookPlayTrail()
        {
            if (!HookedList.Contains("PlayTrail"))
            {
                HookedList.Add("PlayTrail");
                On.JumpEffects.PlayTrail += PlayTrail;
            }
        }

        internal static event Delegates.PlayTrail_BeforeArgs _beforePlayTrail;
        internal static event Delegates.PlayTrail_NormalArgs _afterPlayTrail;

        private static void PlayTrail(On.JumpEffects.orig_PlayTrail orig, JumpEffects self)
        {
            Delegates.Params_PlayTrail @params = new()
            {
                self = self
            };
            _beforePlayTrail?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayTrail != null) _afterPlayTrail.Invoke(@params);
        }

        internal static void HookPlayJumpPuff()
        {
            if (!HookedList.Contains("PlayJumpPuff"))
            {
                HookedList.Add("PlayJumpPuff");
                On.JumpEffects.PlayJumpPuff += PlayJumpPuff;
            }
        }

        internal static event Delegates.PlayJumpPuff_BeforeArgs _beforePlayJumpPuff;
        internal static event Delegates.PlayJumpPuff_NormalArgs _afterPlayJumpPuff;

        private static void PlayJumpPuff(On.JumpEffects.orig_PlayJumpPuff orig, JumpEffects self)
        {
            Delegates.Params_PlayJumpPuff @params = new()
            {
                self = self
            };
            _beforePlayJumpPuff?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayJumpPuff != null) _afterPlayJumpPuff.Invoke(@params);
        }

        internal static void HookSplashOut()
        {
            if (!HookedList.Contains("SplashOut"))
            {
                HookedList.Add("SplashOut");
                On.JumpEffects.SplashOut += SplashOut;
            }
        }

        internal static event Delegates.SplashOut_BeforeArgs _beforeSplashOut;
        internal static event Delegates.SplashOut_NormalArgs _afterSplashOut;

        private static void SplashOut(On.JumpEffects.orig_SplashOut orig, JumpEffects self)
        {
            Delegates.Params_SplashOut @params = new()
            {
                self = self
            };
            _beforeSplashOut?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSplashOut != null) _afterSplashOut.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CheckForFall_BeforeArgs(Params_CheckForFall args);

        public delegate void CheckForFall_NormalArgs(Params_CheckForFall args);

        public delegate void GetHero_BeforeArgs(Params_GetHero args);

        public delegate void GetHero_NormalArgs(Params_GetHero args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void PlayJumpPuff_BeforeArgs(Params_PlayJumpPuff args);

        public delegate void PlayJumpPuff_NormalArgs(Params_PlayJumpPuff args);

        public delegate void PlayTrail_BeforeArgs(Params_PlayTrail args);

        public delegate void PlayTrail_NormalArgs(Params_PlayTrail args);

        public delegate void SplashOut_BeforeArgs(Params_SplashOut args);

        public delegate void SplashOut_NormalArgs(Params_SplashOut args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_OnEnable
        {
            public JumpEffects self;
        }

        public sealed class Params_Update
        {
            public JumpEffects self;
        }

        public sealed class Params_GetHero
        {
            public JumpEffects self;
        }

        public sealed class Params_CheckForFall
        {
            public JumpEffects self;
        }

        public sealed class Params_PlayTrail
        {
            public JumpEffects self;
        }

        public sealed class Params_PlayJumpPuff
        {
            public JumpEffects self;
        }

        public sealed class Params_SplashOut
        {
            public JumpEffects self;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.GetHero_BeforeArgs GetHero
        {
            add
            {
                HookHandler._beforeGetHero += value;
                HookHandler.HookGetHero();
            }
            remove => HookHandler._beforeGetHero -= value;
        }

        public static event Delegates.CheckForFall_BeforeArgs CheckForFall
        {
            add
            {
                HookHandler._beforeCheckForFall += value;
                HookHandler.HookCheckForFall();
            }
            remove => HookHandler._beforeCheckForFall -= value;
        }

        public static event Delegates.PlayTrail_BeforeArgs PlayTrail
        {
            add
            {
                HookHandler._beforePlayTrail += value;
                HookHandler.HookPlayTrail();
            }
            remove => HookHandler._beforePlayTrail -= value;
        }

        public static event Delegates.PlayJumpPuff_BeforeArgs PlayJumpPuff
        {
            add
            {
                HookHandler._beforePlayJumpPuff += value;
                HookHandler.HookPlayJumpPuff();
            }
            remove => HookHandler._beforePlayJumpPuff -= value;
        }

        public static event Delegates.SplashOut_BeforeArgs SplashOut
        {
            add
            {
                HookHandler._beforeSplashOut += value;
                HookHandler.HookSplashOut();
            }
            remove => HookHandler._beforeSplashOut -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.GetHero_NormalArgs GetHero
        {
            add
            {
                HookHandler._afterGetHero += value;
                HookHandler.HookGetHero();
            }
            remove => HookHandler._afterGetHero -= value;
        }

        public static event Delegates.CheckForFall_NormalArgs CheckForFall
        {
            add
            {
                HookHandler._afterCheckForFall += value;
                HookHandler.HookCheckForFall();
            }
            remove => HookHandler._afterCheckForFall -= value;
        }

        public static event Delegates.PlayTrail_NormalArgs PlayTrail
        {
            add
            {
                HookHandler._afterPlayTrail += value;
                HookHandler.HookPlayTrail();
            }
            remove => HookHandler._afterPlayTrail -= value;
        }

        public static event Delegates.PlayJumpPuff_NormalArgs PlayJumpPuff
        {
            add
            {
                HookHandler._afterPlayJumpPuff += value;
                HookHandler.HookPlayJumpPuff();
            }
            remove => HookHandler._afterPlayJumpPuff -= value;
        }

        public static event Delegates.SplashOut_NormalArgs SplashOut
        {
            add
            {
                HookHandler._afterSplashOut += value;
                HookHandler.HookSplashOut();
            }
            remove => HookHandler._afterSplashOut -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.JumpEffects.hook_OnEnable OnEnable
        {
            add => On.JumpEffects.OnEnable += value;
            remove => On.JumpEffects.OnEnable -= value;
        }

        public static event On.JumpEffects.hook_Update Update
        {
            add => On.JumpEffects.Update += value;
            remove => On.JumpEffects.Update -= value;
        }

        public static event On.JumpEffects.hook_GetHero GetHero
        {
            add => On.JumpEffects.GetHero += value;
            remove => On.JumpEffects.GetHero -= value;
        }

        public static event On.JumpEffects.hook_CheckForFall CheckForFall
        {
            add => On.JumpEffects.CheckForFall += value;
            remove => On.JumpEffects.CheckForFall -= value;
        }

        public static event On.JumpEffects.hook_PlayTrail PlayTrail
        {
            add => On.JumpEffects.PlayTrail += value;
            remove => On.JumpEffects.PlayTrail -= value;
        }

        public static event On.JumpEffects.hook_PlayJumpPuff PlayJumpPuff
        {
            add => On.JumpEffects.PlayJumpPuff += value;
            remove => On.JumpEffects.PlayJumpPuff -= value;
        }

        public static event On.JumpEffects.hook_SplashOut SplashOut
        {
            add => On.JumpEffects.SplashOut += value;
            remove => On.JumpEffects.SplashOut -= value;
        }
    }
}