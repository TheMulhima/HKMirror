using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for TriggerEvent class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTriggerEvent
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "Reset", true),
                    Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.TriggerEvent> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "OnPreprocess",
                        true), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<HutongGames.PlayMaker.Actions.TriggerEvent> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self)
        {
            Delegates.Params_OnPreprocess @params = new()
            {
                self = self
            };
            if (_beforeOnPreprocess != null)
            {
                foreach (Delegates.OnPreprocess_BeforeArgs toInvoke in _beforeOnPreprocess.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPreprocess?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnPreprocess != null)
            {
                foreach (Delegates.OnPreprocess_AfterArgs toInvoke in _afterOnPreprocess.GetInvocationList())
                {
                    try
                    {
                        _afterOnPreprocess.Invoke(@params);
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent),
                        "StoreCollisionInfo", true), StoreCollisionInfo);
            }
        }

        internal static event Delegates.StoreCollisionInfo_BeforeArgs _beforeStoreCollisionInfo;
        internal static event Delegates.StoreCollisionInfo_AfterArgs _afterStoreCollisionInfo;

        private static void StoreCollisionInfo(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider collisionInfo)
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

        internal static void HookDoTriggerEnter()
        {
            if (!HookedList.Contains("DoTriggerEnter"))
            {
                HookedList.Add("DoTriggerEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerEnter",
                        true), DoTriggerEnter);
            }
        }

        internal static event Delegates.DoTriggerEnter_BeforeArgs _beforeDoTriggerEnter;
        internal static event Delegates.DoTriggerEnter_AfterArgs _afterDoTriggerEnter;

        private static void DoTriggerEnter(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other)
        {
            Delegates.Params_DoTriggerEnter @params = new()
            {
                self = self, other = other
            };
            if (_beforeDoTriggerEnter != null)
            {
                foreach (Delegates.DoTriggerEnter_BeforeArgs toInvoke in _beforeDoTriggerEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeDoTriggerEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            other = @params.other;
            orig(self, other);
            if (_afterDoTriggerEnter != null)
            {
                foreach (Delegates.DoTriggerEnter_AfterArgs toInvoke in _afterDoTriggerEnter.GetInvocationList())
                {
                    try
                    {
                        _afterDoTriggerEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoTriggerStay()
        {
            if (!HookedList.Contains("DoTriggerStay"))
            {
                HookedList.Add("DoTriggerStay");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerStay",
                        true), DoTriggerStay);
            }
        }

        internal static event Delegates.DoTriggerStay_BeforeArgs _beforeDoTriggerStay;
        internal static event Delegates.DoTriggerStay_AfterArgs _afterDoTriggerStay;

        private static void DoTriggerStay(Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other)
        {
            Delegates.Params_DoTriggerStay @params = new()
            {
                self = self, other = other
            };
            if (_beforeDoTriggerStay != null)
            {
                foreach (Delegates.DoTriggerStay_BeforeArgs toInvoke in _beforeDoTriggerStay.GetInvocationList())
                {
                    try
                    {
                        _beforeDoTriggerStay?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            other = @params.other;
            orig(self, other);
            if (_afterDoTriggerStay != null)
            {
                foreach (Delegates.DoTriggerStay_AfterArgs toInvoke in _afterDoTriggerStay.GetInvocationList())
                {
                    try
                    {
                        _afterDoTriggerStay.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoTriggerExit()
        {
            if (!HookedList.Contains("DoTriggerExit"))
            {
                HookedList.Add("DoTriggerExit");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerExit",
                        true), DoTriggerExit);
            }
        }

        internal static event Delegates.DoTriggerExit_BeforeArgs _beforeDoTriggerExit;
        internal static event Delegates.DoTriggerExit_AfterArgs _afterDoTriggerExit;

        private static void DoTriggerExit(Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other)
        {
            Delegates.Params_DoTriggerExit @params = new()
            {
                self = self, other = other
            };
            if (_beforeDoTriggerExit != null)
            {
                foreach (Delegates.DoTriggerExit_BeforeArgs toInvoke in _beforeDoTriggerExit.GetInvocationList())
                {
                    try
                    {
                        _beforeDoTriggerExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            other = @params.other;
            orig(self, other);
            if (_afterDoTriggerExit != null)
            {
                foreach (Delegates.DoTriggerExit_AfterArgs toInvoke in _afterDoTriggerExit.GetInvocationList())
                {
                    try
                    {
                        _afterDoTriggerExit.Invoke(@params);
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "ErrorCheck",
                        true), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<HutongGames.PlayMaker.Actions.TriggerEvent, string> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self)
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
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.TriggerEvent> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self);

        public sealed class Params_OnPreprocess
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
        }

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<HutongGames.PlayMaker.Actions.TriggerEvent> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self);

        public sealed class Params_StoreCollisionInfo
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
            public UnityEngine.Collider collisionInfo;
        }

        public delegate void StoreCollisionInfo_BeforeArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_AfterArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_WithArgs(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider collisionInfo);

        public sealed class Params_DoTriggerEnter
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
            public UnityEngine.Collider other;
        }

        public delegate void DoTriggerEnter_BeforeArgs(Params_DoTriggerEnter args);

        public delegate void DoTriggerEnter_AfterArgs(Params_DoTriggerEnter args);

        public delegate void DoTriggerEnter_WithArgs(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other);

        public sealed class Params_DoTriggerStay
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
            public UnityEngine.Collider other;
        }

        public delegate void DoTriggerStay_BeforeArgs(Params_DoTriggerStay args);

        public delegate void DoTriggerStay_AfterArgs(Params_DoTriggerStay args);

        public delegate void DoTriggerStay_WithArgs(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other);

        public sealed class Params_DoTriggerExit
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
            public UnityEngine.Collider other;
        }

        public delegate void DoTriggerExit_BeforeArgs(Params_DoTriggerExit args);

        public delegate void DoTriggerExit_AfterArgs(Params_DoTriggerExit args);

        public delegate void DoTriggerExit_WithArgs(
            Action<HutongGames.PlayMaker.Actions.TriggerEvent, UnityEngine.Collider> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self, UnityEngine.Collider other);

        public sealed class Params_ErrorCheck
        {
            public HutongGames.PlayMaker.Actions.TriggerEvent self;
        }

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate string ErrorCheck_WithArgs(Func<HutongGames.PlayMaker.Actions.TriggerEvent, string> orig,
            HutongGames.PlayMaker.Actions.TriggerEvent self);
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

        public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
        {
            add
            {
                HookHandler._beforeOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._beforeOnPreprocess -= value;
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

        public static event Delegates.DoTriggerEnter_BeforeArgs DoTriggerEnter
        {
            add
            {
                HookHandler._beforeDoTriggerEnter += value;
                HookHandler.HookDoTriggerEnter();
            }
            remove => HookHandler._beforeDoTriggerEnter -= value;
        }

        public static event Delegates.DoTriggerStay_BeforeArgs DoTriggerStay
        {
            add
            {
                HookHandler._beforeDoTriggerStay += value;
                HookHandler.HookDoTriggerStay();
            }
            remove => HookHandler._beforeDoTriggerStay -= value;
        }

        public static event Delegates.DoTriggerExit_BeforeArgs DoTriggerExit
        {
            add
            {
                HookHandler._beforeDoTriggerExit += value;
                HookHandler.HookDoTriggerExit();
            }
            remove => HookHandler._beforeDoTriggerExit -= value;
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

        public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
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

        public static event Delegates.DoTriggerEnter_AfterArgs DoTriggerEnter
        {
            add
            {
                HookHandler._afterDoTriggerEnter += value;
                HookHandler.HookDoTriggerEnter();
            }
            remove => HookHandler._afterDoTriggerEnter -= value;
        }

        public static event Delegates.DoTriggerStay_AfterArgs DoTriggerStay
        {
            add
            {
                HookHandler._afterDoTriggerStay += value;
                HookHandler.HookDoTriggerStay();
            }
            remove => HookHandler._afterDoTriggerStay -= value;
        }

        public static event Delegates.DoTriggerExit_AfterArgs DoTriggerExit
        {
            add
            {
                HookHandler._afterDoTriggerExit += value;
                HookHandler.HookDoTriggerExit();
            }
            remove => HookHandler._afterDoTriggerExit -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "Reset", true),
                value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "OnPreprocess",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "OnPreprocess",
                    true), value);
        }

        public static event Delegates.StoreCollisionInfo_WithArgs StoreCollisionInfo
        {
            add => HookEndpointManager.Add<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "StoreCollisionInfo",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "StoreCollisionInfo",
                    true), value);
        }

        public static event Delegates.DoTriggerEnter_WithArgs DoTriggerEnter
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerEnter",
                    true), value);
        }

        public static event Delegates.DoTriggerStay_WithArgs DoTriggerStay
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerStay_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerStay",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerStay_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerStay",
                    true), value);
        }

        public static event Delegates.DoTriggerExit_WithArgs DoTriggerExit
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerExit",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "DoTriggerExit",
                    true), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "ErrorCheck", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.TriggerEvent), "ErrorCheck", true),
                value);
        }
    }
}