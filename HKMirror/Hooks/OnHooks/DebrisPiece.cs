namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DebrisPiece class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDebrisPiece
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.DebrisPiece.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.DebrisPiece.orig_Reset orig, DebrisPiece self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.DebrisPiece.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.DebrisPiece.orig_Awake orig, DebrisPiece self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.DebrisPiece.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.DebrisPiece.orig_OnEnable orig, DebrisPiece self)
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

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.DebrisPiece.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.DebrisPiece.orig_OnDisable orig, DebrisPiece self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookLaunch()
        {
            if (!HookedList.Contains("Launch"))
            {
                HookedList.Add("Launch");
                On.DebrisPiece.Launch += Launch;
            }
        }

        internal static event Delegates.Launch_BeforeArgs _beforeLaunch;
        internal static event Delegates.Launch_AfterArgs _afterLaunch;

        private static void Launch(On.DebrisPiece.orig_Launch orig, DebrisPiece self)
        {
            Delegates.Params_Launch @params = new()
            {
                self = self
            };
            if (_beforeLaunch != null)
                foreach (Delegates.Launch_BeforeArgs toInvoke in _beforeLaunch.GetInvocationList())
                    try
                    {
                        _beforeLaunch?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterLaunch != null)
                foreach (Delegates.Launch_AfterArgs toInvoke in _afterLaunch.GetInvocationList())
                    try
                    {
                        _afterLaunch.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.DebrisPiece.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_AfterArgs _afterFixedUpdate;

        private static void FixedUpdate(On.DebrisPiece.orig_FixedUpdate orig, DebrisPiece self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            if (_beforeFixedUpdate != null)
                foreach (Delegates.FixedUpdate_BeforeArgs toInvoke in _beforeFixedUpdate.GetInvocationList())
                    try
                    {
                        _beforeFixedUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null)
                foreach (Delegates.FixedUpdate_AfterArgs toInvoke in _afterFixedUpdate.GetInvocationList())
                    try
                    {
                        _afterFixedUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSpin()
        {
            if (!HookedList.Contains("Spin"))
            {
                HookedList.Add("Spin");
                On.DebrisPiece.Spin += Spin;
            }
        }

        internal static event Delegates.Spin_BeforeArgs _beforeSpin;
        internal static event Delegates.Spin_AfterArgs _afterSpin;

        private static void Spin(On.DebrisPiece.orig_Spin orig, DebrisPiece self)
        {
            Delegates.Params_Spin @params = new()
            {
                self = self
            };
            if (_beforeSpin != null)
                foreach (Delegates.Spin_BeforeArgs toInvoke in _beforeSpin.GetInvocationList())
                    try
                    {
                        _beforeSpin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSpin != null)
                foreach (Delegates.Spin_AfterArgs toInvoke in _afterSpin.GetInvocationList())
                    try
                    {
                        _afterSpin.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void FixedUpdate_AfterArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void Launch_AfterArgs(Params_Launch args);

        public delegate void Launch_BeforeArgs(Params_Launch args);

        public delegate void Launch_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public delegate void Spin_AfterArgs(Params_Spin args);

        public delegate void Spin_BeforeArgs(Params_Spin args);

        public delegate void Spin_WithArgs(Action<DebrisPiece> orig, DebrisPiece self);

        public sealed class Params_Reset
        {
            public DebrisPiece self;
        }

        public sealed class Params_Awake
        {
            public DebrisPiece self;
        }

        public sealed class Params_OnEnable
        {
            public DebrisPiece self;
        }

        public sealed class Params_OnDisable
        {
            public DebrisPiece self;
        }

        public sealed class Params_Launch
        {
            public DebrisPiece self;
        }

        public sealed class Params_FixedUpdate
        {
            public DebrisPiece self;
        }

        public sealed class Params_Spin
        {
            public DebrisPiece self;
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

        public static event Delegates.Launch_BeforeArgs Launch
        {
            add
            {
                HookHandler._beforeLaunch += value;
                HookHandler.HookLaunch();
            }
            remove => HookHandler._beforeLaunch -= value;
        }

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.Spin_BeforeArgs Spin
        {
            add
            {
                HookHandler._beforeSpin += value;
                HookHandler.HookSpin();
            }
            remove => HookHandler._beforeSpin -= value;
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

        public static event Delegates.Launch_AfterArgs Launch
        {
            add
            {
                HookHandler._afterLaunch += value;
                HookHandler.HookLaunch();
            }
            remove => HookHandler._afterLaunch -= value;
        }

        public static event Delegates.FixedUpdate_AfterArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.Spin_AfterArgs Spin
        {
            add
            {
                HookHandler._afterSpin += value;
                HookHandler.HookSpin();
            }
            remove => HookHandler._afterSpin -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DebrisPiece.hook_Reset Reset
        {
            add => On.DebrisPiece.Reset += value;
            remove => On.DebrisPiece.Reset -= value;
        }

        public static event On.DebrisPiece.hook_Awake Awake
        {
            add => On.DebrisPiece.Awake += value;
            remove => On.DebrisPiece.Awake -= value;
        }

        public static event On.DebrisPiece.hook_OnEnable OnEnable
        {
            add => On.DebrisPiece.OnEnable += value;
            remove => On.DebrisPiece.OnEnable -= value;
        }

        public static event On.DebrisPiece.hook_OnDisable OnDisable
        {
            add => On.DebrisPiece.OnDisable += value;
            remove => On.DebrisPiece.OnDisable -= value;
        }

        public static event On.DebrisPiece.hook_Launch Launch
        {
            add => On.DebrisPiece.Launch += value;
            remove => On.DebrisPiece.Launch -= value;
        }

        public static event On.DebrisPiece.hook_FixedUpdate FixedUpdate
        {
            add => On.DebrisPiece.FixedUpdate += value;
            remove => On.DebrisPiece.FixedUpdate -= value;
        }

        public static event On.DebrisPiece.hook_Spin Spin
        {
            add => On.DebrisPiece.Spin += value;
            remove => On.DebrisPiece.Spin -= value;
        }
    }
}