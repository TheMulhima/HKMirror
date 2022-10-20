namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUISoundItem class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUISoundItem
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.tk2dUISoundItem.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUISoundItem.orig_OnEnable orig, tk2dUISoundItem self)
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
                On.tk2dUISoundItem.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUISoundItem.orig_OnDisable orig, tk2dUISoundItem self)
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

        internal static void HookPlayDownSound()
        {
            if (!HookedList.Contains("PlayDownSound"))
            {
                HookedList.Add("PlayDownSound");
                On.tk2dUISoundItem.PlayDownSound += PlayDownSound;
            }
        }

        internal static event Delegates.PlayDownSound_BeforeArgs _beforePlayDownSound;
        internal static event Delegates.PlayDownSound_NormalArgs _afterPlayDownSound;

        private static void PlayDownSound(On.tk2dUISoundItem.orig_PlayDownSound orig, tk2dUISoundItem self)
        {
            Delegates.Params_PlayDownSound @params = new()
            {
                self = self
            };
            _beforePlayDownSound?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayDownSound != null) _afterPlayDownSound.Invoke(@params);
        }

        internal static void HookPlayUpSound()
        {
            if (!HookedList.Contains("PlayUpSound"))
            {
                HookedList.Add("PlayUpSound");
                On.tk2dUISoundItem.PlayUpSound += PlayUpSound;
            }
        }

        internal static event Delegates.PlayUpSound_BeforeArgs _beforePlayUpSound;
        internal static event Delegates.PlayUpSound_NormalArgs _afterPlayUpSound;

        private static void PlayUpSound(On.tk2dUISoundItem.orig_PlayUpSound orig, tk2dUISoundItem self)
        {
            Delegates.Params_PlayUpSound @params = new()
            {
                self = self
            };
            _beforePlayUpSound?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayUpSound != null) _afterPlayUpSound.Invoke(@params);
        }

        internal static void HookPlayClickSound()
        {
            if (!HookedList.Contains("PlayClickSound"))
            {
                HookedList.Add("PlayClickSound");
                On.tk2dUISoundItem.PlayClickSound += PlayClickSound;
            }
        }

        internal static event Delegates.PlayClickSound_BeforeArgs _beforePlayClickSound;
        internal static event Delegates.PlayClickSound_NormalArgs _afterPlayClickSound;

        private static void PlayClickSound(On.tk2dUISoundItem.orig_PlayClickSound orig, tk2dUISoundItem self)
        {
            Delegates.Params_PlayClickSound @params = new()
            {
                self = self
            };
            _beforePlayClickSound?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayClickSound != null) _afterPlayClickSound.Invoke(@params);
        }

        internal static void HookPlayReleaseSound()
        {
            if (!HookedList.Contains("PlayReleaseSound"))
            {
                HookedList.Add("PlayReleaseSound");
                On.tk2dUISoundItem.PlayReleaseSound += PlayReleaseSound;
            }
        }

        internal static event Delegates.PlayReleaseSound_BeforeArgs _beforePlayReleaseSound;
        internal static event Delegates.PlayReleaseSound_NormalArgs _afterPlayReleaseSound;

        private static void PlayReleaseSound(On.tk2dUISoundItem.orig_PlayReleaseSound orig, tk2dUISoundItem self)
        {
            Delegates.Params_PlayReleaseSound @params = new()
            {
                self = self
            };
            _beforePlayReleaseSound?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayReleaseSound != null) _afterPlayReleaseSound.Invoke(@params);
        }

        internal static void HookPlaySound()
        {
            if (!HookedList.Contains("PlaySound"))
            {
                HookedList.Add("PlaySound");
                On.tk2dUISoundItem.PlaySound += PlaySound;
            }
        }

        internal static event Delegates.PlaySound_BeforeArgs _beforePlaySound;
        internal static event Delegates.PlaySound_NormalArgs _afterPlaySound;

        private static void PlaySound(On.tk2dUISoundItem.orig_PlaySound orig, tk2dUISoundItem self, AudioClip source)
        {
            Delegates.Params_PlaySound @params = new()
            {
                self = self, source = source
            };
            _beforePlaySound?.Invoke(@params);
            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterPlaySound != null) _afterPlaySound.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void PlayClickSound_BeforeArgs(Params_PlayClickSound args);

        public delegate void PlayClickSound_NormalArgs(Params_PlayClickSound args);

        public delegate void PlayDownSound_BeforeArgs(Params_PlayDownSound args);

        public delegate void PlayDownSound_NormalArgs(Params_PlayDownSound args);

        public delegate void PlayReleaseSound_BeforeArgs(Params_PlayReleaseSound args);

        public delegate void PlayReleaseSound_NormalArgs(Params_PlayReleaseSound args);

        public delegate void PlaySound_BeforeArgs(Params_PlaySound args);

        public delegate void PlaySound_NormalArgs(Params_PlaySound args);

        public delegate void PlayUpSound_BeforeArgs(Params_PlayUpSound args);

        public delegate void PlayUpSound_NormalArgs(Params_PlayUpSound args);

        public sealed class Params_OnEnable
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_OnDisable
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_PlayDownSound
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_PlayUpSound
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_PlayClickSound
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_PlayReleaseSound
        {
            public tk2dUISoundItem self;
        }

        public sealed class Params_PlaySound
        {
            public tk2dUISoundItem self;
            public AudioClip source;
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

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.PlayDownSound_BeforeArgs PlayDownSound
        {
            add
            {
                HookHandler._beforePlayDownSound += value;
                HookHandler.HookPlayDownSound();
            }
            remove => HookHandler._beforePlayDownSound -= value;
        }

        public static event Delegates.PlayUpSound_BeforeArgs PlayUpSound
        {
            add
            {
                HookHandler._beforePlayUpSound += value;
                HookHandler.HookPlayUpSound();
            }
            remove => HookHandler._beforePlayUpSound -= value;
        }

        public static event Delegates.PlayClickSound_BeforeArgs PlayClickSound
        {
            add
            {
                HookHandler._beforePlayClickSound += value;
                HookHandler.HookPlayClickSound();
            }
            remove => HookHandler._beforePlayClickSound -= value;
        }

        public static event Delegates.PlayReleaseSound_BeforeArgs PlayReleaseSound
        {
            add
            {
                HookHandler._beforePlayReleaseSound += value;
                HookHandler.HookPlayReleaseSound();
            }
            remove => HookHandler._beforePlayReleaseSound -= value;
        }

        public static event Delegates.PlaySound_BeforeArgs PlaySound
        {
            add
            {
                HookHandler._beforePlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._beforePlaySound -= value;
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

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.PlayDownSound_NormalArgs PlayDownSound
        {
            add
            {
                HookHandler._afterPlayDownSound += value;
                HookHandler.HookPlayDownSound();
            }
            remove => HookHandler._afterPlayDownSound -= value;
        }

        public static event Delegates.PlayUpSound_NormalArgs PlayUpSound
        {
            add
            {
                HookHandler._afterPlayUpSound += value;
                HookHandler.HookPlayUpSound();
            }
            remove => HookHandler._afterPlayUpSound -= value;
        }

        public static event Delegates.PlayClickSound_NormalArgs PlayClickSound
        {
            add
            {
                HookHandler._afterPlayClickSound += value;
                HookHandler.HookPlayClickSound();
            }
            remove => HookHandler._afterPlayClickSound -= value;
        }

        public static event Delegates.PlayReleaseSound_NormalArgs PlayReleaseSound
        {
            add
            {
                HookHandler._afterPlayReleaseSound += value;
                HookHandler.HookPlayReleaseSound();
            }
            remove => HookHandler._afterPlayReleaseSound -= value;
        }

        public static event Delegates.PlaySound_NormalArgs PlaySound
        {
            add
            {
                HookHandler._afterPlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._afterPlaySound -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.tk2dUISoundItem.hook_OnEnable OnEnable
        {
            add => On.tk2dUISoundItem.OnEnable += value;
            remove => On.tk2dUISoundItem.OnEnable -= value;
        }

        public static event On.tk2dUISoundItem.hook_OnDisable OnDisable
        {
            add => On.tk2dUISoundItem.OnDisable += value;
            remove => On.tk2dUISoundItem.OnDisable -= value;
        }

        public static event On.tk2dUISoundItem.hook_PlayDownSound PlayDownSound
        {
            add => On.tk2dUISoundItem.PlayDownSound += value;
            remove => On.tk2dUISoundItem.PlayDownSound -= value;
        }

        public static event On.tk2dUISoundItem.hook_PlayUpSound PlayUpSound
        {
            add => On.tk2dUISoundItem.PlayUpSound += value;
            remove => On.tk2dUISoundItem.PlayUpSound -= value;
        }

        public static event On.tk2dUISoundItem.hook_PlayClickSound PlayClickSound
        {
            add => On.tk2dUISoundItem.PlayClickSound += value;
            remove => On.tk2dUISoundItem.PlayClickSound -= value;
        }

        public static event On.tk2dUISoundItem.hook_PlayReleaseSound PlayReleaseSound
        {
            add => On.tk2dUISoundItem.PlayReleaseSound += value;
            remove => On.tk2dUISoundItem.PlayReleaseSound -= value;
        }

        public static event On.tk2dUISoundItem.hook_PlaySound PlaySound
        {
            add => On.tk2dUISoundItem.PlaySound += value;
            remove => On.tk2dUISoundItem.PlaySound -= value;
        }
    }
}