using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListLastIndexOf class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListLastIndexOf
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self)
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

        internal static void HookDoArrayListLastIndex()
        {
            if (!HookedList.Contains("DoArrayListLastIndex"))
            {
                HookedList.Add("DoArrayListLastIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "DoArrayListLastIndex"),
                    DoArrayListLastIndex);
            }
        }

        internal static event Delegates.DoArrayListLastIndex_BeforeArgs _beforeDoArrayListLastIndex;
        internal static event Delegates.DoArrayListLastIndex_AfterArgs _afterDoArrayListLastIndex;

        private static void DoArrayListLastIndex(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self)
        {
            Delegates.Params_DoArrayListLastIndex @params = new()
            {
                self = self
            };
            if (_beforeDoArrayListLastIndex != null)
                foreach (Delegates.DoArrayListLastIndex_BeforeArgs toInvoke in _beforeDoArrayListLastIndex
                             .GetInvocationList())
                    try
                    {
                        _beforeDoArrayListLastIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoArrayListLastIndex != null)
                foreach (Delegates.DoArrayListLastIndex_AfterArgs toInvoke in _afterDoArrayListLastIndex
                             .GetInvocationList())
                    try
                    {
                        _afterDoArrayListLastIndex.Invoke(@params);
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
        public delegate void DoArrayListLastIndex_AfterArgs(Params_DoArrayListLastIndex args);

        public delegate void DoArrayListLastIndex_BeforeArgs(Params_DoArrayListLastIndex args);

        public delegate void
            DoArrayListLastIndex_WithArgs(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ArrayListLastIndexOf> orig, ArrayListLastIndexOf self);

        public sealed class Params_Reset
        {
            public ArrayListLastIndexOf self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListLastIndexOf self;
        }

        public sealed class Params_DoArrayListLastIndex
        {
            public ArrayListLastIndexOf self;
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

        public static event Delegates.DoArrayListLastIndex_BeforeArgs DoArrayListLastIndex
        {
            add
            {
                HookHandler._beforeDoArrayListLastIndex += value;
                HookHandler.HookDoArrayListLastIndex();
            }
            remove => HookHandler._beforeDoArrayListLastIndex -= value;
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

        public static event Delegates.DoArrayListLastIndex_AfterArgs DoArrayListLastIndex
        {
            add
            {
                HookHandler._afterDoArrayListLastIndex += value;
                HookHandler.HookDoArrayListLastIndex();
            }
            remove => HookHandler._afterDoArrayListLastIndex -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "OnEnter"), value);
        }

        public static event Delegates.DoArrayListLastIndex_WithArgs DoArrayListLastIndex
        {
            add => HookEndpointManager.Add<Delegates.DoArrayListLastIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "DoArrayListLastIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.DoArrayListLastIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListLastIndexOf), "DoArrayListLastIndex"), value);
        }
    }
}