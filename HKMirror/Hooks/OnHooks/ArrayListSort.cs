using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListSort class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListSort
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListSort> orig, ArrayListSort self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListSort> orig, ArrayListSort self)
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

        internal static void HookDoArrayListSort()
        {
            if (!HookedList.Contains("DoArrayListSort"))
            {
                HookedList.Add("DoArrayListSort");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), DoArrayListSort);
            }
        }

        internal static event Delegates.DoArrayListSort_BeforeArgs _beforeDoArrayListSort;
        internal static event Delegates.DoArrayListSort_NormalArgs _afterDoArrayListSort;

        private static void DoArrayListSort(Action<ArrayListSort> orig, ArrayListSort self)
        {
            Delegates.Params_DoArrayListSort @params = new()
            {
                self = self
            };
            _beforeDoArrayListSort?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoArrayListSort != null) _afterDoArrayListSort.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoArrayListSort_BeforeArgs(Params_DoArrayListSort args);

        public delegate void DoArrayListSort_NormalArgs(Params_DoArrayListSort args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ArrayListSort self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListSort self;
        }

        public sealed class Params_DoArrayListSort
        {
            public ArrayListSort self;
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

        public static event Delegates.DoArrayListSort_BeforeArgs DoArrayListSort
        {
            add
            {
                HookHandler._beforeDoArrayListSort += value;
                HookHandler.HookDoArrayListSort();
            }
            remove => HookHandler._beforeDoArrayListSort -= value;
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

        public static event Delegates.DoArrayListSort_NormalArgs DoArrayListSort
        {
            add
            {
                HookHandler._afterDoArrayListSort += value;
                HookHandler.HookDoArrayListSort();
            }
            remove => HookHandler._afterDoArrayListSort -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), value);
        }

        public static event Delegates.DoArrayListSort_NormalArgs DoArrayListSort
        {
            add => HookEndpointManager.Add<Delegates.DoArrayListSort_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), value);
            remove => HookEndpointManager.Remove<Delegates.DoArrayListSort_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), value);
        }
    }
}