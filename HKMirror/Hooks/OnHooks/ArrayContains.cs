using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayContains class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayContains
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ArrayContains> orig, ArrayContains self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayContains> orig, ArrayContains self)
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

        internal static void HookDoCheckContainsValue()
        {
            if (!HookedList.Contains("DoCheckContainsValue"))
            {
                HookedList.Add("DoCheckContainsValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "DoCheckContainsValue"),
                    DoCheckContainsValue);
            }
        }

        internal static event Delegates.DoCheckContainsValue_BeforeArgs _beforeDoCheckContainsValue;
        internal static event Delegates.DoCheckContainsValue_AfterArgs _afterDoCheckContainsValue;

        private static void DoCheckContainsValue(Action<ArrayContains> orig, ArrayContains self)
        {
            Delegates.Params_DoCheckContainsValue @params = new()
            {
                self = self
            };
            if (_beforeDoCheckContainsValue != null)
                foreach (Delegates.DoCheckContainsValue_BeforeArgs toInvoke in _beforeDoCheckContainsValue
                             .GetInvocationList())
                    try
                    {
                        _beforeDoCheckContainsValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoCheckContainsValue != null)
                foreach (Delegates.DoCheckContainsValue_AfterArgs toInvoke in _afterDoCheckContainsValue
                             .GetInvocationList())
                    try
                    {
                        _afterDoCheckContainsValue.Invoke(@params);
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
        public delegate void DoCheckContainsValue_AfterArgs(Params_DoCheckContainsValue args);

        public delegate void DoCheckContainsValue_BeforeArgs(Params_DoCheckContainsValue args);

        public delegate void DoCheckContainsValue_WithArgs(Action<ArrayContains> orig, ArrayContains self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ArrayContains> orig, ArrayContains self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ArrayContains> orig, ArrayContains self);

        public sealed class Params_Reset
        {
            public ArrayContains self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayContains self;
        }

        public sealed class Params_DoCheckContainsValue
        {
            public ArrayContains self;
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

        public static event Delegates.DoCheckContainsValue_BeforeArgs DoCheckContainsValue
        {
            add
            {
                HookHandler._beforeDoCheckContainsValue += value;
                HookHandler.HookDoCheckContainsValue();
            }
            remove => HookHandler._beforeDoCheckContainsValue -= value;
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

        public static event Delegates.DoCheckContainsValue_AfterArgs DoCheckContainsValue
        {
            add
            {
                HookHandler._afterDoCheckContainsValue += value;
                HookHandler.HookDoCheckContainsValue();
            }
            remove => HookHandler._afterDoCheckContainsValue -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "OnEnter"), value);
        }

        public static event Delegates.DoCheckContainsValue_WithArgs DoCheckContainsValue
        {
            add => HookEndpointManager.Add<Delegates.DoCheckContainsValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "DoCheckContainsValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCheckContainsValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayContains), "DoCheckContainsValue"), value);
        }
    }
}