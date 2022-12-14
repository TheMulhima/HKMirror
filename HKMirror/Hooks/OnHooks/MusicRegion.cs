namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MusicRegion class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMusicRegion
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.MusicRegion.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.MusicRegion.orig_Reset orig, MusicRegion self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.MusicRegion.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.MusicRegion.orig_OnTriggerEnter2D orig, MusicRegion self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.MusicRegion.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.MusicRegion.orig_OnTriggerExit2D orig, MusicRegion self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerExit2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerExit2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFadeIn()
        {
            if (!HookedList.Contains("FadeIn"))
            {
                HookedList.Add("FadeIn");
                On.MusicRegion.FadeIn += FadeIn;
            }
        }

        internal static event Delegates.FadeIn_BeforeArgs _beforeFadeIn;

        private static IEnumerator FadeIn(On.MusicRegion.orig_FadeIn orig, MusicRegion self)
        {
            Delegates.Params_FadeIn @params = new()
            {
                self = self
            };
            if (_beforeFadeIn != null)
                foreach (Delegates.FadeIn_BeforeArgs toInvoke in _beforeFadeIn.GetInvocationList())
                    try
                    {
                        _beforeFadeIn?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookFadeOut()
        {
            if (!HookedList.Contains("FadeOut"))
            {
                HookedList.Add("FadeOut");
                On.MusicRegion.FadeOut += FadeOut;
            }
        }

        internal static event Delegates.FadeOut_BeforeArgs _beforeFadeOut;
        internal static event Delegates.FadeOut_AfterArgs _afterFadeOut;

        private static void FadeOut(On.MusicRegion.orig_FadeOut orig, MusicRegion self)
        {
            Delegates.Params_FadeOut @params = new()
            {
                self = self
            };
            if (_beforeFadeOut != null)
                foreach (Delegates.FadeOut_BeforeArgs toInvoke in _beforeFadeOut.GetInvocationList())
                    try
                    {
                        _beforeFadeOut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterFadeOut != null)
                foreach (Delegates.FadeOut_AfterArgs toInvoke in _afterFadeOut.GetInvocationList())
                    try
                    {
                        _afterFadeOut.Invoke(@params);
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
        public delegate IEnumerator FadeIn_AfterArgs(Params_FadeIn args, IEnumerator ret);

        public delegate void FadeIn_BeforeArgs(Params_FadeIn args);

        public delegate IEnumerator FadeIn_WithArgs(Func<MusicRegion, IEnumerator> orig, MusicRegion self);

        public delegate void FadeOut_AfterArgs(Params_FadeOut args);

        public delegate void FadeOut_BeforeArgs(Params_FadeOut args);

        public delegate void FadeOut_WithArgs(Action<MusicRegion> orig, MusicRegion self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<MusicRegion, Collider2D> orig, MusicRegion self,
            Collider2D collision);

        public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_WithArgs(Action<MusicRegion, Collider2D> orig, MusicRegion self,
            Collider2D collision);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<MusicRegion> orig, MusicRegion self);

        public sealed class Params_Reset
        {
            public MusicRegion self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public MusicRegion self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D collision;
            public MusicRegion self;
        }

        public sealed class Params_FadeIn
        {
            public MusicRegion self;
        }

        public sealed class Params_FadeOut
        {
            public MusicRegion self;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._beforeOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._beforeOnTriggerExit2D -= value;
        }

        public static event Delegates.FadeIn_BeforeArgs FadeIn
        {
            add
            {
                HookHandler._beforeFadeIn += value;
                HookHandler.HookFadeIn();
            }
            remove => HookHandler._beforeFadeIn -= value;
        }

        public static event Delegates.FadeOut_BeforeArgs FadeOut
        {
            add
            {
                HookHandler._beforeFadeOut += value;
                HookHandler.HookFadeOut();
            }
            remove => HookHandler._beforeFadeOut -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._afterOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._afterOnTriggerExit2D -= value;
        }

        public static event Delegates.FadeOut_AfterArgs FadeOut
        {
            add
            {
                HookHandler._afterFadeOut += value;
                HookHandler.HookFadeOut();
            }
            remove => HookHandler._afterFadeOut -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MusicRegion.hook_Reset Reset
        {
            add => On.MusicRegion.Reset += value;
            remove => On.MusicRegion.Reset -= value;
        }

        public static event On.MusicRegion.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.MusicRegion.OnTriggerEnter2D += value;
            remove => On.MusicRegion.OnTriggerEnter2D -= value;
        }

        public static event On.MusicRegion.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.MusicRegion.OnTriggerExit2D += value;
            remove => On.MusicRegion.OnTriggerExit2D -= value;
        }

        public static event On.MusicRegion.hook_FadeIn FadeIn
        {
            add => On.MusicRegion.FadeIn += value;
            remove => On.MusicRegion.FadeIn -= value;
        }

        public static event On.MusicRegion.hook_FadeOut FadeOut
        {
            add => On.MusicRegion.FadeOut += value;
            remove => On.MusicRegion.FadeOut -= value;
        }
    }
}