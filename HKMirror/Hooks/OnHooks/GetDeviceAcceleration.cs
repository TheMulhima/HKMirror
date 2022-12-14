using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetDeviceAcceleration class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetDeviceAcceleration
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self)
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

        internal static void HookDoGetDeviceAcceleration()
        {
            if (!HookedList.Contains("DoGetDeviceAcceleration"))
            {
                HookedList.Add("DoGetDeviceAcceleration");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "DoGetDeviceAcceleration"),
                    DoGetDeviceAcceleration);
            }
        }

        internal static event Delegates.DoGetDeviceAcceleration_BeforeArgs _beforeDoGetDeviceAcceleration;
        internal static event Delegates.DoGetDeviceAcceleration_AfterArgs _afterDoGetDeviceAcceleration;

        private static void DoGetDeviceAcceleration(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self)
        {
            Delegates.Params_DoGetDeviceAcceleration @params = new()
            {
                self = self
            };
            if (_beforeDoGetDeviceAcceleration != null)
                foreach (Delegates.DoGetDeviceAcceleration_BeforeArgs toInvoke in _beforeDoGetDeviceAcceleration
                             .GetInvocationList())
                    try
                    {
                        _beforeDoGetDeviceAcceleration?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoGetDeviceAcceleration != null)
                foreach (Delegates.DoGetDeviceAcceleration_AfterArgs toInvoke in _afterDoGetDeviceAcceleration
                             .GetInvocationList())
                    try
                    {
                        _afterDoGetDeviceAcceleration.Invoke(@params);
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
        public delegate void DoGetDeviceAcceleration_AfterArgs(Params_DoGetDeviceAcceleration args);

        public delegate void DoGetDeviceAcceleration_BeforeArgs(Params_DoGetDeviceAcceleration args);

        public delegate void DoGetDeviceAcceleration_WithArgs(Action<GetDeviceAcceleration> orig,
            GetDeviceAcceleration self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GetDeviceAcceleration> orig, GetDeviceAcceleration self);

        public sealed class Params_Reset
        {
            public GetDeviceAcceleration self;
        }

        public sealed class Params_OnEnter
        {
            public GetDeviceAcceleration self;
        }

        public sealed class Params_OnUpdate
        {
            public GetDeviceAcceleration self;
        }

        public sealed class Params_DoGetDeviceAcceleration
        {
            public GetDeviceAcceleration self;
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

        public static event Delegates.DoGetDeviceAcceleration_BeforeArgs DoGetDeviceAcceleration
        {
            add
            {
                HookHandler._beforeDoGetDeviceAcceleration += value;
                HookHandler.HookDoGetDeviceAcceleration();
            }
            remove => HookHandler._beforeDoGetDeviceAcceleration -= value;
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

        public static event Delegates.DoGetDeviceAcceleration_AfterArgs DoGetDeviceAcceleration
        {
            add
            {
                HookHandler._afterDoGetDeviceAcceleration += value;
                HookHandler.HookDoGetDeviceAcceleration();
            }
            remove => HookHandler._afterDoGetDeviceAcceleration -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "OnUpdate"), value);
        }

        public static event Delegates.DoGetDeviceAcceleration_WithArgs DoGetDeviceAcceleration
        {
            add => HookEndpointManager.Add<Delegates.DoGetDeviceAcceleration_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "DoGetDeviceAcceleration"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetDeviceAcceleration_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetDeviceAcceleration), "DoGetDeviceAcceleration"), value);
        }
    }
}