using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetChildNum class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetChildNum
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GetChildNum> orig, GetChildNum self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GetChildNum> orig, GetChildNum self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }

        internal static void HookDoGetChildNum()
        {
            if (!HookedList.Contains("DoGetChildNum"))
            {
                HookedList.Add("DoGetChildNum");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "DoGetChildNum"), DoGetChildNum);
            }
        }

        internal static event Delegates.DoGetChildNum_BeforeArgs _beforeDoGetChildNum;
        internal static event Delegates.DoGetChildNum_NormalArgs _afterDoGetChildNum;

        private static GameObject DoGetChildNum(Func<GetChildNum, GameObject, GameObject> orig, GetChildNum self,
            GameObject go)
        {
            Delegates.Params_DoGetChildNum @params = new()
            {
                self = self, go = go
            };
            _beforeDoGetChildNum?.Invoke(@params);
            self = @params.self;
            go = @params.go;
            var retVal = orig(self, go);
            if (_afterDoGetChildNum != null) retVal = _afterDoGetChildNum.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoGetChildNum_BeforeArgs(Params_DoGetChildNum args);

        public delegate GameObject DoGetChildNum_NormalArgs(Params_DoGetChildNum args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GetChildNum self;
        }

        public sealed class Params_OnEnter
        {
            public GetChildNum self;
        }

        public sealed class Params_DoGetChildNum
        {
            public GameObject go;
            public GetChildNum self;
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

        public static event Delegates.DoGetChildNum_BeforeArgs DoGetChildNum
        {
            add
            {
                HookHandler._beforeDoGetChildNum += value;
                HookHandler.HookDoGetChildNum();
            }
            remove => HookHandler._beforeDoGetChildNum -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.DoGetChildNum_NormalArgs DoGetChildNum
        {
            add
            {
                HookHandler._afterDoGetChildNum += value;
                HookHandler.HookDoGetChildNum();
            }
            remove => HookHandler._afterDoGetChildNum -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "OnEnter"), value);
        }

        public static event Delegates.DoGetChildNum_NormalArgs DoGetChildNum
        {
            add => HookEndpointManager.Add<Delegates.DoGetChildNum_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "DoGetChildNum"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetChildNum_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetChildNum), "DoGetChildNum"), value);
        }
    }
}