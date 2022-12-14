using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CameraLockArea class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCameraLockArea
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.CameraLockArea.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.CameraLockArea.orig_Awake orig, CameraLockArea self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.CameraLockArea.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.CameraLockArea.orig_Start orig, CameraLockArea self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookIsInApplicableGameState()
        {
            if (!HookedList.Contains("IsInApplicableGameState"))
            {
                HookedList.Add("IsInApplicableGameState");
                On.CameraLockArea.IsInApplicableGameState += IsInApplicableGameState;
            }
        }

        internal static event Delegates.IsInApplicableGameState_BeforeArgs _beforeIsInApplicableGameState;
        internal static event Delegates.IsInApplicableGameState_AfterArgs _afterIsInApplicableGameState;

        private static bool IsInApplicableGameState(On.CameraLockArea.orig_IsInApplicableGameState orig,
            CameraLockArea self)
        {
            Delegates.Params_IsInApplicableGameState @params = new()
            {
                self = self
            };
            if (_beforeIsInApplicableGameState != null)
                foreach (Delegates.IsInApplicableGameState_BeforeArgs toInvoke in _beforeIsInApplicableGameState
                             .GetInvocationList())
                    try
                    {
                        _beforeIsInApplicableGameState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterIsInApplicableGameState != null)
                foreach (Delegates.IsInApplicableGameState_AfterArgs toInvoke in _afterIsInApplicableGameState
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterIsInApplicableGameState.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.CameraLockArea.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.CameraLockArea.orig_OnTriggerEnter2D orig, CameraLockArea self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            if (_beforeOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerStay2D()
        {
            if (!HookedList.Contains("OnTriggerStay2D"))
            {
                HookedList.Add("OnTriggerStay2D");
                On.CameraLockArea.OnTriggerStay2D += OnTriggerStay2D;
            }
        }

        internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
        internal static event Delegates.OnTriggerStay2D_AfterArgs _afterOnTriggerStay2D;

        private static void OnTriggerStay2D(On.CameraLockArea.orig_OnTriggerStay2D orig, CameraLockArea self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerStay2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            if (_beforeOnTriggerStay2D != null)
                foreach (Delegates.OnTriggerStay2D_BeforeArgs toInvoke in _beforeOnTriggerStay2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerStay2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerStay2D != null)
                foreach (Delegates.OnTriggerStay2D_AfterArgs toInvoke in _afterOnTriggerStay2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerStay2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.CameraLockArea.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.CameraLockArea.orig_OnTriggerExit2D orig, CameraLockArea self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            if (_beforeOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerExit2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerExit2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.CameraLockArea.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.CameraLockArea.orig_OnDisable orig, CameraLockArea self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookValidateBounds()
        {
            if (!HookedList.Contains("ValidateBounds"))
            {
                HookedList.Add("ValidateBounds");
                On.CameraLockArea.ValidateBounds += ValidateBounds;
            }
        }

        internal static event Delegates.ValidateBounds_BeforeArgs _beforeValidateBounds;
        internal static event Delegates.ValidateBounds_AfterArgs _afterValidateBounds;

        private static bool ValidateBounds(On.CameraLockArea.orig_ValidateBounds orig, CameraLockArea self)
        {
            Delegates.Params_ValidateBounds @params = new()
            {
                self = self
            };
            if (_beforeValidateBounds != null)
                foreach (Delegates.ValidateBounds_BeforeArgs toInvoke in _beforeValidateBounds.GetInvocationList())
                    try
                    {
                        _beforeValidateBounds?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterValidateBounds != null)
                foreach (Delegates.ValidateBounds_AfterArgs toInvoke in _afterValidateBounds.GetInvocationList())
                    try
                    {
                        retVal = _afterValidateBounds.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSetXMin()
        {
            if (!HookedList.Contains("SetXMin"))
            {
                HookedList.Add("SetXMin");
                On.CameraLockArea.SetXMin += SetXMin;
            }
        }

        internal static event Delegates.SetXMin_BeforeArgs _beforeSetXMin;
        internal static event Delegates.SetXMin_AfterArgs _afterSetXMin;

        private static void SetXMin(On.CameraLockArea.orig_SetXMin orig, CameraLockArea self, float xmin)
        {
            Delegates.Params_SetXMin @params = new()
            {
                self = self, xmin = xmin
            };
            if (_beforeSetXMin != null)
                foreach (Delegates.SetXMin_BeforeArgs toInvoke in _beforeSetXMin.GetInvocationList())
                    try
                    {
                        _beforeSetXMin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            xmin = @params.xmin;
            orig(self, xmin);
            if (_afterSetXMin != null)
                foreach (Delegates.SetXMin_AfterArgs toInvoke in _afterSetXMin.GetInvocationList())
                    try
                    {
                        _afterSetXMin.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetXMax()
        {
            if (!HookedList.Contains("SetXMax"))
            {
                HookedList.Add("SetXMax");
                On.CameraLockArea.SetXMax += SetXMax;
            }
        }

        internal static event Delegates.SetXMax_BeforeArgs _beforeSetXMax;
        internal static event Delegates.SetXMax_AfterArgs _afterSetXMax;

        private static void SetXMax(On.CameraLockArea.orig_SetXMax orig, CameraLockArea self, float xmax)
        {
            Delegates.Params_SetXMax @params = new()
            {
                self = self, xmax = xmax
            };
            if (_beforeSetXMax != null)
                foreach (Delegates.SetXMax_BeforeArgs toInvoke in _beforeSetXMax.GetInvocationList())
                    try
                    {
                        _beforeSetXMax?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            xmax = @params.xmax;
            orig(self, xmax);
            if (_afterSetXMax != null)
                foreach (Delegates.SetXMax_AfterArgs toInvoke in _afterSetXMax.GetInvocationList())
                    try
                    {
                        _afterSetXMax.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookorig_Start()
        {
            if (!HookedList.Contains("orig_Start"))
            {
                HookedList.Add("orig_Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "orig_Start"), orig_Start);
            }
        }

        internal static event Delegates.orig_Start_BeforeArgs _beforeorig_Start;

        private static IEnumerator orig_Start(Func<CameraLockArea, IEnumerator> orig, CameraLockArea self)
        {
            Delegates.Params_orig_Start @params = new()
            {
                self = self
            };
            if (_beforeorig_Start != null)
                foreach (Delegates.orig_Start_BeforeArgs toInvoke in _beforeorig_Start.GetInvocationList())
                    try
                    {
                        _beforeorig_Start?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<CameraLockArea> orig, CameraLockArea self);

        public delegate bool IsInApplicableGameState_AfterArgs(Params_IsInApplicableGameState args, bool ret);

        public delegate void IsInApplicableGameState_BeforeArgs(Params_IsInApplicableGameState args);

        public delegate bool IsInApplicableGameState_WithArgs(Func<CameraLockArea, bool> orig, CameraLockArea self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<CameraLockArea> orig, CameraLockArea self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<CameraLockArea, Collider2D> orig, CameraLockArea self,
            Collider2D otherCollider);

        public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_WithArgs(Action<CameraLockArea, Collider2D> orig, CameraLockArea self,
            Collider2D otherCollider);

        public delegate void OnTriggerStay2D_AfterArgs(Params_OnTriggerStay2D args);

        public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);

        public delegate void OnTriggerStay2D_WithArgs(Action<CameraLockArea, Collider2D> orig, CameraLockArea self,
            Collider2D otherCollider);

        public delegate IEnumerator orig_Start_AfterArgs(Params_orig_Start args, IEnumerator ret);

        public delegate void orig_Start_BeforeArgs(Params_orig_Start args);

        public delegate IEnumerator orig_Start_WithArgs(Func<CameraLockArea, IEnumerator> orig, CameraLockArea self);

        public delegate void SetXMax_AfterArgs(Params_SetXMax args);

        public delegate void SetXMax_BeforeArgs(Params_SetXMax args);

        public delegate void SetXMax_WithArgs(Action<CameraLockArea, float> orig, CameraLockArea self, float xmax);

        public delegate void SetXMin_AfterArgs(Params_SetXMin args);

        public delegate void SetXMin_BeforeArgs(Params_SetXMin args);

        public delegate void SetXMin_WithArgs(Action<CameraLockArea, float> orig, CameraLockArea self, float xmin);

        public delegate IEnumerator Start_AfterArgs(Params_Start args, IEnumerator ret);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_WithArgs(Func<CameraLockArea, IEnumerator> orig, CameraLockArea self);

        public delegate bool ValidateBounds_AfterArgs(Params_ValidateBounds args, bool ret);

        public delegate void ValidateBounds_BeforeArgs(Params_ValidateBounds args);

        public delegate bool ValidateBounds_WithArgs(Func<CameraLockArea, bool> orig, CameraLockArea self);

        public sealed class Params_Awake
        {
            public CameraLockArea self;
        }

        public sealed class Params_Start
        {
            public CameraLockArea self;
        }

        public sealed class Params_IsInApplicableGameState
        {
            public CameraLockArea self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public CameraLockArea self;
        }

        public sealed class Params_OnTriggerStay2D
        {
            public Collider2D otherCollider;
            public CameraLockArea self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D otherCollider;
            public CameraLockArea self;
        }

        public sealed class Params_OnDisable
        {
            public CameraLockArea self;
        }

        public sealed class Params_ValidateBounds
        {
            public CameraLockArea self;
        }

        public sealed class Params_SetXMin
        {
            public CameraLockArea self;
            public float xmin;
        }

        public sealed class Params_SetXMax
        {
            public CameraLockArea self;
            public float xmax;
        }

        public sealed class Params_orig_Start
        {
            public CameraLockArea self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.IsInApplicableGameState_BeforeArgs IsInApplicableGameState
        {
            add
            {
                HookHandler._beforeIsInApplicableGameState += value;
                HookHandler.HookIsInApplicableGameState();
            }
            remove => HookHandler._beforeIsInApplicableGameState -= value;
        }

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerStay2D_BeforeArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._beforeOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._beforeOnTriggerStay2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._beforeOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._beforeOnTriggerExit2D -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.ValidateBounds_BeforeArgs ValidateBounds
        {
            add
            {
                HookHandler._beforeValidateBounds += value;
                HookHandler.HookValidateBounds();
            }
            remove => HookHandler._beforeValidateBounds -= value;
        }

        public static event Delegates.SetXMin_BeforeArgs SetXMin
        {
            add
            {
                HookHandler._beforeSetXMin += value;
                HookHandler.HookSetXMin();
            }
            remove => HookHandler._beforeSetXMin -= value;
        }

        public static event Delegates.SetXMax_BeforeArgs SetXMax
        {
            add
            {
                HookHandler._beforeSetXMax += value;
                HookHandler.HookSetXMax();
            }
            remove => HookHandler._beforeSetXMax -= value;
        }

        public static event Delegates.orig_Start_BeforeArgs orig_Start
        {
            add
            {
                HookHandler._beforeorig_Start += value;
                HookHandler.Hookorig_Start();
            }
            remove => HookHandler._beforeorig_Start -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.IsInApplicableGameState_AfterArgs IsInApplicableGameState
        {
            add
            {
                HookHandler._afterIsInApplicableGameState += value;
                HookHandler.HookIsInApplicableGameState();
            }
            remove => HookHandler._afterIsInApplicableGameState -= value;
        }

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerStay2D_AfterArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._afterOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._afterOnTriggerStay2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._afterOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._afterOnTriggerExit2D -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.ValidateBounds_AfterArgs ValidateBounds
        {
            add
            {
                HookHandler._afterValidateBounds += value;
                HookHandler.HookValidateBounds();
            }
            remove => HookHandler._afterValidateBounds -= value;
        }

        public static event Delegates.SetXMin_AfterArgs SetXMin
        {
            add
            {
                HookHandler._afterSetXMin += value;
                HookHandler.HookSetXMin();
            }
            remove => HookHandler._afterSetXMin -= value;
        }

        public static event Delegates.SetXMax_AfterArgs SetXMax
        {
            add
            {
                HookHandler._afterSetXMax += value;
                HookHandler.HookSetXMax();
            }
            remove => HookHandler._afterSetXMax -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CameraLockArea.hook_Awake Awake
        {
            add => On.CameraLockArea.Awake += value;
            remove => On.CameraLockArea.Awake -= value;
        }

        public static event On.CameraLockArea.hook_Start Start
        {
            add => On.CameraLockArea.Start += value;
            remove => On.CameraLockArea.Start -= value;
        }

        public static event On.CameraLockArea.hook_IsInApplicableGameState IsInApplicableGameState
        {
            add => On.CameraLockArea.IsInApplicableGameState += value;
            remove => On.CameraLockArea.IsInApplicableGameState -= value;
        }

        public static event On.CameraLockArea.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.CameraLockArea.OnTriggerEnter2D += value;
            remove => On.CameraLockArea.OnTriggerEnter2D -= value;
        }

        public static event On.CameraLockArea.hook_OnTriggerStay2D OnTriggerStay2D
        {
            add => On.CameraLockArea.OnTriggerStay2D += value;
            remove => On.CameraLockArea.OnTriggerStay2D -= value;
        }

        public static event On.CameraLockArea.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.CameraLockArea.OnTriggerExit2D += value;
            remove => On.CameraLockArea.OnTriggerExit2D -= value;
        }

        public static event On.CameraLockArea.hook_OnDisable OnDisable
        {
            add => On.CameraLockArea.OnDisable += value;
            remove => On.CameraLockArea.OnDisable -= value;
        }

        public static event On.CameraLockArea.hook_ValidateBounds ValidateBounds
        {
            add => On.CameraLockArea.ValidateBounds += value;
            remove => On.CameraLockArea.ValidateBounds -= value;
        }

        public static event On.CameraLockArea.hook_SetXMin SetXMin
        {
            add => On.CameraLockArea.SetXMin += value;
            remove => On.CameraLockArea.SetXMin -= value;
        }

        public static event On.CameraLockArea.hook_SetXMax SetXMax
        {
            add => On.CameraLockArea.SetXMax += value;
            remove => On.CameraLockArea.SetXMax -= value;
        }

        public static event Delegates.orig_Start_WithArgs orig_Start
        {
            add => HookEndpointManager.Add<Delegates.orig_Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "orig_Start"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "orig_Start"), value);
        }
    }
}