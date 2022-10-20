using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossDoorTargetLock class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossDoorTargetLock
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsUnlocked()
        {
            if (!HookedList.Contains("get_IsUnlocked"))
            {
                HookedList.Add("get_IsUnlocked");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "get_IsUnlocked"), get_IsUnlocked);
            }
        }

        internal static event Delegates.get_IsUnlocked_BeforeArgs _beforeget_IsUnlocked;
        internal static event Delegates.get_IsUnlocked_NormalArgs _afterget_IsUnlocked;

        private static bool get_IsUnlocked(Func<BossDoorTargetLock, bool> orig, BossDoorTargetLock self)
        {
            Delegates.Params_get_IsUnlocked @params = new()
            {
                self = self
            };
            _beforeget_IsUnlocked?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsUnlocked != null) retVal = _afterget_IsUnlocked.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_IsUnlocked()
        {
            if (!HookedList.Contains("set_IsUnlocked"))
            {
                HookedList.Add("set_IsUnlocked");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "set_IsUnlocked"), set_IsUnlocked);
            }
        }

        internal static event Delegates.set_IsUnlocked_BeforeArgs _beforeset_IsUnlocked;
        internal static event Delegates.set_IsUnlocked_NormalArgs _afterset_IsUnlocked;

        private static void set_IsUnlocked(Action<BossDoorTargetLock, bool> orig, BossDoorTargetLock self, bool value)
        {
            Delegates.Params_set_IsUnlocked @params = new()
            {
                self = self, value = value
            };
            _beforeset_IsUnlocked?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_IsUnlocked != null) _afterset_IsUnlocked.Invoke(@params);
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BossDoorTargetLock.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.BossDoorTargetLock.orig_Awake orig, BossDoorTargetLock self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossDoorTargetLock.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.BossDoorTargetLock.orig_Start orig, BossDoorTargetLock self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookUnlockSequence()
        {
            if (!HookedList.Contains("UnlockSequence"))
            {
                HookedList.Add("UnlockSequence");
                On.BossDoorTargetLock.UnlockSequence += UnlockSequence;
            }
        }

        internal static event Delegates.UnlockSequence_BeforeArgs _beforeUnlockSequence;

        private static IEnumerator UnlockSequence(On.BossDoorTargetLock.orig_UnlockSequence orig,
            BossDoorTargetLock self)
        {
            Delegates.Params_UnlockSequence @params = new()
            {
                self = self
            };
            _beforeUnlockSequence?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookStartRoarLock()
        {
            if (!HookedList.Contains("StartRoarLock"))
            {
                HookedList.Add("StartRoarLock");
                On.BossDoorTargetLock.StartRoarLock += StartRoarLock;
            }
        }

        internal static event Delegates.StartRoarLock_BeforeArgs _beforeStartRoarLock;
        internal static event Delegates.StartRoarLock_NormalArgs _afterStartRoarLock;

        private static void StartRoarLock(On.BossDoorTargetLock.orig_StartRoarLock orig, BossDoorTargetLock self)
        {
            Delegates.Params_StartRoarLock @params = new()
            {
                self = self
            };
            _beforeStartRoarLock?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartRoarLock != null) _afterStartRoarLock.Invoke(@params);
        }

        internal static void HookStopRoarLock()
        {
            if (!HookedList.Contains("StopRoarLock"))
            {
                HookedList.Add("StopRoarLock");
                On.BossDoorTargetLock.StopRoarLock += StopRoarLock;
            }
        }

        internal static event Delegates.StopRoarLock_BeforeArgs _beforeStopRoarLock;
        internal static event Delegates.StopRoarLock_NormalArgs _afterStopRoarLock;

        private static void StopRoarLock(On.BossDoorTargetLock.orig_StopRoarLock orig, BossDoorTargetLock self)
        {
            Delegates.Params_StopRoarLock @params = new()
            {
                self = self
            };
            _beforeStopRoarLock?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStopRoarLock != null) _afterStopRoarLock.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void get_IsUnlocked_BeforeArgs(Params_get_IsUnlocked args);

        public delegate bool get_IsUnlocked_NormalArgs(Params_get_IsUnlocked args);

        public delegate void set_IsUnlocked_BeforeArgs(Params_set_IsUnlocked args);

        public delegate void set_IsUnlocked_NormalArgs(Params_set_IsUnlocked args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void StartRoarLock_BeforeArgs(Params_StartRoarLock args);

        public delegate void StartRoarLock_NormalArgs(Params_StartRoarLock args);

        public delegate void StopRoarLock_BeforeArgs(Params_StopRoarLock args);

        public delegate void StopRoarLock_NormalArgs(Params_StopRoarLock args);

        public delegate void UnlockSequence_BeforeArgs(Params_UnlockSequence args);

        public delegate IEnumerator UnlockSequence_NormalArgs(Params_UnlockSequence args);

        public sealed class Params_get_IsUnlocked
        {
            public BossDoorTargetLock self;
        }

        public sealed class Params_set_IsUnlocked
        {
            public BossDoorTargetLock self;
            public bool value;
        }

        public sealed class Params_Awake
        {
            public BossDoorTargetLock self;
        }

        public sealed class Params_Start
        {
            public BossDoorTargetLock self;
        }

        public sealed class Params_UnlockSequence
        {
            public BossDoorTargetLock self;
        }

        public sealed class Params_StartRoarLock
        {
            public BossDoorTargetLock self;
        }

        public sealed class Params_StopRoarLock
        {
            public BossDoorTargetLock self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsUnlocked_BeforeArgs get_IsUnlocked
        {
            add
            {
                HookHandler._beforeget_IsUnlocked += value;
                HookHandler.Hookget_IsUnlocked();
            }
            remove => HookHandler._beforeget_IsUnlocked -= value;
        }

        public static event Delegates.set_IsUnlocked_BeforeArgs set_IsUnlocked
        {
            add
            {
                HookHandler._beforeset_IsUnlocked += value;
                HookHandler.Hookset_IsUnlocked();
            }
            remove => HookHandler._beforeset_IsUnlocked -= value;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.UnlockSequence_BeforeArgs UnlockSequence
        {
            add
            {
                HookHandler._beforeUnlockSequence += value;
                HookHandler.HookUnlockSequence();
            }
            remove => HookHandler._beforeUnlockSequence -= value;
        }

        public static event Delegates.StartRoarLock_BeforeArgs StartRoarLock
        {
            add
            {
                HookHandler._beforeStartRoarLock += value;
                HookHandler.HookStartRoarLock();
            }
            remove => HookHandler._beforeStartRoarLock -= value;
        }

        public static event Delegates.StopRoarLock_BeforeArgs StopRoarLock
        {
            add
            {
                HookHandler._beforeStopRoarLock += value;
                HookHandler.HookStopRoarLock();
            }
            remove => HookHandler._beforeStopRoarLock -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsUnlocked_NormalArgs get_IsUnlocked
        {
            add
            {
                HookHandler._afterget_IsUnlocked += value;
                HookHandler.Hookget_IsUnlocked();
            }
            remove => HookHandler._afterget_IsUnlocked -= value;
        }

        public static event Delegates.set_IsUnlocked_NormalArgs set_IsUnlocked
        {
            add
            {
                HookHandler._afterset_IsUnlocked += value;
                HookHandler.Hookset_IsUnlocked();
            }
            remove => HookHandler._afterset_IsUnlocked -= value;
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.StartRoarLock_NormalArgs StartRoarLock
        {
            add
            {
                HookHandler._afterStartRoarLock += value;
                HookHandler.HookStartRoarLock();
            }
            remove => HookHandler._afterStartRoarLock -= value;
        }

        public static event Delegates.StopRoarLock_NormalArgs StopRoarLock
        {
            add
            {
                HookHandler._afterStopRoarLock += value;
                HookHandler.HookStopRoarLock();
            }
            remove => HookHandler._afterStopRoarLock -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsUnlocked_NormalArgs get_IsUnlocked
        {
            add => HookEndpointManager.Add<Delegates.get_IsUnlocked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "get_IsUnlocked"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsUnlocked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "get_IsUnlocked"), value);
        }

        public static event Delegates.set_IsUnlocked_NormalArgs set_IsUnlocked
        {
            add => HookEndpointManager.Add<Delegates.set_IsUnlocked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "set_IsUnlocked"), value);
            remove => HookEndpointManager.Remove<Delegates.set_IsUnlocked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "set_IsUnlocked"), value);
        }

        public static event On.BossDoorTargetLock.hook_Awake Awake
        {
            add => On.BossDoorTargetLock.Awake += value;
            remove => On.BossDoorTargetLock.Awake -= value;
        }

        public static event On.BossDoorTargetLock.hook_Start Start
        {
            add => On.BossDoorTargetLock.Start += value;
            remove => On.BossDoorTargetLock.Start -= value;
        }

        public static event On.BossDoorTargetLock.hook_UnlockSequence UnlockSequence
        {
            add => On.BossDoorTargetLock.UnlockSequence += value;
            remove => On.BossDoorTargetLock.UnlockSequence -= value;
        }

        public static event On.BossDoorTargetLock.hook_StartRoarLock StartRoarLock
        {
            add => On.BossDoorTargetLock.StartRoarLock += value;
            remove => On.BossDoorTargetLock.StartRoarLock -= value;
        }

        public static event On.BossDoorTargetLock.hook_StopRoarLock StopRoarLock
        {
            add => On.BossDoorTargetLock.StopRoarLock += value;
            remove => On.BossDoorTargetLock.StopRoarLock -= value;
        }
    }
}