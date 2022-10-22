namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossStatueLever class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossStatueLever
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookEnable()
        {
            if (!HookedList.Contains("Enable"))
            {
                HookedList.Add("Enable");
                On.BossStatueLever.Enable += Enable;
            }
        }

        internal static event Delegates.Enable_BeforeArgs _beforeEnable;
        internal static event Delegates.Enable_AfterArgs _afterEnable;

        private static void Enable(On.BossStatueLever.orig_Enable orig, BossStatueLever self)
        {
            Delegates.Params_Enable @params = new()
            {
                self = self
            };
            if (_beforeEnable != null)
                foreach (Delegates.Enable_BeforeArgs toInvoke in _beforeEnable.GetInvocationList())
                    try
                    {
                        _beforeEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterEnable != null)
                foreach (Delegates.Enable_AfterArgs toInvoke in _afterEnable.GetInvocationList())
                    try
                    {
                        _afterEnable.Invoke(@params);
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
                On.BossStatueLever.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.BossStatueLever.orig_OnTriggerEnter2D orig, BossStatueLever self,
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

        internal static void HookSetOwner()
        {
            if (!HookedList.Contains("SetOwner"))
            {
                HookedList.Add("SetOwner");
                On.BossStatueLever.SetOwner += SetOwner;
            }
        }

        internal static event Delegates.SetOwner_BeforeArgs _beforeSetOwner;
        internal static event Delegates.SetOwner_AfterArgs _afterSetOwner;

        private static void SetOwner(On.BossStatueLever.orig_SetOwner orig, BossStatueLever self, BossStatue statue)
        {
            Delegates.Params_SetOwner @params = new()
            {
                self = self, statue = statue
            };
            if (_beforeSetOwner != null)
                foreach (Delegates.SetOwner_BeforeArgs toInvoke in _beforeSetOwner.GetInvocationList())
                    try
                    {
                        _beforeSetOwner?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            statue = @params.statue;
            orig(self, statue);
            if (_afterSetOwner != null)
                foreach (Delegates.SetOwner_AfterArgs toInvoke in _afterSetOwner.GetInvocationList())
                    try
                    {
                        _afterSetOwner.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetState()
        {
            if (!HookedList.Contains("SetState"))
            {
                HookedList.Add("SetState");
                On.BossStatueLever.SetState += SetState;
            }
        }

        internal static event Delegates.SetState_BeforeArgs _beforeSetState;
        internal static event Delegates.SetState_AfterArgs _afterSetState;

        private static void SetState(On.BossStatueLever.orig_SetState orig, BossStatueLever self, bool value)
        {
            Delegates.Params_SetState @params = new()
            {
                self = self, value = value
            };
            if (_beforeSetState != null)
                foreach (Delegates.SetState_BeforeArgs toInvoke in _beforeSetState.GetInvocationList())
                    try
                    {
                        _beforeSetState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterSetState != null)
                foreach (Delegates.SetState_AfterArgs toInvoke in _afterSetState.GetInvocationList())
                    try
                    {
                        _afterSetState.Invoke(@params);
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
        public delegate void Enable_AfterArgs(Params_Enable args);

        public delegate void Enable_BeforeArgs(Params_Enable args);

        public delegate void Enable_WithArgs(Action<BossStatueLever> orig, BossStatueLever self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<BossStatueLever, Collider2D> orig, BossStatueLever self,
            Collider2D collision);

        public delegate void SetOwner_AfterArgs(Params_SetOwner args);

        public delegate void SetOwner_BeforeArgs(Params_SetOwner args);

        public delegate void SetOwner_WithArgs(Action<BossStatueLever, BossStatue> orig, BossStatueLever self,
            BossStatue statue);

        public delegate void SetState_AfterArgs(Params_SetState args);

        public delegate void SetState_BeforeArgs(Params_SetState args);

        public delegate void SetState_WithArgs(Action<BossStatueLever, bool> orig, BossStatueLever self, bool value);

        public sealed class Params_Enable
        {
            public BossStatueLever self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public BossStatueLever self;
        }

        public sealed class Params_SetOwner
        {
            public BossStatueLever self;
            public BossStatue statue;
        }

        public sealed class Params_SetState
        {
            public BossStatueLever self;
            public bool value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Enable_BeforeArgs Enable
        {
            add
            {
                HookHandler._beforeEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._beforeEnable -= value;
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

        public static event Delegates.SetOwner_BeforeArgs SetOwner
        {
            add
            {
                HookHandler._beforeSetOwner += value;
                HookHandler.HookSetOwner();
            }
            remove => HookHandler._beforeSetOwner -= value;
        }

        public static event Delegates.SetState_BeforeArgs SetState
        {
            add
            {
                HookHandler._beforeSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._beforeSetState -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Enable_AfterArgs Enable
        {
            add
            {
                HookHandler._afterEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._afterEnable -= value;
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

        public static event Delegates.SetOwner_AfterArgs SetOwner
        {
            add
            {
                HookHandler._afterSetOwner += value;
                HookHandler.HookSetOwner();
            }
            remove => HookHandler._afterSetOwner -= value;
        }

        public static event Delegates.SetState_AfterArgs SetState
        {
            add
            {
                HookHandler._afterSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._afterSetState -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossStatueLever.hook_Enable Enable
        {
            add => On.BossStatueLever.Enable += value;
            remove => On.BossStatueLever.Enable -= value;
        }

        public static event On.BossStatueLever.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.BossStatueLever.OnTriggerEnter2D += value;
            remove => On.BossStatueLever.OnTriggerEnter2D -= value;
        }

        public static event On.BossStatueLever.hook_SetOwner SetOwner
        {
            add => On.BossStatueLever.SetOwner += value;
            remove => On.BossStatueLever.SetOwner -= value;
        }

        public static event On.BossStatueLever.hook_SetState SetState
        {
            add => On.BossStatueLever.SetState += value;
            remove => On.BossStatueLever.SetState -= value;
        }
    }
}