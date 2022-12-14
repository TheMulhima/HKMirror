using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CallMethod class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCallMethod
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<CallMethod> orig, CallMethod self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<CallMethod> orig, CallMethod self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<CallMethod> orig, CallMethod self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoMethodCall()
        {
            if (!HookedList.Contains("DoMethodCall"))
            {
                HookedList.Add("DoMethodCall");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoMethodCall"), DoMethodCall);
            }
        }

        internal static event Delegates.DoMethodCall_BeforeArgs _beforeDoMethodCall;
        internal static event Delegates.DoMethodCall_AfterArgs _afterDoMethodCall;

        private static void DoMethodCall(Action<CallMethod> orig, CallMethod self)
        {
            Delegates.Params_DoMethodCall @params = new()
            {
                self = self
            };
            if (_beforeDoMethodCall != null)
                foreach (Delegates.DoMethodCall_BeforeArgs toInvoke in _beforeDoMethodCall.GetInvocationList())
                    try
                    {
                        _beforeDoMethodCall?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoMethodCall != null)
                foreach (Delegates.DoMethodCall_AfterArgs toInvoke in _afterDoMethodCall.GetInvocationList())
                    try
                    {
                        _afterDoMethodCall.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookNeedToUpdateCache()
        {
            if (!HookedList.Contains("NeedToUpdateCache"))
            {
                HookedList.Add("NeedToUpdateCache");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "NeedToUpdateCache"), NeedToUpdateCache);
            }
        }

        internal static event Delegates.NeedToUpdateCache_BeforeArgs _beforeNeedToUpdateCache;
        internal static event Delegates.NeedToUpdateCache_AfterArgs _afterNeedToUpdateCache;

        private static bool NeedToUpdateCache(Func<CallMethod, bool> orig, CallMethod self)
        {
            Delegates.Params_NeedToUpdateCache @params = new()
            {
                self = self
            };
            if (_beforeNeedToUpdateCache != null)
                foreach (Delegates.NeedToUpdateCache_BeforeArgs toInvoke in
                         _beforeNeedToUpdateCache.GetInvocationList())
                    try
                    {
                        _beforeNeedToUpdateCache?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterNeedToUpdateCache != null)
                foreach (Delegates.NeedToUpdateCache_AfterArgs toInvoke in _afterNeedToUpdateCache.GetInvocationList())
                    try
                    {
                        retVal = _afterNeedToUpdateCache.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookClearCache()
        {
            if (!HookedList.Contains("ClearCache"))
            {
                HookedList.Add("ClearCache");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ClearCache"), ClearCache);
            }
        }

        internal static event Delegates.ClearCache_BeforeArgs _beforeClearCache;
        internal static event Delegates.ClearCache_AfterArgs _afterClearCache;

        private static void ClearCache(Action<CallMethod> orig, CallMethod self)
        {
            Delegates.Params_ClearCache @params = new()
            {
                self = self
            };
            if (_beforeClearCache != null)
                foreach (Delegates.ClearCache_BeforeArgs toInvoke in _beforeClearCache.GetInvocationList())
                    try
                    {
                        _beforeClearCache?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterClearCache != null)
                foreach (Delegates.ClearCache_AfterArgs toInvoke in _afterClearCache.GetInvocationList())
                    try
                    {
                        _afterClearCache.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoCache()
        {
            if (!HookedList.Contains("DoCache"))
            {
                HookedList.Add("DoCache");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoCache"), DoCache);
            }
        }

        internal static event Delegates.DoCache_BeforeArgs _beforeDoCache;
        internal static event Delegates.DoCache_AfterArgs _afterDoCache;

        private static bool DoCache(Func<CallMethod, bool> orig, CallMethod self)
        {
            Delegates.Params_DoCache @params = new()
            {
                self = self
            };
            if (_beforeDoCache != null)
                foreach (Delegates.DoCache_BeforeArgs toInvoke in _beforeDoCache.GetInvocationList())
                    try
                    {
                        _beforeDoCache?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterDoCache != null)
                foreach (Delegates.DoCache_AfterArgs toInvoke in _afterDoCache.GetInvocationList())
                    try
                    {
                        retVal = _afterDoCache.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ErrorCheck"), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<CallMethod, string> orig, CallMethod self)
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
        public delegate void ClearCache_AfterArgs(Params_ClearCache args);

        public delegate void ClearCache_BeforeArgs(Params_ClearCache args);

        public delegate void ClearCache_WithArgs(Action<CallMethod> orig, CallMethod self);

        public delegate bool DoCache_AfterArgs(Params_DoCache args, bool ret);

        public delegate void DoCache_BeforeArgs(Params_DoCache args);

        public delegate bool DoCache_WithArgs(Func<CallMethod, bool> orig, CallMethod self);

        public delegate void DoMethodCall_AfterArgs(Params_DoMethodCall args);

        public delegate void DoMethodCall_BeforeArgs(Params_DoMethodCall args);

        public delegate void DoMethodCall_WithArgs(Action<CallMethod> orig, CallMethod self);

        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_WithArgs(Func<CallMethod, string> orig, CallMethod self);

        public delegate bool NeedToUpdateCache_AfterArgs(Params_NeedToUpdateCache args, bool ret);

        public delegate void NeedToUpdateCache_BeforeArgs(Params_NeedToUpdateCache args);

        public delegate bool NeedToUpdateCache_WithArgs(Func<CallMethod, bool> orig, CallMethod self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<CallMethod> orig, CallMethod self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<CallMethod> orig, CallMethod self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<CallMethod> orig, CallMethod self);

        public sealed class Params_Reset
        {
            public CallMethod self;
        }

        public sealed class Params_OnEnter
        {
            public CallMethod self;
        }

        public sealed class Params_OnUpdate
        {
            public CallMethod self;
        }

        public sealed class Params_DoMethodCall
        {
            public CallMethod self;
        }

        public sealed class Params_NeedToUpdateCache
        {
            public CallMethod self;
        }

        public sealed class Params_ClearCache
        {
            public CallMethod self;
        }

        public sealed class Params_DoCache
        {
            public CallMethod self;
        }

        public sealed class Params_ErrorCheck
        {
            public CallMethod self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoMethodCall_BeforeArgs DoMethodCall
        {
            add
            {
                HookHandler._beforeDoMethodCall += value;
                HookHandler.HookDoMethodCall();
            }
            remove => HookHandler._beforeDoMethodCall -= value;
        }

        public static event Delegates.NeedToUpdateCache_BeforeArgs NeedToUpdateCache
        {
            add
            {
                HookHandler._beforeNeedToUpdateCache += value;
                HookHandler.HookNeedToUpdateCache();
            }
            remove => HookHandler._beforeNeedToUpdateCache -= value;
        }

        public static event Delegates.ClearCache_BeforeArgs ClearCache
        {
            add
            {
                HookHandler._beforeClearCache += value;
                HookHandler.HookClearCache();
            }
            remove => HookHandler._beforeClearCache -= value;
        }

        public static event Delegates.DoCache_BeforeArgs DoCache
        {
            add
            {
                HookHandler._beforeDoCache += value;
                HookHandler.HookDoCache();
            }
            remove => HookHandler._beforeDoCache -= value;
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

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoMethodCall_AfterArgs DoMethodCall
        {
            add
            {
                HookHandler._afterDoMethodCall += value;
                HookHandler.HookDoMethodCall();
            }
            remove => HookHandler._afterDoMethodCall -= value;
        }

        public static event Delegates.NeedToUpdateCache_AfterArgs NeedToUpdateCache
        {
            add
            {
                HookHandler._afterNeedToUpdateCache += value;
                HookHandler.HookNeedToUpdateCache();
            }
            remove => HookHandler._afterNeedToUpdateCache -= value;
        }

        public static event Delegates.ClearCache_AfterArgs ClearCache
        {
            add
            {
                HookHandler._afterClearCache += value;
                HookHandler.HookClearCache();
            }
            remove => HookHandler._afterClearCache -= value;
        }

        public static event Delegates.DoCache_AfterArgs DoCache
        {
            add
            {
                HookHandler._afterDoCache += value;
                HookHandler.HookDoCache();
            }
            remove => HookHandler._afterDoCache -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnUpdate"), value);
        }

        public static event Delegates.DoMethodCall_WithArgs DoMethodCall
        {
            add => HookEndpointManager.Add<Delegates.DoMethodCall_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoMethodCall"), value);
            remove => HookEndpointManager.Remove<Delegates.DoMethodCall_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoMethodCall"), value);
        }

        public static event Delegates.NeedToUpdateCache_WithArgs NeedToUpdateCache
        {
            add => HookEndpointManager.Add<Delegates.NeedToUpdateCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "NeedToUpdateCache"), value);
            remove => HookEndpointManager.Remove<Delegates.NeedToUpdateCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "NeedToUpdateCache"), value);
        }

        public static event Delegates.ClearCache_WithArgs ClearCache
        {
            add => HookEndpointManager.Add<Delegates.ClearCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ClearCache"), value);
            remove => HookEndpointManager.Remove<Delegates.ClearCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ClearCache"), value);
        }

        public static event Delegates.DoCache_WithArgs DoCache
        {
            add => HookEndpointManager.Add<Delegates.DoCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoCache"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCache_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoCache"), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ErrorCheck"), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ErrorCheck"), value);
        }
    }
}