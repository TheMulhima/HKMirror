namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SimpleRock class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSimpleRock
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SimpleRock.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.SimpleRock.orig_Start orig, SimpleRock self)
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

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.SimpleRock.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_AfterArgs _afterFixedUpdate;

        private static void FixedUpdate(On.SimpleRock.orig_FixedUpdate orig, SimpleRock self)
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

        internal static void HookOnTriggerEnter()
        {
            if (!HookedList.Contains("OnTriggerEnter"))
            {
                HookedList.Add("OnTriggerEnter");
                On.SimpleRock.OnTriggerEnter += OnTriggerEnter;
            }
        }

        internal static event Delegates.OnTriggerEnter_BeforeArgs _beforeOnTriggerEnter;
        internal static event Delegates.OnTriggerEnter_AfterArgs _afterOnTriggerEnter;

        private static void OnTriggerEnter(On.SimpleRock.orig_OnTriggerEnter orig, SimpleRock self, Collider other)
        {
            Delegates.Params_OnTriggerEnter @params = new()
            {
                self = self, other = other
            };
            if (_beforeOnTriggerEnter != null)
                foreach (Delegates.OnTriggerEnter_BeforeArgs toInvoke in _beforeOnTriggerEnter.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            other = @params.other;
            orig(self, other);
            if (_afterOnTriggerEnter != null)
                foreach (Delegates.OnTriggerEnter_AfterArgs toInvoke in _afterOnTriggerEnter.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter.Invoke(@params);
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
        public delegate void FixedUpdate_AfterArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_WithArgs(Action<SimpleRock> orig, SimpleRock self);

        public delegate void OnTriggerEnter_AfterArgs(Params_OnTriggerEnter args);

        public delegate void OnTriggerEnter_BeforeArgs(Params_OnTriggerEnter args);

        public delegate void OnTriggerEnter_WithArgs(Action<SimpleRock, Collider> orig, SimpleRock self,
            Collider other);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<SimpleRock> orig, SimpleRock self);

        public sealed class Params_Start
        {
            public SimpleRock self;
        }

        public sealed class Params_FixedUpdate
        {
            public SimpleRock self;
        }

        public sealed class Params_OnTriggerEnter
        {
            public Collider other;
            public SimpleRock self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.OnTriggerEnter_BeforeArgs OnTriggerEnter
        {
            add
            {
                HookHandler._beforeOnTriggerEnter += value;
                HookHandler.HookOnTriggerEnter();
            }
            remove => HookHandler._beforeOnTriggerEnter -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.OnTriggerEnter_AfterArgs OnTriggerEnter
        {
            add
            {
                HookHandler._afterOnTriggerEnter += value;
                HookHandler.HookOnTriggerEnter();
            }
            remove => HookHandler._afterOnTriggerEnter -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SimpleRock.hook_Start Start
        {
            add => On.SimpleRock.Start += value;
            remove => On.SimpleRock.Start -= value;
        }

        public static event On.SimpleRock.hook_FixedUpdate FixedUpdate
        {
            add => On.SimpleRock.FixedUpdate += value;
            remove => On.SimpleRock.FixedUpdate -= value;
        }

        public static event On.SimpleRock.hook_OnTriggerEnter OnTriggerEnter
        {
            add => On.SimpleRock.OnTriggerEnter += value;
            remove => On.SimpleRock.OnTriggerEnter -= value;
        }
    }
}