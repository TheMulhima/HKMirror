using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ForceCameraAspect class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnForceCameraAspect
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_CurrentViewportAspect()
        {
            if (!HookedList.Contains("get_CurrentViewportAspect"))
            {
                HookedList.Add("get_CurrentViewportAspect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false),
                    get_CurrentViewportAspect);
            }
        }

        internal static event Delegates.get_CurrentViewportAspect_BeforeArgs _beforeget_CurrentViewportAspect;
        internal static event Delegates.get_CurrentViewportAspect_NormalArgs _afterget_CurrentViewportAspect;

        private static float get_CurrentViewportAspect(Func<float> orig)
        {
            _beforeget_CurrentViewportAspect?.Invoke();
            var retVal = orig();
            if (_afterget_CurrentViewportAspect != null) retVal = _afterget_CurrentViewportAspect.Invoke();
            return retVal;
        }

        internal static void Hookset_CurrentViewportAspect()
        {
            if (!HookedList.Contains("set_CurrentViewportAspect"))
            {
                HookedList.Add("set_CurrentViewportAspect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false),
                    set_CurrentViewportAspect);
            }
        }

        internal static event Delegates.set_CurrentViewportAspect_BeforeArgs _beforeset_CurrentViewportAspect;
        internal static event Delegates.set_CurrentViewportAspect_NormalArgs _afterset_CurrentViewportAspect;

        private static void set_CurrentViewportAspect(Action<float> orig, float value)
        {
            Delegates.Params_set_CurrentViewportAspect @params = new()
            {
                value = value
            };
            _beforeset_CurrentViewportAspect?.Invoke(@params);
            value = @params.value;
            orig(value);
            if (_afterset_CurrentViewportAspect != null) _afterset_CurrentViewportAspect.Invoke(@params);
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.ForceCameraAspect.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.ForceCameraAspect.orig_Awake orig, ForceCameraAspect self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ForceCameraAspect.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.ForceCameraAspect.orig_Start orig, ForceCameraAspect self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.ForceCameraAspect.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.ForceCameraAspect.orig_Update orig, ForceCameraAspect self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookSetOverscanViewport()
        {
            if (!HookedList.Contains("SetOverscanViewport"))
            {
                HookedList.Add("SetOverscanViewport");
                On.ForceCameraAspect.SetOverscanViewport += SetOverscanViewport;
            }
        }

        internal static event Delegates.SetOverscanViewport_BeforeArgs _beforeSetOverscanViewport;
        internal static event Delegates.SetOverscanViewport_NormalArgs _afterSetOverscanViewport;

        private static void SetOverscanViewport(On.ForceCameraAspect.orig_SetOverscanViewport orig,
            ForceCameraAspect self, float adjustment)
        {
            Delegates.Params_SetOverscanViewport @params = new()
            {
                self = self, adjustment = adjustment
            };
            _beforeSetOverscanViewport?.Invoke(@params);
            self = @params.self;
            adjustment = @params.adjustment;
            orig(self, adjustment);
            if (_afterSetOverscanViewport != null) _afterSetOverscanViewport.Invoke(@params);
        }

        internal static void HookAutoScaleViewport()
        {
            if (!HookedList.Contains("AutoScaleViewport"))
            {
                HookedList.Add("AutoScaleViewport");
                On.ForceCameraAspect.AutoScaleViewport += AutoScaleViewport;
            }
        }

        internal static event Delegates.AutoScaleViewport_BeforeArgs _beforeAutoScaleViewport;
        internal static event Delegates.AutoScaleViewport_NormalArgs _afterAutoScaleViewport;

        private static float AutoScaleViewport(On.ForceCameraAspect.orig_AutoScaleViewport orig, ForceCameraAspect self)
        {
            Delegates.Params_AutoScaleViewport @params = new()
            {
                self = self
            };
            _beforeAutoScaleViewport?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterAutoScaleViewport != null) retVal = _afterAutoScaleViewport.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void AutoScaleViewport_BeforeArgs(Params_AutoScaleViewport args);

        public delegate float AutoScaleViewport_NormalArgs(Params_AutoScaleViewport args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void get_CurrentViewportAspect_BeforeArgs();

        public delegate float get_CurrentViewportAspect_NormalArgs();

        public delegate void set_CurrentViewportAspect_BeforeArgs(Params_set_CurrentViewportAspect args);

        public delegate void set_CurrentViewportAspect_NormalArgs(Params_set_CurrentViewportAspect args);

        public delegate void SetOverscanViewport_BeforeArgs(Params_SetOverscanViewport args);

        public delegate void SetOverscanViewport_NormalArgs(Params_SetOverscanViewport args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_set_CurrentViewportAspect
        {
            public float value;
        }

        public sealed class Params_Awake
        {
            public ForceCameraAspect self;
        }

        public sealed class Params_Start
        {
            public ForceCameraAspect self;
        }

        public sealed class Params_Update
        {
            public ForceCameraAspect self;
        }

        public sealed class Params_SetOverscanViewport
        {
            public float adjustment;
            public ForceCameraAspect self;
        }

        public sealed class Params_AutoScaleViewport
        {
            public ForceCameraAspect self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_CurrentViewportAspect_BeforeArgs get_CurrentViewportAspect
        {
            add
            {
                HookHandler._beforeget_CurrentViewportAspect += value;
                HookHandler.Hookget_CurrentViewportAspect();
            }
            remove => HookHandler._beforeget_CurrentViewportAspect -= value;
        }

        public static event Delegates.set_CurrentViewportAspect_BeforeArgs set_CurrentViewportAspect
        {
            add
            {
                HookHandler._beforeset_CurrentViewportAspect += value;
                HookHandler.Hookset_CurrentViewportAspect();
            }
            remove => HookHandler._beforeset_CurrentViewportAspect -= value;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.SetOverscanViewport_BeforeArgs SetOverscanViewport
        {
            add
            {
                HookHandler._beforeSetOverscanViewport += value;
                HookHandler.HookSetOverscanViewport();
            }
            remove => HookHandler._beforeSetOverscanViewport -= value;
        }

        public static event Delegates.AutoScaleViewport_BeforeArgs AutoScaleViewport
        {
            add
            {
                HookHandler._beforeAutoScaleViewport += value;
                HookHandler.HookAutoScaleViewport();
            }
            remove => HookHandler._beforeAutoScaleViewport -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_CurrentViewportAspect_NormalArgs get_CurrentViewportAspect
        {
            add
            {
                HookHandler._afterget_CurrentViewportAspect += value;
                HookHandler.Hookget_CurrentViewportAspect();
            }
            remove => HookHandler._afterget_CurrentViewportAspect -= value;
        }

        public static event Delegates.set_CurrentViewportAspect_NormalArgs set_CurrentViewportAspect
        {
            add
            {
                HookHandler._afterset_CurrentViewportAspect += value;
                HookHandler.Hookset_CurrentViewportAspect();
            }
            remove => HookHandler._afterset_CurrentViewportAspect -= value;
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.SetOverscanViewport_NormalArgs SetOverscanViewport
        {
            add
            {
                HookHandler._afterSetOverscanViewport += value;
                HookHandler.HookSetOverscanViewport();
            }
            remove => HookHandler._afterSetOverscanViewport -= value;
        }

        public static event Delegates.AutoScaleViewport_NormalArgs AutoScaleViewport
        {
            add
            {
                HookHandler._afterAutoScaleViewport += value;
                HookHandler.HookAutoScaleViewport();
            }
            remove => HookHandler._afterAutoScaleViewport -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_CurrentViewportAspect_NormalArgs get_CurrentViewportAspect
        {
            add => HookEndpointManager.Add<Delegates.get_CurrentViewportAspect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_CurrentViewportAspect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
        }

        public static event Delegates.set_CurrentViewportAspect_NormalArgs set_CurrentViewportAspect
        {
            add => HookEndpointManager.Add<Delegates.set_CurrentViewportAspect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false), value);
            remove => HookEndpointManager.Remove<Delegates.set_CurrentViewportAspect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false), value);
        }

        public static event On.ForceCameraAspect.hook_Awake Awake
        {
            add => On.ForceCameraAspect.Awake += value;
            remove => On.ForceCameraAspect.Awake -= value;
        }

        public static event On.ForceCameraAspect.hook_Start Start
        {
            add => On.ForceCameraAspect.Start += value;
            remove => On.ForceCameraAspect.Start -= value;
        }

        public static event On.ForceCameraAspect.hook_Update Update
        {
            add => On.ForceCameraAspect.Update += value;
            remove => On.ForceCameraAspect.Update -= value;
        }

        public static event On.ForceCameraAspect.hook_SetOverscanViewport SetOverscanViewport
        {
            add => On.ForceCameraAspect.SetOverscanViewport += value;
            remove => On.ForceCameraAspect.SetOverscanViewport -= value;
        }

        public static event On.ForceCameraAspect.hook_AutoScaleViewport AutoScaleViewport
        {
            add => On.ForceCameraAspect.AutoScaleViewport += value;
            remove => On.ForceCameraAspect.AutoScaleViewport -= value;
        }
    }
}