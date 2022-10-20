using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListResetValues class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListResetValues
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListResetValues> orig, ArrayListResetValues self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListResetValues> orig, ArrayListResetValues self)
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

        internal static void HookResetArrayList()
        {
            if (!HookedList.Contains("ResetArrayList"))
            {
                HookedList.Add("ResetArrayList");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "ResetArrayList"),
                    ResetArrayList);
            }
        }

        internal static event Delegates.ResetArrayList_BeforeArgs _beforeResetArrayList;
        internal static event Delegates.ResetArrayList_NormalArgs _afterResetArrayList;

        private static void ResetArrayList(Action<ArrayListResetValues> orig, ArrayListResetValues self)
        {
            Delegates.Params_ResetArrayList @params = new()
            {
                self = self
            };
            _beforeResetArrayList?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterResetArrayList != null) _afterResetArrayList.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public delegate void ResetArrayList_BeforeArgs(Params_ResetArrayList args);

        public delegate void ResetArrayList_NormalArgs(Params_ResetArrayList args);

        public sealed class Params_Reset
        {
            public ArrayListResetValues self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListResetValues self;
        }

        public sealed class Params_ResetArrayList
        {
            public ArrayListResetValues self;
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

        public static event Delegates.ResetArrayList_BeforeArgs ResetArrayList
        {
            add
            {
                HookHandler._beforeResetArrayList += value;
                HookHandler.HookResetArrayList();
            }
            remove => HookHandler._beforeResetArrayList -= value;
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

        public static event Delegates.ResetArrayList_NormalArgs ResetArrayList
        {
            add
            {
                HookHandler._afterResetArrayList += value;
                HookHandler.HookResetArrayList();
            }
            remove => HookHandler._afterResetArrayList -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "OnEnter"), value);
        }

        public static event Delegates.ResetArrayList_NormalArgs ResetArrayList
        {
            add => HookEndpointManager.Add<Delegates.ResetArrayList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "ResetArrayList"), value);
            remove => HookEndpointManager.Remove<Delegates.ResetArrayList_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListResetValues), "ResetArrayList"), value);
        }
    }
}