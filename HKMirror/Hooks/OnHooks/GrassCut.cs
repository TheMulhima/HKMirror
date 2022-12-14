namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GrassCut class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGrassCut
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.GrassCut.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.GrassCut.orig_Awake orig, GrassCut self)
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
                On.GrassCut.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.GrassCut.orig_OnTriggerEnter2D orig, GrassCut self,
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

        internal static void HookShouldCut()
        {
            if (!HookedList.Contains("ShouldCut"))
            {
                HookedList.Add("ShouldCut");
                On.GrassCut.ShouldCut += ShouldCut;
            }
        }

        internal static event Delegates.ShouldCut_BeforeArgs _beforeShouldCut;
        internal static event Delegates.ShouldCut_AfterArgs _afterShouldCut;

        private static bool ShouldCut(On.GrassCut.orig_ShouldCut orig, Collider2D collision)
        {
            Delegates.Params_ShouldCut @params = new()
            {
                collision = collision
            };
            if (_beforeShouldCut != null)
                foreach (Delegates.ShouldCut_BeforeArgs toInvoke in _beforeShouldCut.GetInvocationList())
                    try
                    {
                        _beforeShouldCut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            collision = @params.collision;
            var retVal = orig(collision);
            if (_afterShouldCut != null)
                foreach (Delegates.ShouldCut_AfterArgs toInvoke in _afterShouldCut.GetInvocationList())
                    try
                    {
                        retVal = _afterShouldCut.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<GrassCut> orig, GrassCut self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<GrassCut, Collider2D> orig, GrassCut self,
            Collider2D collision);

        public delegate bool ShouldCut_AfterArgs(Params_ShouldCut args, bool ret);

        public delegate void ShouldCut_BeforeArgs(Params_ShouldCut args);

        public delegate bool ShouldCut_WithArgs(Func<Collider2D, bool> orig, Collider2D collision);

        public sealed class Params_Awake
        {
            public GrassCut self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public GrassCut self;
        }

        public sealed class Params_ShouldCut
        {
            public Collider2D collision;
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

        public static event Delegates.ShouldCut_BeforeArgs ShouldCut
        {
            add
            {
                HookHandler._beforeShouldCut += value;
                HookHandler.HookShouldCut();
            }
            remove => HookHandler._beforeShouldCut -= value;
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

        public static event Delegates.ShouldCut_AfterArgs ShouldCut
        {
            add
            {
                HookHandler._afterShouldCut += value;
                HookHandler.HookShouldCut();
            }
            remove => HookHandler._afterShouldCut -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GrassCut.hook_Awake Awake
        {
            add => On.GrassCut.Awake += value;
            remove => On.GrassCut.Awake -= value;
        }

        public static event On.GrassCut.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.GrassCut.OnTriggerEnter2D += value;
            remove => On.GrassCut.OnTriggerEnter2D -= value;
        }

        public static event On.GrassCut.hook_ShouldCut ShouldCut
        {
            add => On.GrassCut.ShouldCut += value;
            remove => On.GrassCut.ShouldCut -= value;
        }
    }
}