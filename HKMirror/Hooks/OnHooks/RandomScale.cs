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
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.RandomScale.orig_Start orig, RandomScale self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.RandomScale.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.RandomScale.orig_OnEnable orig, RandomScale self)
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

        internal static void HookApplyScale()
        {
            if (!HookedList.Contains("ApplyScale"))
            {
                HookedList.Add("ApplyScale");
                On.RandomScale.ApplyScale += ApplyScale;
            }
        }

        internal static event Delegates.ApplyScale_BeforeArgs _beforeApplyScale;
        internal static event Delegates.ApplyScale_AfterArgs _afterApplyScale;

        private static void ApplyScale(On.RandomScale.orig_ApplyScale orig, RandomScale self)
        {
            Delegates.Params_ApplyScale @params = new()
            {
                self = self
            };
            if (_beforeApplyScale != null)
                foreach (Delegates.ApplyScale_BeforeArgs toInvoke in _beforeApplyScale.GetInvocationList())
                    try
                    {
                        _beforeApplyScale?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterApplyScale != null)
                foreach (Delegates.ApplyScale_AfterArgs toInvoke in _afterApplyScale.GetInvocationList())
                    try
                    {
                        _afterApplyScale.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.InitExternalDebris_AfterArgs _afterInitExternalDebris;

        private static void InitExternalDebris(Action<RandomScale> orig, RandomScale self)
        {
            Delegates.Params_InitExternalDebris @params = new()
            {
                self = self
            };
            if (_beforeInitExternalDebris != null)
                foreach (Delegates.InitExternalDebris_BeforeArgs toInvoke in
                         _beforeInitExternalDebris.GetInvocationList())
                    try
                    {
                        _beforeInitExternalDebris?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterInitExternalDebris != null)
                foreach (Delegates.InitExternalDebris_AfterArgs toInvoke in
                         _afterInitExternalDebris.GetInvocationList())
                    try
                    {
                        _afterInitExternalDebris.Invoke(@params);
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
        public delegate void ApplyScale_AfterArgs(Params_ApplyScale args);

        public delegate void ApplyScale_BeforeArgs(Params_ApplyScale args);

        public delegate void ApplyScale_WithArgs(Action<RandomScale> orig, RandomScale self);

        public delegate void InitExternalDebris_AfterArgs(Params_InitExternalDebris args);

        public delegate void InitExternalDebris_BeforeArgs(Params_InitExternalDebris args);

        public delegate void InitExternalDebris_WithArgs(Action<RandomScale> orig, RandomScale self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<RandomScale> orig, RandomScale self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<RandomScale> orig, RandomScale self);

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
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.ApplyScale_AfterArgs ApplyScale
        {
            add
            {
                HookHandler._afterApplyScale += value;
                HookHandler.HookApplyScale();
            }
            remove => HookHandler._afterApplyScale -= value;
        }

        public static event Delegates.InitExternalDebris_AfterArgs InitExternalDebris
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

        public static event Delegates.InitExternalDebris_WithArgs InitExternalDebris
        {
            add => HookEndpointManager.Add<Delegates.InitExternalDebris_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
            remove => HookEndpointManager.Remove<Delegates.InitExternalDebris_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RandomScale), "IExternalDebris.InitExternalDebris"), value);
        }
    }
}