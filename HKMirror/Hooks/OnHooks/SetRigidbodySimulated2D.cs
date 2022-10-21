using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for SetRigidbodySimulated2D class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetRigidbodySimulated2D
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.SetRigidbodySimulated2D.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.SetRigidbodySimulated2D.orig_Reset orig, SetRigidbodySimulated2D self)
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
                On.SetRigidbodySimulated2D.OnEnter += OnEnter;
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(On.SetRigidbodySimulated2D.orig_OnEnter orig, SetRigidbodySimulated2D self)
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

        internal static void HookDoSetIsKinematic()
        {
            if (!HookedList.Contains("DoSetIsKinematic"))
            {
                HookedList.Add("DoSetIsKinematic");
                On.SetRigidbodySimulated2D.DoSetIsKinematic += DoSetIsKinematic;
            }
        }

        internal static event Delegates.DoSetIsKinematic_BeforeArgs _beforeDoSetIsKinematic;
        internal static event Delegates.DoSetIsKinematic_AfterArgs _afterDoSetIsKinematic;

        private static void DoSetIsKinematic(On.SetRigidbodySimulated2D.orig_DoSetIsKinematic orig,
            SetRigidbodySimulated2D self)
        {
            Delegates.Params_DoSetIsKinematic @params = new()
            {
                self = self
            };
            if (_beforeDoSetIsKinematic != null)
            {
                foreach (Delegates.DoSetIsKinematic_BeforeArgs toInvoke in _beforeDoSetIsKinematic.GetInvocationList())
                {
                    try
                    {
                        _beforeDoSetIsKinematic?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoSetIsKinematic != null)
            {
                foreach (Delegates.DoSetIsKinematic_AfterArgs toInvoke in _afterDoSetIsKinematic.GetInvocationList())
                {
                    try
                    {
                        _afterDoSetIsKinematic.Invoke(@params);
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
            public SetRigidbodySimulated2D self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SetRigidbodySimulated2D> orig, SetRigidbodySimulated2D self);

        public sealed class Params_OnEnter
        {
            public SetRigidbodySimulated2D self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SetRigidbodySimulated2D> orig, SetRigidbodySimulated2D self);

        public sealed class Params_DoSetIsKinematic
        {
            public SetRigidbodySimulated2D self;
        }

        public delegate void DoSetIsKinematic_BeforeArgs(Params_DoSetIsKinematic args);

        public delegate void DoSetIsKinematic_AfterArgs(Params_DoSetIsKinematic args);

        public delegate void DoSetIsKinematic_WithArgs(Action<SetRigidbodySimulated2D> orig,
            SetRigidbodySimulated2D self);
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

        public static event Delegates.DoSetIsKinematic_BeforeArgs DoSetIsKinematic
        {
            add
            {
                HookHandler._beforeDoSetIsKinematic += value;
                HookHandler.HookDoSetIsKinematic();
            }
            remove => HookHandler._beforeDoSetIsKinematic -= value;
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

        public static event Delegates.DoSetIsKinematic_AfterArgs DoSetIsKinematic
        {
            add
            {
                HookHandler._afterDoSetIsKinematic += value;
                HookHandler.HookDoSetIsKinematic();
            }
            remove => HookHandler._afterDoSetIsKinematic -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SetRigidbodySimulated2D.hook_Reset Reset
        {
            add => On.SetRigidbodySimulated2D.Reset += value;
            remove => On.SetRigidbodySimulated2D.Reset -= value;
        }

        public static event On.SetRigidbodySimulated2D.hook_OnEnter OnEnter
        {
            add => On.SetRigidbodySimulated2D.OnEnter += value;
            remove => On.SetRigidbodySimulated2D.OnEnter -= value;
        }

        public static event On.SetRigidbodySimulated2D.hook_DoSetIsKinematic DoSetIsKinematic
        {
            add => On.SetRigidbodySimulated2D.DoSetIsKinematic += value;
            remove => On.SetRigidbodySimulated2D.DoSetIsKinematic -= value;
        }
    }
}