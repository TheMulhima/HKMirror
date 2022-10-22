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
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ArrayListSort> orig, ArrayListSort self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListSort> orig, ArrayListSort self)
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

        internal static void HookDoArrayListSort()
        {
            if (!HookedList.Contains("DoArrayListSort"))
            {
                HookedList.Add("DoArrayListSort");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), DoArrayListSort);
            }
        }

        internal static event Delegates.DoArrayListSort_BeforeArgs _beforeDoArrayListSort;
        internal static event Delegates.DoArrayListSort_AfterArgs _afterDoArrayListSort;

        private static void DoArrayListSort(Action<ArrayListSort> orig, ArrayListSort self)
        {
            Delegates.Params_DoArrayListSort @params = new()
            {
                self = self
            };
            if (_beforeDoArrayListSort != null)
                foreach (Delegates.DoArrayListSort_BeforeArgs toInvoke in _beforeDoArrayListSort.GetInvocationList())
                    try
                    {
                        _beforeDoArrayListSort?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoArrayListSort != null)
                foreach (Delegates.DoArrayListSort_AfterArgs toInvoke in _afterDoArrayListSort.GetInvocationList())
                    try
                    {
                        _afterDoArrayListSort.Invoke(@params);
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
        public delegate void DoArrayListSort_AfterArgs(Params_DoArrayListSort args);

        public delegate void DoArrayListSort_BeforeArgs(Params_DoArrayListSort args);

        public delegate void DoArrayListSort_WithArgs(Action<ArrayListSort> orig, ArrayListSort self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ArrayListSort> orig, ArrayListSort self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ArrayListSort> orig, ArrayListSort self);

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

        public static event Delegates.DoArrayListSort_AfterArgs DoArrayListSort
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
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "OnEnter"), value);
        }

        public static event Delegates.DoArrayListSort_WithArgs DoArrayListSort
        {
            add => HookEndpointManager.Add<Delegates.DoArrayListSort_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), value);
            remove => HookEndpointManager.Remove<Delegates.DoArrayListSort_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListSort), "DoArrayListSort"), value);
        }
    }
}