using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for BridgeSection class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBridgeSection
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BridgeSection.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.BridgeSection.orig_Awake orig, BridgeSection self)
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

        internal static void HookOpen_BridgeLever_bool()
        {
            if (!HookedList.Contains("Open_BridgeLever_bool"))
            {
                HookedList.Add("Open_BridgeLever_bool");
                On.BridgeSection.Open_BridgeLever_bool += Open_BridgeLever_bool;
            }
        }

        internal static event Delegates.Open_BridgeLever_bool_BeforeArgs _beforeOpen_BridgeLever_bool;
        internal static event Delegates.Open_BridgeLever_bool_AfterArgs _afterOpen_BridgeLever_bool;

        private static void Open_BridgeLever_bool(On.BridgeSection.orig_Open_BridgeLever_bool orig, BridgeSection self,
            BridgeLever lever, bool playAnim)
        {
            Delegates.Params_Open_BridgeLever_bool @params = new()
            {
                self = self, lever = lever, playAnim = playAnim
            };
            if (_beforeOpen_BridgeLever_bool != null)
            {
                foreach (Delegates.Open_BridgeLever_bool_BeforeArgs toInvoke in _beforeOpen_BridgeLever_bool
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeOpen_BridgeLever_bool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            lever = @params.lever;
            playAnim = @params.playAnim;
            orig(self, lever, playAnim);
            if (_afterOpen_BridgeLever_bool != null)
            {
                foreach (Delegates.Open_BridgeLever_bool_AfterArgs toInvoke in _afterOpen_BridgeLever_bool
                             .GetInvocationList())
                {
                    try
                    {
                        _afterOpen_BridgeLever_bool.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOpen_float()
        {
            if (!HookedList.Contains("Open_float"))
            {
                HookedList.Add("Open_float");
                On.BridgeSection.Open_float += Open_float;
            }
        }

        internal static event Delegates.Open_float_BeforeArgs _beforeOpen_float;

        private static System.Collections.IEnumerator Open_float(On.BridgeSection.orig_Open_float orig,
            BridgeSection self, float waitTime)
        {
            Delegates.Params_Open_float @params = new()
            {
                self = self, waitTime = waitTime
            };
            if (_beforeOpen_float != null)
            {
                foreach (Delegates.Open_float_BeforeArgs toInvoke in _beforeOpen_float.GetInvocationList())
                {
                    try
                    {
                        _beforeOpen_float?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            waitTime = @params.waitTime;
            return orig(self, waitTime);
        }

        internal static void HookOpenFence()
        {
            if (!HookedList.Contains("OpenFence"))
            {
                HookedList.Add("OpenFence");
                On.BridgeSection.OpenFence += OpenFence;
            }
        }

        internal static event Delegates.OpenFence_BeforeArgs _beforeOpenFence;

        private static System.Collections.IEnumerator OpenFence(On.BridgeSection.orig_OpenFence orig,
            BridgeSection self)
        {
            Delegates.Params_OpenFence @params = new()
            {
                self = self
            };
            if (_beforeOpenFence != null)
            {
                foreach (Delegates.OpenFence_BeforeArgs toInvoke in _beforeOpenFence.GetInvocationList())
                {
                    try
                    {
                        _beforeOpenFence?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Awake
        {
            public BridgeSection self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<BridgeSection> orig, BridgeSection self);

        public sealed class Params_Open_BridgeLever_bool
        {
            public BridgeSection self;
            public BridgeLever lever;
            public bool playAnim;
        }

        public delegate void Open_BridgeLever_bool_BeforeArgs(Params_Open_BridgeLever_bool args);

        public delegate void Open_BridgeLever_bool_AfterArgs(Params_Open_BridgeLever_bool args);

        public delegate void Open_BridgeLever_bool_WithArgs(Action<BridgeSection, BridgeLever, bool> orig,
            BridgeSection self, BridgeLever lever, bool playAnim);

        public sealed class Params_Open_float
        {
            public BridgeSection self;
            public float waitTime;
        }

        public delegate void Open_float_BeforeArgs(Params_Open_float args);

        public delegate System.Collections.IEnumerator Open_float_AfterArgs(Params_Open_float args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Open_float_WithArgs(
            Func<BridgeSection, float, System.Collections.IEnumerator> orig, BridgeSection self, float waitTime);

        public sealed class Params_OpenFence
        {
            public BridgeSection self;
        }

        public delegate void OpenFence_BeforeArgs(Params_OpenFence args);

        public delegate System.Collections.IEnumerator OpenFence_AfterArgs(Params_OpenFence args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator OpenFence_WithArgs(
            Func<BridgeSection, System.Collections.IEnumerator> orig, BridgeSection self);
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

        public static event Delegates.Open_BridgeLever_bool_BeforeArgs Open_BridgeLever_bool
        {
            add
            {
                HookHandler._beforeOpen_BridgeLever_bool += value;
                HookHandler.HookOpen_BridgeLever_bool();
            }
            remove => HookHandler._beforeOpen_BridgeLever_bool -= value;
        }

        public static event Delegates.Open_float_BeforeArgs Open_float
        {
            add
            {
                HookHandler._beforeOpen_float += value;
                HookHandler.HookOpen_float();
            }
            remove => HookHandler._beforeOpen_float -= value;
        }

        public static event Delegates.OpenFence_BeforeArgs OpenFence
        {
            add
            {
                HookHandler._beforeOpenFence += value;
                HookHandler.HookOpenFence();
            }
            remove => HookHandler._beforeOpenFence -= value;
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

        public static event Delegates.Open_BridgeLever_bool_AfterArgs Open_BridgeLever_bool
        {
            add
            {
                HookHandler._afterOpen_BridgeLever_bool += value;
                HookHandler.HookOpen_BridgeLever_bool();
            }
            remove => HookHandler._afterOpen_BridgeLever_bool -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BridgeSection.hook_Awake Awake
        {
            add => On.BridgeSection.Awake += value;
            remove => On.BridgeSection.Awake -= value;
        }

        public static event On.BridgeSection.hook_Open_BridgeLever_bool Open_BridgeLever_bool
        {
            add => On.BridgeSection.Open_BridgeLever_bool += value;
            remove => On.BridgeSection.Open_BridgeLever_bool -= value;
        }

        public static event On.BridgeSection.hook_Open_float Open_float
        {
            add => On.BridgeSection.Open_float += value;
            remove => On.BridgeSection.Open_float -= value;
        }

        public static event On.BridgeSection.hook_OpenFence OpenFence
        {
            add => On.BridgeSection.OpenFence += value;
            remove => On.BridgeSection.OpenFence -= value;
        }
    }
}