using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for RandomScale class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRandomScale
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.RandomScale.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.RandomScale.orig_Start orig, RandomScale self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.RandomScale.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.RandomScale.orig_OnEnable orig, RandomScale self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookApplyScale()
        {
            if (!HookedList.Contains("ApplyScale"))
            {
                HookedList.Add("ApplyScale");
                On.RandomScale.ApplyScale += ApplyScale;
            }
        }

        internal static event Delegates.ApplyScale_BeforeArgs _beforeApplyScale;
        internal static event Delegates.ApplyScale_NormalArgs _afterApplyScale;

        private static void ApplyScale(On.RandomScale.orig_ApplyScale orig, RandomScale self)
        {
            Delegates.Params_ApplyScale @params = new()
            {
                self = self
            };
            _beforeApplyScale?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterApplyScale != null) _afterApplyScale.Invoke(@params);
        }

        internal static void HookInitExternalDebris()
        {
            if (!HookedList.Contains("InitExternalDebris"))
            {
                HookedList.Add("InitExternalDebris");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RandomScale), "InitExternalDebris"), InitExternalDebris);
            }
        }

        internal static event Delegates.InitExternalDebris_BeforeArgs _beforeInitExternalDebris;
        internal static event Delegates.InitExternalDebris_NormalArgs _afterInitExternalDebris;

        private static void InitExternalDebris(Action<RandomScale> orig, RandomScale self)
        {
            Delegates.Params_InitExternalDebris @params = new()
            {
                self = self
            };
            _beforeInitExternalDebris?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterInitExternalDebris != null) _afterInitExternalDebris.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void ApplyScale_BeforeArgs(Params_ApplyScale args);

        public delegate void ApplyScale_NormalArgs(Params_ApplyScale args);

        public delegate void InitExternalDebris_BeforeArgs(Params_InitExternalDebris args);

        public delegate void InitExternalDebris_NormalArgs(Params_InitExternalDebris args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Start
        {
            public RandomScale self;
        }

        public sealed class Params_OnEnable
        {
            public RandomScale self;
        }

        public sealed class Params_ApplyScale
        {
            public RandomScale self;
        }

        public sealed class Params_InitExternalDebris
        {
            public RandomScale self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.ApplyScale_BeforeArgs ApplyScale
        {
            add
            {
                HookHandler._beforeApplyScale += value;
                HookHandler.HookApplyScale();
            }
            remove => HookHandler._beforeApplyScale -= value;
        }

        public static event Delegates.InitExternalDebris_BeforeArgs InitExternalDebris
        {
            add
            {
                HookHandler._beforeInitExternalDebris += value;
                HookHandler.HookInitExternalDebris();
            }
            remove => HookHandler._beforeInitExternalDebris -= value;
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

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.ApplyScale_NormalArgs ApplyScale
        {
            add
            {
                HookHandler._afterApplyScale += value;
                HookHandler.HookApplyScale();
            }
            remove => HookHandler._afterApplyScale -= value;
        }

        public static event Delegates.InitExternalDebris_NormalArgs InitExternalDebris
        {
            add
            {
                HookHandler._afterInitExternalDebris += value;
                HookHandler.HookInitExternalDebris();
            }
            remove => HookHandler._afterInitExternalDebris -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.RandomScale.hook_Start Start
        {
            add => On.RandomScale.Start += value;
            remove => On.RandomScale.Start -= value;
        }

        public static event On.RandomScale.hook_OnEnable OnEnable
        {
            add => On.RandomScale.OnEnable += value;
            remove => On.RandomScale.OnEnable -= value;
        }

        public static event On.RandomScale.hook_ApplyScale ApplyScale
        {
            add => On.RandomScale.ApplyScale += value;
            remove => On.RandomScale.ApplyScale -= value;
        }

        public static event Delegates.InitExternalDebris_NormalArgs InitExternalDebris
        {
            add => HookEndpointManager.Add<Delegates.InitExternalDebris_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
            remove => HookEndpointManager.Remove<Delegates.InitExternalDebris_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
        }
    }
}