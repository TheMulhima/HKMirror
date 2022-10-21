using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for TutorialEntryPauser class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTutorialEntryPauser
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.TutorialEntryPauser.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.TutorialEntryPauser.orig_Start orig, TutorialEntryPauser self)
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

        internal static void HookEnableControl()
        {
            if (!HookedList.Contains("EnableControl"))
            {
                HookedList.Add("EnableControl");
                On.TutorialEntryPauser.EnableControl += EnableControl;
            }
        }

        internal static event Delegates.EnableControl_BeforeArgs _beforeEnableControl;
        internal static event Delegates.EnableControl_AfterArgs _afterEnableControl;

        private static void EnableControl(On.TutorialEntryPauser.orig_EnableControl orig, TutorialEntryPauser self)
        {
            Delegates.Params_EnableControl @params = new()
            {
                self = self
            };
            if (_beforeEnableControl != null)
            {
                foreach (Delegates.EnableControl_BeforeArgs toInvoke in _beforeEnableControl.GetInvocationList())
                {
                    try
                    {
                        _beforeEnableControl?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterEnableControl != null)
            {
                foreach (Delegates.EnableControl_AfterArgs toInvoke in _afterEnableControl.GetInvocationList())
                {
                    try
                    {
                        _afterEnableControl.Invoke(@params);
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
            public TutorialEntryPauser self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<TutorialEntryPauser> orig, TutorialEntryPauser self);

        public sealed class Params_EnableControl
        {
            public TutorialEntryPauser self;
        }

        public delegate void EnableControl_BeforeArgs(Params_EnableControl args);

        public delegate void EnableControl_AfterArgs(Params_EnableControl args);

        public delegate void EnableControl_WithArgs(Action<TutorialEntryPauser> orig, TutorialEntryPauser self);
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

        public static event Delegates.EnableControl_BeforeArgs EnableControl
        {
            add
            {
                HookHandler._beforeEnableControl += value;
                HookHandler.HookEnableControl();
            }
            remove => HookHandler._beforeEnableControl -= value;
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

        public static event Delegates.EnableControl_AfterArgs EnableControl
        {
            add
            {
                HookHandler._afterEnableControl += value;
                HookHandler.HookEnableControl();
            }
            remove => HookHandler._afterEnableControl -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.TutorialEntryPauser.hook_Start Start
        {
            add => On.TutorialEntryPauser.Start += value;
            remove => On.TutorialEntryPauser.Start -= value;
        }

        public static event On.TutorialEntryPauser.hook_EnableControl EnableControl
        {
            add => On.TutorialEntryPauser.EnableControl += value;
            remove => On.TutorialEntryPauser.EnableControl -= value;
        }
    }
}