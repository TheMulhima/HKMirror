namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ColorFader class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnColorFader
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.ColorFader.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.ColorFader.orig_Reset orig, ColorFader self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ColorFader.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.ColorFader.orig_Start orig, ColorFader self)
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

        internal static void HookSetup()
        {
            if (!HookedList.Contains("Setup"))
            {
                HookedList.Add("Setup");
                On.ColorFader.Setup += Setup;
            }
        }

        internal static event Delegates.Setup_BeforeArgs _beforeSetup;
        internal static event Delegates.Setup_AfterArgs _afterSetup;

        private static void Setup(On.ColorFader.orig_Setup orig, ColorFader self)
        {
            Delegates.Params_Setup @params = new()
            {
                self = self
            };
            if (_beforeSetup != null)
                foreach (Delegates.Setup_BeforeArgs toInvoke in _beforeSetup.GetInvocationList())
                    try
                    {
                        _beforeSetup?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetup != null)
                foreach (Delegates.Setup_AfterArgs toInvoke in _afterSetup.GetInvocationList())
                    try
                    {
                        _afterSetup.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFade_bool()
        {
            if (!HookedList.Contains("Fade_bool"))
            {
                HookedList.Add("Fade_bool");
                On.ColorFader.Fade_bool += Fade_bool;
            }
        }

        internal static event Delegates.Fade_bool_BeforeArgs _beforeFade_bool;
        internal static event Delegates.Fade_bool_AfterArgs _afterFade_bool;

        private static void Fade_bool(On.ColorFader.orig_Fade_bool orig, ColorFader self, bool up)
        {
            Delegates.Params_Fade_bool @params = new()
            {
                self = self, up = up
            };
            if (_beforeFade_bool != null)
                foreach (Delegates.Fade_bool_BeforeArgs toInvoke in _beforeFade_bool.GetInvocationList())
                    try
                    {
                        _beforeFade_bool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            up = @params.up;
            orig(self, up);
            if (_afterFade_bool != null)
                foreach (Delegates.Fade_bool_AfterArgs toInvoke in _afterFade_bool.GetInvocationList())
                    try
                    {
                        _afterFade_bool.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFade_Color_float_float()
        {
            if (!HookedList.Contains("Fade_Color_float_float"))
            {
                HookedList.Add("Fade_Color_float_float");
                On.ColorFader.Fade_Color_float_float += Fade_Color_float_float;
            }
        }

        internal static event Delegates.Fade_Color_float_float_BeforeArgs _beforeFade_Color_float_float;

        private static IEnumerator Fade_Color_float_float(On.ColorFader.orig_Fade_Color_float_float orig,
            ColorFader self, Color to, float time, float delay)
        {
            Delegates.Params_Fade_Color_float_float @params = new()
            {
                self = self, to = to, time = time, delay = delay
            };
            if (_beforeFade_Color_float_float != null)
                foreach (Delegates.Fade_Color_float_float_BeforeArgs toInvoke in _beforeFade_Color_float_float
                             .GetInvocationList())
                    try
                    {
                        _beforeFade_Color_float_float?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            to = @params.to;
            time = @params.time;
            delay = @params.delay;
            return orig(self, to, time, delay);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Fade_bool_AfterArgs(Params_Fade_bool args);

        public delegate void Fade_bool_BeforeArgs(Params_Fade_bool args);

        public delegate void Fade_bool_WithArgs(Action<ColorFader, bool> orig, ColorFader self, bool up);

        public delegate IEnumerator Fade_Color_float_float_AfterArgs(Params_Fade_Color_float_float args,
            IEnumerator ret);

        public delegate void Fade_Color_float_float_BeforeArgs(Params_Fade_Color_float_float args);

        public delegate IEnumerator Fade_Color_float_float_WithArgs(
            Func<ColorFader, Color, float, float, IEnumerator> orig, ColorFader self, Color to, float time,
            float delay);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ColorFader> orig, ColorFader self);

        public delegate void Setup_AfterArgs(Params_Setup args);

        public delegate void Setup_BeforeArgs(Params_Setup args);

        public delegate void Setup_WithArgs(Action<ColorFader> orig, ColorFader self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<ColorFader> orig, ColorFader self);

        public sealed class Params_Reset
        {
            public ColorFader self;
        }

        public sealed class Params_Start
        {
            public ColorFader self;
        }

        public sealed class Params_Setup
        {
            public ColorFader self;
        }

        public sealed class Params_Fade_bool
        {
            public ColorFader self;
            public bool up;
        }

        public sealed class Params_Fade_Color_float_float
        {
            public float delay;
            public ColorFader self;
            public float time;
            public Color to;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.Setup_BeforeArgs Setup
        {
            add
            {
                HookHandler._beforeSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._beforeSetup -= value;
        }

        public static event Delegates.Fade_bool_BeforeArgs Fade_bool
        {
            add
            {
                HookHandler._beforeFade_bool += value;
                HookHandler.HookFade_bool();
            }
            remove => HookHandler._beforeFade_bool -= value;
        }

        public static event Delegates.Fade_Color_float_float_BeforeArgs Fade_Color_float_float
        {
            add
            {
                HookHandler._beforeFade_Color_float_float += value;
                HookHandler.HookFade_Color_float_float();
            }
            remove => HookHandler._beforeFade_Color_float_float -= value;
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

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.Setup_AfterArgs Setup
        {
            add
            {
                HookHandler._afterSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._afterSetup -= value;
        }

        public static event Delegates.Fade_bool_AfterArgs Fade_bool
        {
            add
            {
                HookHandler._afterFade_bool += value;
                HookHandler.HookFade_bool();
            }
            remove => HookHandler._afterFade_bool -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.ColorFader.hook_Reset Reset
        {
            add => On.ColorFader.Reset += value;
            remove => On.ColorFader.Reset -= value;
        }

        public static event On.ColorFader.hook_Start Start
        {
            add => On.ColorFader.Start += value;
            remove => On.ColorFader.Start -= value;
        }

        public static event On.ColorFader.hook_Setup Setup
        {
            add => On.ColorFader.Setup += value;
            remove => On.ColorFader.Setup -= value;
        }

        public static event On.ColorFader.hook_Fade_bool Fade_bool
        {
            add => On.ColorFader.Fade_bool += value;
            remove => On.ColorFader.Fade_bool -= value;
        }

        public static event On.ColorFader.hook_Fade_Color_float_float Fade_Color_float_float
        {
            add => On.ColorFader.Fade_Color_float_float += value;
            remove => On.ColorFader.Fade_Color_float_float -= value;
        }
    }
}