namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossSequenceBindingsDisplay class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSequenceBindingsDisplay
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossSequenceBindingsDisplay.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.BossSequenceBindingsDisplay.orig_Start orig, BossSequenceBindingsDisplay self)
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

        internal static void HookCountBindings()
        {
            if (!HookedList.Contains("CountBindings"))
            {
                HookedList.Add("CountBindings");
                On.BossSequenceBindingsDisplay.CountBindings += CountBindings;
            }
        }

        internal static event Delegates.CountBindings_BeforeArgs _beforeCountBindings;
        internal static event Delegates.CountBindings_AfterArgs _afterCountBindings;

        private static void CountBindings(On.BossSequenceBindingsDisplay.orig_CountBindings orig, out int total,
            out int completed)
        {
            Delegates.Params_CountBindings @params = new();
            if (_beforeCountBindings != null)
                foreach (Delegates.CountBindings_BeforeArgs toInvoke in _beforeCountBindings.GetInvocationList())
                    try
                    {
                        _beforeCountBindings?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            total = @params.total;
            completed = @params.completed;
            orig(out total, out completed);
            if (_afterCountBindings != null)
                foreach (Delegates.CountBindings_AfterArgs toInvoke in _afterCountBindings.GetInvocationList())
                    try
                    {
                        _afterCountBindings.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCountCompletedBindings()
        {
            if (!HookedList.Contains("CountCompletedBindings"))
            {
                HookedList.Add("CountCompletedBindings");
                On.BossSequenceBindingsDisplay.CountCompletedBindings += CountCompletedBindings;
            }
        }

        internal static event Delegates.CountCompletedBindings_BeforeArgs _beforeCountCompletedBindings;
        internal static event Delegates.CountCompletedBindings_AfterArgs _afterCountCompletedBindings;

        private static int CountCompletedBindings(On.BossSequenceBindingsDisplay.orig_CountCompletedBindings orig)
        {
            if (_beforeCountCompletedBindings != null)
                foreach (Delegates.CountCompletedBindings_BeforeArgs toInvoke in _beforeCountCompletedBindings
                             .GetInvocationList())
                    try
                    {
                        _beforeCountCompletedBindings?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterCountCompletedBindings != null)
                foreach (Delegates.CountCompletedBindings_AfterArgs toInvoke in _afterCountCompletedBindings
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCountCompletedBindings.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCountTotalBindings()
        {
            if (!HookedList.Contains("CountTotalBindings"))
            {
                HookedList.Add("CountTotalBindings");
                On.BossSequenceBindingsDisplay.CountTotalBindings += CountTotalBindings;
            }
        }

        internal static event Delegates.CountTotalBindings_BeforeArgs _beforeCountTotalBindings;
        internal static event Delegates.CountTotalBindings_AfterArgs _afterCountTotalBindings;

        private static int CountTotalBindings(On.BossSequenceBindingsDisplay.orig_CountTotalBindings orig)
        {
            if (_beforeCountTotalBindings != null)
                foreach (Delegates.CountTotalBindings_BeforeArgs toInvoke in
                         _beforeCountTotalBindings.GetInvocationList())
                    try
                    {
                        _beforeCountTotalBindings?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterCountTotalBindings != null)
                foreach (Delegates.CountTotalBindings_AfterArgs toInvoke in
                         _afterCountTotalBindings.GetInvocationList())
                    try
                    {
                        retVal = _afterCountTotalBindings.Invoke(retVal);
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
        public delegate void CountBindings_AfterArgs(Params_CountBindings args);

        public delegate void CountBindings_BeforeArgs(Params_CountBindings args);

        public delegate void CountBindings_WithArgs(Action<int, int> orig, out int total, out int completed);

        public delegate int CountCompletedBindings_AfterArgs(int ret);

        public delegate void CountCompletedBindings_BeforeArgs();

        public delegate int CountCompletedBindings_WithArgs(Func<int> orig);

        public delegate int CountTotalBindings_AfterArgs(int ret);

        public delegate void CountTotalBindings_BeforeArgs();

        public delegate int CountTotalBindings_WithArgs(Func<int> orig);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<BossSequenceBindingsDisplay> orig, BossSequenceBindingsDisplay self);

        public sealed class Params_Start
        {
            public BossSequenceBindingsDisplay self;
        }

        public sealed class Params_CountBindings
        {
            public int completed;
            public int total;
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

        public static event Delegates.CountBindings_BeforeArgs CountBindings
        {
            add
            {
                HookHandler._beforeCountBindings += value;
                HookHandler.HookCountBindings();
            }
            remove => HookHandler._beforeCountBindings -= value;
        }

        public static event Delegates.CountCompletedBindings_BeforeArgs CountCompletedBindings
        {
            add
            {
                HookHandler._beforeCountCompletedBindings += value;
                HookHandler.HookCountCompletedBindings();
            }
            remove => HookHandler._beforeCountCompletedBindings -= value;
        }

        public static event Delegates.CountTotalBindings_BeforeArgs CountTotalBindings
        {
            add
            {
                HookHandler._beforeCountTotalBindings += value;
                HookHandler.HookCountTotalBindings();
            }
            remove => HookHandler._beforeCountTotalBindings -= value;
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

        public static event Delegates.CountBindings_AfterArgs CountBindings
        {
            add
            {
                HookHandler._afterCountBindings += value;
                HookHandler.HookCountBindings();
            }
            remove => HookHandler._afterCountBindings -= value;
        }

        public static event Delegates.CountCompletedBindings_AfterArgs CountCompletedBindings
        {
            add
            {
                HookHandler._afterCountCompletedBindings += value;
                HookHandler.HookCountCompletedBindings();
            }
            remove => HookHandler._afterCountCompletedBindings -= value;
        }

        public static event Delegates.CountTotalBindings_AfterArgs CountTotalBindings
        {
            add
            {
                HookHandler._afterCountTotalBindings += value;
                HookHandler.HookCountTotalBindings();
            }
            remove => HookHandler._afterCountTotalBindings -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossSequenceBindingsDisplay.hook_Start Start
        {
            add => On.BossSequenceBindingsDisplay.Start += value;
            remove => On.BossSequenceBindingsDisplay.Start -= value;
        }

        public static event On.BossSequenceBindingsDisplay.hook_CountBindings CountBindings
        {
            add => On.BossSequenceBindingsDisplay.CountBindings += value;
            remove => On.BossSequenceBindingsDisplay.CountBindings -= value;
        }

        public static event On.BossSequenceBindingsDisplay.hook_CountCompletedBindings CountCompletedBindings
        {
            add => On.BossSequenceBindingsDisplay.CountCompletedBindings += value;
            remove => On.BossSequenceBindingsDisplay.CountCompletedBindings -= value;
        }

        public static event On.BossSequenceBindingsDisplay.hook_CountTotalBindings CountTotalBindings
        {
            add => On.BossSequenceBindingsDisplay.CountTotalBindings += value;
            remove => On.BossSequenceBindingsDisplay.CountTotalBindings -= value;
        }
    }
}