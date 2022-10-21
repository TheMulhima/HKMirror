using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for VisibilityControl class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVisibilityControl
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.VisibilityControl.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.VisibilityControl.orig_Awake orig, VisibilityControl self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookReveal()
        {
            if (!HookedList.Contains("Reveal"))
            {
                HookedList.Add("Reveal");
                On.VisibilityControl.Reveal += Reveal;
            }
        }

        internal static event Delegates.Reveal_BeforeArgs _beforeReveal;
        internal static event Delegates.Reveal_AfterArgs _afterReveal;

        private static void Reveal(On.VisibilityControl.orig_Reveal orig, VisibilityControl self)
        {
            Delegates.Params_Reveal @params = new()
            {
                self = self
            };
            if (_beforeReveal != null)
            {
                foreach (Delegates.Reveal_BeforeArgs toInvoke in _beforeReveal.GetInvocationList())
                {
                    try
                    {
                        _beforeReveal?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReveal != null)
            {
                foreach (Delegates.Reveal_AfterArgs toInvoke in _afterReveal.GetInvocationList())
                {
                    try
                    {
                        _afterReveal.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.VisibilityControl.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_AfterArgs _afterHide;

        private static void Hide(On.VisibilityControl.orig_Hide orig, VisibilityControl self)
        {
            Delegates.Params_Hide @params = new()
            {
                self = self
            };
            if (_beforeHide != null)
            {
                foreach (Delegates.Hide_BeforeArgs toInvoke in _beforeHide.GetInvocationList())
                {
                    try
                    {
                        _beforeHide?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterHide != null)
            {
                foreach (Delegates.Hide_AfterArgs toInvoke in _afterHide.GetInvocationList())
                {
                    try
                    {
                        _afterHide.Invoke(@params);
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
        public sealed class Params_Awake
        {
            public VisibilityControl self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<VisibilityControl> orig, VisibilityControl self);

        public sealed class Params_Reveal
        {
            public VisibilityControl self;
        }

        public delegate void Reveal_BeforeArgs(Params_Reveal args);

        public delegate void Reveal_AfterArgs(Params_Reveal args);

        public delegate void Reveal_WithArgs(Action<VisibilityControl> orig, VisibilityControl self);

        public sealed class Params_Hide
        {
            public VisibilityControl self;
        }

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_AfterArgs(Params_Hide args);

        public delegate void Hide_WithArgs(Action<VisibilityControl> orig, VisibilityControl self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.Reveal_BeforeArgs Reveal
        {
            add
            {
                HookHandler._beforeReveal += value;
                HookHandler.HookReveal();
            }
            remove => HookHandler._beforeReveal -= value;
        }

        public static event Delegates.Hide_BeforeArgs Hide
        {
            add
            {
                HookHandler._beforeHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._beforeHide -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Reveal_AfterArgs Reveal
        {
            add
            {
                HookHandler._afterReveal += value;
                HookHandler.HookReveal();
            }
            remove => HookHandler._afterReveal -= value;
        }

        public static event Delegates.Hide_AfterArgs Hide
        {
            add
            {
                HookHandler._afterHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._afterHide -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.VisibilityControl.hook_Awake Awake
        {
            add => On.VisibilityControl.Awake += value;
            remove => On.VisibilityControl.Awake -= value;
        }

        public static event On.VisibilityControl.hook_Reveal Reveal
        {
            add => On.VisibilityControl.Reveal += value;
            remove => On.VisibilityControl.Reveal -= value;
        }

        public static event On.VisibilityControl.hook_Hide Hide
        {
            add => On.VisibilityControl.Hide += value;
            remove => On.VisibilityControl.Hide -= value;
        }
    }
}