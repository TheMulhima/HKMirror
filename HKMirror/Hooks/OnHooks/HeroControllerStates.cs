using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for HeroControllerStates class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHeroControllerStates
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookGetState()
        {
            if (!HookedList.Contains("GetState"))
            {
                HookedList.Add("GetState");
                On.HeroControllerStates.GetState += GetState;
            }
        }

        internal static event Delegates.GetState_BeforeArgs _beforeGetState;
        internal static event Delegates.GetState_AfterArgs _afterGetState;

        private static bool GetState(On.HeroControllerStates.orig_GetState orig, HeroControllerStates self,
            string stateName)
        {
            Delegates.Params_GetState @params = new()
            {
                self = self, stateName = stateName
            };
            if (_beforeGetState != null)
            {
                foreach (Delegates.GetState_BeforeArgs toInvoke in _beforeGetState.GetInvocationList())
                {
                    try
                    {
                        _beforeGetState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            stateName = @params.stateName;
            var retVal = orig(self, stateName);
            if (_afterGetState != null)
            {
                foreach (Delegates.GetState_AfterArgs toInvoke in _afterGetState.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetState.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookSetState()
        {
            if (!HookedList.Contains("SetState"))
            {
                HookedList.Add("SetState");
                On.HeroControllerStates.SetState += SetState;
            }
        }

        internal static event Delegates.SetState_BeforeArgs _beforeSetState;
        internal static event Delegates.SetState_AfterArgs _afterSetState;

        private static void SetState(On.HeroControllerStates.orig_SetState orig, HeroControllerStates self,
            string stateName, bool value)
        {
            Delegates.Params_SetState @params = new()
            {
                self = self, stateName = stateName, value = value
            };
            if (_beforeSetState != null)
            {
                foreach (Delegates.SetState_BeforeArgs toInvoke in _beforeSetState.GetInvocationList())
                {
                    try
                    {
                        _beforeSetState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            stateName = @params.stateName;
            value = @params.value;
            orig(self, stateName, value);
            if (_afterSetState != null)
            {
                foreach (Delegates.SetState_AfterArgs toInvoke in _afterSetState.GetInvocationList())
                {
                    try
                    {
                        _afterSetState.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.HeroControllerStates.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.HeroControllerStates.orig_Reset orig, HeroControllerStates self)
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
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_GetState
        {
            public HeroControllerStates self;
            public string stateName;
        }

        public delegate void GetState_BeforeArgs(Params_GetState args);

        public delegate bool GetState_AfterArgs(Params_GetState args, bool ret);

        public delegate bool GetState_WithArgs(Func<HeroControllerStates, string, bool> orig, HeroControllerStates self,
            string stateName);

        public sealed class Params_SetState
        {
            public HeroControllerStates self;
            public string stateName;
            public bool value;
        }

        public delegate void SetState_BeforeArgs(Params_SetState args);

        public delegate void SetState_AfterArgs(Params_SetState args);

        public delegate void SetState_WithArgs(Action<HeroControllerStates, string, bool> orig,
            HeroControllerStates self, string stateName, bool value);

        public sealed class Params_Reset
        {
            public HeroControllerStates self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HeroControllerStates> orig, HeroControllerStates self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.GetState_BeforeArgs GetState
        {
            add
            {
                HookHandler._beforeGetState += value;
                HookHandler.HookGetState();
            }
            remove => HookHandler._beforeGetState -= value;
        }

        public static event Delegates.SetState_BeforeArgs SetState
        {
            add
            {
                HookHandler._beforeSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._beforeSetState -= value;
        }

        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.GetState_AfterArgs GetState
        {
            add
            {
                HookHandler._afterGetState += value;
                HookHandler.HookGetState();
            }
            remove => HookHandler._afterGetState -= value;
        }

        public static event Delegates.SetState_AfterArgs SetState
        {
            add
            {
                HookHandler._afterSetState += value;
                HookHandler.HookSetState();
            }
            remove => HookHandler._afterSetState -= value;
        }

        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.HeroControllerStates.hook_GetState GetState
        {
            add => On.HeroControllerStates.GetState += value;
            remove => On.HeroControllerStates.GetState -= value;
        }

        public static event On.HeroControllerStates.hook_SetState SetState
        {
            add => On.HeroControllerStates.SetState += value;
            remove => On.HeroControllerStates.SetState -= value;
        }

        public static event On.HeroControllerStates.hook_Reset Reset
        {
            add => On.HeroControllerStates.Reset += value;
            remove => On.HeroControllerStates.Reset -= value;
        }
    }
}