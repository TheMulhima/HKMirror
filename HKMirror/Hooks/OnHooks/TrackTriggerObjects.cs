using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TrackTriggerObjects class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTrackTriggerObjects
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_InsideCount()
        {
            if (!HookedList.Contains("get_InsideCount"))
            {
                HookedList.Add("get_InsideCount");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TrackTriggerObjects), "get_InsideCount"),
                    get_InsideCount);
            }
        }

        internal static event Delegates.get_InsideCount_BeforeArgs _beforeget_InsideCount;
        internal static event Delegates.get_InsideCount_AfterArgs _afterget_InsideCount;

        private static int get_InsideCount(Func<TrackTriggerObjects, int> orig, TrackTriggerObjects self)
        {
            Delegates.Params_get_InsideCount @params = new()
            {
                self = self
            };
            if (_beforeget_InsideCount != null)
                foreach (Delegates.get_InsideCount_BeforeArgs toInvoke in _beforeget_InsideCount.GetInvocationList())
                    try
                    {
                        _beforeget_InsideCount?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_InsideCount != null)
                foreach (Delegates.get_InsideCount_AfterArgs toInvoke in _afterget_InsideCount.GetInvocationList())
                    try
                    {
                        retVal = _afterget_InsideCount.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.TrackTriggerObjects.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.TrackTriggerObjects.orig_OnDisable orig, TrackTriggerObjects self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.TrackTriggerObjects.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.TrackTriggerObjects.orig_OnEnable orig, TrackTriggerObjects self)
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

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.TrackTriggerObjects.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_AfterArgs _afterFixedUpdate;

        private static void FixedUpdate(On.TrackTriggerObjects.orig_FixedUpdate orig, TrackTriggerObjects self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            if (_beforeFixedUpdate != null)
                foreach (Delegates.FixedUpdate_BeforeArgs toInvoke in _beforeFixedUpdate.GetInvocationList())
                    try
                    {
                        _beforeFixedUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null)
                foreach (Delegates.FixedUpdate_AfterArgs toInvoke in _afterFixedUpdate.GetInvocationList())
                    try
                    {
                        _afterFixedUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnHeroInPosition()
        {
            if (!HookedList.Contains("OnHeroInPosition"))
            {
                HookedList.Add("OnHeroInPosition");
                On.TrackTriggerObjects.OnHeroInPosition += OnHeroInPosition;
            }
        }

        internal static event Delegates.OnHeroInPosition_BeforeArgs _beforeOnHeroInPosition;
        internal static event Delegates.OnHeroInPosition_AfterArgs _afterOnHeroInPosition;

        private static void OnHeroInPosition(On.TrackTriggerObjects.orig_OnHeroInPosition orig,
            TrackTriggerObjects self, bool forceDirect)
        {
            Delegates.Params_OnHeroInPosition @params = new()
            {
                self = self, forceDirect = forceDirect
            };
            if (_beforeOnHeroInPosition != null)
                foreach (Delegates.OnHeroInPosition_BeforeArgs toInvoke in _beforeOnHeroInPosition.GetInvocationList())
                    try
                    {
                        _beforeOnHeroInPosition?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            forceDirect = @params.forceDirect;
            orig(self, forceDirect);
            if (_afterOnHeroInPosition != null)
                foreach (Delegates.OnHeroInPosition_AfterArgs toInvoke in _afterOnHeroInPosition.GetInvocationList())
                    try
                    {
                        _afterOnHeroInPosition.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetOverlappedColliders()
        {
            if (!HookedList.Contains("GetOverlappedColliders"))
            {
                HookedList.Add("GetOverlappedColliders");
                On.TrackTriggerObjects.GetOverlappedColliders += GetOverlappedColliders;
            }
        }

        internal static event Delegates.GetOverlappedColliders_BeforeArgs _beforeGetOverlappedColliders;
        internal static event Delegates.GetOverlappedColliders_AfterArgs _afterGetOverlappedColliders;

        private static void GetOverlappedColliders(On.TrackTriggerObjects.orig_GetOverlappedColliders orig,
            TrackTriggerObjects self, bool isRefresh)
        {
            Delegates.Params_GetOverlappedColliders @params = new()
            {
                self = self, isRefresh = isRefresh
            };
            if (_beforeGetOverlappedColliders != null)
                foreach (Delegates.GetOverlappedColliders_BeforeArgs toInvoke in _beforeGetOverlappedColliders
                             .GetInvocationList())
                    try
                    {
                        _beforeGetOverlappedColliders?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            isRefresh = @params.isRefresh;
            orig(self, isRefresh);
            if (_afterGetOverlappedColliders != null)
                foreach (Delegates.GetOverlappedColliders_AfterArgs toInvoke in _afterGetOverlappedColliders
                             .GetInvocationList())
                    try
                    {
                        _afterGetOverlappedColliders.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.TrackTriggerObjects.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.TrackTriggerObjects.orig_OnTriggerEnter2D orig,
            TrackTriggerObjects self, Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
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
            collision = @params.collision;
            orig(self, collision);
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

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.TrackTriggerObjects.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.TrackTriggerObjects.orig_OnTriggerExit2D orig, TrackTriggerObjects self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, collision = collision
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
            collision = @params.collision;
            orig(self, collision);
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                On.TrackTriggerObjects.OnExit += OnExit;
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(On.TrackTriggerObjects.orig_OnExit orig, TrackTriggerObjects self, GameObject obj)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self, obj = obj
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
            obj = @params.obj;
            orig(self, obj);
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

        internal static void HookIsIgnored()
        {
            if (!HookedList.Contains("IsIgnored"))
            {
                HookedList.Add("IsIgnored");
                On.TrackTriggerObjects.IsIgnored += IsIgnored;
            }
        }

        internal static event Delegates.IsIgnored_BeforeArgs _beforeIsIgnored;
        internal static event Delegates.IsIgnored_AfterArgs _afterIsIgnored;

        private static bool IsIgnored(On.TrackTriggerObjects.orig_IsIgnored orig, TrackTriggerObjects self,
            GameObject obj)
        {
            Delegates.Params_IsIgnored @params = new()
            {
                self = self, obj = obj
            };
            if (_beforeIsIgnored != null)
                foreach (Delegates.IsIgnored_BeforeArgs toInvoke in _beforeIsIgnored.GetInvocationList())
                    try
                    {
                        _beforeIsIgnored?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            obj = @params.obj;
            var retVal = orig(self, obj);
            if (_afterIsIgnored != null)
                foreach (Delegates.IsIgnored_AfterArgs toInvoke in _afterIsIgnored.GetInvocationList())
                    try
                    {
                        retVal = _afterIsIgnored.Invoke(@params, retVal);
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
        public delegate void FixedUpdate_AfterArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_WithArgs(Action<TrackTriggerObjects> orig, TrackTriggerObjects self);

        public delegate int get_InsideCount_AfterArgs(Params_get_InsideCount args, int ret);

        public delegate void get_InsideCount_BeforeArgs(Params_get_InsideCount args);

        public delegate int get_InsideCount_WithArgs(Func<TrackTriggerObjects, int> orig, TrackTriggerObjects self);

        public delegate void GetOverlappedColliders_AfterArgs(Params_GetOverlappedColliders args);

        public delegate void GetOverlappedColliders_BeforeArgs(Params_GetOverlappedColliders args);

        public delegate void GetOverlappedColliders_WithArgs(Action<TrackTriggerObjects, bool> orig,
            TrackTriggerObjects self, bool isRefresh);

        public delegate bool IsIgnored_AfterArgs(Params_IsIgnored args, bool ret);

        public delegate void IsIgnored_BeforeArgs(Params_IsIgnored args);

        public delegate bool IsIgnored_WithArgs(Func<TrackTriggerObjects, GameObject, bool> orig,
            TrackTriggerObjects self, GameObject obj);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<TrackTriggerObjects> orig, TrackTriggerObjects self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<TrackTriggerObjects> orig, TrackTriggerObjects self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<TrackTriggerObjects, GameObject> orig, TrackTriggerObjects self,
            GameObject obj);

        public delegate void OnHeroInPosition_AfterArgs(Params_OnHeroInPosition args);

        public delegate void OnHeroInPosition_BeforeArgs(Params_OnHeroInPosition args);

        public delegate void OnHeroInPosition_WithArgs(Action<TrackTriggerObjects, bool> orig, TrackTriggerObjects self,
            bool forceDirect);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<TrackTriggerObjects, Collider2D> orig,
            TrackTriggerObjects self, Collider2D collision);

        public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_WithArgs(Action<TrackTriggerObjects, Collider2D> orig,
            TrackTriggerObjects self, Collider2D collision);

        public sealed class Params_get_InsideCount
        {
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnDisable
        {
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnEnable
        {
            public TrackTriggerObjects self;
        }

        public sealed class Params_FixedUpdate
        {
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnHeroInPosition
        {
            public bool forceDirect;
            public TrackTriggerObjects self;
        }

        public sealed class Params_GetOverlappedColliders
        {
            public bool isRefresh;
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D collision;
            public TrackTriggerObjects self;
        }

        public sealed class Params_OnExit
        {
            public GameObject obj;
            public TrackTriggerObjects self;
        }

        public sealed class Params_IsIgnored
        {
            public GameObject obj;
            public TrackTriggerObjects self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_InsideCount_BeforeArgs get_InsideCount
        {
            add
            {
                HookHandler._beforeget_InsideCount += value;
                HookHandler.Hookget_InsideCount();
            }
            remove => HookHandler._beforeget_InsideCount -= value;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.OnHeroInPosition_BeforeArgs OnHeroInPosition
        {
            add
            {
                HookHandler._beforeOnHeroInPosition += value;
                HookHandler.HookOnHeroInPosition();
            }
            remove => HookHandler._beforeOnHeroInPosition -= value;
        }

        public static event Delegates.GetOverlappedColliders_BeforeArgs GetOverlappedColliders
        {
            add
            {
                HookHandler._beforeGetOverlappedColliders += value;
                HookHandler.HookGetOverlappedColliders();
            }
            remove => HookHandler._beforeGetOverlappedColliders -= value;
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

        public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._beforeOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._beforeOnTriggerExit2D -= value;
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

        public static event Delegates.IsIgnored_BeforeArgs IsIgnored
        {
            add
            {
                HookHandler._beforeIsIgnored += value;
                HookHandler.HookIsIgnored();
            }
            remove => HookHandler._beforeIsIgnored -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_InsideCount_AfterArgs get_InsideCount
        {
            add
            {
                HookHandler._afterget_InsideCount += value;
                HookHandler.Hookget_InsideCount();
            }
            remove => HookHandler._afterget_InsideCount -= value;
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

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.FixedUpdate_AfterArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.OnHeroInPosition_AfterArgs OnHeroInPosition
        {
            add
            {
                HookHandler._afterOnHeroInPosition += value;
                HookHandler.HookOnHeroInPosition();
            }
            remove => HookHandler._afterOnHeroInPosition -= value;
        }

        public static event Delegates.GetOverlappedColliders_AfterArgs GetOverlappedColliders
        {
            add
            {
                HookHandler._afterGetOverlappedColliders += value;
                HookHandler.HookGetOverlappedColliders();
            }
            remove => HookHandler._afterGetOverlappedColliders -= value;
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

        public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._afterOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._afterOnTriggerExit2D -= value;
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

        public static event Delegates.IsIgnored_AfterArgs IsIgnored
        {
            add
            {
                HookHandler._afterIsIgnored += value;
                HookHandler.HookIsIgnored();
            }
            remove => HookHandler._afterIsIgnored -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_InsideCount_WithArgs get_InsideCount
        {
            add => HookEndpointManager.Add<Delegates.get_InsideCount_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackTriggerObjects), "get_InsideCount"), value);
            remove => HookEndpointManager.Remove<Delegates.get_InsideCount_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackTriggerObjects), "get_InsideCount"), value);
        }

        public static event On.TrackTriggerObjects.hook_OnDisable OnDisable
        {
            add => On.TrackTriggerObjects.OnDisable += value;
            remove => On.TrackTriggerObjects.OnDisable -= value;
        }

        public static event On.TrackTriggerObjects.hook_OnEnable OnEnable
        {
            add => On.TrackTriggerObjects.OnEnable += value;
            remove => On.TrackTriggerObjects.OnEnable -= value;
        }

        public static event On.TrackTriggerObjects.hook_FixedUpdate FixedUpdate
        {
            add => On.TrackTriggerObjects.FixedUpdate += value;
            remove => On.TrackTriggerObjects.FixedUpdate -= value;
        }

        public static event On.TrackTriggerObjects.hook_OnHeroInPosition OnHeroInPosition
        {
            add => On.TrackTriggerObjects.OnHeroInPosition += value;
            remove => On.TrackTriggerObjects.OnHeroInPosition -= value;
        }

        public static event On.TrackTriggerObjects.hook_GetOverlappedColliders GetOverlappedColliders
        {
            add => On.TrackTriggerObjects.GetOverlappedColliders += value;
            remove => On.TrackTriggerObjects.GetOverlappedColliders -= value;
        }

        public static event On.TrackTriggerObjects.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.TrackTriggerObjects.OnTriggerEnter2D += value;
            remove => On.TrackTriggerObjects.OnTriggerEnter2D -= value;
        }

        public static event On.TrackTriggerObjects.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.TrackTriggerObjects.OnTriggerExit2D += value;
            remove => On.TrackTriggerObjects.OnTriggerExit2D -= value;
        }

        public static event On.TrackTriggerObjects.hook_OnExit OnExit
        {
            add => On.TrackTriggerObjects.OnExit += value;
            remove => On.TrackTriggerObjects.OnExit -= value;
        }

        public static event On.TrackTriggerObjects.hook_IsIgnored IsIgnored
        {
            add => On.TrackTriggerObjects.IsIgnored += value;
            remove => On.TrackTriggerObjects.IsIgnored -= value;
        }
    }
}