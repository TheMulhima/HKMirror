namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GrimmEnemyRange class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGrimmEnemyRange
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.GrimmEnemyRange.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.GrimmEnemyRange.orig_OnEnable orig, GrimmEnemyRange self)
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

        internal static void HookIsEnemyInRange()
        {
            if (!HookedList.Contains("IsEnemyInRange"))
            {
                HookedList.Add("IsEnemyInRange");
                On.GrimmEnemyRange.IsEnemyInRange += IsEnemyInRange;
            }
        }

        internal static event Delegates.IsEnemyInRange_BeforeArgs _beforeIsEnemyInRange;
        internal static event Delegates.IsEnemyInRange_AfterArgs _afterIsEnemyInRange;

        private static bool IsEnemyInRange(On.GrimmEnemyRange.orig_IsEnemyInRange orig, GrimmEnemyRange self)
        {
            Delegates.Params_IsEnemyInRange @params = new()
            {
                self = self
            };
            if (_beforeIsEnemyInRange != null)
                foreach (Delegates.IsEnemyInRange_BeforeArgs toInvoke in _beforeIsEnemyInRange.GetInvocationList())
                    try
                    {
                        _beforeIsEnemyInRange?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterIsEnemyInRange != null)
                foreach (Delegates.IsEnemyInRange_AfterArgs toInvoke in _afterIsEnemyInRange.GetInvocationList())
                    try
                    {
                        retVal = _afterIsEnemyInRange.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetTarget()
        {
            if (!HookedList.Contains("GetTarget"))
            {
                HookedList.Add("GetTarget");
                On.GrimmEnemyRange.GetTarget += GetTarget;
            }
        }

        internal static event Delegates.GetTarget_BeforeArgs _beforeGetTarget;
        internal static event Delegates.GetTarget_AfterArgs _afterGetTarget;

        private static GameObject GetTarget(On.GrimmEnemyRange.orig_GetTarget orig, GrimmEnemyRange self)
        {
            Delegates.Params_GetTarget @params = new()
            {
                self = self
            };
            if (_beforeGetTarget != null)
                foreach (Delegates.GetTarget_BeforeArgs toInvoke in _beforeGetTarget.GetInvocationList())
                    try
                    {
                        _beforeGetTarget?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetTarget != null)
                foreach (Delegates.GetTarget_AfterArgs toInvoke in _afterGetTarget.GetInvocationList())
                    try
                    {
                        retVal = _afterGetTarget.Invoke(@params, retVal);
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
                On.GrimmEnemyRange.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.GrimmEnemyRange.orig_OnTriggerEnter2D orig, GrimmEnemyRange self,
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

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.GrimmEnemyRange.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.GrimmEnemyRange.orig_OnTriggerExit2D orig, GrimmEnemyRange self,
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

        internal static void HookClearEnemyList()
        {
            if (!HookedList.Contains("ClearEnemyList"))
            {
                HookedList.Add("ClearEnemyList");
                On.GrimmEnemyRange.ClearEnemyList += ClearEnemyList;
            }
        }

        internal static event Delegates.ClearEnemyList_BeforeArgs _beforeClearEnemyList;
        internal static event Delegates.ClearEnemyList_AfterArgs _afterClearEnemyList;

        private static void ClearEnemyList(On.GrimmEnemyRange.orig_ClearEnemyList orig, GrimmEnemyRange self)
        {
            Delegates.Params_ClearEnemyList @params = new()
            {
                self = self
            };
            if (_beforeClearEnemyList != null)
                foreach (Delegates.ClearEnemyList_BeforeArgs toInvoke in _beforeClearEnemyList.GetInvocationList())
                    try
                    {
                        _beforeClearEnemyList?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterClearEnemyList != null)
                foreach (Delegates.ClearEnemyList_AfterArgs toInvoke in _afterClearEnemyList.GetInvocationList())
                    try
                    {
                        _afterClearEnemyList.Invoke(@params);
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
        public delegate void ClearEnemyList_AfterArgs(Params_ClearEnemyList args);

        public delegate void ClearEnemyList_BeforeArgs(Params_ClearEnemyList args);

        public delegate void ClearEnemyList_WithArgs(Action<GrimmEnemyRange> orig, GrimmEnemyRange self);

        public delegate GameObject GetTarget_AfterArgs(Params_GetTarget args, GameObject ret);

        public delegate void GetTarget_BeforeArgs(Params_GetTarget args);

        public delegate GameObject GetTarget_WithArgs(Func<GrimmEnemyRange, GameObject> orig, GrimmEnemyRange self);

        public delegate bool IsEnemyInRange_AfterArgs(Params_IsEnemyInRange args, bool ret);

        public delegate void IsEnemyInRange_BeforeArgs(Params_IsEnemyInRange args);

        public delegate bool IsEnemyInRange_WithArgs(Func<GrimmEnemyRange, bool> orig, GrimmEnemyRange self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<GrimmEnemyRange> orig, GrimmEnemyRange self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<GrimmEnemyRange, Collider2D> orig, GrimmEnemyRange self,
            Collider2D otherCollider);

        public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_WithArgs(Action<GrimmEnemyRange, Collider2D> orig, GrimmEnemyRange self,
            Collider2D otherCollider);

        public sealed class Params_OnEnable
        {
            public GrimmEnemyRange self;
        }

        public sealed class Params_IsEnemyInRange
        {
            public GrimmEnemyRange self;
        }

        public sealed class Params_GetTarget
        {
            public GrimmEnemyRange self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public GrimmEnemyRange self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D otherCollider;
            public GrimmEnemyRange self;
        }

        public sealed class Params_ClearEnemyList
        {
            public GrimmEnemyRange self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.IsEnemyInRange_BeforeArgs IsEnemyInRange
        {
            add
            {
                HookHandler._beforeIsEnemyInRange += value;
                HookHandler.HookIsEnemyInRange();
            }
            remove => HookHandler._beforeIsEnemyInRange -= value;
        }

        public static event Delegates.GetTarget_BeforeArgs GetTarget
        {
            add
            {
                HookHandler._beforeGetTarget += value;
                HookHandler.HookGetTarget();
            }
            remove => HookHandler._beforeGetTarget -= value;
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

        public static event Delegates.ClearEnemyList_BeforeArgs ClearEnemyList
        {
            add
            {
                HookHandler._beforeClearEnemyList += value;
                HookHandler.HookClearEnemyList();
            }
            remove => HookHandler._beforeClearEnemyList -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.IsEnemyInRange_AfterArgs IsEnemyInRange
        {
            add
            {
                HookHandler._afterIsEnemyInRange += value;
                HookHandler.HookIsEnemyInRange();
            }
            remove => HookHandler._afterIsEnemyInRange -= value;
        }

        public static event Delegates.GetTarget_AfterArgs GetTarget
        {
            add
            {
                HookHandler._afterGetTarget += value;
                HookHandler.HookGetTarget();
            }
            remove => HookHandler._afterGetTarget -= value;
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

        public static event Delegates.ClearEnemyList_AfterArgs ClearEnemyList
        {
            add
            {
                HookHandler._afterClearEnemyList += value;
                HookHandler.HookClearEnemyList();
            }
            remove => HookHandler._afterClearEnemyList -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GrimmEnemyRange.hook_OnEnable OnEnable
        {
            add => On.GrimmEnemyRange.OnEnable += value;
            remove => On.GrimmEnemyRange.OnEnable -= value;
        }

        public static event On.GrimmEnemyRange.hook_IsEnemyInRange IsEnemyInRange
        {
            add => On.GrimmEnemyRange.IsEnemyInRange += value;
            remove => On.GrimmEnemyRange.IsEnemyInRange -= value;
        }

        public static event On.GrimmEnemyRange.hook_GetTarget GetTarget
        {
            add => On.GrimmEnemyRange.GetTarget += value;
            remove => On.GrimmEnemyRange.GetTarget -= value;
        }

        public static event On.GrimmEnemyRange.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.GrimmEnemyRange.OnTriggerEnter2D += value;
            remove => On.GrimmEnemyRange.OnTriggerEnter2D -= value;
        }

        public static event On.GrimmEnemyRange.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.GrimmEnemyRange.OnTriggerExit2D += value;
            remove => On.GrimmEnemyRange.OnTriggerExit2D -= value;
        }

        public static event On.GrimmEnemyRange.hook_ClearEnemyList ClearEnemyList
        {
            add => On.GrimmEnemyRange.ClearEnemyList += value;
            remove => On.GrimmEnemyRange.ClearEnemyList -= value;
        }
    }
}