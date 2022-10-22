using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetNextOverlapPoint2d class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetNextOverlapPoint2d
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self)
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

        internal static void HookDoGetNextCollider()
        {
            if (!HookedList.Contains("DoGetNextCollider"))
            {
                HookedList.Add("DoGetNextCollider");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "DoGetNextCollider"),
                    DoGetNextCollider);
            }
        }

        internal static event Delegates.DoGetNextCollider_BeforeArgs _beforeDoGetNextCollider;
        internal static event Delegates.DoGetNextCollider_AfterArgs _afterDoGetNextCollider;

        private static void DoGetNextCollider(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self)
        {
            Delegates.Params_DoGetNextCollider @params = new()
            {
                self = self
            };
            if (_beforeDoGetNextCollider != null)
                foreach (Delegates.DoGetNextCollider_BeforeArgs toInvoke in
                         _beforeDoGetNextCollider.GetInvocationList())
                    try
                    {
                        _beforeDoGetNextCollider?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoGetNextCollider != null)
                foreach (Delegates.DoGetNextCollider_AfterArgs toInvoke in _afterDoGetNextCollider.GetInvocationList())
                    try
                    {
                        _afterDoGetNextCollider.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetOverlapPointAll()
        {
            if (!HookedList.Contains("GetOverlapPointAll"))
            {
                HookedList.Add("GetOverlapPointAll");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "GetOverlapPointAll"),
                    GetOverlapPointAll);
            }
        }

        internal static event Delegates.GetOverlapPointAll_BeforeArgs _beforeGetOverlapPointAll;
        internal static event Delegates.GetOverlapPointAll_AfterArgs _afterGetOverlapPointAll;

        private static Collider2D[] GetOverlapPointAll(Func<GetNextOverlapPoint2d, Collider2D[]> orig,
            GetNextOverlapPoint2d self)
        {
            Delegates.Params_GetOverlapPointAll @params = new()
            {
                self = self
            };
            if (_beforeGetOverlapPointAll != null)
                foreach (Delegates.GetOverlapPointAll_BeforeArgs toInvoke in
                         _beforeGetOverlapPointAll.GetInvocationList())
                    try
                    {
                        _beforeGetOverlapPointAll?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetOverlapPointAll != null)
                foreach (Delegates.GetOverlapPointAll_AfterArgs toInvoke in
                         _afterGetOverlapPointAll.GetInvocationList())
                    try
                    {
                        retVal = _afterGetOverlapPointAll.Invoke(@params, retVal);
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
        public delegate void DoGetNextCollider_AfterArgs(Params_DoGetNextCollider args);

        public delegate void DoGetNextCollider_BeforeArgs(Params_DoGetNextCollider args);

        public delegate void DoGetNextCollider_WithArgs(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self);

        public delegate Collider2D[] GetOverlapPointAll_AfterArgs(Params_GetOverlapPointAll args, Collider2D[] ret);

        public delegate void GetOverlapPointAll_BeforeArgs(Params_GetOverlapPointAll args);

        public delegate Collider2D[] GetOverlapPointAll_WithArgs(Func<GetNextOverlapPoint2d, Collider2D[]> orig,
            GetNextOverlapPoint2d self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GetNextOverlapPoint2d> orig, GetNextOverlapPoint2d self);

        public sealed class Params_Reset
        {
            public GetNextOverlapPoint2d self;
        }

        public sealed class Params_OnEnter
        {
            public GetNextOverlapPoint2d self;
        }

        public sealed class Params_DoGetNextCollider
        {
            public GetNextOverlapPoint2d self;
        }

        public sealed class Params_GetOverlapPointAll
        {
            public GetNextOverlapPoint2d self;
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

        public static event Delegates.DoGetNextCollider_BeforeArgs DoGetNextCollider
        {
            add
            {
                HookHandler._beforeDoGetNextCollider += value;
                HookHandler.HookDoGetNextCollider();
            }
            remove => HookHandler._beforeDoGetNextCollider -= value;
        }

        public static event Delegates.GetOverlapPointAll_BeforeArgs GetOverlapPointAll
        {
            add
            {
                HookHandler._beforeGetOverlapPointAll += value;
                HookHandler.HookGetOverlapPointAll();
            }
            remove => HookHandler._beforeGetOverlapPointAll -= value;
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

        public static event Delegates.DoGetNextCollider_AfterArgs DoGetNextCollider
        {
            add
            {
                HookHandler._afterDoGetNextCollider += value;
                HookHandler.HookDoGetNextCollider();
            }
            remove => HookHandler._afterDoGetNextCollider -= value;
        }

        public static event Delegates.GetOverlapPointAll_AfterArgs GetOverlapPointAll
        {
            add
            {
                HookHandler._afterGetOverlapPointAll += value;
                HookHandler.HookGetOverlapPointAll();
            }
            remove => HookHandler._afterGetOverlapPointAll -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "OnEnter"), value);
        }

        public static event Delegates.DoGetNextCollider_WithArgs DoGetNextCollider
        {
            add => HookEndpointManager.Add<Delegates.DoGetNextCollider_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "DoGetNextCollider"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetNextCollider_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "DoGetNextCollider"), value);
        }

        public static event Delegates.GetOverlapPointAll_WithArgs GetOverlapPointAll
        {
            add => HookEndpointManager.Add<Delegates.GetOverlapPointAll_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "GetOverlapPointAll"), value);
            remove => HookEndpointManager.Remove<Delegates.GetOverlapPointAll_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetNextOverlapPoint2d), "GetOverlapPointAll"), value);
        }
    }
}