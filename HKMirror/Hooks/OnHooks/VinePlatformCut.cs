namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for VinePlatformCut class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVinePlatformCut
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.VinePlatformCut.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.VinePlatformCut.orig_Awake orig, VinePlatformCut self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.VinePlatformCut.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.VinePlatformCut.orig_OnTriggerEnter2D orig, VinePlatformCut self,
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

        internal static void HookCut()
        {
            if (!HookedList.Contains("Cut"))
            {
                HookedList.Add("Cut");
                On.VinePlatformCut.Cut += Cut;
            }
        }

        internal static event Delegates.Cut_BeforeArgs _beforeCut;
        internal static event Delegates.Cut_AfterArgs _afterCut;

        private static void Cut(On.VinePlatformCut.orig_Cut orig, VinePlatformCut self)
        {
            Delegates.Params_Cut @params = new()
            {
                self = self
            };
            if (_beforeCut != null)
                foreach (Delegates.Cut_BeforeArgs toInvoke in _beforeCut.GetInvocationList())
                    try
                    {
                        _beforeCut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterCut != null)
                foreach (Delegates.Cut_AfterArgs toInvoke in _afterCut.GetInvocationList())
                    try
                    {
                        _afterCut.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDisable()
        {
            if (!HookedList.Contains("Disable"))
            {
                HookedList.Add("Disable");
                On.VinePlatformCut.Disable += Disable;
            }
        }

        internal static event Delegates.Disable_BeforeArgs _beforeDisable;
        internal static event Delegates.Disable_AfterArgs _afterDisable;

        private static void Disable(On.VinePlatformCut.orig_Disable orig, VinePlatformCut self, bool disableAll)
        {
            Delegates.Params_Disable @params = new()
            {
                self = self, disableAll = disableAll
            };
            if (_beforeDisable != null)
                foreach (Delegates.Disable_BeforeArgs toInvoke in _beforeDisable.GetInvocationList())
                    try
                    {
                        _beforeDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            disableAll = @params.disableAll;
            orig(self, disableAll);
            if (_afterDisable != null)
                foreach (Delegates.Disable_AfterArgs toInvoke in _afterDisable.GetInvocationList())
                    try
                    {
                        _afterDisable.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<VinePlatformCut> orig, VinePlatformCut self);

        public delegate void Cut_AfterArgs(Params_Cut args);

        public delegate void Cut_BeforeArgs(Params_Cut args);

        public delegate void Cut_WithArgs(Action<VinePlatformCut> orig, VinePlatformCut self);

        public delegate void Disable_AfterArgs(Params_Disable args);

        public delegate void Disable_BeforeArgs(Params_Disable args);

        public delegate void Disable_WithArgs(Action<VinePlatformCut, bool> orig, VinePlatformCut self,
            bool disableAll);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<VinePlatformCut, Collider2D> orig, VinePlatformCut self,
            Collider2D collision);

        public sealed class Params_Awake
        {
            public VinePlatformCut self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public VinePlatformCut self;
        }

        public sealed class Params_Cut
        {
            public VinePlatformCut self;
        }

        public sealed class Params_Disable
        {
            public bool disableAll;
            public VinePlatformCut self;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.Cut_BeforeArgs Cut
        {
            add
            {
                HookHandler._beforeCut += value;
                HookHandler.HookCut();
            }
            remove => HookHandler._beforeCut -= value;
        }

        public static event Delegates.Disable_BeforeArgs Disable
        {
            add
            {
                HookHandler._beforeDisable += value;
                HookHandler.HookDisable();
            }
            remove => HookHandler._beforeDisable -= value;
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

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.Cut_AfterArgs Cut
        {
            add
            {
                HookHandler._afterCut += value;
                HookHandler.HookCut();
            }
            remove => HookHandler._afterCut -= value;
        }

        public static event Delegates.Disable_AfterArgs Disable
        {
            add
            {
                HookHandler._afterDisable += value;
                HookHandler.HookDisable();
            }
            remove => HookHandler._afterDisable -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.VinePlatformCut.hook_Awake Awake
        {
            add => On.VinePlatformCut.Awake += value;
            remove => On.VinePlatformCut.Awake -= value;
        }

        public static event On.VinePlatformCut.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.VinePlatformCut.OnTriggerEnter2D += value;
            remove => On.VinePlatformCut.OnTriggerEnter2D -= value;
        }

        public static event On.VinePlatformCut.hook_Cut Cut
        {
            add => On.VinePlatformCut.Cut += value;
            remove => On.VinePlatformCut.Cut -= value;
        }

        public static event On.VinePlatformCut.hook_Disable Disable
        {
            add => On.VinePlatformCut.Disable += value;
            remove => On.VinePlatformCut.Disable -= value;
        }
    }
}