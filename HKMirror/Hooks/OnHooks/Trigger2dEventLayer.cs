using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Trigger2dEventLayer class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTrigger2dEventLayer
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                    try
                    {
                        _afterOnExit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStoreCollisionInfo()
        {
            if (!HookedList.Contains("StoreCollisionInfo"))
            {
                HookedList.Add("StoreCollisionInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "StoreCollisionInfo"),
                    StoreCollisionInfo);
            }
        }

        internal static event Delegates.StoreCollisionInfo_BeforeArgs _beforeStoreCollisionInfo;
        internal static event Delegates.StoreCollisionInfo_AfterArgs _afterStoreCollisionInfo;

        private static void StoreCollisionInfo(Action<Trigger2dEventLayer, Collider2D> orig, Trigger2dEventLayer self,
            Collider2D collisionInfo)
        {
            Delegates.Params_StoreCollisionInfo @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeStoreCollisionInfo != null)
                foreach (Delegates.StoreCollisionInfo_BeforeArgs toInvoke in
                         _beforeStoreCollisionInfo.GetInvocationList())
                    try
                    {
                        _beforeStoreCollisionInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterStoreCollisionInfo != null)
                foreach (Delegates.StoreCollisionInfo_AfterArgs toInvoke in
                         _afterStoreCollisionInfo.GetInvocationList())
                    try
                    {
                        _afterStoreCollisionInfo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoTriggerEnter2D()
        {
            if (!HookedList.Contains("DoTriggerEnter2D"))
            {
                HookedList.Add("DoTriggerEnter2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerEnter2D"),
                    DoTriggerEnter2D);
            }
        }

        internal static event Delegates.DoTriggerEnter2D_BeforeArgs _beforeDoTriggerEnter2D;
        internal static event Delegates.DoTriggerEnter2D_AfterArgs _afterDoTriggerEnter2D;

        private static void DoTriggerEnter2D(Action<Trigger2dEventLayer, Collider2D> orig, Trigger2dEventLayer self,
            Collider2D collisionInfo)
        {
            Delegates.Params_DoTriggerEnter2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoTriggerEnter2D != null)
                foreach (Delegates.DoTriggerEnter2D_BeforeArgs toInvoke in _beforeDoTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeDoTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoTriggerEnter2D != null)
                foreach (Delegates.DoTriggerEnter2D_AfterArgs toInvoke in _afterDoTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterDoTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoTriggerStay2D()
        {
            if (!HookedList.Contains("DoTriggerStay2D"))
            {
                HookedList.Add("DoTriggerStay2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerStay2D"),
                    DoTriggerStay2D);
            }
        }

        internal static event Delegates.DoTriggerStay2D_BeforeArgs _beforeDoTriggerStay2D;
        internal static event Delegates.DoTriggerStay2D_AfterArgs _afterDoTriggerStay2D;

        private static void DoTriggerStay2D(Action<Trigger2dEventLayer, Collider2D> orig, Trigger2dEventLayer self,
            Collider2D collisionInfo)
        {
            Delegates.Params_DoTriggerStay2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoTriggerStay2D != null)
                foreach (Delegates.DoTriggerStay2D_BeforeArgs toInvoke in _beforeDoTriggerStay2D.GetInvocationList())
                    try
                    {
                        _beforeDoTriggerStay2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoTriggerStay2D != null)
                foreach (Delegates.DoTriggerStay2D_AfterArgs toInvoke in _afterDoTriggerStay2D.GetInvocationList())
                    try
                    {
                        _afterDoTriggerStay2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoTriggerExit2D()
        {
            if (!HookedList.Contains("DoTriggerExit2D"))
            {
                HookedList.Add("DoTriggerExit2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerExit2D"),
                    DoTriggerExit2D);
            }
        }

        internal static event Delegates.DoTriggerExit2D_BeforeArgs _beforeDoTriggerExit2D;
        internal static event Delegates.DoTriggerExit2D_AfterArgs _afterDoTriggerExit2D;

        private static void DoTriggerExit2D(Action<Trigger2dEventLayer, Collider2D> orig, Trigger2dEventLayer self,
            Collider2D collisionInfo)
        {
            Delegates.Params_DoTriggerExit2D @params = new()
            {
                self = self, collisionInfo = collisionInfo
            };
            if (_beforeDoTriggerExit2D != null)
                foreach (Delegates.DoTriggerExit2D_BeforeArgs toInvoke in _beforeDoTriggerExit2D.GetInvocationList())
                    try
                    {
                        _beforeDoTriggerExit2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collisionInfo = @params.collisionInfo;
            orig(self, collisionInfo);
            if (_afterDoTriggerExit2D != null)
                foreach (Delegates.DoTriggerExit2D_AfterArgs toInvoke in _afterDoTriggerExit2D.GetInvocationList())
                    try
                    {
                        _afterDoTriggerExit2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "ErrorCheck"), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<Trigger2dEventLayer, string> orig, Trigger2dEventLayer self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            if (_beforeErrorCheck != null)
                foreach (Delegates.ErrorCheck_BeforeArgs toInvoke in _beforeErrorCheck.GetInvocationList())
                    try
                    {
                        _beforeErrorCheck?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null)
                foreach (Delegates.ErrorCheck_AfterArgs toInvoke in _afterErrorCheck.GetInvocationList())
                    try
                    {
                        retVal = _afterErrorCheck.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoTriggerEnter2D_AfterArgs(Params_DoTriggerEnter2D args);

        public delegate void DoTriggerEnter2D_BeforeArgs(Params_DoTriggerEnter2D args);

        public delegate void DoTriggerEnter2D_WithArgs(Action<Trigger2dEventLayer, Collider2D> orig,
            Trigger2dEventLayer self, Collider2D collisionInfo);

        public delegate void DoTriggerExit2D_AfterArgs(Params_DoTriggerExit2D args);

        public delegate void DoTriggerExit2D_BeforeArgs(Params_DoTriggerExit2D args);

        public delegate void DoTriggerExit2D_WithArgs(Action<Trigger2dEventLayer, Collider2D> orig,
            Trigger2dEventLayer self, Collider2D collisionInfo);

        public delegate void DoTriggerStay2D_AfterArgs(Params_DoTriggerStay2D args);

        public delegate void DoTriggerStay2D_BeforeArgs(Params_DoTriggerStay2D args);

        public delegate void DoTriggerStay2D_WithArgs(Action<Trigger2dEventLayer, Collider2D> orig,
            Trigger2dEventLayer self, Collider2D collisionInfo);

        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_WithArgs(Func<Trigger2dEventLayer, string> orig, Trigger2dEventLayer self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Trigger2dEventLayer> orig, Trigger2dEventLayer self);

        public delegate void StoreCollisionInfo_AfterArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_BeforeArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_WithArgs(Action<Trigger2dEventLayer, Collider2D> orig,
            Trigger2dEventLayer self, Collider2D collisionInfo);

        public sealed class Params_Reset
        {
            public Trigger2dEventLayer self;
        }

        public sealed class Params_OnEnter
        {
            public Trigger2dEventLayer self;
        }

        public sealed class Params_OnExit
        {
            public Trigger2dEventLayer self;
        }

        public sealed class Params_StoreCollisionInfo
        {
            public Collider2D collisionInfo;
            public Trigger2dEventLayer self;
        }

        public sealed class Params_DoTriggerEnter2D
        {
            public Collider2D collisionInfo;
            public Trigger2dEventLayer self;
        }

        public sealed class Params_DoTriggerStay2D
        {
            public Collider2D collisionInfo;
            public Trigger2dEventLayer self;
        }

        public sealed class Params_DoTriggerExit2D
        {
            public Collider2D collisionInfo;
            public Trigger2dEventLayer self;
        }

        public sealed class Params_ErrorCheck
        {
            public Trigger2dEventLayer self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.DoTriggerEnter2D_BeforeArgs DoTriggerEnter2D
        {
            add
            {
                HookHandler._beforeDoTriggerEnter2D += value;
                HookHandler.HookDoTriggerEnter2D();
            }
            remove => HookHandler._beforeDoTriggerEnter2D -= value;
        }

        public static event Delegates.DoTriggerStay2D_BeforeArgs DoTriggerStay2D
        {
            add
            {
                HookHandler._beforeDoTriggerStay2D += value;
                HookHandler.HookDoTriggerStay2D();
            }
            remove => HookHandler._beforeDoTriggerStay2D -= value;
        }

        public static event Delegates.DoTriggerExit2D_BeforeArgs DoTriggerExit2D
        {
            add
            {
                HookHandler._beforeDoTriggerExit2D += value;
                HookHandler.HookDoTriggerExit2D();
            }
            remove => HookHandler._beforeDoTriggerExit2D -= value;
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
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.DoTriggerEnter2D_AfterArgs DoTriggerEnter2D
        {
            add
            {
                HookHandler._afterDoTriggerEnter2D += value;
                HookHandler.HookDoTriggerEnter2D();
            }
            remove => HookHandler._afterDoTriggerEnter2D -= value;
        }

        public static event Delegates.DoTriggerStay2D_AfterArgs DoTriggerStay2D
        {
            add
            {
                HookHandler._afterDoTriggerStay2D += value;
                HookHandler.HookDoTriggerStay2D();
            }
            remove => HookHandler._afterDoTriggerStay2D -= value;
        }

        public static event Delegates.DoTriggerExit2D_AfterArgs DoTriggerExit2D
        {
            add
            {
                HookHandler._afterDoTriggerExit2D += value;
                HookHandler.HookDoTriggerExit2D();
            }
            remove => HookHandler._afterDoTriggerExit2D -= value;
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
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnEnter"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "OnExit"), value);
        }

        public static event Delegates.StoreCollisionInfo_WithArgs StoreCollisionInfo
        {
            add => HookEndpointManager.Add<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "StoreCollisionInfo"), value);
            remove => HookEndpointManager.Remove<Delegates.StoreCollisionInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "StoreCollisionInfo"), value);
        }

        public static event Delegates.DoTriggerEnter2D_WithArgs DoTriggerEnter2D
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerEnter2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerEnter2D"), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerEnter2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerEnter2D"), value);
        }

        public static event Delegates.DoTriggerStay2D_WithArgs DoTriggerStay2D
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerStay2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerStay2D"), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerStay2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerStay2D"), value);
        }

        public static event Delegates.DoTriggerExit2D_WithArgs DoTriggerExit2D
        {
            add => HookEndpointManager.Add<Delegates.DoTriggerExit2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerExit2D"), value);
            remove => HookEndpointManager.Remove<Delegates.DoTriggerExit2D_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "DoTriggerExit2D"), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "ErrorCheck"), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Trigger2dEventLayer), "ErrorCheck"), value);
        }
    }
}