using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AchievementHandler class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAchievementHandler
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_achievementsList()
        {
            if (!HookedList.Contains("get_achievementsList"))
            {
                HookedList.Add("get_achievementsList");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "get_achievementsList"),
                    get_achievementsList);
            }
        }

        internal static event Delegates.get_achievementsList_BeforeArgs _beforeget_achievementsList;
        internal static event Delegates.get_achievementsList_NormalArgs _afterget_achievementsList;

        private static AchievementsList get_achievementsList(Func<AchievementHandler, AchievementsList> orig,
            AchievementHandler self)
        {
            Delegates.Params_get_achievementsList @params = new()
            {
                self = self
            };
            _beforeget_achievementsList?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_achievementsList != null) retVal = _afterget_achievementsList.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_achievementsList()
        {
            if (!HookedList.Contains("set_achievementsList"))
            {
                HookedList.Add("set_achievementsList");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "set_achievementsList"),
                    set_achievementsList);
            }
        }

        internal static event Delegates.set_achievementsList_BeforeArgs _beforeset_achievementsList;
        internal static event Delegates.set_achievementsList_NormalArgs _afterset_achievementsList;

        private static void set_achievementsList(Action<AchievementHandler, AchievementsList> orig,
            AchievementHandler self, AchievementsList value)
        {
            Delegates.Params_set_achievementsList @params = new()
            {
                self = self, value = value
            };
            _beforeset_achievementsList?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_achievementsList != null) _afterset_achievementsList.Invoke(@params);
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.AchievementHandler.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.AchievementHandler.orig_Awake orig, AchievementHandler self)
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
                On.AchievementHandler.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.AchievementHandler.orig_Start orig, AchievementHandler self)
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

        internal static void HookAwardAchievementToPlayer()
        {
            if (!HookedList.Contains("AwardAchievementToPlayer"))
            {
                HookedList.Add("AwardAchievementToPlayer");
                On.AchievementHandler.AwardAchievementToPlayer += AwardAchievementToPlayer;
            }
        }

        internal static event Delegates.AwardAchievementToPlayer_BeforeArgs _beforeAwardAchievementToPlayer;
        internal static event Delegates.AwardAchievementToPlayer_NormalArgs _afterAwardAchievementToPlayer;

        private static void AwardAchievementToPlayer(On.AchievementHandler.orig_AwardAchievementToPlayer orig,
            AchievementHandler self, string key)
        {
            Delegates.Params_AwardAchievementToPlayer @params = new()
            {
                self = self, key = key
            };
            _beforeAwardAchievementToPlayer?.Invoke(@params);
            self = @params.self;
            key = @params.key;
            orig(self, key);
            if (_afterAwardAchievementToPlayer != null) _afterAwardAchievementToPlayer.Invoke(@params);
        }

        internal static void HookAchievementWasAwarded()
        {
            if (!HookedList.Contains("AchievementWasAwarded"))
            {
                HookedList.Add("AchievementWasAwarded");
                On.AchievementHandler.AchievementWasAwarded += AchievementWasAwarded;
            }
        }

        internal static event Delegates.AchievementWasAwarded_BeforeArgs _beforeAchievementWasAwarded;
        internal static event Delegates.AchievementWasAwarded_NormalArgs _afterAchievementWasAwarded;

        private static bool AchievementWasAwarded(On.AchievementHandler.orig_AchievementWasAwarded orig,
            AchievementHandler self, string key)
        {
            Delegates.Params_AchievementWasAwarded @params = new()
            {
                self = self, key = key
            };
            _beforeAchievementWasAwarded?.Invoke(@params);
            self = @params.self;
            key = @params.key;
            var retVal = orig(self, key);
            if (_afterAchievementWasAwarded != null) retVal = _afterAchievementWasAwarded.Invoke(@params);
            return retVal;
        }

        internal static void HookResetAllAchievements()
        {
            if (!HookedList.Contains("ResetAllAchievements"))
            {
                HookedList.Add("ResetAllAchievements");
                On.AchievementHandler.ResetAllAchievements += ResetAllAchievements;
            }
        }

        internal static event Delegates.ResetAllAchievements_BeforeArgs _beforeResetAllAchievements;
        internal static event Delegates.ResetAllAchievements_NormalArgs _afterResetAllAchievements;

        private static void ResetAllAchievements(On.AchievementHandler.orig_ResetAllAchievements orig,
            AchievementHandler self)
        {
            Delegates.Params_ResetAllAchievements @params = new()
            {
                self = self
            };
            _beforeResetAllAchievements?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterResetAllAchievements != null) _afterResetAllAchievements.Invoke(@params);
        }

        internal static void HookFlushRecordsToDisk()
        {
            if (!HookedList.Contains("FlushRecordsToDisk"))
            {
                HookedList.Add("FlushRecordsToDisk");
                On.AchievementHandler.FlushRecordsToDisk += FlushRecordsToDisk;
            }
        }

        internal static event Delegates.FlushRecordsToDisk_BeforeArgs _beforeFlushRecordsToDisk;
        internal static event Delegates.FlushRecordsToDisk_NormalArgs _afterFlushRecordsToDisk;

        private static void FlushRecordsToDisk(On.AchievementHandler.orig_FlushRecordsToDisk orig,
            AchievementHandler self)
        {
            Delegates.Params_FlushRecordsToDisk @params = new()
            {
                self = self
            };
            _beforeFlushRecordsToDisk?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFlushRecordsToDisk != null) _afterFlushRecordsToDisk.Invoke(@params);
        }

        internal static void HookQueueAchievement()
        {
            if (!HookedList.Contains("QueueAchievement"))
            {
                HookedList.Add("QueueAchievement");
                On.AchievementHandler.QueueAchievement += QueueAchievement;
            }
        }

        internal static event Delegates.QueueAchievement_BeforeArgs _beforeQueueAchievement;
        internal static event Delegates.QueueAchievement_NormalArgs _afterQueueAchievement;

        private static void QueueAchievement(On.AchievementHandler.orig_QueueAchievement orig, AchievementHandler self,
            string key)
        {
            Delegates.Params_QueueAchievement @params = new()
            {
                self = self, key = key
            };
            _beforeQueueAchievement?.Invoke(@params);
            self = @params.self;
            key = @params.key;
            orig(self, key);
            if (_afterQueueAchievement != null) _afterQueueAchievement.Invoke(@params);
        }

        internal static void HookAwardQueuedAchievements()
        {
            if (!HookedList.Contains("AwardQueuedAchievements"))
            {
                HookedList.Add("AwardQueuedAchievements");
                On.AchievementHandler.AwardQueuedAchievements += AwardQueuedAchievements;
            }
        }

        internal static event Delegates.AwardQueuedAchievements_BeforeArgs _beforeAwardQueuedAchievements;
        internal static event Delegates.AwardQueuedAchievements_NormalArgs _afterAwardQueuedAchievements;

        private static void AwardQueuedAchievements(On.AchievementHandler.orig_AwardQueuedAchievements orig,
            AchievementHandler self)
        {
            Delegates.Params_AwardQueuedAchievements @params = new()
            {
                self = self
            };
            _beforeAwardQueuedAchievements?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwardQueuedAchievements != null) _afterAwardQueuedAchievements.Invoke(@params);
        }

        internal static void HookAwardAllAchievements()
        {
            if (!HookedList.Contains("AwardAllAchievements"))
            {
                HookedList.Add("AwardAllAchievements");
                On.AchievementHandler.AwardAllAchievements += AwardAllAchievements;
            }
        }

        internal static event Delegates.AwardAllAchievements_BeforeArgs _beforeAwardAllAchievements;
        internal static event Delegates.AwardAllAchievements_NormalArgs _afterAwardAllAchievements;

        private static void AwardAllAchievements(On.AchievementHandler.orig_AwardAllAchievements orig,
            AchievementHandler self)
        {
            Delegates.Params_AwardAllAchievements @params = new()
            {
                self = self
            };
            _beforeAwardAllAchievements?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwardAllAchievements != null) _afterAwardAllAchievements.Invoke(@params);
        }

        internal static void HookCanAwardAchievement()
        {
            if (!HookedList.Contains("CanAwardAchievement"))
            {
                HookedList.Add("CanAwardAchievement");
                On.AchievementHandler.CanAwardAchievement += CanAwardAchievement;
            }
        }

        internal static event Delegates.CanAwardAchievement_BeforeArgs _beforeCanAwardAchievement;
        internal static event Delegates.CanAwardAchievement_NormalArgs _afterCanAwardAchievement;

        private static bool CanAwardAchievement(On.AchievementHandler.orig_CanAwardAchievement orig,
            AchievementHandler self, string key)
        {
            Delegates.Params_CanAwardAchievement @params = new()
            {
                self = self, key = key
            };
            _beforeCanAwardAchievement?.Invoke(@params);
            self = @params.self;
            key = @params.key;
            var retVal = orig(self, key);
            if (_afterCanAwardAchievement != null) retVal = _afterCanAwardAchievement.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void AchievementWasAwarded_BeforeArgs(Params_AchievementWasAwarded args);

        public delegate bool AchievementWasAwarded_NormalArgs(Params_AchievementWasAwarded args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void AwardAchievementToPlayer_BeforeArgs(Params_AwardAchievementToPlayer args);

        public delegate void AwardAchievementToPlayer_NormalArgs(Params_AwardAchievementToPlayer args);

        public delegate void AwardAllAchievements_BeforeArgs(Params_AwardAllAchievements args);

        public delegate void AwardAllAchievements_NormalArgs(Params_AwardAllAchievements args);

        public delegate void AwardQueuedAchievements_BeforeArgs(Params_AwardQueuedAchievements args);

        public delegate void AwardQueuedAchievements_NormalArgs(Params_AwardQueuedAchievements args);

        public delegate void CanAwardAchievement_BeforeArgs(Params_CanAwardAchievement args);

        public delegate bool CanAwardAchievement_NormalArgs(Params_CanAwardAchievement args);

        public delegate void FlushRecordsToDisk_BeforeArgs(Params_FlushRecordsToDisk args);

        public delegate void FlushRecordsToDisk_NormalArgs(Params_FlushRecordsToDisk args);

        public delegate void get_achievementsList_BeforeArgs(Params_get_achievementsList args);

        public delegate AchievementsList get_achievementsList_NormalArgs(Params_get_achievementsList args);

        public delegate void QueueAchievement_BeforeArgs(Params_QueueAchievement args);

        public delegate void QueueAchievement_NormalArgs(Params_QueueAchievement args);

        public delegate void ResetAllAchievements_BeforeArgs(Params_ResetAllAchievements args);

        public delegate void ResetAllAchievements_NormalArgs(Params_ResetAllAchievements args);

        public delegate void set_achievementsList_BeforeArgs(Params_set_achievementsList args);

        public delegate void set_achievementsList_NormalArgs(Params_set_achievementsList args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_get_achievementsList
        {
            public AchievementHandler self;
        }

        public sealed class Params_set_achievementsList
        {
            public AchievementHandler self;
            public AchievementsList value;
        }

        public sealed class Params_Awake
        {
            public AchievementHandler self;
        }

        public sealed class Params_Start
        {
            public AchievementHandler self;
        }

        public sealed class Params_AwardAchievementToPlayer
        {
            public string key;
            public AchievementHandler self;
        }

        public sealed class Params_AchievementWasAwarded
        {
            public string key;
            public AchievementHandler self;
        }

        public sealed class Params_ResetAllAchievements
        {
            public AchievementHandler self;
        }

        public sealed class Params_FlushRecordsToDisk
        {
            public AchievementHandler self;
        }

        public sealed class Params_QueueAchievement
        {
            public string key;
            public AchievementHandler self;
        }

        public sealed class Params_AwardQueuedAchievements
        {
            public AchievementHandler self;
        }

        public sealed class Params_AwardAllAchievements
        {
            public AchievementHandler self;
        }

        public sealed class Params_CanAwardAchievement
        {
            public string key;
            public AchievementHandler self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_achievementsList_BeforeArgs get_achievementsList
        {
            add
            {
                HookHandler._beforeget_achievementsList += value;
                HookHandler.Hookget_achievementsList();
            }
            remove => HookHandler._beforeget_achievementsList -= value;
        }

        public static event Delegates.set_achievementsList_BeforeArgs set_achievementsList
        {
            add
            {
                HookHandler._beforeset_achievementsList += value;
                HookHandler.Hookset_achievementsList();
            }
            remove => HookHandler._beforeset_achievementsList -= value;
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

        public static event Delegates.AwardAchievementToPlayer_BeforeArgs AwardAchievementToPlayer
        {
            add
            {
                HookHandler._beforeAwardAchievementToPlayer += value;
                HookHandler.HookAwardAchievementToPlayer();
            }
            remove => HookHandler._beforeAwardAchievementToPlayer -= value;
        }

        public static event Delegates.AchievementWasAwarded_BeforeArgs AchievementWasAwarded
        {
            add
            {
                HookHandler._beforeAchievementWasAwarded += value;
                HookHandler.HookAchievementWasAwarded();
            }
            remove => HookHandler._beforeAchievementWasAwarded -= value;
        }

        public static event Delegates.ResetAllAchievements_BeforeArgs ResetAllAchievements
        {
            add
            {
                HookHandler._beforeResetAllAchievements += value;
                HookHandler.HookResetAllAchievements();
            }
            remove => HookHandler._beforeResetAllAchievements -= value;
        }

        public static event Delegates.FlushRecordsToDisk_BeforeArgs FlushRecordsToDisk
        {
            add
            {
                HookHandler._beforeFlushRecordsToDisk += value;
                HookHandler.HookFlushRecordsToDisk();
            }
            remove => HookHandler._beforeFlushRecordsToDisk -= value;
        }

        public static event Delegates.QueueAchievement_BeforeArgs QueueAchievement
        {
            add
            {
                HookHandler._beforeQueueAchievement += value;
                HookHandler.HookQueueAchievement();
            }
            remove => HookHandler._beforeQueueAchievement -= value;
        }

        public static event Delegates.AwardQueuedAchievements_BeforeArgs AwardQueuedAchievements
        {
            add
            {
                HookHandler._beforeAwardQueuedAchievements += value;
                HookHandler.HookAwardQueuedAchievements();
            }
            remove => HookHandler._beforeAwardQueuedAchievements -= value;
        }

        public static event Delegates.AwardAllAchievements_BeforeArgs AwardAllAchievements
        {
            add
            {
                HookHandler._beforeAwardAllAchievements += value;
                HookHandler.HookAwardAllAchievements();
            }
            remove => HookHandler._beforeAwardAllAchievements -= value;
        }

        public static event Delegates.CanAwardAchievement_BeforeArgs CanAwardAchievement
        {
            add
            {
                HookHandler._beforeCanAwardAchievement += value;
                HookHandler.HookCanAwardAchievement();
            }
            remove => HookHandler._beforeCanAwardAchievement -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_achievementsList_NormalArgs get_achievementsList
        {
            add
            {
                HookHandler._afterget_achievementsList += value;
                HookHandler.Hookget_achievementsList();
            }
            remove => HookHandler._afterget_achievementsList -= value;
        }

        public static event Delegates.set_achievementsList_NormalArgs set_achievementsList
        {
            add
            {
                HookHandler._afterset_achievementsList += value;
                HookHandler.Hookset_achievementsList();
            }
            remove => HookHandler._afterset_achievementsList -= value;
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

        public static event Delegates.AwardAchievementToPlayer_NormalArgs AwardAchievementToPlayer
        {
            add
            {
                HookHandler._afterAwardAchievementToPlayer += value;
                HookHandler.HookAwardAchievementToPlayer();
            }
            remove => HookHandler._afterAwardAchievementToPlayer -= value;
        }

        public static event Delegates.AchievementWasAwarded_NormalArgs AchievementWasAwarded
        {
            add
            {
                HookHandler._afterAchievementWasAwarded += value;
                HookHandler.HookAchievementWasAwarded();
            }
            remove => HookHandler._afterAchievementWasAwarded -= value;
        }

        public static event Delegates.ResetAllAchievements_NormalArgs ResetAllAchievements
        {
            add
            {
                HookHandler._afterResetAllAchievements += value;
                HookHandler.HookResetAllAchievements();
            }
            remove => HookHandler._afterResetAllAchievements -= value;
        }

        public static event Delegates.FlushRecordsToDisk_NormalArgs FlushRecordsToDisk
        {
            add
            {
                HookHandler._afterFlushRecordsToDisk += value;
                HookHandler.HookFlushRecordsToDisk();
            }
            remove => HookHandler._afterFlushRecordsToDisk -= value;
        }

        public static event Delegates.QueueAchievement_NormalArgs QueueAchievement
        {
            add
            {
                HookHandler._afterQueueAchievement += value;
                HookHandler.HookQueueAchievement();
            }
            remove => HookHandler._afterQueueAchievement -= value;
        }

        public static event Delegates.AwardQueuedAchievements_NormalArgs AwardQueuedAchievements
        {
            add
            {
                HookHandler._afterAwardQueuedAchievements += value;
                HookHandler.HookAwardQueuedAchievements();
            }
            remove => HookHandler._afterAwardQueuedAchievements -= value;
        }

        public static event Delegates.AwardAllAchievements_NormalArgs AwardAllAchievements
        {
            add
            {
                HookHandler._afterAwardAllAchievements += value;
                HookHandler.HookAwardAllAchievements();
            }
            remove => HookHandler._afterAwardAllAchievements -= value;
        }

        public static event Delegates.CanAwardAchievement_NormalArgs CanAwardAchievement
        {
            add
            {
                HookHandler._afterCanAwardAchievement += value;
                HookHandler.HookCanAwardAchievement();
            }
            remove => HookHandler._afterCanAwardAchievement -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_achievementsList_NormalArgs get_achievementsList
        {
            add => HookEndpointManager.Add<Delegates.get_achievementsList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "get_achievementsList"), value);
            remove => HookEndpointManager.Remove<Delegates.get_achievementsList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "get_achievementsList"), value);
        }

        public static event Delegates.set_achievementsList_NormalArgs set_achievementsList
        {
            add => HookEndpointManager.Add<Delegates.set_achievementsList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "set_achievementsList"), value);
            remove => HookEndpointManager.Remove<Delegates.set_achievementsList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "set_achievementsList"), value);
        }

        public static event On.AchievementHandler.hook_Awake Awake
        {
            add => On.AchievementHandler.Awake += value;
            remove => On.AchievementHandler.Awake -= value;
        }

        public static event On.AchievementHandler.hook_Start Start
        {
            add => On.AchievementHandler.Start += value;
            remove => On.AchievementHandler.Start -= value;
        }

        public static event On.AchievementHandler.hook_AwardAchievementToPlayer AwardAchievementToPlayer
        {
            add => On.AchievementHandler.AwardAchievementToPlayer += value;
            remove => On.AchievementHandler.AwardAchievementToPlayer -= value;
        }

        public static event On.AchievementHandler.hook_AchievementWasAwarded AchievementWasAwarded
        {
            add => On.AchievementHandler.AchievementWasAwarded += value;
            remove => On.AchievementHandler.AchievementWasAwarded -= value;
        }

        public static event On.AchievementHandler.hook_ResetAllAchievements ResetAllAchievements
        {
            add => On.AchievementHandler.ResetAllAchievements += value;
            remove => On.AchievementHandler.ResetAllAchievements -= value;
        }

        public static event On.AchievementHandler.hook_FlushRecordsToDisk FlushRecordsToDisk
        {
            add => On.AchievementHandler.FlushRecordsToDisk += value;
            remove => On.AchievementHandler.FlushRecordsToDisk -= value;
        }

        public static event On.AchievementHandler.hook_QueueAchievement QueueAchievement
        {
            add => On.AchievementHandler.QueueAchievement += value;
            remove => On.AchievementHandler.QueueAchievement -= value;
        }

        public static event On.AchievementHandler.hook_AwardQueuedAchievements AwardQueuedAchievements
        {
            add => On.AchievementHandler.AwardQueuedAchievements += value;
            remove => On.AchievementHandler.AwardQueuedAchievements -= value;
        }

        public static event On.AchievementHandler.hook_AwardAllAchievements AwardAllAchievements
        {
            add => On.AchievementHandler.AwardAllAchievements += value;
            remove => On.AchievementHandler.AwardAllAchievements -= value;
        }

        public static event On.AchievementHandler.hook_CanAwardAchievement CanAwardAchievement
        {
            add => On.AchievementHandler.CanAwardAchievement += value;
            remove => On.AchievementHandler.CanAwardAchievement -= value;
        }
    }
}