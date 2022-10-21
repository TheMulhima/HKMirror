using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for RandomRotation class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRandomRotation
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.RandomRotation.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.RandomRotation.orig_Start orig, RandomRotation self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.RandomRotation.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.RandomRotation.orig_OnEnable orig, RandomRotation self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
            {
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
            {
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookRandomRotate()
        {
            if (!HookedList.Contains("RandomRotate"))
            {
                HookedList.Add("RandomRotate");
                On.RandomRotation.RandomRotate += RandomRotate;
            }
        }

        internal static event Delegates.RandomRotate_BeforeArgs _beforeRandomRotate;
        internal static event Delegates.RandomRotate_AfterArgs _afterRandomRotate;

        private static void RandomRotate(On.RandomRotation.orig_RandomRotate orig, RandomRotation self)
        {
            Delegates.Params_RandomRotate @params = new()
            {
                self = self
            };
            if (_beforeRandomRotate != null)
            {
                foreach (Delegates.RandomRotate_BeforeArgs toInvoke in _beforeRandomRotate.GetInvocationList())
                {
                    try
                    {
                        _beforeRandomRotate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterRandomRotate != null)
            {
                foreach (Delegates.RandomRotate_AfterArgs toInvoke in _afterRandomRotate.GetInvocationList())
                {
                    try
                    {
                        _afterRandomRotate.Invoke(@params);
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
        public sealed class Params_Start
        {
            public RandomRotation self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<RandomRotation> orig, RandomRotation self);

        public sealed class Params_OnEnable
        {
            public RandomRotation self;
        }

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<RandomRotation> orig, RandomRotation self);

        public sealed class Params_RandomRotate
        {
            public RandomRotation self;
        }

        public delegate void RandomRotate_BeforeArgs(Params_RandomRotate args);

        public delegate void RandomRotate_AfterArgs(Params_RandomRotate args);

        public delegate void RandomRotate_WithArgs(Action<RandomRotation> orig, RandomRotation self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.RandomRotate_BeforeArgs RandomRotate
        {
            add
            {
                HookHandler._beforeRandomRotate += value;
                HookHandler.HookRandomRotate();
            }
            remove => HookHandler._beforeRandomRotate -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.RandomRotate_AfterArgs RandomRotate
        {
            add
            {
                HookHandler._afterRandomRotate += value;
                HookHandler.HookRandomRotate();
            }
            remove => HookHandler._afterRandomRotate -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.RandomRotation.hook_Start Start
        {
            add => On.RandomRotation.Start += value;
            remove => On.RandomRotation.Start -= value;
        }

        public static event On.RandomRotation.hook_OnEnable OnEnable
        {
            add => On.RandomRotation.OnEnable += value;
            remove => On.RandomRotation.OnEnable -= value;
        }

        public static event On.RandomRotation.hook_RandomRotate RandomRotate
        {
            add => On.RandomRotation.RandomRotate += value;
            remove => On.RandomRotation.RandomRotate -= value;
        }
    }
}