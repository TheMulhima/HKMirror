using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dFontData class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dFontData
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_inst()
        {
            if (!HookedList.Contains("get_inst"))
            {
                HookedList.Add("get_inst");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dFontData), "get_inst"), get_inst);
            }
        }

        internal static event Delegates.get_inst_BeforeArgs _beforeget_inst;
        internal static event Delegates.get_inst_AfterArgs _afterget_inst;

        private static tk2dFontData get_inst(Func<tk2dFontData, tk2dFontData> orig, tk2dFontData self)
        {
            Delegates.Params_get_inst @params = new()
            {
                self = self
            };
            if (_beforeget_inst != null)
                foreach (Delegates.get_inst_BeforeArgs toInvoke in _beforeget_inst.GetInvocationList())
                    try
                    {
                        _beforeget_inst?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_inst != null)
                foreach (Delegates.get_inst_AfterArgs toInvoke in _afterget_inst.GetInvocationList())
                    try
                    {
                        retVal = _afterget_inst.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookInit()
        {
            if (!HookedList.Contains("Init"))
            {
                HookedList.Add("Init");
                On.tk2dFontData.Init += Init;
            }
        }

        internal static event Delegates.Init_BeforeArgs _beforeInit;
        internal static event Delegates.Init_AfterArgs _afterInit;

        private static void Init(On.tk2dFontData.orig_Init orig, tk2dFontData self)
        {
            Delegates.Params_Init @params = new()
            {
                self = self
            };
            if (_beforeInit != null)
                foreach (Delegates.Init_BeforeArgs toInvoke in _beforeInit.GetInvocationList())
                    try
                    {
                        _beforeInit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterInit != null)
                foreach (Delegates.Init_AfterArgs toInvoke in _afterInit.GetInvocationList())
                    try
                    {
                        _afterInit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookResetPlatformData()
        {
            if (!HookedList.Contains("ResetPlatformData"))
            {
                HookedList.Add("ResetPlatformData");
                On.tk2dFontData.ResetPlatformData += ResetPlatformData;
            }
        }

        internal static event Delegates.ResetPlatformData_BeforeArgs _beforeResetPlatformData;
        internal static event Delegates.ResetPlatformData_AfterArgs _afterResetPlatformData;

        private static void ResetPlatformData(On.tk2dFontData.orig_ResetPlatformData orig, tk2dFontData self)
        {
            Delegates.Params_ResetPlatformData @params = new()
            {
                self = self
            };
            if (_beforeResetPlatformData != null)
                foreach (Delegates.ResetPlatformData_BeforeArgs toInvoke in
                         _beforeResetPlatformData.GetInvocationList())
                    try
                    {
                        _beforeResetPlatformData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterResetPlatformData != null)
                foreach (Delegates.ResetPlatformData_AfterArgs toInvoke in _afterResetPlatformData.GetInvocationList())
                    try
                    {
                        _afterResetPlatformData.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.tk2dFontData.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.tk2dFontData.orig_OnDestroy orig, tk2dFontData self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookInitDictionary()
        {
            if (!HookedList.Contains("InitDictionary"))
            {
                HookedList.Add("InitDictionary");
                On.tk2dFontData.InitDictionary += InitDictionary;
            }
        }

        internal static event Delegates.InitDictionary_BeforeArgs _beforeInitDictionary;
        internal static event Delegates.InitDictionary_AfterArgs _afterInitDictionary;

        private static void InitDictionary(On.tk2dFontData.orig_InitDictionary orig, tk2dFontData self)
        {
            Delegates.Params_InitDictionary @params = new()
            {
                self = self
            };
            if (_beforeInitDictionary != null)
                foreach (Delegates.InitDictionary_BeforeArgs toInvoke in _beforeInitDictionary.GetInvocationList())
                    try
                    {
                        _beforeInitDictionary?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterInitDictionary != null)
                foreach (Delegates.InitDictionary_AfterArgs toInvoke in _afterInitDictionary.GetInvocationList())
                    try
                    {
                        _afterInitDictionary.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetDictionary()
        {
            if (!HookedList.Contains("SetDictionary"))
            {
                HookedList.Add("SetDictionary");
                On.tk2dFontData.SetDictionary += SetDictionary;
            }
        }

        internal static event Delegates.SetDictionary_BeforeArgs _beforeSetDictionary;
        internal static event Delegates.SetDictionary_AfterArgs _afterSetDictionary;

        private static void SetDictionary(On.tk2dFontData.orig_SetDictionary orig, tk2dFontData self,
            Dictionary<int, tk2dFontChar> dict)
        {
            Delegates.Params_SetDictionary @params = new()
            {
                self = self, dict = dict
            };
            if (_beforeSetDictionary != null)
                foreach (Delegates.SetDictionary_BeforeArgs toInvoke in _beforeSetDictionary.GetInvocationList())
                    try
                    {
                        _beforeSetDictionary?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            dict = @params.dict;
            orig(self, dict);
            if (_afterSetDictionary != null)
                foreach (Delegates.SetDictionary_AfterArgs toInvoke in _afterSetDictionary.GetInvocationList())
                    try
                    {
                        _afterSetDictionary.Invoke(@params);
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
        public delegate tk2dFontData get_inst_AfterArgs(Params_get_inst args, tk2dFontData ret);

        public delegate void get_inst_BeforeArgs(Params_get_inst args);

        public delegate tk2dFontData get_inst_WithArgs(Func<tk2dFontData, tk2dFontData> orig, tk2dFontData self);

        public delegate void Init_AfterArgs(Params_Init args);

        public delegate void Init_BeforeArgs(Params_Init args);

        public delegate void Init_WithArgs(Action<tk2dFontData> orig, tk2dFontData self);

        public delegate void InitDictionary_AfterArgs(Params_InitDictionary args);

        public delegate void InitDictionary_BeforeArgs(Params_InitDictionary args);

        public delegate void InitDictionary_WithArgs(Action<tk2dFontData> orig, tk2dFontData self);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<tk2dFontData> orig, tk2dFontData self);

        public delegate void ResetPlatformData_AfterArgs(Params_ResetPlatformData args);

        public delegate void ResetPlatformData_BeforeArgs(Params_ResetPlatformData args);

        public delegate void ResetPlatformData_WithArgs(Action<tk2dFontData> orig, tk2dFontData self);

        public delegate void SetDictionary_AfterArgs(Params_SetDictionary args);

        public delegate void SetDictionary_BeforeArgs(Params_SetDictionary args);

        public delegate void SetDictionary_WithArgs(Action<tk2dFontData, Dictionary<int, tk2dFontChar>> orig,
            tk2dFontData self, Dictionary<int, tk2dFontChar> dict);

        public sealed class Params_get_inst
        {
            public tk2dFontData self;
        }

        public sealed class Params_Init
        {
            public tk2dFontData self;
        }

        public sealed class Params_ResetPlatformData
        {
            public tk2dFontData self;
        }

        public sealed class Params_OnDestroy
        {
            public tk2dFontData self;
        }

        public sealed class Params_InitDictionary
        {
            public tk2dFontData self;
        }

        public sealed class Params_SetDictionary
        {
            public Dictionary<int, tk2dFontChar> dict;
            public tk2dFontData self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_inst_BeforeArgs get_inst
        {
            add
            {
                HookHandler._beforeget_inst += value;
                HookHandler.Hookget_inst();
            }
            remove => HookHandler._beforeget_inst -= value;
        }

        public static event Delegates.Init_BeforeArgs Init
        {
            add
            {
                HookHandler._beforeInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._beforeInit -= value;
        }

        public static event Delegates.ResetPlatformData_BeforeArgs ResetPlatformData
        {
            add
            {
                HookHandler._beforeResetPlatformData += value;
                HookHandler.HookResetPlatformData();
            }
            remove => HookHandler._beforeResetPlatformData -= value;
        }

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
        }

        public static event Delegates.InitDictionary_BeforeArgs InitDictionary
        {
            add
            {
                HookHandler._beforeInitDictionary += value;
                HookHandler.HookInitDictionary();
            }
            remove => HookHandler._beforeInitDictionary -= value;
        }

        public static event Delegates.SetDictionary_BeforeArgs SetDictionary
        {
            add
            {
                HookHandler._beforeSetDictionary += value;
                HookHandler.HookSetDictionary();
            }
            remove => HookHandler._beforeSetDictionary -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_inst_AfterArgs get_inst
        {
            add
            {
                HookHandler._afterget_inst += value;
                HookHandler.Hookget_inst();
            }
            remove => HookHandler._afterget_inst -= value;
        }

        public static event Delegates.Init_AfterArgs Init
        {
            add
            {
                HookHandler._afterInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._afterInit -= value;
        }

        public static event Delegates.ResetPlatformData_AfterArgs ResetPlatformData
        {
            add
            {
                HookHandler._afterResetPlatformData += value;
                HookHandler.HookResetPlatformData();
            }
            remove => HookHandler._afterResetPlatformData -= value;
        }

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
        }

        public static event Delegates.InitDictionary_AfterArgs InitDictionary
        {
            add
            {
                HookHandler._afterInitDictionary += value;
                HookHandler.HookInitDictionary();
            }
            remove => HookHandler._afterInitDictionary -= value;
        }

        public static event Delegates.SetDictionary_AfterArgs SetDictionary
        {
            add
            {
                HookHandler._afterSetDictionary += value;
                HookHandler.HookSetDictionary();
            }
            remove => HookHandler._afterSetDictionary -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_inst_WithArgs get_inst
        {
            add => HookEndpointManager.Add<Delegates.get_inst_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dFontData), "get_inst"), value);
            remove => HookEndpointManager.Remove<Delegates.get_inst_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dFontData), "get_inst"), value);
        }

        public static event On.tk2dFontData.hook_Init Init
        {
            add => On.tk2dFontData.Init += value;
            remove => On.tk2dFontData.Init -= value;
        }

        public static event On.tk2dFontData.hook_ResetPlatformData ResetPlatformData
        {
            add => On.tk2dFontData.ResetPlatformData += value;
            remove => On.tk2dFontData.ResetPlatformData -= value;
        }

        public static event On.tk2dFontData.hook_OnDestroy OnDestroy
        {
            add => On.tk2dFontData.OnDestroy += value;
            remove => On.tk2dFontData.OnDestroy -= value;
        }

        public static event On.tk2dFontData.hook_InitDictionary InitDictionary
        {
            add => On.tk2dFontData.InitDictionary += value;
            remove => On.tk2dFontData.InitDictionary -= value;
        }

        public static event On.tk2dFontData.hook_SetDictionary SetDictionary
        {
            add => On.tk2dFontData.SetDictionary += value;
            remove => On.tk2dFontData.SetDictionary -= value;
        }
    }
}