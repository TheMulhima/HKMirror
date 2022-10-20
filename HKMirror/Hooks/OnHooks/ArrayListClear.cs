using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListClear class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListClear
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListClear> orig, ArrayListClear self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListClear> orig, ArrayListClear self)
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

        internal static void HookClearArrayList()
        {
            if (!HookedList.Contains("ClearArrayList"))
            {
                HookedList.Add("ClearArrayList");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "ClearArrayList"), ClearArrayList);
            }
        }

        internal static event Delegates.ClearArrayList_BeforeArgs _beforeClearArrayList;
        internal static event Delegates.ClearArrayList_NormalArgs _afterClearArrayList;

        private static void ClearArrayList(Action<ArrayListClear> orig, ArrayListClear self)
        {
            Delegates.Params_ClearArrayList @params = new()
            {
                self = self
            };
            _beforeClearArrayList?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterClearArrayList != null) _afterClearArrayList.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void ClearArrayList_BeforeArgs(Params_ClearArrayList args);

        public delegate void ClearArrayList_NormalArgs(Params_ClearArrayList args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ArrayListClear self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListClear self;
        }

        public sealed class Params_ClearArrayList
        {
            public ArrayListClear self;
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

        public static event Delegates.ClearArrayList_BeforeArgs ClearArrayList
        {
            add
            {
                HookHandler._beforeClearArrayList += value;
                HookHandler.HookClearArrayList();
            }
            remove => HookHandler._beforeClearArrayList -= value;
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

        public static event Delegates.ClearArrayList_NormalArgs ClearArrayList
        {
            add
            {
                HookHandler._afterClearArrayList += value;
                HookHandler.HookClearArrayList();
            }
            remove => HookHandler._afterClearArrayList -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "OnEnter"), value);
        }

        public static event Delegates.ClearArrayList_NormalArgs ClearArrayList
        {
            add => HookEndpointManager.Add<Delegates.ClearArrayList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "ClearArrayList"), value);
            remove => HookEndpointManager.Remove<Delegates.ClearArrayList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListClear), "ClearArrayList"), value);
        }
    }
}