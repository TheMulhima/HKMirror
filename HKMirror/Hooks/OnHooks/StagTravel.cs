using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for StagTravel class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStagTravel
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.StagTravel.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.StagTravel.orig_Start orig, StagTravel self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookFadeInRoutine()
        {
            if (!HookedList.Contains("FadeInRoutine"))
            {
                HookedList.Add("FadeInRoutine");
                On.StagTravel.FadeInRoutine += FadeInRoutine;
            }
        }

        internal static event Delegates.FadeInRoutine_BeforeArgs _beforeFadeInRoutine;

        private static IEnumerator FadeInRoutine(On.StagTravel.orig_FadeInRoutine orig, StagTravel self)
        {
            Delegates.Params_FadeInRoutine @params = new()
            {
                self = self
            };
            _beforeFadeInRoutine?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.StagTravel.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.StagTravel.orig_Update orig, StagTravel self)
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

        internal static void HookNotifyFetchComplete()
        {
            if (!HookedList.Contains("NotifyFetchComplete"))
            {
                HookedList.Add("NotifyFetchComplete");
                On.StagTravel.NotifyFetchComplete += NotifyFetchComplete;
            }
        }

        internal static event Delegates.NotifyFetchComplete_BeforeArgs _beforeNotifyFetchComplete;
        internal static event Delegates.NotifyFetchComplete_NormalArgs _afterNotifyFetchComplete;

        private static void NotifyFetchComplete(On.StagTravel.orig_NotifyFetchComplete orig, StagTravel self)
        {
            Delegates.Params_NotifyFetchComplete @params = new()
            {
                self = self
            };
            _beforeNotifyFetchComplete?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterNotifyFetchComplete != null) _afterNotifyFetchComplete.Invoke(@params);
        }

        internal static void Hookget_IsReadyToActivate()
        {
            if (!HookedList.Contains("get_IsReadyToActivate"))
            {
                HookedList.Add("get_IsReadyToActivate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(StagTravel), "get_IsReadyToActivate"),
                    get_IsReadyToActivate);
            }
        }

        internal static event Delegates.get_IsReadyToActivate_BeforeArgs _beforeget_IsReadyToActivate;
        internal static event Delegates.get_IsReadyToActivate_NormalArgs _afterget_IsReadyToActivate;

        private static bool get_IsReadyToActivate(Func<StagTravel, bool> orig, StagTravel self)
        {
            Delegates.Params_get_IsReadyToActivate @params = new()
            {
                self = self
            };
            _beforeget_IsReadyToActivate?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsReadyToActivate != null) retVal = _afterget_IsReadyToActivate.Invoke(@params);
            return retVal;
        }

        internal static void HookSkip()
        {
            if (!HookedList.Contains("Skip"))
            {
                HookedList.Add("Skip");
                On.StagTravel.Skip += Skip;
            }
        }

        internal static event Delegates.Skip_BeforeArgs _beforeSkip;

        private static IEnumerator Skip(On.StagTravel.orig_Skip orig, StagTravel self)
        {
            Delegates.Params_Skip @params = new()
            {
                self = self
            };
            _beforeSkip?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void FadeInRoutine_BeforeArgs(Params_FadeInRoutine args);

        public delegate IEnumerator FadeInRoutine_NormalArgs(Params_FadeInRoutine args);

        public delegate void get_IsReadyToActivate_BeforeArgs(Params_get_IsReadyToActivate args);

        public delegate bool get_IsReadyToActivate_NormalArgs(Params_get_IsReadyToActivate args);

        public delegate void NotifyFetchComplete_BeforeArgs(Params_NotifyFetchComplete args);

        public delegate void NotifyFetchComplete_NormalArgs(Params_NotifyFetchComplete args);

        public delegate void Skip_BeforeArgs(Params_Skip args);

        public delegate IEnumerator Skip_NormalArgs(Params_Skip args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public StagTravel self;
        }

        public sealed class Params_FadeInRoutine
        {
            public StagTravel self;
        }

        public sealed class Params_Update
        {
            public StagTravel self;
        }

        public sealed class Params_NotifyFetchComplete
        {
            public StagTravel self;
        }

        public sealed class Params_get_IsReadyToActivate
        {
            public StagTravel self;
        }

        public sealed class Params_Skip
        {
            public StagTravel self;
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

        public static event Delegates.FadeInRoutine_BeforeArgs FadeInRoutine
        {
            add
            {
                HookHandler._beforeFadeInRoutine += value;
                HookHandler.HookFadeInRoutine();
            }
            remove => HookHandler._beforeFadeInRoutine -= value;
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

        public static event Delegates.NotifyFetchComplete_BeforeArgs NotifyFetchComplete
        {
            add
            {
                HookHandler._beforeNotifyFetchComplete += value;
                HookHandler.HookNotifyFetchComplete();
            }
            remove => HookHandler._beforeNotifyFetchComplete -= value;
        }

        public static event Delegates.get_IsReadyToActivate_BeforeArgs get_IsReadyToActivate
        {
            add
            {
                HookHandler._beforeget_IsReadyToActivate += value;
                HookHandler.Hookget_IsReadyToActivate();
            }
            remove => HookHandler._beforeget_IsReadyToActivate -= value;
        }

        public static event Delegates.Skip_BeforeArgs Skip
        {
            add
            {
                HookHandler._beforeSkip += value;
                HookHandler.HookSkip();
            }
            remove => HookHandler._beforeSkip -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.NotifyFetchComplete_NormalArgs NotifyFetchComplete
        {
            add
            {
                HookHandler._afterNotifyFetchComplete += value;
                HookHandler.HookNotifyFetchComplete();
            }
            remove => HookHandler._afterNotifyFetchComplete -= value;
        }

        public static event Delegates.get_IsReadyToActivate_NormalArgs get_IsReadyToActivate
        {
            add
            {
                HookHandler._afterget_IsReadyToActivate += value;
                HookHandler.Hookget_IsReadyToActivate();
            }
            remove => HookHandler._afterget_IsReadyToActivate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.StagTravel.hook_Start Start
        {
            add => On.StagTravel.Start += value;
            remove => On.StagTravel.Start -= value;
        }

        public static event On.StagTravel.hook_FadeInRoutine FadeInRoutine
        {
            add => On.StagTravel.FadeInRoutine += value;
            remove => On.StagTravel.FadeInRoutine -= value;
        }

        public static event On.StagTravel.hook_Update Update
        {
            add => On.StagTravel.Update += value;
            remove => On.StagTravel.Update -= value;
        }

        public static event On.StagTravel.hook_NotifyFetchComplete NotifyFetchComplete
        {
            add => On.StagTravel.NotifyFetchComplete += value;
            remove => On.StagTravel.NotifyFetchComplete -= value;
        }

        public static event Delegates.get_IsReadyToActivate_NormalArgs get_IsReadyToActivate
        {
            add => HookEndpointManager.Add<Delegates.get_IsReadyToActivate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StagTravel), "get_IsReadyToActivate"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsReadyToActivate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StagTravel), "get_IsReadyToActivate"), value);
        }

        public static event On.StagTravel.hook_Skip Skip
        {
            add => On.StagTravel.Skip += value;
            remove => On.StagTravel.Skip -= value;
        }
    }
}