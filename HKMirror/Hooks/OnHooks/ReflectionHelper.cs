using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ReflectionHelper class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnReflectionHelper
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookPreloadCommonTypes()
        {
            if (!HookedList.Contains("PreloadCommonTypes"))
            {
                HookedList.Add("PreloadCommonTypes");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "PreloadCommonTypes", false),
                    PreloadCommonTypes);
            }
        }

        internal static event Delegates.PreloadCommonTypes_BeforeArgs _beforePreloadCommonTypes;
        internal static event Delegates.PreloadCommonTypes_AfterArgs _afterPreloadCommonTypes;

        private static void PreloadCommonTypes(Action orig)
        {
            if (_beforePreloadCommonTypes != null)
                foreach (Delegates.PreloadCommonTypes_BeforeArgs toInvoke in
                         _beforePreloadCommonTypes.GetInvocationList())
                    try
                    {
                        _beforePreloadCommonTypes?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            orig();
            if (_afterPreloadCommonTypes != null)
                foreach (Delegates.PreloadCommonTypes_AfterArgs toInvoke in
                         _afterPreloadCommonTypes.GetInvocationList())
                    try
                    {
                        _afterPreloadCommonTypes.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetFieldInfo()
        {
            if (!HookedList.Contains("GetFieldInfo"))
            {
                HookedList.Add("GetFieldInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFieldInfo", false), GetFieldInfo);
            }
        }

        internal static event Delegates.GetFieldInfo_BeforeArgs _beforeGetFieldInfo;
        internal static event Delegates.GetFieldInfo_AfterArgs _afterGetFieldInfo;

        private static FieldInfo GetFieldInfo(Func<Type, string, bool, FieldInfo> orig, Type t, string field,
            bool instance)
        {
            Delegates.Params_GetFieldInfo @params = new()
            {
                t = t, field = field, instance = instance
            };
            if (_beforeGetFieldInfo != null)
                foreach (Delegates.GetFieldInfo_BeforeArgs toInvoke in _beforeGetFieldInfo.GetInvocationList())
                    try
                    {
                        _beforeGetFieldInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            t = @params.t;
            field = @params.field;
            instance = @params.instance;
            var retVal = orig(t, field, instance);
            if (_afterGetFieldInfo != null)
                foreach (Delegates.GetFieldInfo_AfterArgs toInvoke in _afterGetFieldInfo.GetInvocationList())
                    try
                    {
                        retVal = _afterGetFieldInfo.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetPropertyInfo()
        {
            if (!HookedList.Contains("GetPropertyInfo"))
            {
                HookedList.Add("GetPropertyInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetPropertyInfo", false),
                    GetPropertyInfo);
            }
        }

        internal static event Delegates.GetPropertyInfo_BeforeArgs _beforeGetPropertyInfo;
        internal static event Delegates.GetPropertyInfo_AfterArgs _afterGetPropertyInfo;

        private static PropertyInfo GetPropertyInfo(Func<Type, string, bool, PropertyInfo> orig, Type t,
            string property, bool instance)
        {
            Delegates.Params_GetPropertyInfo @params = new()
            {
                t = t, property = property, instance = instance
            };
            if (_beforeGetPropertyInfo != null)
                foreach (Delegates.GetPropertyInfo_BeforeArgs toInvoke in _beforeGetPropertyInfo.GetInvocationList())
                    try
                    {
                        _beforeGetPropertyInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            t = @params.t;
            property = @params.property;
            instance = @params.instance;
            var retVal = orig(t, property, instance);
            if (_afterGetPropertyInfo != null)
                foreach (Delegates.GetPropertyInfo_AfterArgs toInvoke in _afterGetPropertyInfo.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPropertyInfo.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetMethodInfo()
        {
            if (!HookedList.Contains("GetMethodInfo"))
            {
                HookedList.Add("GetMethodInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetMethodInfo", false),
                    GetMethodInfo);
            }
        }

        internal static event Delegates.GetMethodInfo_BeforeArgs _beforeGetMethodInfo;
        internal static event Delegates.GetMethodInfo_AfterArgs _afterGetMethodInfo;

        private static MethodInfo GetMethodInfo(Func<Type, string, bool, MethodInfo> orig, Type t, string method,
            bool instance)
        {
            Delegates.Params_GetMethodInfo @params = new()
            {
                t = t, method = method, instance = instance
            };
            if (_beforeGetMethodInfo != null)
                foreach (Delegates.GetMethodInfo_BeforeArgs toInvoke in _beforeGetMethodInfo.GetInvocationList())
                    try
                    {
                        _beforeGetMethodInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            t = @params.t;
            method = @params.method;
            instance = @params.instance;
            var retVal = orig(t, method, instance);
            if (_afterGetMethodInfo != null)
                foreach (Delegates.GetMethodInfo_AfterArgs toInvoke in _afterGetMethodInfo.GetInvocationList())
                    try
                    {
                        retVal = _afterGetMethodInfo.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetFastReflectionDelegate()
        {
            if (!HookedList.Contains("GetFastReflectionDelegate"))
            {
                HookedList.Add("GetFastReflectionDelegate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFastReflectionDelegate", false),
                    GetFastReflectionDelegate);
            }
        }

        internal static event Delegates.GetFastReflectionDelegate_BeforeArgs _beforeGetFastReflectionDelegate;
        internal static event Delegates.GetFastReflectionDelegate_AfterArgs _afterGetFastReflectionDelegate;

        private static FastReflectionDelegate GetFastReflectionDelegate(Func<MethodInfo, FastReflectionDelegate> orig,
            MethodInfo mi)
        {
            Delegates.Params_GetFastReflectionDelegate @params = new()
            {
                mi = mi
            };
            if (_beforeGetFastReflectionDelegate != null)
                foreach (Delegates.GetFastReflectionDelegate_BeforeArgs toInvoke in _beforeGetFastReflectionDelegate
                             .GetInvocationList())
                    try
                    {
                        _beforeGetFastReflectionDelegate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            mi = @params.mi;
            var retVal = orig(mi);
            if (_afterGetFastReflectionDelegate != null)
                foreach (Delegates.GetFastReflectionDelegate_AfterArgs toInvoke in _afterGetFastReflectionDelegate
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterGetFastReflectionDelegate.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCallMethod()
        {
            if (!HookedList.Contains("CallMethod"))
            {
                HookedList.Add("CallMethod");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "CallMethod", false), CallMethod);
            }
        }

        internal static event Delegates.CallMethod_BeforeArgs _beforeCallMethod;
        internal static event Delegates.CallMethod_AfterArgs _afterCallMethod;

        private static void CallMethod(Action<Type, string, object[]> orig, Type type, string name, object[] param)
        {
            Delegates.Params_CallMethod @params = new()
            {
                type = type, name = name, param = param
            };
            if (_beforeCallMethod != null)
                foreach (Delegates.CallMethod_BeforeArgs toInvoke in _beforeCallMethod.GetInvocationList())
                    try
                    {
                        _beforeCallMethod?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            type = @params.type;
            name = @params.name;
            param = @params.param;
            orig(type, name, param);
            if (_afterCallMethod != null)
                foreach (Delegates.CallMethod_AfterArgs toInvoke in _afterCallMethod.GetInvocationList())
                    try
                    {
                        _afterCallMethod.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CallMethod_AfterArgs(Params_CallMethod args);

        public delegate void CallMethod_BeforeArgs(Params_CallMethod args);

        public delegate void CallMethod_WithArgs(Action<Type, string, object[]> orig, Type type, string name,
            object[] param);

        public delegate FastReflectionDelegate GetFastReflectionDelegate_AfterArgs(
            Params_GetFastReflectionDelegate args, FastReflectionDelegate ret);

        public delegate void GetFastReflectionDelegate_BeforeArgs(Params_GetFastReflectionDelegate args);

        public delegate FastReflectionDelegate GetFastReflectionDelegate_WithArgs(
            Func<MethodInfo, FastReflectionDelegate> orig, MethodInfo mi);

        public delegate FieldInfo GetFieldInfo_AfterArgs(Params_GetFieldInfo args, FieldInfo ret);

        public delegate void GetFieldInfo_BeforeArgs(Params_GetFieldInfo args);

        public delegate FieldInfo GetFieldInfo_WithArgs(Func<Type, string, bool, FieldInfo> orig, Type t, string field,
            bool instance);

        public delegate MethodInfo GetMethodInfo_AfterArgs(Params_GetMethodInfo args, MethodInfo ret);

        public delegate void GetMethodInfo_BeforeArgs(Params_GetMethodInfo args);

        public delegate MethodInfo GetMethodInfo_WithArgs(Func<Type, string, bool, MethodInfo> orig, Type t,
            string method, bool instance);

        public delegate PropertyInfo GetPropertyInfo_AfterArgs(Params_GetPropertyInfo args, PropertyInfo ret);

        public delegate void GetPropertyInfo_BeforeArgs(Params_GetPropertyInfo args);

        public delegate PropertyInfo GetPropertyInfo_WithArgs(Func<Type, string, bool, PropertyInfo> orig, Type t,
            string property, bool instance);

        public delegate void PreloadCommonTypes_AfterArgs();

        public delegate void PreloadCommonTypes_BeforeArgs();

        public delegate void PreloadCommonTypes_WithArgs(Action orig);

        public sealed class Params_GetFieldInfo
        {
            public string field;
            public bool instance;
            public Type t;
        }

        public sealed class Params_GetPropertyInfo
        {
            public bool instance;
            public string property;
            public Type t;
        }

        public sealed class Params_GetMethodInfo
        {
            public bool instance;
            public string method;
            public Type t;
        }

        public sealed class Params_GetFastReflectionDelegate
        {
            public MethodInfo mi;
        }

        public sealed class Params_CallMethod
        {
            public string name;
            public object[] param;
            public Type type;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.PreloadCommonTypes_BeforeArgs PreloadCommonTypes
        {
            add
            {
                HookHandler._beforePreloadCommonTypes += value;
                HookHandler.HookPreloadCommonTypes();
            }
            remove => HookHandler._beforePreloadCommonTypes -= value;
        }

        public static event Delegates.GetFieldInfo_BeforeArgs GetFieldInfo
        {
            add
            {
                HookHandler._beforeGetFieldInfo += value;
                HookHandler.HookGetFieldInfo();
            }
            remove => HookHandler._beforeGetFieldInfo -= value;
        }

        public static event Delegates.GetPropertyInfo_BeforeArgs GetPropertyInfo
        {
            add
            {
                HookHandler._beforeGetPropertyInfo += value;
                HookHandler.HookGetPropertyInfo();
            }
            remove => HookHandler._beforeGetPropertyInfo -= value;
        }

        public static event Delegates.GetMethodInfo_BeforeArgs GetMethodInfo
        {
            add
            {
                HookHandler._beforeGetMethodInfo += value;
                HookHandler.HookGetMethodInfo();
            }
            remove => HookHandler._beforeGetMethodInfo -= value;
        }

        public static event Delegates.GetFastReflectionDelegate_BeforeArgs GetFastReflectionDelegate
        {
            add
            {
                HookHandler._beforeGetFastReflectionDelegate += value;
                HookHandler.HookGetFastReflectionDelegate();
            }
            remove => HookHandler._beforeGetFastReflectionDelegate -= value;
        }

        public static event Delegates.CallMethod_BeforeArgs CallMethod
        {
            add
            {
                HookHandler._beforeCallMethod += value;
                HookHandler.HookCallMethod();
            }
            remove => HookHandler._beforeCallMethod -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.PreloadCommonTypes_AfterArgs PreloadCommonTypes
        {
            add
            {
                HookHandler._afterPreloadCommonTypes += value;
                HookHandler.HookPreloadCommonTypes();
            }
            remove => HookHandler._afterPreloadCommonTypes -= value;
        }

        public static event Delegates.GetFieldInfo_AfterArgs GetFieldInfo
        {
            add
            {
                HookHandler._afterGetFieldInfo += value;
                HookHandler.HookGetFieldInfo();
            }
            remove => HookHandler._afterGetFieldInfo -= value;
        }

        public static event Delegates.GetPropertyInfo_AfterArgs GetPropertyInfo
        {
            add
            {
                HookHandler._afterGetPropertyInfo += value;
                HookHandler.HookGetPropertyInfo();
            }
            remove => HookHandler._afterGetPropertyInfo -= value;
        }

        public static event Delegates.GetMethodInfo_AfterArgs GetMethodInfo
        {
            add
            {
                HookHandler._afterGetMethodInfo += value;
                HookHandler.HookGetMethodInfo();
            }
            remove => HookHandler._afterGetMethodInfo -= value;
        }

        public static event Delegates.GetFastReflectionDelegate_AfterArgs GetFastReflectionDelegate
        {
            add
            {
                HookHandler._afterGetFastReflectionDelegate += value;
                HookHandler.HookGetFastReflectionDelegate();
            }
            remove => HookHandler._afterGetFastReflectionDelegate -= value;
        }

        public static event Delegates.CallMethod_AfterArgs CallMethod
        {
            add
            {
                HookHandler._afterCallMethod += value;
                HookHandler.HookCallMethod();
            }
            remove => HookHandler._afterCallMethod -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.PreloadCommonTypes_WithArgs PreloadCommonTypes
        {
            add => HookEndpointManager.Add<Delegates.PreloadCommonTypes_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "PreloadCommonTypes", false), value);
            remove => HookEndpointManager.Remove<Delegates.PreloadCommonTypes_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "PreloadCommonTypes", false), value);
        }

        public static event Delegates.GetFieldInfo_WithArgs GetFieldInfo
        {
            add => HookEndpointManager.Add<Delegates.GetFieldInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFieldInfo", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetFieldInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFieldInfo", false), value);
        }

        public static event Delegates.GetPropertyInfo_WithArgs GetPropertyInfo
        {
            add => HookEndpointManager.Add<Delegates.GetPropertyInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetPropertyInfo", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetPropertyInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetPropertyInfo", false), value);
        }

        public static event Delegates.GetMethodInfo_WithArgs GetMethodInfo
        {
            add => HookEndpointManager.Add<Delegates.GetMethodInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetMethodInfo", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetMethodInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetMethodInfo", false), value);
        }

        public static event Delegates.GetFastReflectionDelegate_WithArgs GetFastReflectionDelegate
        {
            add => HookEndpointManager.Add<Delegates.GetFastReflectionDelegate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFastReflectionDelegate", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetFastReflectionDelegate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFastReflectionDelegate", false), value);
        }

        public static event Delegates.CallMethod_WithArgs CallMethod
        {
            add => HookEndpointManager.Add<Delegates.CallMethod_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "CallMethod", false), value);
            remove => HookEndpointManager.Remove<Delegates.CallMethod_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "CallMethod", false), value);
        }
    }
}