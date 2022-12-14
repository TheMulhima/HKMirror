namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpinSelfSimple class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpinSelfSimple
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SpinSelfSimple.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.SpinSelfSimple.orig_Update orig, SpinSelfSimple self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
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
                On.SpinSelfSimple.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.SpinSelfSimple.orig_OnEnable orig, SpinSelfSimple self)
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

        internal static void HookDoSpin()
        {
            if (!HookedList.Contains("DoSpin"))
            {
                HookedList.Add("DoSpin");
                On.SpinSelfSimple.DoSpin += DoSpin;
            }
        }

        internal static event Delegates.DoSpin_BeforeArgs _beforeDoSpin;
        internal static event Delegates.DoSpin_AfterArgs _afterDoSpin;

        private static void DoSpin(On.SpinSelfSimple.orig_DoSpin orig, SpinSelfSimple self)
        {
            Delegates.Params_DoSpin @params = new()
            {
                self = self
            };
            if (_beforeDoSpin != null)
                foreach (Delegates.DoSpin_BeforeArgs toInvoke in _beforeDoSpin.GetInvocationList())
                    try
                    {
                        _beforeDoSpin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSpin != null)
                foreach (Delegates.DoSpin_AfterArgs toInvoke in _afterDoSpin.GetInvocationList())
                    try
                    {
                        _afterDoSpin.Invoke(@params);
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
        public delegate void DoSpin_AfterArgs(Params_DoSpin args);

        public delegate void DoSpin_BeforeArgs(Params_DoSpin args);

        public delegate void DoSpin_WithArgs(Action<SpinSelfSimple> orig, SpinSelfSimple self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<SpinSelfSimple> orig, SpinSelfSimple self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SpinSelfSimple> orig, SpinSelfSimple self);

        public sealed class Params_Update
        {
            public SpinSelfSimple self;
        }

        public sealed class Params_OnEnable
        {
            public SpinSelfSimple self;
        }

        public sealed class Params_DoSpin
        {
            public SpinSelfSimple self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
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

        public static event Delegates.DoSpin_BeforeArgs DoSpin
        {
            add
            {
                HookHandler._beforeDoSpin += value;
                HookHandler.HookDoSpin();
            }
            remove => HookHandler._beforeDoSpin -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
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

        public static event Delegates.DoSpin_AfterArgs DoSpin
        {
            add
            {
                HookHandler._afterDoSpin += value;
                HookHandler.HookDoSpin();
            }
            remove => HookHandler._afterDoSpin -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpinSelfSimple.hook_Update Update
        {
            add => On.SpinSelfSimple.Update += value;
            remove => On.SpinSelfSimple.Update -= value;
        }

        public static event On.SpinSelfSimple.hook_OnEnable OnEnable
        {
            add => On.SpinSelfSimple.OnEnable += value;
            remove => On.SpinSelfSimple.OnEnable -= value;
        }

        public static event On.SpinSelfSimple.hook_DoSpin DoSpin
        {
            add => On.SpinSelfSimple.DoSpin += value;
            remove => On.SpinSelfSimple.DoSpin -= value;
        }
    }
}