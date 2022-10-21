using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ForceCameraAspect class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnForceCameraAspect
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

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
        internal static event Delegates.get_CurrentViewportAspect_AfterArgs _afterget_CurrentViewportAspect;

        private static float get_CurrentViewportAspect(Func<float> orig)
        {
            if (_beforeget_CurrentViewportAspect != null)
            {
                foreach (Delegates.get_CurrentViewportAspect_BeforeArgs toInvoke in _beforeget_CurrentViewportAspect
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_CurrentViewportAspect?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            var retVal = orig();
            if (_afterget_CurrentViewportAspect != null)
            {
                foreach (Delegates.get_CurrentViewportAspect_AfterArgs toInvoke in _afterget_CurrentViewportAspect
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_CurrentViewportAspect.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

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
        internal static event Delegates.set_CurrentViewportAspect_AfterArgs _afterset_CurrentViewportAspect;

        private static void set_CurrentViewportAspect(Action<float> orig, float value)
        {
            Delegates.Params_set_CurrentViewportAspect @params = new()
            {
                value = value
            };
            if (_beforeset_CurrentViewportAspect != null)
            {
                foreach (Delegates.set_CurrentViewportAspect_BeforeArgs toInvoke in _beforeset_CurrentViewportAspect
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeset_CurrentViewportAspect?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            value = @params.value;
            orig(value);
            if (_afterset_CurrentViewportAspect != null)
            {
                foreach (Delegates.set_CurrentViewportAspect_AfterArgs toInvoke in _afterset_CurrentViewportAspect
                             .GetInvocationList())
                {
                    try
                    {
                        _afterset_CurrentViewportAspect.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
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
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.ForceCameraAspect.orig_Awake orig, ForceCameraAspect self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ForceCameraAspect.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.ForceCameraAspect.orig_Start orig, ForceCameraAspect self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
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
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.ForceCameraAspect.orig_Update orig, ForceCameraAspect self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
            {
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
            {
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                {
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
        internal static event Delegates.SetOverscanViewport_AfterArgs _afterSetOverscanViewport;

        private static void SetOverscanViewport(On.ForceCameraAspect.orig_SetOverscanViewport orig,
            ForceCameraAspect self, float adjustment)
        {
            Delegates.Params_SetOverscanViewport @params = new()
            {
                self = self, adjustment = adjustment
            };
            if (_beforeSetOverscanViewport != null)
            {
                foreach (Delegates.SetOverscanViewport_BeforeArgs toInvoke in _beforeSetOverscanViewport
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeSetOverscanViewport?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            adjustment = @params.adjustment;
            orig(self, adjustment);
            if (_afterSetOverscanViewport != null)
            {
                foreach (Delegates.SetOverscanViewport_AfterArgs toInvoke in
                         _afterSetOverscanViewport.GetInvocationList())
                {
                    try
                    {
                        _afterSetOverscanViewport.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
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
        internal static event Delegates.AutoScaleViewport_AfterArgs _afterAutoScaleViewport;

        private static float AutoScaleViewport(On.ForceCameraAspect.orig_AutoScaleViewport orig, ForceCameraAspect self)
        {
            Delegates.Params_AutoScaleViewport @params = new()
            {
                self = self
            };
            if (_beforeAutoScaleViewport != null)
            {
                foreach (Delegates.AutoScaleViewport_BeforeArgs toInvoke in
                         _beforeAutoScaleViewport.GetInvocationList())
                {
                    try
                    {
                        _beforeAutoScaleViewport?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterAutoScaleViewport != null)
            {
                foreach (Delegates.AutoScaleViewport_AfterArgs toInvoke in _afterAutoScaleViewport.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterAutoScaleViewport.Invoke(@params, retVal);
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
        public delegate void get_CurrentViewportAspect_BeforeArgs();

        public delegate float get_CurrentViewportAspect_AfterArgs(float ret);

        public delegate float get_CurrentViewportAspect_WithArgs(Func<float> orig);

        public sealed class Params_set_CurrentViewportAspect
        {
            public float value;
        }

        public delegate void set_CurrentViewportAspect_BeforeArgs(Params_set_CurrentViewportAspect args);

        public delegate void set_CurrentViewportAspect_AfterArgs(Params_set_CurrentViewportAspect args);

        public delegate void set_CurrentViewportAspect_WithArgs(Action<float> orig, float value);

        public sealed class Params_Awake
        {
            public ForceCameraAspect self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<ForceCameraAspect> orig, ForceCameraAspect self);

        public sealed class Params_Start
        {
            public ForceCameraAspect self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<ForceCameraAspect> orig, ForceCameraAspect self);

        public sealed class Params_Update
        {
            public ForceCameraAspect self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<ForceCameraAspect> orig, ForceCameraAspect self);

        public sealed class Params_SetOverscanViewport
        {
            public ForceCameraAspect self;
            public float adjustment;
        }

        public delegate void SetOverscanViewport_BeforeArgs(Params_SetOverscanViewport args);

        public delegate void SetOverscanViewport_AfterArgs(Params_SetOverscanViewport args);

        public delegate void SetOverscanViewport_WithArgs(Action<ForceCameraAspect, float> orig, ForceCameraAspect self,
            float adjustment);

        public sealed class Params_AutoScaleViewport
        {
            public ForceCameraAspect self;
        }

        public delegate void AutoScaleViewport_BeforeArgs(Params_AutoScaleViewport args);

        public delegate float AutoScaleViewport_AfterArgs(Params_AutoScaleViewport args, float ret);

        public delegate float AutoScaleViewport_WithArgs(Func<ForceCameraAspect, float> orig, ForceCameraAspect self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_CurrentViewportAspect_AfterArgs get_CurrentViewportAspect
        {
            add
            {
                HookHandler._afterget_CurrentViewportAspect += value;
                HookHandler.Hookget_CurrentViewportAspect();
            }
            remove => HookHandler._afterget_CurrentViewportAspect -= value;
        }

        public static event Delegates.set_CurrentViewportAspect_AfterArgs set_CurrentViewportAspect
        {
            add
            {
                HookHandler._afterset_CurrentViewportAspect += value;
                HookHandler.Hookset_CurrentViewportAspect();
            }
            remove => HookHandler._afterset_CurrentViewportAspect -= value;
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

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.SetOverscanViewport_AfterArgs SetOverscanViewport
        {
            add
            {
                HookHandler._afterSetOverscanViewport += value;
                HookHandler.HookSetOverscanViewport();
            }
            remove => HookHandler._afterSetOverscanViewport -= value;
        }

        public static event Delegates.AutoScaleViewport_AfterArgs AutoScaleViewport
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
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_CurrentViewportAspect_WithArgs get_CurrentViewportAspect
        {
            add => HookEndpointManager.Add<Delegates.get_CurrentViewportAspect_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_CurrentViewportAspect_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
        }

        public static event Delegates.set_CurrentViewportAspect_WithArgs set_CurrentViewportAspect
        {
            add => HookEndpointManager.Add<Delegates.set_CurrentViewportAspect_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false), value);
            remove => HookEndpointManager.Remove<Delegates.set_CurrentViewportAspect_WithArgs>(
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