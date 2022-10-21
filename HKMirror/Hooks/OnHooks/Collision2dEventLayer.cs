using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Collision2dEventLayer class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCollision2dEventLayer
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self)
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "OnEnter", true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "OnExit", true), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self)
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

        internal static void HookStoreCollisionInfo()
        {
            if (!HookedList.Contains("StoreCollisionInfo"))
            {
                HookedList.Add("StoreCollisionInfo");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "StoreCollisionInfo", true), StoreCollisionInfo);
            }
        }

        internal static event Delegates.StoreCollisionInfo_BeforeArgs _beforeStoreCollisionInfo;
        internal static event Delegates.StoreCollisionInfo_AfterArgs _afterStoreCollisionInfo;

        private static void StoreCollisionInfo(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo)
        {
            Delegates.Params_StoreCollisionInfo @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeStoreCollisionInfo != null)
            {
                foreach (Delegates.StoreCollisionInfo_BeforeArgs toInvoke in
                         _beforeStoreCollisionInfo.GetInvocationList())
                {
                    try
                    {
                        _beforeStoreCollisionInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterStoreCollisionInfo != null)
            {
                foreach (Delegates.StoreCollisionInfo_AfterArgs toInvoke in
                         _afterStoreCollisionInfo.GetInvocationList())
                {
                    try
                    {
                        _afterStoreCollisionInfo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoCollisionEnter2D()
        {
            if (!HookedList.Contains("DoCollisionEnter2D"))
            {
                HookedList.Add("DoCollisionEnter2D");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "DoCollisionEnter2D", true), DoCollisionEnter2D);
            }
        }

        internal static event Delegates.DoCollisionEnter2D_BeforeArgs _beforeDoCollisionEnter2D;
        internal static event Delegates.DoCollisionEnter2D_AfterArgs _afterDoCollisionEnter2D;

        private static void DoCollisionEnter2D(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo)
        {
            Delegates.Params_DoCollisionEnter2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoCollisionEnter2D != null)
            {
                foreach (Delegates.DoCollisionEnter2D_BeforeArgs toInvoke in
                         _beforeDoCollisionEnter2D.GetInvocationList())
                {
                    try
                    {
                        _beforeDoCollisionEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoCollisionEnter2D != null)
            {
                foreach (Delegates.DoCollisionEnter2D_AfterArgs toInvoke in
                         _afterDoCollisionEnter2D.GetInvocationList())
                {
                    try
                    {
                        _afterDoCollisionEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoCollisionStay2D()
        {
            if (!HookedList.Contains("DoCollisionStay2D"))
            {
                HookedList.Add("DoCollisionStay2D");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "DoCollisionStay2D", true), DoCollisionStay2D);
            }
        }

        internal static event Delegates.DoCollisionStay2D_BeforeArgs _beforeDoCollisionStay2D;
        internal static event Delegates.DoCollisionStay2D_AfterArgs _afterDoCollisionStay2D;

        private static void DoCollisionStay2D(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo)
        {
            Delegates.Params_DoCollisionStay2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoCollisionStay2D != null)
            {
                foreach (Delegates.DoCollisionStay2D_BeforeArgs toInvoke in
                         _beforeDoCollisionStay2D.GetInvocationList())
                {
                    try
                    {
                        _beforeDoCollisionStay2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoCollisionStay2D != null)
            {
                foreach (Delegates.DoCollisionStay2D_AfterArgs toInvoke in _afterDoCollisionStay2D.GetInvocationList())
                {
                    try
                    {
                        _afterDoCollisionStay2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoCollisionExit2D()
        {
            if (!HookedList.Contains("DoCollisionExit2D"))
            {
                HookedList.Add("DoCollisionExit2D");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "DoCollisionExit2D", true), DoCollisionExit2D);
            }
        }

        internal static event Delegates.DoCollisionExit2D_BeforeArgs _beforeDoCollisionExit2D;
        internal static event Delegates.DoCollisionExit2D_AfterArgs _afterDoCollisionExit2D;

        private static void DoCollisionExit2D(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo)
        {
            Delegates.Params_DoCollisionExit2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoCollisionExit2D != null)
            {
                foreach (Delegates.DoCollisionExit2D_BeforeArgs toInvoke in
                         _beforeDoCollisionExit2D.GetInvocationList())
                {
                    try
                    {
                        _beforeDoCollisionExit2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoCollisionExit2D != null)
            {
                foreach (Delegates.DoCollisionExit2D_AfterArgs toInvoke in _afterDoCollisionExit2D.GetInvocationList())
                {
                    try
                    {
                        _afterDoCollisionExit2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                        "ErrorCheck", true), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<HutongGames.PlayMaker.Actions.Collision2dEventLayer, string> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            if (_beforeErrorCheck != null)
            {
                foreach (Delegates.ErrorCheck_BeforeArgs toInvoke in _beforeErrorCheck.GetInvocationList())
                {
                    try
                    {
                        _beforeErrorCheck?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null)
            {
                foreach (Delegates.ErrorCheck_AfterArgs toInvoke in _afterErrorCheck.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterErrorCheck.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self);

        public sealed class Params_OnExit
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
        }

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self);

        public sealed class Params_StoreCollisionInfo
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
            public UnityEngine.Collision2D collisionInfo;
        }

        public delegate void StoreCollisionInfo_BeforeArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_AfterArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_WithArgs(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo);

        public sealed class Params_DoCollisionEnter2D
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
            public UnityEngine.Collision2D collisionInfo;
        }

        public delegate void DoCollisionEnter2D_BeforeArgs(Params_DoCollisionEnter2D args);

        public delegate void DoCollisionEnter2D_AfterArgs(Params_DoCollisionEnter2D args);

        public delegate void DoCollisionEnter2D_WithArgs(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo);

        public sealed class Params_DoCollisionStay2D
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
            public UnityEngine.Collision2D collisionInfo;
        }

        public delegate void DoCollisionStay2D_BeforeArgs(Params_DoCollisionStay2D args);

        public delegate void DoCollisionStay2D_AfterArgs(Params_DoCollisionStay2D args);

        public delegate void DoCollisionStay2D_WithArgs(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo);

        public sealed class Params_DoCollisionExit2D
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
            public UnityEngine.Collision2D collisionInfo;
        }

        public delegate void DoCollisionExit2D_BeforeArgs(Params_DoCollisionExit2D args);

        public delegate void DoCollisionExit2D_AfterArgs(Params_DoCollisionExit2D args);

        public delegate void DoCollisionExit2D_WithArgs(
            Action<HutongGames.PlayMaker.Actions.Collision2dEventLayer, UnityEngine.Collision2D> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self, UnityEngine.Collision2D collisionInfo);

        public sealed class Params_ErrorCheck
        {
            public HutongGames.PlayMaker.Actions.Collision2dEventLayer self;
        }

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate string ErrorCheck_WithArgs(
            Func<HutongGames.PlayMaker.Actions.Collision2dEventLayer, string> orig,
            HutongGames.PlayMaker.Actions.Collision2dEventLayer self);
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.StoreCollisionInfo_BeforeArgs StoreCollisionInfo
        {
            add
            {
                HookHandler._beforeStoreCollisionInfo += value;
                HookHandler.HookStoreCollisionInfo();
            }
            remove => HookHandler._beforeStoreCollisionInfo -= value;
        }

        public static event Delegates.DoCollisionEnter2D_BeforeArgs DoCollisionEnter2D
        {
            add
            {
                HookHandler._beforeDoCollisionEnter2D += value;
                HookHandler.HookDoCollisionEnter2D();
            }
            remove => HookHandler._beforeDoCollisionEnter2D -= value;
        }

        public static event Delegates.DoCollisionStay2D_BeforeArgs DoCollisionStay2D
        {
            add
            {
                HookHandler._beforeDoCollisionStay2D += value;
                HookHandler.HookDoCollisionStay2D();
            }
            remove => HookHandler._beforeDoCollisionStay2D -= value;
        }

        public static event Delegates.DoCollisionExit2D_BeforeArgs DoCollisionExit2D
        {
            add
            {
                HookHandler._beforeDoCollisionExit2D += value;
                HookHandler.HookDoCollisionExit2D();
            }
            remove => HookHandler._beforeDoCollisionExit2D -= value;
        }

        public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
        {
            add
            {
                HookHandler._beforeErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._beforeErrorCheck -= value;
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

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.StoreCollisionInfo_AfterArgs StoreCollisionInfo
        {
            add
            {
                HookHandler._afterStoreCollisionInfo += value;
                HookHandler.HookStoreCollisionInfo();
            }
            remove => HookHandler._afterStoreCollisionInfo -= value;
        }

        public static event Delegates.DoCollisionEnter2D_AfterArgs DoCollisionEnter2D
        {
            add
            {
                HookHandler._afterDoCollisionEnter2D += value;
                HookHandler.HookDoCollisionEnter2D();
            }
            remove => HookHandler._afterDoCollisionEnter2D -= value;
        }

        public static event Delegates.DoCollisionStay2D_AfterArgs DoCollisionStay2D
        {
            add
            {
                HookHandler._afterDoCollisionStay2D += value;
                HookHandler.HookDoCollisionStay2D();
            }
            remove => HookHandler._afterDoCollisionStay2D -= value;
        }

        public static event Delegates.DoCollisionExit2D_AfterArgs DoCollisionExit2D
        {
            add
            {
                HookHandler._afterDoCollisionExit2D += value;
                HookHandler.HookDoCollisionExit2D();
            }
            remove => HookHandler._afterDoCollisionExit2D -= value;
        }

        public static event Delegates.ErrorCheck_AfterArgs ErrorCheck
        {
            add
            {
                HookHandler._afterErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._afterErrorCheck -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "Reset",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "Reset",
                    true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "OnEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "OnEnter",
                    true), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "OnExit",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer), "OnExit",
                    true), value);
        }

        public static event Delegates.StoreCollisionInfo_WithArgs StoreCollisionInfo
        {
            add => HookEndpointManager.Add<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "StoreCollisionInfo", true), value);
            remove => HookEndpointManager.Remove<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "StoreCollisionInfo", true), value);
        }

        public static event Delegates.DoCollisionEnter2D_WithArgs DoCollisionEnter2D
        {
            add => HookEndpointManager.Add<Delegates.DoCollisionEnter2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionEnter2D", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoCollisionEnter2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionEnter2D", true), value);
        }

        public static event Delegates.DoCollisionStay2D_WithArgs DoCollisionStay2D
        {
            add => HookEndpointManager.Add<Delegates.DoCollisionStay2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionStay2D", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoCollisionStay2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionStay2D", true), value);
        }

        public static event Delegates.DoCollisionExit2D_WithArgs DoCollisionExit2D
        {
            add => HookEndpointManager.Add<Delegates.DoCollisionExit2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionExit2D", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoCollisionExit2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "DoCollisionExit2D", true), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "ErrorCheck", true), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Collision2dEventLayer),
                    "ErrorCheck", true), value);
        }
    }
}