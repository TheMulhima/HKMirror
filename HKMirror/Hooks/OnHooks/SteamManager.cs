using System.Text;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SteamManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSteamManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Instance()
        {
            if (!HookedList.Contains("get_Instance"))
            {
                HookedList.Add("get_Instance");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Instance", false), get_Instance);
            }
        }

        internal static event Delegates.get_Instance_BeforeArgs _beforeget_Instance;
        internal static event Delegates.get_Instance_AfterArgs _afterget_Instance;

        private static SteamManager get_Instance(Func<SteamManager> orig)
        {
            if (_beforeget_Instance != null)
                foreach (Delegates.get_Instance_BeforeArgs toInvoke in _beforeget_Instance.GetInvocationList())
                    try
                    {
                        _beforeget_Instance?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_Instance != null)
                foreach (Delegates.get_Instance_AfterArgs toInvoke in _afterget_Instance.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Instance.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_Initialized()
        {
            if (!HookedList.Contains("get_Initialized"))
            {
                HookedList.Add("get_Initialized");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Initialized", false),
                    get_Initialized);
            }
        }

        internal static event Delegates.get_Initialized_BeforeArgs _beforeget_Initialized;
        internal static event Delegates.get_Initialized_AfterArgs _afterget_Initialized;

        private static bool get_Initialized(Func<bool> orig)
        {
            if (_beforeget_Initialized != null)
                foreach (Delegates.get_Initialized_BeforeArgs toInvoke in _beforeget_Initialized.GetInvocationList())
                    try
                    {
                        _beforeget_Initialized?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_Initialized != null)
                foreach (Delegates.get_Initialized_AfterArgs toInvoke in _afterget_Initialized.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Initialized.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSteamAPIDebugTextHook()
        {
            if (!HookedList.Contains("SteamAPIDebugTextHook"))
            {
                HookedList.Add("SteamAPIDebugTextHook");
                On.SteamManager.SteamAPIDebugTextHook += SteamAPIDebugTextHook;
            }
        }

        internal static event Delegates.SteamAPIDebugTextHook_BeforeArgs _beforeSteamAPIDebugTextHook;
        internal static event Delegates.SteamAPIDebugTextHook_AfterArgs _afterSteamAPIDebugTextHook;

        private static void SteamAPIDebugTextHook(On.SteamManager.orig_SteamAPIDebugTextHook orig, int nSeverity,
            StringBuilder pchDebugText)
        {
            Delegates.Params_SteamAPIDebugTextHook @params = new()
            {
                nSeverity = nSeverity, pchDebugText = pchDebugText
            };
            if (_beforeSteamAPIDebugTextHook != null)
                foreach (Delegates.SteamAPIDebugTextHook_BeforeArgs toInvoke in _beforeSteamAPIDebugTextHook
                             .GetInvocationList())
                    try
                    {
                        _beforeSteamAPIDebugTextHook?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            nSeverity = @params.nSeverity;
            pchDebugText = @params.pchDebugText;
            orig(nSeverity, pchDebugText);
            if (_afterSteamAPIDebugTextHook != null)
                foreach (Delegates.SteamAPIDebugTextHook_AfterArgs toInvoke in _afterSteamAPIDebugTextHook
                             .GetInvocationList())
                    try
                    {
                        _afterSteamAPIDebugTextHook.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SteamManager.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.SteamManager.orig_Awake orig, SteamManager self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.SteamManager.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.SteamManager.orig_OnEnable orig, SteamManager self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
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
                On.SteamManager.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.SteamManager.orig_OnDestroy orig, SteamManager self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SteamManager.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.SteamManager.orig_Update orig, SteamManager self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<SteamManager> orig, SteamManager self);

        public delegate bool get_Initialized_AfterArgs(bool ret);

        public delegate void get_Initialized_BeforeArgs();

        public delegate bool get_Initialized_WithArgs(Func<bool> orig);

        public delegate SteamManager get_Instance_AfterArgs(SteamManager ret);

        public delegate void get_Instance_BeforeArgs();

        public delegate SteamManager get_Instance_WithArgs(Func<SteamManager> orig);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<SteamManager> orig, SteamManager self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<SteamManager> orig, SteamManager self);

        public delegate void SteamAPIDebugTextHook_AfterArgs(Params_SteamAPIDebugTextHook args);

        public delegate void SteamAPIDebugTextHook_BeforeArgs(Params_SteamAPIDebugTextHook args);

        public delegate void SteamAPIDebugTextHook_WithArgs(Action<int, StringBuilder> orig, int nSeverity,
            StringBuilder pchDebugText);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SteamManager> orig, SteamManager self);

        public sealed class Params_SteamAPIDebugTextHook
        {
            public int nSeverity;
            public StringBuilder pchDebugText;
        }

        public sealed class Params_Awake
        {
            public SteamManager self;
        }

        public sealed class Params_OnEnable
        {
            public SteamManager self;
        }

        public sealed class Params_OnDestroy
        {
            public SteamManager self;
        }

        public sealed class Params_Update
        {
            public SteamManager self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Instance_BeforeArgs get_Instance
        {
            add
            {
                HookHandler._beforeget_Instance += value;
                HookHandler.Hookget_Instance();
            }
            remove => HookHandler._beforeget_Instance -= value;
        }

        public static event Delegates.get_Initialized_BeforeArgs get_Initialized
        {
            add
            {
                HookHandler._beforeget_Initialized += value;
                HookHandler.Hookget_Initialized();
            }
            remove => HookHandler._beforeget_Initialized -= value;
        }

        public static event Delegates.SteamAPIDebugTextHook_BeforeArgs SteamAPIDebugTextHook
        {
            add
            {
                HookHandler._beforeSteamAPIDebugTextHook += value;
                HookHandler.HookSteamAPIDebugTextHook();
            }
            remove => HookHandler._beforeSteamAPIDebugTextHook -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Instance_AfterArgs get_Instance
        {
            add
            {
                HookHandler._afterget_Instance += value;
                HookHandler.Hookget_Instance();
            }
            remove => HookHandler._afterget_Instance -= value;
        }

        public static event Delegates.get_Initialized_AfterArgs get_Initialized
        {
            add
            {
                HookHandler._afterget_Initialized += value;
                HookHandler.Hookget_Initialized();
            }
            remove => HookHandler._afterget_Initialized -= value;
        }

        public static event Delegates.SteamAPIDebugTextHook_AfterArgs SteamAPIDebugTextHook
        {
            add
            {
                HookHandler._afterSteamAPIDebugTextHook += value;
                HookHandler.HookSteamAPIDebugTextHook();
            }
            remove => HookHandler._afterSteamAPIDebugTextHook -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
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

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Instance_WithArgs get_Instance
        {
            add => HookEndpointManager.Add<Delegates.get_Instance_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Instance", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_Instance_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Instance", false), value);
        }

        public static event Delegates.get_Initialized_WithArgs get_Initialized
        {
            add => HookEndpointManager.Add<Delegates.get_Initialized_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Initialized", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_Initialized_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Initialized", false), value);
        }

        public static event On.SteamManager.hook_SteamAPIDebugTextHook SteamAPIDebugTextHook
        {
            add => On.SteamManager.SteamAPIDebugTextHook += value;
            remove => On.SteamManager.SteamAPIDebugTextHook -= value;
        }

        public static event On.SteamManager.hook_Awake Awake
        {
            add => On.SteamManager.Awake += value;
            remove => On.SteamManager.Awake -= value;
        }

        public static event On.SteamManager.hook_OnEnable OnEnable
        {
            add => On.SteamManager.OnEnable += value;
            remove => On.SteamManager.OnEnable -= value;
        }

        public static event On.SteamManager.hook_OnDestroy OnDestroy
        {
            add => On.SteamManager.OnDestroy += value;
            remove => On.SteamManager.OnDestroy -= value;
        }

        public static event On.SteamManager.hook_Update Update
        {
            add => On.SteamManager.Update += value;
            remove => On.SteamManager.Update -= value;
        }
    }
}