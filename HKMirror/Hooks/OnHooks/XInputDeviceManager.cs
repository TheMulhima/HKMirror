using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using XInputDotNetPure;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for XInputDeviceManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnXInputDeviceManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStartWorker()
        {
            if (!HookedList.Contains("StartWorker"))
            {
                HookedList.Add("StartWorker");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StartWorker"), StartWorker);
            }
        }

        internal static event Delegates.StartWorker_BeforeArgs _beforeStartWorker;
        internal static event Delegates.StartWorker_NormalArgs _afterStartWorker;

        private static void StartWorker(Action<XInputDeviceManager> orig, XInputDeviceManager self)
        {
            Delegates.Params_StartWorker @params = new()
            {
                self = self
            };
            _beforeStartWorker?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartWorker != null) _afterStartWorker.Invoke(@params);
        }

        internal static void HookStopWorker()
        {
            if (!HookedList.Contains("StopWorker"))
            {
                HookedList.Add("StopWorker");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StopWorker"), StopWorker);
            }
        }

        internal static event Delegates.StopWorker_BeforeArgs _beforeStopWorker;
        internal static event Delegates.StopWorker_NormalArgs _afterStopWorker;

        private static void StopWorker(Action<XInputDeviceManager> orig, XInputDeviceManager self)
        {
            Delegates.Params_StopWorker @params = new()
            {
                self = self
            };
            _beforeStopWorker?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStopWorker != null) _afterStopWorker.Invoke(@params);
        }

        internal static void HookWorker()
        {
            if (!HookedList.Contains("Worker"))
            {
                HookedList.Add("Worker");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Worker"), Worker);
            }
        }

        internal static event Delegates.Worker_BeforeArgs _beforeWorker;
        internal static event Delegates.Worker_NormalArgs _afterWorker;

        private static void Worker(Action<XInputDeviceManager> orig, XInputDeviceManager self)
        {
            Delegates.Params_Worker @params = new()
            {
                self = self
            };
            _beforeWorker?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterWorker != null) _afterWorker.Invoke(@params);
        }

        internal static void HookGetState()
        {
            if (!HookedList.Contains("GetState"))
            {
                HookedList.Add("GetState");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "GetState"), GetState);
            }
        }

        internal static event Delegates.GetState_BeforeArgs _beforeGetState;
        internal static event Delegates.GetState_NormalArgs _afterGetState;

        private static GamePadState GetState(Func<XInputDeviceManager, int, GamePadState> orig,
            XInputDeviceManager self, int deviceIndex)
        {
            Delegates.Params_GetState @params = new()
            {
                self = self, deviceIndex = deviceIndex
            };
            _beforeGetState?.Invoke(@params);
            self = @params.self;
            deviceIndex = @params.deviceIndex;
            var retVal = orig(self, deviceIndex);
            if (_afterGetState != null) retVal = _afterGetState.Invoke(@params);
            return retVal;
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(Action<XInputDeviceManager, ulong, float> orig, XInputDeviceManager self,
            ulong updateTick, float deltaTime)
        {
            Delegates.Params_Update @params = new()
            {
                self = self, updateTick = updateTick, deltaTime = deltaTime
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, updateTick, deltaTime);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookDestroy()
        {
            if (!HookedList.Contains("Destroy"))
            {
                HookedList.Add("Destroy");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Destroy"), Destroy);
            }
        }

        internal static event Delegates.Destroy_BeforeArgs _beforeDestroy;
        internal static event Delegates.Destroy_NormalArgs _afterDestroy;

        private static void Destroy(Action<XInputDeviceManager> orig, XInputDeviceManager self)
        {
            Delegates.Params_Destroy @params = new()
            {
                self = self
            };
            _beforeDestroy?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDestroy != null) _afterDestroy.Invoke(@params);
        }

        internal static void HookCheckPlatformSupport()
        {
            if (!HookedList.Contains("CheckPlatformSupport"))
            {
                HookedList.Add("CheckPlatformSupport");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "CheckPlatformSupport", false),
                    CheckPlatformSupport);
            }
        }

        internal static event Delegates.CheckPlatformSupport_BeforeArgs _beforeCheckPlatformSupport;
        internal static event Delegates.CheckPlatformSupport_NormalArgs _afterCheckPlatformSupport;

        private static bool CheckPlatformSupport(Func<ICollection<string>, bool> orig, ICollection<string> errors)
        {
            Delegates.Params_CheckPlatformSupport @params = new()
            {
                errors = errors
            };
            _beforeCheckPlatformSupport?.Invoke(@params);
            errors = @params.errors;
            var retVal = orig(errors);
            if (_afterCheckPlatformSupport != null) retVal = _afterCheckPlatformSupport.Invoke(@params);
            return retVal;
        }

        internal static void HookEnable()
        {
            if (!HookedList.Contains("Enable"))
            {
                HookedList.Add("Enable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Enable", false), Enable);
            }
        }

        internal static event Delegates.Enable_BeforeArgs _beforeEnable;
        internal static event Delegates.Enable_NormalArgs _afterEnable;

        private static void Enable(Action orig)
        {
            _beforeEnable?.Invoke();
            orig();
            if (_afterEnable != null) _afterEnable.Invoke();
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CheckPlatformSupport_BeforeArgs(Params_CheckPlatformSupport args);

        public delegate bool CheckPlatformSupport_NormalArgs(Params_CheckPlatformSupport args);

        public delegate void Destroy_BeforeArgs(Params_Destroy args);

        public delegate void Destroy_NormalArgs(Params_Destroy args);

        public delegate void Enable_BeforeArgs();

        public delegate void Enable_NormalArgs();

        public delegate void GetState_BeforeArgs(Params_GetState args);

        public delegate GamePadState GetState_NormalArgs(Params_GetState args);

        public delegate void StartWorker_BeforeArgs(Params_StartWorker args);

        public delegate void StartWorker_NormalArgs(Params_StartWorker args);

        public delegate void StopWorker_BeforeArgs(Params_StopWorker args);

        public delegate void StopWorker_NormalArgs(Params_StopWorker args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public delegate void Worker_BeforeArgs(Params_Worker args);

        public delegate void Worker_NormalArgs(Params_Worker args);

        public sealed class Params_StartWorker
        {
            public XInputDeviceManager self;
        }

        public sealed class Params_StopWorker
        {
            public XInputDeviceManager self;
        }

        public sealed class Params_Worker
        {
            public XInputDeviceManager self;
        }

        public sealed class Params_GetState
        {
            public int deviceIndex;
            public XInputDeviceManager self;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public XInputDeviceManager self;
            public ulong updateTick;
        }

        public sealed class Params_Destroy
        {
            public XInputDeviceManager self;
        }

        public sealed class Params_CheckPlatformSupport
        {
            public ICollection<string> errors;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.StartWorker_BeforeArgs StartWorker
        {
            add
            {
                HookHandler._beforeStartWorker += value;
                HookHandler.HookStartWorker();
            }
            remove => HookHandler._beforeStartWorker -= value;
        }

        public static event Delegates.StopWorker_BeforeArgs StopWorker
        {
            add
            {
                HookHandler._beforeStopWorker += value;
                HookHandler.HookStopWorker();
            }
            remove => HookHandler._beforeStopWorker -= value;
        }

        public static event Delegates.Worker_BeforeArgs Worker
        {
            add
            {
                HookHandler._beforeWorker += value;
                HookHandler.HookWorker();
            }
            remove => HookHandler._beforeWorker -= value;
        }

        public static event Delegates.GetState_BeforeArgs GetState
        {
            add
            {
                HookHandler._beforeGetState += value;
                HookHandler.HookGetState();
            }
            remove => HookHandler._beforeGetState -= value;
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

        public static event Delegates.Destroy_BeforeArgs Destroy
        {
            add
            {
                HookHandler._beforeDestroy += value;
                HookHandler.HookDestroy();
            }
            remove => HookHandler._beforeDestroy -= value;
        }

        public static event Delegates.CheckPlatformSupport_BeforeArgs CheckPlatformSupport
        {
            add
            {
                HookHandler._beforeCheckPlatformSupport += value;
                HookHandler.HookCheckPlatformSupport();
            }
            remove => HookHandler._beforeCheckPlatformSupport -= value;
        }

        public static event Delegates.Enable_BeforeArgs Enable
        {
            add
            {
                HookHandler._beforeEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._beforeEnable -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.StartWorker_NormalArgs StartWorker
        {
            add
            {
                HookHandler._afterStartWorker += value;
                HookHandler.HookStartWorker();
            }
            remove => HookHandler._afterStartWorker -= value;
        }

        public static event Delegates.StopWorker_NormalArgs StopWorker
        {
            add
            {
                HookHandler._afterStopWorker += value;
                HookHandler.HookStopWorker();
            }
            remove => HookHandler._afterStopWorker -= value;
        }

        public static event Delegates.Worker_NormalArgs Worker
        {
            add
            {
                HookHandler._afterWorker += value;
                HookHandler.HookWorker();
            }
            remove => HookHandler._afterWorker -= value;
        }

        public static event Delegates.GetState_NormalArgs GetState
        {
            add
            {
                HookHandler._afterGetState += value;
                HookHandler.HookGetState();
            }
            remove => HookHandler._afterGetState -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Destroy_NormalArgs Destroy
        {
            add
            {
                HookHandler._afterDestroy += value;
                HookHandler.HookDestroy();
            }
            remove => HookHandler._afterDestroy -= value;
        }

        public static event Delegates.CheckPlatformSupport_NormalArgs CheckPlatformSupport
        {
            add
            {
                HookHandler._afterCheckPlatformSupport += value;
                HookHandler.HookCheckPlatformSupport();
            }
            remove => HookHandler._afterCheckPlatformSupport -= value;
        }

        public static event Delegates.Enable_NormalArgs Enable
        {
            add
            {
                HookHandler._afterEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._afterEnable -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.StartWorker_NormalArgs StartWorker
        {
            add => HookEndpointManager.Add<Delegates.StartWorker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StartWorker"), value);
            remove => HookEndpointManager.Remove<Delegates.StartWorker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StartWorker"), value);
        }

        public static event Delegates.StopWorker_NormalArgs StopWorker
        {
            add => HookEndpointManager.Add<Delegates.StopWorker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StopWorker"), value);
            remove => HookEndpointManager.Remove<Delegates.StopWorker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StopWorker"), value);
        }

        public static event Delegates.Worker_NormalArgs Worker
        {
            add => HookEndpointManager.Add<Delegates.Worker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Worker"), value);
            remove => HookEndpointManager.Remove<Delegates.Worker_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Worker"), value);
        }

        public static event Delegates.GetState_NormalArgs GetState
        {
            add => HookEndpointManager.Add<Delegates.GetState_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "GetState"), value);
            remove => HookEndpointManager.Remove<Delegates.GetState_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "GetState"), value);
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Update"), value);
        }

        public static event Delegates.Destroy_NormalArgs Destroy
        {
            add => HookEndpointManager.Add<Delegates.Destroy_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Destroy"), value);
            remove => HookEndpointManager.Remove<Delegates.Destroy_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Destroy"), value);
        }

        public static event Delegates.CheckPlatformSupport_NormalArgs CheckPlatformSupport
        {
            add => HookEndpointManager.Add<Delegates.CheckPlatformSupport_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "CheckPlatformSupport", false), value);
            remove => HookEndpointManager.Remove<Delegates.CheckPlatformSupport_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "CheckPlatformSupport", false), value);
        }

        public static event Delegates.Enable_NormalArgs Enable
        {
            add => HookEndpointManager.Add<Delegates.Enable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Enable", false), value);
            remove => HookEndpointManager.Remove<Delegates.Enable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Enable", false), value);
        }
    }
}