using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for StartCoroutine class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStartCoroutine
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "Reset", true),
                    Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoStartCoroutine()
        {
            if (!HookedList.Contains("DoStartCoroutine"))
            {
                HookedList.Add("DoStartCoroutine");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine),
                        "DoStartCoroutine", true), DoStartCoroutine);
            }
        }

        internal static event Delegates.DoStartCoroutine_BeforeArgs _beforeDoStartCoroutine;
        internal static event Delegates.DoStartCoroutine_AfterArgs _afterDoStartCoroutine;

        private static void DoStartCoroutine(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self)
        {
            Delegates.Params_DoStartCoroutine @params = new()
            {
                self = self
            };
            if (_beforeDoStartCoroutine != null)
            {
                foreach (Delegates.DoStartCoroutine_BeforeArgs toInvoke in _beforeDoStartCoroutine.GetInvocationList())
                {
                    try
                    {
                        _beforeDoStartCoroutine?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoStartCoroutine != null)
            {
                foreach (Delegates.DoStartCoroutine_AfterArgs toInvoke in _afterDoStartCoroutine.GetInvocationList())
                {
                    try
                    {
                        _afterDoStartCoroutine.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnExit",
                        true), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
            {
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                {
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
            {
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                {
                    try
                    {
                        _afterOnExit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.StartCoroutine self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.StartCoroutine self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self);

        public sealed class Params_DoStartCoroutine
        {
            public HutongGames.PlayMaker.Actions.StartCoroutine self;
        }

        public delegate void DoStartCoroutine_BeforeArgs(Params_DoStartCoroutine args);

        public delegate void DoStartCoroutine_AfterArgs(Params_DoStartCoroutine args);

        public delegate void DoStartCoroutine_WithArgs(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self);

        public sealed class Params_OnExit
        {
            public HutongGames.PlayMaker.Actions.StartCoroutine self;
        }

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<HutongGames.PlayMaker.Actions.StartCoroutine> orig,
            HutongGames.PlayMaker.Actions.StartCoroutine self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.DoStartCoroutine_BeforeArgs DoStartCoroutine
        {
            add
            {
                HookHandler._beforeDoStartCoroutine += value;
                HookHandler.HookDoStartCoroutine();
            }
            remove => HookHandler._beforeDoStartCoroutine -= value;
        }

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.DoStartCoroutine_AfterArgs DoStartCoroutine
        {
            add
            {
                HookHandler._afterDoStartCoroutine += value;
                HookHandler.HookDoStartCoroutine();
            }
            remove => HookHandler._afterDoStartCoroutine -= value;
        }

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnEnter", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnEnter", true),
                value);
        }

        public static event Delegates.DoStartCoroutine_WithArgs DoStartCoroutine
        {
            add => HookEndpointManager.Add<Delegates.DoStartCoroutine_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "DoStartCoroutine",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoStartCoroutine_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "DoStartCoroutine",
                    true), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnExit", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.StartCoroutine), "OnExit", true),
                value);
        }
    }
}