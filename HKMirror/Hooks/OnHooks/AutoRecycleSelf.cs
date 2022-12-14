namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AutoRecycleSelf class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAutoRecycleSelf
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.AutoRecycleSelf.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.AutoRecycleSelf.orig_OnEnable orig, AutoRecycleSelf self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.AutoRecycleSelf.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.AutoRecycleSelf.orig_Update orig, AutoRecycleSelf self)
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

        internal static void HookUpdate20()
        {
            if (!HookedList.Contains("Update20"))
            {
                HookedList.Add("Update20");
                On.AutoRecycleSelf.Update20 += Update20;
            }
        }

        internal static event Delegates.Update20_BeforeArgs _beforeUpdate20;
        internal static event Delegates.Update20_AfterArgs _afterUpdate20;

        private static void Update20(On.AutoRecycleSelf.orig_Update20 orig, AutoRecycleSelf self)
        {
            Delegates.Params_Update20 @params = new()
            {
                self = self
            };
            if (_beforeUpdate20 != null)
                foreach (Delegates.Update20_BeforeArgs toInvoke in _beforeUpdate20.GetInvocationList())
                    try
                    {
                        _beforeUpdate20?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate20 != null)
                foreach (Delegates.Update20_AfterArgs toInvoke in _afterUpdate20.GetInvocationList())
                    try
                    {
                        _afterUpdate20.Invoke(@params);
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
                On.AutoRecycleSelf.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.AutoRecycleSelf.orig_OnDisable orig, AutoRecycleSelf self)
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

        internal static void HookOnApplicationQuit()
        {
            if (!HookedList.Contains("OnApplicationQuit"))
            {
                HookedList.Add("OnApplicationQuit");
                On.AutoRecycleSelf.OnApplicationQuit += OnApplicationQuit;
            }
        }

        internal static event Delegates.OnApplicationQuit_BeforeArgs _beforeOnApplicationQuit;
        internal static event Delegates.OnApplicationQuit_AfterArgs _afterOnApplicationQuit;

        private static void OnApplicationQuit(On.AutoRecycleSelf.orig_OnApplicationQuit orig, AutoRecycleSelf self)
        {
            Delegates.Params_OnApplicationQuit @params = new()
            {
                self = self
            };
            if (_beforeOnApplicationQuit != null)
                foreach (Delegates.OnApplicationQuit_BeforeArgs toInvoke in
                         _beforeOnApplicationQuit.GetInvocationList())
                    try
                    {
                        _beforeOnApplicationQuit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnApplicationQuit != null)
                foreach (Delegates.OnApplicationQuit_AfterArgs toInvoke in _afterOnApplicationQuit.GetInvocationList())
                    try
                    {
                        _afterOnApplicationQuit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStartTimer()
        {
            if (!HookedList.Contains("StartTimer"))
            {
                HookedList.Add("StartTimer");
                On.AutoRecycleSelf.StartTimer += StartTimer;
            }
        }

        internal static event Delegates.StartTimer_BeforeArgs _beforeStartTimer;

        private static IEnumerator StartTimer(On.AutoRecycleSelf.orig_StartTimer orig, AutoRecycleSelf self, float wait)
        {
            Delegates.Params_StartTimer @params = new()
            {
                self = self, wait = wait
            };
            if (_beforeStartTimer != null)
                foreach (Delegates.StartTimer_BeforeArgs toInvoke in _beforeStartTimer.GetInvocationList())
                    try
                    {
                        _beforeStartTimer?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            wait = @params.wait;
            return orig(self, wait);
        }

        internal static void HookRecycleSelf()
        {
            if (!HookedList.Contains("RecycleSelf"))
            {
                HookedList.Add("RecycleSelf");
                On.AutoRecycleSelf.RecycleSelf += RecycleSelf;
            }
        }

        internal static event Delegates.RecycleSelf_BeforeArgs _beforeRecycleSelf;
        internal static event Delegates.RecycleSelf_AfterArgs _afterRecycleSelf;

        private static void RecycleSelf(On.AutoRecycleSelf.orig_RecycleSelf orig, AutoRecycleSelf self)
        {
            Delegates.Params_RecycleSelf @params = new()
            {
                self = self
            };
            if (_beforeRecycleSelf != null)
                foreach (Delegates.RecycleSelf_BeforeArgs toInvoke in _beforeRecycleSelf.GetInvocationList())
                    try
                    {
                        _beforeRecycleSelf?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterRecycleSelf != null)
                foreach (Delegates.RecycleSelf_AfterArgs toInvoke in _afterRecycleSelf.GetInvocationList())
                    try
                    {
                        _afterRecycleSelf.Invoke(@params);
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
        public delegate void OnApplicationQuit_AfterArgs(Params_OnApplicationQuit args);

        public delegate void OnApplicationQuit_BeforeArgs(Params_OnApplicationQuit args);

        public delegate void OnApplicationQuit_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public delegate void RecycleSelf_AfterArgs(Params_RecycleSelf args);

        public delegate void RecycleSelf_BeforeArgs(Params_RecycleSelf args);

        public delegate void RecycleSelf_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public delegate IEnumerator StartTimer_AfterArgs(Params_StartTimer args, IEnumerator ret);

        public delegate void StartTimer_BeforeArgs(Params_StartTimer args);

        public delegate IEnumerator StartTimer_WithArgs(Func<AutoRecycleSelf, float, IEnumerator> orig,
            AutoRecycleSelf self, float wait);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public delegate void Update20_AfterArgs(Params_Update20 args);

        public delegate void Update20_BeforeArgs(Params_Update20 args);

        public delegate void Update20_WithArgs(Action<AutoRecycleSelf> orig, AutoRecycleSelf self);

        public sealed class Params_OnEnable
        {
            public AutoRecycleSelf self;
        }

        public sealed class Params_Update
        {
            public AutoRecycleSelf self;
        }

        public sealed class Params_Update20
        {
            public AutoRecycleSelf self;
        }

        public sealed class Params_OnDisable
        {
            public AutoRecycleSelf self;
        }

        public sealed class Params_OnApplicationQuit
        {
            public AutoRecycleSelf self;
        }

        public sealed class Params_StartTimer
        {
            public AutoRecycleSelf self;
            public float wait;
        }

        public sealed class Params_RecycleSelf
        {
            public AutoRecycleSelf self;
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

        public static event Delegates.Update20_BeforeArgs Update20
        {
            add
            {
                HookHandler._beforeUpdate20 += value;
                HookHandler.HookUpdate20();
            }
            remove => HookHandler._beforeUpdate20 -= value;
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

        public static event Delegates.OnApplicationQuit_BeforeArgs OnApplicationQuit
        {
            add
            {
                HookHandler._beforeOnApplicationQuit += value;
                HookHandler.HookOnApplicationQuit();
            }
            remove => HookHandler._beforeOnApplicationQuit -= value;
        }

        public static event Delegates.StartTimer_BeforeArgs StartTimer
        {
            add
            {
                HookHandler._beforeStartTimer += value;
                HookHandler.HookStartTimer();
            }
            remove => HookHandler._beforeStartTimer -= value;
        }

        public static event Delegates.RecycleSelf_BeforeArgs RecycleSelf
        {
            add
            {
                HookHandler._beforeRecycleSelf += value;
                HookHandler.HookRecycleSelf();
            }
            remove => HookHandler._beforeRecycleSelf -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Update20_AfterArgs Update20
        {
            add
            {
                HookHandler._afterUpdate20 += value;
                HookHandler.HookUpdate20();
            }
            remove => HookHandler._afterUpdate20 -= value;
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

        public static event Delegates.OnApplicationQuit_AfterArgs OnApplicationQuit
        {
            add
            {
                HookHandler._afterOnApplicationQuit += value;
                HookHandler.HookOnApplicationQuit();
            }
            remove => HookHandler._afterOnApplicationQuit -= value;
        }

        public static event Delegates.RecycleSelf_AfterArgs RecycleSelf
        {
            add
            {
                HookHandler._afterRecycleSelf += value;
                HookHandler.HookRecycleSelf();
            }
            remove => HookHandler._afterRecycleSelf -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.AutoRecycleSelf.hook_OnEnable OnEnable
        {
            add => On.AutoRecycleSelf.OnEnable += value;
            remove => On.AutoRecycleSelf.OnEnable -= value;
        }

        public static event On.AutoRecycleSelf.hook_Update Update
        {
            add => On.AutoRecycleSelf.Update += value;
            remove => On.AutoRecycleSelf.Update -= value;
        }

        public static event On.AutoRecycleSelf.hook_Update20 Update20
        {
            add => On.AutoRecycleSelf.Update20 += value;
            remove => On.AutoRecycleSelf.Update20 -= value;
        }

        public static event On.AutoRecycleSelf.hook_OnDisable OnDisable
        {
            add => On.AutoRecycleSelf.OnDisable += value;
            remove => On.AutoRecycleSelf.OnDisable -= value;
        }

        public static event On.AutoRecycleSelf.hook_OnApplicationQuit OnApplicationQuit
        {
            add => On.AutoRecycleSelf.OnApplicationQuit += value;
            remove => On.AutoRecycleSelf.OnApplicationQuit -= value;
        }

        public static event On.AutoRecycleSelf.hook_StartTimer StartTimer
        {
            add => On.AutoRecycleSelf.StartTimer += value;
            remove => On.AutoRecycleSelf.StartTimer -= value;
        }

        public static event On.AutoRecycleSelf.hook_RecycleSelf RecycleSelf
        {
            add => On.AutoRecycleSelf.RecycleSelf += value;
            remove => On.AutoRecycleSelf.RecycleSelf -= value;
        }
    }
}