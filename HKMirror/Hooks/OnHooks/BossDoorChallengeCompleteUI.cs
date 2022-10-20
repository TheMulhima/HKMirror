namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossDoorChallengeCompleteUI class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossDoorChallengeCompleteUI
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossDoorChallengeCompleteUI.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.BossDoorChallengeCompleteUI.orig_Start orig, BossDoorChallengeCompleteUI self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.BossDoorChallengeCompleteUI.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.BossDoorChallengeCompleteUI.orig_Update orig, BossDoorChallengeCompleteUI self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookShowAchievements()
        {
            if (!HookedList.Contains("ShowAchievements"))
            {
                HookedList.Add("ShowAchievements");
                On.BossDoorChallengeCompleteUI.ShowAchievements += ShowAchievements;
            }
        }

        internal static event Delegates.ShowAchievements_BeforeArgs _beforeShowAchievements;

        private static IEnumerator ShowAchievements(On.BossDoorChallengeCompleteUI.orig_ShowAchievements orig,
            BossDoorChallengeCompleteUI self)
        {
            Delegates.Params_ShowAchievements @params = new()
            {
                self = self
            };
            _beforeShowAchievements?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookSequence()
        {
            if (!HookedList.Contains("Sequence"))
            {
                HookedList.Add("Sequence");
                On.BossDoorChallengeCompleteUI.Sequence += Sequence;
            }
        }

        internal static event Delegates.Sequence_BeforeArgs _beforeSequence;

        private static IEnumerator Sequence(On.BossDoorChallengeCompleteUI.orig_Sequence orig,
            BossDoorChallengeCompleteUI self)
        {
            Delegates.Params_Sequence @params = new()
            {
                self = self
            };
            _beforeSequence?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Sequence_BeforeArgs(Params_Sequence args);

        public delegate IEnumerator Sequence_NormalArgs(Params_Sequence args);

        public delegate void ShowAchievements_BeforeArgs(Params_ShowAchievements args);

        public delegate IEnumerator ShowAchievements_NormalArgs(Params_ShowAchievements args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public BossDoorChallengeCompleteUI self;
        }

        public sealed class Params_Update
        {
            public BossDoorChallengeCompleteUI self;
        }

        public sealed class Params_ShowAchievements
        {
            public BossDoorChallengeCompleteUI self;
        }

        public sealed class Params_Sequence
        {
            public BossDoorChallengeCompleteUI self;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.ShowAchievements_BeforeArgs ShowAchievements
        {
            add
            {
                HookHandler._beforeShowAchievements += value;
                HookHandler.HookShowAchievements();
            }
            remove => HookHandler._beforeShowAchievements -= value;
        }

        public static event Delegates.Sequence_BeforeArgs Sequence
        {
            add
            {
                HookHandler._beforeSequence += value;
                HookHandler.HookSequence();
            }
            remove => HookHandler._beforeSequence -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossDoorChallengeCompleteUI.hook_Start Start
        {
            add => On.BossDoorChallengeCompleteUI.Start += value;
            remove => On.BossDoorChallengeCompleteUI.Start -= value;
        }

        public static event On.BossDoorChallengeCompleteUI.hook_Update Update
        {
            add => On.BossDoorChallengeCompleteUI.Update += value;
            remove => On.BossDoorChallengeCompleteUI.Update -= value;
        }

        public static event On.BossDoorChallengeCompleteUI.hook_ShowAchievements ShowAchievements
        {
            add => On.BossDoorChallengeCompleteUI.ShowAchievements += value;
            remove => On.BossDoorChallengeCompleteUI.ShowAchievements -= value;
        }

        public static event On.BossDoorChallengeCompleteUI.hook_Sequence Sequence
        {
            add => On.BossDoorChallengeCompleteUI.Sequence += value;
            remove => On.BossDoorChallengeCompleteUI.Sequence -= value;
        }
    }
}