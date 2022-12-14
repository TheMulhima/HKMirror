using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for FloatSquareRoot class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFloatSquareRoot
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<FloatSquareRoot> orig, FloatSquareRoot self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<FloatSquareRoot> orig, FloatSquareRoot self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<FloatSquareRoot> orig, FloatSquareRoot self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoFloatSquareRoot()
        {
            if (!HookedList.Contains("DoFloatSquareRoot"))
            {
                HookedList.Add("DoFloatSquareRoot");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "DoFloatSquareRoot"),
                    DoFloatSquareRoot);
            }
        }

        internal static event Delegates.DoFloatSquareRoot_BeforeArgs _beforeDoFloatSquareRoot;
        internal static event Delegates.DoFloatSquareRoot_AfterArgs _afterDoFloatSquareRoot;

        private static void DoFloatSquareRoot(Action<FloatSquareRoot> orig, FloatSquareRoot self)
        {
            Delegates.Params_DoFloatSquareRoot @params = new()
            {
                self = self
            };
            if (_beforeDoFloatSquareRoot != null)
                foreach (Delegates.DoFloatSquareRoot_BeforeArgs toInvoke in
                         _beforeDoFloatSquareRoot.GetInvocationList())
                    try
                    {
                        _beforeDoFloatSquareRoot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoFloatSquareRoot != null)
                foreach (Delegates.DoFloatSquareRoot_AfterArgs toInvoke in _afterDoFloatSquareRoot.GetInvocationList())
                    try
                    {
                        _afterDoFloatSquareRoot.Invoke(@params);
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
        public delegate void DoFloatSquareRoot_AfterArgs(Params_DoFloatSquareRoot args);

        public delegate void DoFloatSquareRoot_BeforeArgs(Params_DoFloatSquareRoot args);

        public delegate void DoFloatSquareRoot_WithArgs(Action<FloatSquareRoot> orig, FloatSquareRoot self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<FloatSquareRoot> orig, FloatSquareRoot self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<FloatSquareRoot> orig, FloatSquareRoot self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<FloatSquareRoot> orig, FloatSquareRoot self);

        public sealed class Params_Reset
        {
            public FloatSquareRoot self;
        }

        public sealed class Params_OnEnter
        {
            public FloatSquareRoot self;
        }

        public sealed class Params_OnUpdate
        {
            public FloatSquareRoot self;
        }

        public sealed class Params_DoFloatSquareRoot
        {
            public FloatSquareRoot self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoFloatSquareRoot_BeforeArgs DoFloatSquareRoot
        {
            add
            {
                HookHandler._beforeDoFloatSquareRoot += value;
                HookHandler.HookDoFloatSquareRoot();
            }
            remove => HookHandler._beforeDoFloatSquareRoot -= value;
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

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoFloatSquareRoot_AfterArgs DoFloatSquareRoot
        {
            add
            {
                HookHandler._afterDoFloatSquareRoot += value;
                HookHandler.HookDoFloatSquareRoot();
            }
            remove => HookHandler._afterDoFloatSquareRoot -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "OnUpdate"), value);
        }

        public static event Delegates.DoFloatSquareRoot_WithArgs DoFloatSquareRoot
        {
            add => HookEndpointManager.Add<Delegates.DoFloatSquareRoot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "DoFloatSquareRoot"), value);
            remove => HookEndpointManager.Remove<Delegates.DoFloatSquareRoot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FloatSquareRoot), "DoFloatSquareRoot"), value);
        }
    }
}